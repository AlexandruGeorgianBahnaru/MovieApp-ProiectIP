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

    /// <summary>
    /// Clasa pentru implementarea optiunii de inregistrare a utilizatorilor noi, prin adaugarea acestora in tabelul Users din baza de date
    /// </summary>
    public partial class Inregistrare : Form
    {
        #region Fields
        private Administrator _admin;
        public static bool dateGresite = false; //flag
        #endregion
        #region Methods

        /// <summary>
        /// Constructorul clasei Inregistrare
        /// </summary>
        public Inregistrare()
        {

            InitializeComponent();
        }

        /// <summary>
        /// Metoda apelata la apasarea butonului de inregistrare a utilizatorului
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, de obicei butonul "Inregistrare"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            dateGresite = false;
            // Verifica daca datele din formular sunt corect introduse
            if (verificaFormularInregistrare(textBoxNume.Text, textBoxPrenume.Text, textBoxEmail.Text, textBoxParola.Text))
            {
                try
                {
                    // Preia datele din campurile formularului
                    string nume = textBoxNume.Text;
                    string prenume = textBoxPrenume.Text;
                    string email = textBoxEmail.Text;
                    string parola = textBoxParola.Text;
                    using (SqlConnection con = Conexiune.GetConexiune())
                    {

                        // Creeaza si deschide conexiunea la baza de date
                        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IpComentat\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                        con.Open();

                        // Verifica daca adresa de email exista deja in baza de date
                        SqlCommand verificaEmail = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", con);
                        verificaEmail.Parameters.AddWithValue("@Email", email);
                        int existaEmail = (int)verificaEmail.ExecuteScalar();

                        // Daca emailul exista, afiseaza un mesaj de eroare
                        if (existaEmail > 0)
                        {
                            dateGresite = true;
                            MessageBox.Show("Utilizatorul există deja! Folosiți alt email!");
                            return;
                        }

                        // Insereaza noul utilizator in baza de date
                        SqlCommand cmd = new SqlCommand("INSERT INTO Users (Nume, Prenume, Email, Parola, Admin) VALUES (@Nume, @Prenume, @Email, @Parola, @Admin)", con);
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cmd.Parameters.AddWithValue("@Prenume", prenume);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Parola", parola);
                        cmd.Parameters.AddWithValue("@Admin", false);

                        // Executa comanda de inserare
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Utilizatorul a fost înregistrat cu succes!");
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    // Afiseaza un mesaj de eroare in caz de exceptie
                    MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Metoda pentru verificarea corectitudinii datelor din formularul de inregistrare
        /// </summary>
        /// <param name="nume">Numele utilizatorului</param>
        /// <param name="prenume">Prenumele utilizatorului</param>
        /// <param name="email">Adresa de email a utilizatorului</param>
        /// <param name="parola">Parola utilizatorului</param>
        /// <returns>True dacă toate datele sunt valide, altfel False</returns>
        private bool verificaFormularInregistrare(string nume, string prenume, string email, string parola)
        {
            dateGresite = true; // Seteaza flag-ul dateGresite la true pentru a indica date incorecte

            // Verifica daca oricare dintre campuri este gol
            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(prenume) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Completati toate campurile");
                return false;
            }

            // Formatele acceptate pentru adresele de email
            string[] mailuri = { "@gmail.com", "@gmail.ro", "@yahoo.com", "@yahoo.ro", "@hotmail.com", "@hotmail.ro" };
            bool esteMailValid = false;

            // Verifica daca email-ul se termina cu una dintre terminatiile acceptate
            foreach (string d in mailuri)
            {
                if (email.EndsWith(d.ToLower()))
                {
                    esteMailValid = true;
                    break;
                }
            }

            // Verifica daca lungimea numelui este mai mare de 3 caractere
            if (nume.Length < 3)
            {
                MessageBox.Show("Numele trebuie sa aiba cel puțin 3 caractere!");
                return false;
            }

            // Verifica daca lungimea prenumelui este mai mare de 3 caractere
            if (prenume.Length < 3)
            {
                MessageBox.Show("Prenumele trebuie sa aiba cel puțin 3 caractere!");
                return false;
            }

            // Verifica daca terminatia adresei de email este corecta
            if (!esteMailValid)
            {
                MessageBox.Show("Emailul trebuie sa fie de tipul @gmail.com, @gmail.ro, @yahoo.com, @yahoo.ro, @hotmail.com, @hotmail.ro");
                return false;
            }

            // Verifica daca lungimea parolei este mai mare de 5 caractere
            if (parola.Length < 5)
            {
                MessageBox.Show("Parola trebuie sa aiba cel puțin 5 caractere!");
                return false;
            }

            // Toate condițiile sunt indeplinite, datele sunt corecte
            dateGresite = false;
            return true;  
        }

        /// <summary>
        /// Metoda pentru minimizarea ferestrei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Mini"</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        /// Metoda pentru inchiderea ferestrei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul,  aici butonul "Close"</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda pentru afisarea informatiilor despre proiect
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "About"</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Gestiunea filmelor unui cinema \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");
        }

        /// <summary>
        /// Metoda pentru deschiderea fisierului de ajutor
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Help"</param>
        /// <param name="e">Argumentele evenimentului</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        #endregion
    }

}
