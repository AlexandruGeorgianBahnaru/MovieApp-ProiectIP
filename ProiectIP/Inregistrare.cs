/**************************************************************************
 *                                                                        *
 *  File:        Inregistrare.cs                                          *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea opțiunii de înregistrare a utilizatorilor  *
 *  noi, prin adăugarea acestora în tabelul Users.                        *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


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
        #region Fields
        private Administrator _admin;
        #endregion
        #region Methods
        public Inregistrare()
        {

            InitializeComponent();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {

            if (verificaFormularInregistrare(textBoxNume.Text, textBoxPrenume.Text, textBoxEmail.Text, textBoxParola.Text))
            {
                try
                {
                    string nume = textBoxNume.Text;
                    string prenume = textBoxPrenume.Text;
                    string email = textBoxEmail.Text;
                    string parola = textBoxParola.Text;
                    using (SqlConnection con = Conexiune.GetConexiune())
                    {
                        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiec_ip_25.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                        con.Open();

                        SqlCommand verificaEmail = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", con);
                        verificaEmail.Parameters.AddWithValue("@Email", email);
                        int existaEmail = (int)verificaEmail.ExecuteScalar();

                        if (existaEmail > 0)
                        {
                            MessageBox.Show("Utilizatorul există deja! Folosiți alt email!");
                            return;
                        }

                        SqlCommand cmd = new SqlCommand("INSERT INTO Users (Nume, Prenume, Email, Parola, Admin) VALUES (@Nume, @Prenume, @Email, @Parola, @Admin)", con);
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cmd.Parameters.AddWithValue("@Prenume", prenume);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Parola", parola);
                        cmd.Parameters.AddWithValue("@Admin", false);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Utilizatorul a fost înregistrat cu succes!");
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
                }
            }
        }


        private bool verificaFormularInregistrare(string nume, string prenume, string email, string parola)
        {
            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(prenume) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Completati toate campurile");
                return false;
            }

            string[] mailuri = { "@gmail.com", "@gmail.ro", "@yahoo.com", "@yahoo.ro", "@hotmail.com", "@hotmail.ro" };
            bool esteMailValid = false;
            foreach (string d in mailuri)
            {
                if (email.EndsWith(d.ToLower()))
                {
                    esteMailValid = true;
                    break;
                }
            }

            if (nume.Length < 3)
            {
                MessageBox.Show("Numele trebuie sa aiba cel puțin 3 caractere!");
                return false;
            }

            if (prenume.Length < 3)
            {
                MessageBox.Show("Prenumele trebuie sa aiba cel puțin 3 caractere!");
                return false;
            }

            if (!esteMailValid)
            {
                MessageBox.Show("Emailul trebuie sa fie de tipul @gmail.com, @gmail.ro, @yahoo.com, @yahoo.ro, @hotmail.com, @hotmail.ro");
                return false;
            }

            if (parola.Length < 5)
            {
                MessageBox.Show("Parola trebuie sa aiba cel puțin 5 caractere!");
                return false;
            }



            return true;
        }

        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }
        #endregion
    }

}
