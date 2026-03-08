using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoo
{
    public partial class TovarForm : Form
    {
        private readonly UserDTO user;
        private readonly TovarDTO tovar;

        private string connectionString =
            "host=localhost;port=5432;username=postgres;password=123456;database=zoo";

        public TovarForm(UserDTO user, TovarDTO tovar)
        {
            InitializeComponent();
            this.user = user;
            this.tovar = tovar;

            if (tovar != null)
            {
                saveBtn.Text = "Сохранить";
                articleTextBox.Text = tovar.article;
                nameTxtBox.Text = tovar.name;
                costN.Value = tovar.cost;
                countN.Value = tovar.count;
                cathegoryComboBox.Text = tovar.cathegory;
                descryptionTextBox.Text = tovar.descryption;
                manufacturerComboBox.Text = tovar.manufacturer;
                supplierComboBox.Text = tovar.supplier;
                unitComboBox.Text = tovar.unit;
                saleN.Value = tovar.sale;
                imageTextBox.Text = tovar.photo;
                try
                {
                    imagePB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", tovar.photo));
                }
                catch
                {
                    imagePB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images\\picture.jpg"));
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string query;

            if (tovar != null)
            {
                query = @"
                UPDATE tovars t 
                SET 
                    name = @name,
                    cost = @cost,
                    cathegory_id = (SELECT id FROM cathegories c WHERE c.name = @cathegory),
                    manufacturer_id = (SELECT id FROM manufacturers m WHERE m.name = @manufacturer),
                    supplier_id = (SELECT id FROM suppliers s WHERE s.name = @supplier),
                    unit_id = (SELECT id FROM units u WHERE u.name = @unit),
                    count = @count,
                    sale = @sale,
                    descryption = @descryption,
                    photo = @photo
                WHERE t.article = @article";
            }
            else
            {
                query = @"
                INSERT INTO tovars 
                (article, name, cost, cathegory_id, manufacturer_id, supplier_id, unit_id, count, sale, descryption, photo)
                VALUES 
                (
                    @article, @name, @cost,
                    (SELECT id FROM cathegories c WHERE c.name = @cathegory),
                    (SELECT id FROM manufacturers m WHERE m.name = @manufacturer),
                    (SELECT id FROM suppliers s WHERE s.name = @supplier),
                    (SELECT id FROM units u WHERE u.name = @unit),
                    @count, @sale, @descryption, @photo
                )";
            }

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@article", articleTextBox.Text);
                    command.Parameters.AddWithValue("@name", nameTxtBox.Text);
                    command.Parameters.AddWithValue("@cost", costN.Value);
                    command.Parameters.AddWithValue("@cathegory", cathegoryComboBox.Text);
                    command.Parameters.AddWithValue("@manufacturer", manufacturerComboBox.Text);
                    command.Parameters.AddWithValue("@supplier", supplierComboBox.Text);
                    command.Parameters.AddWithValue("@unit", unitComboBox.Text);
                    command.Parameters.AddWithValue("@count", countN.Value);
                    command.Parameters.AddWithValue("@sale", saleN.Value);
                    command.Parameters.AddWithValue("@descryption", descryptionTextBox.Text);
                    command.Parameters.AddWithValue("@photo", imageTextBox.Text);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Успешно сохранено");

                        MainForm mainForm = new MainForm(user);
                        mainForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(user);
            form.Show();
            this.Hide();
        }

        private void imagePB_Click(object sender, EventArgs e)
        {

        }
    }
}
