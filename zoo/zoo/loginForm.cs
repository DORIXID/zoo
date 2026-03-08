using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoo
{
    public partial class loginForm : Form
    {
        private string connectionString = "host=localhost;port=5432;username=postgres;password=123456;database=zoo";

        private UserDTO user;
        public loginForm()
        {
            InitializeComponent();
        }

        private UserDTO auth()
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string query = "SELECT r.name, u.fio FROM public.users u JOIN public.user_roles r ON r.id = u.role_id WHERE u.login LIKE @login and u.password LIKE @password";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", username);
                    command.Parameters.AddWithValue("@password", password);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserDTO
                            {
                                role = reader.GetString(0),
                                fio = reader.GetString(1)
                            };
                            return user;
                        } else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        private void guestBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(null);
            mainForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserDTO user = auth();
            if (user != null)
            {
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
