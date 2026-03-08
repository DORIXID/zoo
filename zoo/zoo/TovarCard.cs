using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoo
{
    public partial class TovarCard : UserControl
    {
        private string connectionString = "host=localhost;port=5432;username=postgres;password=123456;database=zoo";

        private UserDTO user;

        public TovarCard(UserDTO user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void deleteTovar()
        {
            string query = "DELETE FROM tovars t WHERE t.article LIKE @article";
            using (var connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new Npgsql.NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@article", this.articleLbl.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MainForm mainForm = (MainForm)this.ParentForm;
                        mainForm.loadTovars();
                        MessageBox.Show("Успешно удалено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Этот товар находится в заказе, его нельзя удалить, пока заказ не забрали" + ex.Message);
                    }
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TovarCard_Load(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteTovar();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            TovarDTO tovar = new TovarDTO();
            tovar.article = this.articleLbl.Text;
            tovar.name = this.nameLbl.Text;
            tovar.unit = this.unitLbl.Text;
            tovar.descryption = this.descLbl.Text;
            tovar.manufacturer = this.manufacturerLbl.Text;
            tovar.supplier = this.supplierLbl.Text;
            tovar.cost = int.Parse(this.costLbl.Text);
            tovar.count = int.Parse(this.countLbl.Text);
            tovar.cathegory = this.cathegoryLbl.Text;
            tovar.sale = int.Parse(this.saleLbl.Text);
            tovar.photo = this.imageNameLbl.Text;

            TovarForm tovarForm = new TovarForm(user, tovar);
            MainForm parent = (MainForm)this.ParentForm;
            parent.Hide();
            tovarForm.Show();
        }

        private void imagePB_Click(object sender, EventArgs e)
        {

        }
    }
}
