using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexiuneBazaDeDate;
namespace ProiectIP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            
        }

        private void labelParola_Click(object sender, EventArgs e)
        {

        }

        private void panelNavigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = ConexiuneBazaDeDate.Conexiune.GetConexiune();
                con.Open();

                SqlCommand cmd = new SqlCommand("select Admin from Users where Email = '" + textBoxEmail.Text + "' and Parola = '" + textBoxParola.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (dt.Rows[0][0].ToString() == "True")
                    {
                        //    this.Hide();
                        //    string userId = dt.Rows[0][0].ToString();
                        Utilizator user = new Utilizator();
                        user.Show();
                        Console.WriteLine("ADMIN");
                    }
                    else if (dt.Rows[0][0].ToString() == "False")
                    {
                        //this.Hide();
                        //string adminId = dt.Rows[0][0].ToString();
                        //Administrator admin = new Administrator();
                        //admin.Show();
                    }
                }

                else
                {
                    MessageBox.Show("E-mail sau parolă greșite!");
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nu s-a putut efectua conexiunea la baza de date.");
            }
        }
    }
}
