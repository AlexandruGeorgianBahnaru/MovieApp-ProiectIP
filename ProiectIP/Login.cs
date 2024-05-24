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
        #region Fields
        public bool IsAboutWindowOpened { get; private set; }
        public bool IsHelpWindowOpened { get; private set; }
        public bool IsInregistrareWindowOpened { get; private set; }
        public bool IsUserAuthenticated { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Constructorul clasei Login
        /// </summary>
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
                SqlConnection con = null;
                try
                {
                    con = ConexiuneBazaDeDate.Conexiune.GetConexiune();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiect_ip_24.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";

                con.Open();

                    string query = "select count(*) from Users where Email = '" + textBoxEmail.Text + "'";
                    SqlCommand cmdEmail = new SqlCommand(query, con);
                    int emailCount = (int)cmdEmail.ExecuteScalar();

                    if (emailCount == 0)
                    {
                        MessageBox.Show("Email inexistent!");
                    }
                    else
                    {
                        string querySelect = "select Admin from Users where Email = '" + textBoxEmail.Text + "' and Parola = '" + textBoxParola.Text + "'";
                        SqlCommand cmd = new SqlCommand(querySelect, con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            if (dt.Rows[0][0].ToString() == "True")
                            {
                                Administrator admin = new Administrator();
                                admin.Show();
                                this.Hide();
                            }
                            else
                            {
                                Utilizator user = new Utilizator();
                                user.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parola greșită!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu s-a putut efectua conexiunea la baza de date: " + ex.Message);
                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
        }

        /// <summary>
        /// Butonul About permite afisarea unor informatii despre proiect 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            string title = "Despre";
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", title);
            IsAboutWindowOpened = true;
        }


        
        /// <summary>
        /// La apasarea 'Help' se deschide un fisier .chm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            IsHelpWindowOpened = true;
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        /// <summary>
        /// Butonul Resize este utilizat pentru a schimba dimensiunea ferestrei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// La apasarea butonului Close se inchide interfata curenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  Butonul 'Mini' este folosit pentru minimizarea ferestrei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            Inregistrare reg1 = new Inregistrare();
            reg1.Show();
        }
    }
}