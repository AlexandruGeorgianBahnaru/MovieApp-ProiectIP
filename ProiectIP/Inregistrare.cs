using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexiuneBazaDeDate;

namespace ProiectIP
{


    public partial class Inregistrare : Form
    {
        private Administrator _admin;
        public Inregistrare()
        {
 
            InitializeComponent();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            string nume = textBoxNume.Text;
            string prenume = textBoxPrenume.Text;
            string email = textBoxEmail.Text;
            string parola = textBoxParola.Text;

            if (nume.Length < 3)
            {
                MessageBox.Show("Numele trebuie să aibă cel puțin 3 caractere!");
            }

            if (prenume.Length < 3)
            {
                MessageBox.Show("Prenumele trebuie să aibă cel puțin 3 caractere!");
            }


            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(parola) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Completați toate câmpurile!");
                return;
            }

            string[] domenii = { "@gmail.com", "@yahoo.com", "@yahoo.ro", "@hotmail.com", "@hotmail.ro" };
            bool esteValid = false;
            string lowerEmail = email.ToLower();

            foreach(string d in domenii)
            {
                if (lowerEmail.EndsWith(d.ToLower()))
                {
                    esteValid = true;
                    break;
                }
            }

            if (!esteValid)
            {
                MessageBox.Show("Emailul trebuie să fie de tipul @gmail.com, @yahoo.com, @yahoo.ro, @hotmail.com, @hotmail.com");
                return;
            }

            if (parola.Length < 5)
            {
                MessageBox.Show("Parola trebuie să aibă cel puțin 5 caractere!");
                return;
            }

            //inserarea în baza de date
            try
            {
                using (SqlConnection con = Conexiune.GetConexiune())
                {
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiect_ip_24.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";

                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Nume, Prenume, Email, Parola, Admin) VALUES (@Nume, @Prenume, @Email, @Parola, @Admin)", con);
                    cmd.Parameters.AddWithValue("@Nume", nume);
                    cmd.Parameters.AddWithValue("@Prenume", prenume);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Parola", parola);

                    bool admin = false;
                    cmd.Parameters.AddWithValue("@Admin", admin);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
                    this.Hide();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
            }
        }


    }
    
}
