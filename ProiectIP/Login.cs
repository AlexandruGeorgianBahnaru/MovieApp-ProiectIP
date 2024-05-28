/**************************************************************************
 *                                                                        *
 *  File:        Login.cs                                                 *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea opțiunii de logare a utilizatorilor deja   *
 *  existenți în tabelul Users.                                           *
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexiuneBazaDeDate;
namespace ProiectIP
{

    /// <summary>
    /// Clasa pentru implementarea optiunii de login a utilizatorilor care au deja cont
    public partial class Login : Form
    {
        #region Fields
        public static bool dateGresite = false;
        #endregion

        #region Methods
        /// <summary>
        /// Constructorul clasei Login
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda apelata când utilizatorul apasa butonul de login
        /// Verifica credentialele utilizatorului si deschide formularul corespunzator
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Login"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            dateGresite = false;// Initializarea flagului datelor gresite la fals 
            SqlConnection con = null;   // Initializarea conexiunii la baza de date
            try
                {
                   // Inițializarea conexiunii la baza de date
                    con = Conexiune.GetConexiune();
                      // Setarea stringului de conexiune cu baza de date
                      con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IpComentat\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";

                   // Deschiderea conexiunii cu baza de date
                   con.Open();

                   // Obțtinerea adresei de email introduse de utilizator din TextBox-ul textBoxEmail
                    string email = textBoxEmail.Text;
                   // Crearea interogarii SQL pentru a numara cate intrari din baza de date au adresa de email specificata
                     string query = "SELECT COUNT(*) FROM Users WHERE Email = '" + email + "'";

                // Crearea unui obiect SqlCommand pentru a executa interogarea
                SqlCommand cmdEmail = new SqlCommand(query, con);
                // Executarea interogarii si obtinerea numarului rezultat
                int contorEmail = (int)cmdEmail.ExecuteScalar();

                // Verificare daca adresa de email introdusa exista in baza de date
                if (contorEmail == 0)
                { // Daca nu exista, se seteaza variabila de control a datelor gresite la adevarat si se afiseaza un mesaj de eroare
                    dateGresite = true;
                        MessageBox.Show("Email sau parola incorecte!");
                    }
                // Daca exista o singura intrare cu adresa de email specificata in baza de date
                else if (contorEmail == 1)
                    {
                    // Obtinerea parolei introduse de utilizator din TextBox-ul textBoxParola
                       string parola = textBoxParola.Text;
                    // Crearea interogarii SQL pentru a selecta coloana "Admin" din baza de date pentru utilizatorul cu adresa de email si parola specificate
                    string querySelect = "SELECT Admin FROM Users WHERE Email = '" + email + "' and Parola = '" + parola + "'";

                    // Crearea unui obiect SqlCommand pentru a executa interogarea
                    SqlCommand cmd = new SqlCommand(querySelect, con);
                    // Executarea interogarii si obtinerea rezultatului (daca exista)
                    object rezultat = cmd.ExecuteScalar();

                    // Verificarea tipului rezultatului si daca utilizatorul este administrator sau nu
                    if (rezultat != null && (bool)rezultat)
                        {
                        // Daca utilizatorul este administrator, se deschide formularul Administrator si se inchide formularul de autentificare
                        Administrator admin = new Administrator();
                            admin.Show();
                            this.Hide();
                        }
                        else if (rezultat != null && !(bool)rezultat)
                        {
                        // Dacăa utilizatorul nu este administrator, se deschide formularul Utilizator si se inchide formularul de autentificare
                        Utilizator user = new Utilizator();
                            user.Show();
                            this.Hide();
                        }
                        else
                        {
                        // Daca parola introdusa nu corespunde cu adresa de email, se seteaza variabila de control a datelor gresite la adevsrat si se afiseaza un mesaj de eroare
                        dateGresite = true;
                        MessageBox.Show("Parola incorectă!");
                        }


                    }
                }
                catch (Exception exception)
                {
                // In caz de exceptie, se afiseaza un mesaj de eroare
                MessageBox.Show("Nu s-a putut efectua conexiunea la baza de date: " + exception.Message);
                }
                finally
                {
                // In blocul finally, se inchide conexiunea la baza de date, daca aceasta este deschisa
                if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            
        }

        /// <summary>
        /// Butonul About permite afisarea unor informatii despre proiect 
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Gestiunea filmelor unui cinema \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "Despre");
        }

        /// <summary>
        /// La apasarea 'Help' se deschide un fisier .chm
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        /// <summary>
        /// Schimbarea dimensiunii ferestrei aplicatiei intre normal si maximizat
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Resize"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonResize_Click(object sender, EventArgs e)
        {
            // Verificare daca starea ferestrei este normala
            if (WindowState == FormWindowState.Normal)
                // Daca este, se seteaza starea la maximizat
                this.WindowState = FormWindowState.Maximized;
            else
                // Altfel, se seteaza starea la normal
                this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// La apasarea butonului Close se inchide interfata curenta
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Close"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  Butonul 'Mini' este folosit pentru minimizarea ferestrei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Mini"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// La apasarea butonului Inregistrare se deschide formularul de inregistrare
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Inregistrare"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            Inregistrare reg1 = new Inregistrare();
            reg1.Show();
        }


        #endregion
    }
}