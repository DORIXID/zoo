using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace zoo
{
    public partial class MainForm : Form
    {
        private string connectionString = "host=localhost;port=5432;username=postgres;password=123456;database=zoo";

        private UserDTO user;
        string searchType = "";
        string sortType = "";

        public MainForm(UserDTO user)
        {
            this.user = user;
            InitializeComponent();
            loadTovars();
            if (user != null)
            {
                this.roleLbl.Text = user.role;
                this.fioLbl.Text = user.fio;
                if (user.role == "Менеджер" || user.role == "Администратор")
                {
                    this.filterCB.Visible = true;
                    this.label2.Visible = true;
                    this.SearchLbl.Visible = true;
                    this.searchCB.Visible = true;
                    this.label3.Visible = true;
                    this.searchCB.Visible = true;
                    this.label4.Visible = true;
                    this.ascRBtn.Visible = true;
                    this.descRBtn.Visible = true;
                    this.label5.Visible = true;
                    this.searchTB.Visible = true;
                    if (user.role == "Администратор")
                    {
                        this.createTovarBtn.Visible = true;
                    }
                }

            }
            else
            {
                this.roleLbl.Text = "Гость";
                this.label2.Visible = false;
            }
        }

        public void loadTovars()
        {
            flowLayoutPanel1.Controls.Clear();
            switch (this.searchCB.SelectedIndex)
            {
                case 0:
                    searchType = "t.name";
                    break;
                case 1:
                    searchType = "t.descryption";
                    break;
                case 2:
                    searchType = "m.name";
                    break;
                case 3:
                    searchType = "s.name";
                    break;
                default:
                    searchType = "t.name";
                    break;
            }
            sortType = ascRBtn.Checked ? "asc" : "desc";
                string query = $@"SELECT t.name, t.cost, c.name as cathegory, m.name as manufacturer, s.name as supplier, article, u.name as unit, count, sale, descryption, photo
                            FROM tovars t
                            JOIN cathegories c ON c.id = t.cathegory_id
                            JOIN manufacturers m ON m.id = t.manufacturer_id
                            JOIN suppliers s ON s.id = t.supplier_id
                            JOIN units u ON u.id = t.unit_id
                            WHERE {searchType} ILIKE @searchVal and
                            s.name ILIKE @supplier
                            ORDER BY count {sortType}";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchVal", "%" + searchTB.Text + "%");

                    if (this.filterCB.Text != "Все") 
                            {
                        command.Parameters.AddWithValue("@supplier", "%" + filterCB.Text + "%");
                    }
                    else {
                        command.Parameters.AddWithValue("@supplier", "%%");
                    }
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TovarCard tovarCard = new TovarCard(user);
                            tovarCard.nameLbl.Text = reader.GetString(0);
                            tovarCard.costLbl.Text = reader.GetInt32(1).ToString();
                            tovarCard.cathegoryLbl.Text = reader.GetString(2);
                            tovarCard.manufacturerLbl.Text = reader.GetString(3);
                            tovarCard.supplierLbl.Text = reader.GetString(4);
                            tovarCard.articleLbl.Text = reader.GetString(5);
                            tovarCard.unitLbl.Text = reader.GetString(6);
                            tovarCard.countLbl.Text = reader.GetInt32(7).ToString();
                            tovarCard.saleLbl.Text = reader.GetInt32(8).ToString();
                            tovarCard.descLbl.Text = reader.GetString(9);
                            tovarCard.imageNameLbl.Text = reader.GetString(10);
                            if (user != null && user.role == "Администратор")
                            {
                                tovarCard.editBtn.Visible = true;
                                tovarCard.deleteBtn.Visible = true;
                            }

                            if (reader.GetInt32(8) > 15)
                            {
                                tovarCard.saleLbl.ForeColor = ColorTranslator.FromHtml("#67D31D");
                                tovarCard.costLbl.ForeColor = Color.Red;
                                tovarCard.costLbl.Font = new Font(tovarCard.costLbl.Font, FontStyle.Strikeout);
                                tovarCard.newCostLbl.Text = (reader.GetInt32(1) - reader.GetInt32(1) / 100 * reader.GetInt32(8)).ToString() + " руб";

                            }
                            if (reader.GetInt32(7) < 1)
                            {
                                tovarCard.countLbl.ForeColor = ColorTranslator.FromHtml("#ADD8E6");
                            }
                            try {
                                tovarCard.imagePB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", reader.GetString(10)));
                            } catch
                            {
                                tovarCard.imagePB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images\\picture.jpg"));
                            }
                            flowLayoutPanel1.Controls.Add(tovarCard);
                        }
                    }
                }

            } 
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void serchTextChanged(object sender, EventArgs e)
        {
            loadTovars();
        }

        private void createTovarBtn_Click(object sender, EventArgs e)
        {
            TovarForm frm = new TovarForm(user, null);
            frm.Show();
            this.Hide();
        }
    }
}
