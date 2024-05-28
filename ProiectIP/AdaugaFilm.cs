/**************************************************************************
 *                                                                        *
 *  File:        AdaugaFilm.cs                                            *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementează adăugarea înregistrărilor în tabela Movies *
 *  de către admin.                                                       *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using ProiectIP;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ConexiuneBazaDeDate;
namespace ProiectIP
{
    /// <summary>
    /// Clasa care implementeaza functionalitatea pentru adaugarea unui film nou in baza de date de catre administrator
    /// </summary>
    public partial class AdaugaFilm : Form
    {
        #region Fields
        private Administrator _admin; // Referinta catre formularul Administrator pentru actualizare
        public static bool dateGresite = false; // Flag pentru a verifica daca exista date gresite in formular
        #endregion

        #region Methods
        /// <summary>
        /// Constructorul clasei AdaugaFilm
        /// </summary>
        /// <param name="admin">Referinta catre formularul Administrator</param>
        public AdaugaFilm(Administrator admin)
            {
                _admin = admin;
                InitializeComponent();
            }


        /// <summary>
        /// Metoda apelata la apasarea butonului 'Adauga' pentru a adauga un nou film in baza de date
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Adauga"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonAdauga_Click(object sender, EventArgs e)
            {
            dateGresite = false;// Resetarea variabilei pentru date gresite

            // Verificarea completitudinii si corectitudinii datelor din formular
            if (verificaFormularComplet(textBoxDenumireFilm.Text, textBoxGenFilm.Text, textBoxDurataFilm.Text, textBoxDataFilm.Text, textBoxOraFilm.Text, out int durata, out DateTime data, out DateTime time))
            {
                try
                {
                    // Extrage datele din campurile formularului
                    string name = textBoxDenumireFilm.Text;
                    string gen = textBoxGenFilm.Text;
                    string durataText = textBoxDurataFilm.Text;
                    string dataText = textBoxDataFilm.Text;
                    string timeText = textBoxOraFilm.Text;

                    // Se stabileste conexiunea la baza de date
                    using (SqlConnection con = Conexiune.GetConexiune())
                    {
                        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IpComentat\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                        con.Open();

                        // Se creeaza comanda pentru inserarea unui nou film in baza de date
                        SqlCommand cmd = new SqlCommand("INSERT INTO Movies (Name, Gen, Durata, Data, Time) VALUES (@Name, @Gen, @Durata, @Data, @Time)", con);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Gen", gen);
                        cmd.Parameters.AddWithValue("@Durata", durata);
                        cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Time", time.ToString("HH:mm"));

                        // Executa comanda si adauga filmul in baza de date
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Filmul " + name + " a fost adăugat cu succes!");
                        this.Close();// Inchide formularul curent
                        _admin.Actualizare();  // Actualizeaza datele in formularul Administratorului
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
                }
            }
            else
                dateGresite = true;  // Seteaza variabila pentru date gresite
        }

        /// <summary>
        /// Metoda pentru a verifica completitudinea si corectitudinea datelor introduse in formular
        /// </summary>
        /// <param name="name">Numele filmului</param>
        /// <param name="gen">Genul filmului</param>
        /// <param name="durataText">Durata filmului</param>
        /// <param name="dataText">Data filmului</param>
        /// <param name="timeText">Ora filmului</param>
        /// <param name="durata">Durata filmului in minute</param>
        /// <param name="data">Data filmului</param>
        /// <param name="time">Ora filmului</param>
        /// <returns>true daca toate datele sunt valide, false in caz contrar</returns>
        private bool verificaFormularComplet(string name, string gen, string durataText, string dataText, string timeText, out int durata, out DateTime data, out DateTime time)
            {
                durata = 0;
                data = DateTime.MinValue;
                time = DateTime.MinValue;

            // Array-uri pentru campurile formularului si numele acestora
               var fields = new[] { name, gen, durataText, dataText, timeText };
                var fieldNames = new[] { "denumirea filmului", "genul filmului", "durata filmului", "data filmului", "ora filmului" };

            // Verificarea daca toate campurile sunt completate
            for (int i = 0; i < fields.Length; i++)
                {
                    if (string.IsNullOrEmpty(fields[i]))
                    {
                        MessageBox.Show($"Câmpul pentru {fieldNames[i]} este obligatoriu!");
                        return false;
                    }
                }

            // Verificarea daca durata este un numar valid si mai mare decat zero
            if (!int.TryParse(durataText, out durata) || durata <= 0)
                {
                    MessageBox.Show("Durata introdusă nu este validă. Introduceți o durată validă, în minute!");
                    return false;
                }

            // Verificare daca data este introdusa in formatul corect
            try
            {
                    data = DateTime.ParseExact(dataText, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Data introdusă nu este validă! Introduceți o dată în formatul dd.MM.yyyy, unde dd = ziua, MM = luna, yyyy = anul");
                    return false;
                }

            // Verificare daca ora este introdusa in formatul corect
            try
            {
                    time = DateTime.ParseExact(timeText, "HH:mm", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ora introdusă este invalidă! Introduceți o oră în formatul HH:mm, unde HH = ora, mm = minutele");
                    return false;
                }

                return true;
            }

        /// <summary>
        /// Inchiderea aplicatiei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Close"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        /// <summary>
        /// Minimizarea aplicatiei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Mini"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
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
        /// Afisarea informatiilor despre proiect
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "About"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonAbout_Click(object sender, EventArgs e)
            {

            MessageBox.Show("Proiect IP 2024 - Gestionarea filmelor unui cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului Help
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Help"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonHelp_Click(object sender, EventArgs e)
            {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");

        }

        #endregion


    }

}


