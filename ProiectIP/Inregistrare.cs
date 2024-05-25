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
        private Administrator _admin;
        public bool IsAboutWindowOpened { get; private set; }
        public bool IsHelpWindowOpened { get; private set; }
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
                                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Z:\\proiect_mai_tb_codu_mod\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";

                    con.Open();

                    //verificare ca userul sa nu existe deja in baza de date
                    SqlCommand verificaEmail = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", con);
                    verificaEmail.Parameters.AddWithValue("@Email", email);
                    int existaEmail = (int)verificaEmail.ExecuteScalar();

                    if (existaEmail > 0)
                    {
                        MessageBox.Show("Utilizatorul exista deja! Folositi alt email!");
                        return;
                    }


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
            string title = "Despre";
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", title);
            IsAboutWindowOpened = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            IsHelpWindowOpened = true;
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }
    }
    
}
