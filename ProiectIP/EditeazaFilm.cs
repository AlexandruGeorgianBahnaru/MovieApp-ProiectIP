/**************************************************************************
 *                                                                        *
 *  File:        EditeazaFilm.cs                                          *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea editării unei înregistrări deja existente  *
 *  în tabela Movies de către admin.                                      *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using ConexiuneBazaDeDate;
    using ProiectIP;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    namespace ProiectIP
    {
    /// <summary>
    /// Clasa pentru implementarea functionalitatii de editare a unei inregistrari deja existente in tabela Movies de catre administrator
    /// </summary>
    public partial class EditeazaFilm : Form
        {
            #region Fields
            private Administrator _admin; // Instanta a clasei Administrator, utilizata pentru gestionarea operatiunilor de administrare
            private int _filmId; // ID-ul filmului care urmeaza sa fie editat
            private DataRow _filmData;// Datele filmului, stocate sub forma de DataRow, care vor fi utilizate pentru completarea formularului de editare
            public static bool dateGresite = false; // Flag care indica daca exista date incorecte in formular

        #endregion

        #region Methods

        /// <summary>
        /// Constructor pentru clasa EditeazaFilm
        /// </summary>
        /// <param name="admin">Administratorul care efectueaza editarea</param>
        /// <param name="filmId">ID-ul filmului de editat</param>
        /// <param name="filmData">Datele filmului de editat</param>
        public EditeazaFilm(Administrator admin, int filmId, DataRow filmData)
        {
            _admin = admin;
            _filmId = filmId;
            _filmData = filmData;
            InitializeComponent();
            FormularEditare();
        }

        /// <summary>
        /// Metoda pentru completarea formularului de editare cu datele filmului
        /// </summary>
        private void FormularEditare()
        {
            if (_filmData != null)
            {  // Completare campuri formular cu datele filmului din _filmData
                textBoxDenumireFilm.Text = _filmData["Name"].ToString();
                textBoxGenFilm.Text = _filmData["Gen"].ToString();
                textBoxDurataFilm.Text = _filmData["Durata"].ToString();
                textBoxDataFilm.Text = ((DateTime)_filmData["Data"]).ToString("dd.MM.yyyy");
                textBoxOraFilm.Text = _filmData["Time"].ToString();
            }
            else
            {
                // Afiseaza un mesaj de eroare daca datele filmului nu au fost gasite
                MessageBox.Show("Nu s-a găsit filmul!");
            }
        }


        /// <summary>
        /// Verifica intregimea si corectitudinea datelor din formular
        /// </summary>
        /// <param name="name">Numele filmului</param>
        /// <param name="gen">Genul filmului</param>
        /// <param name="durataText">Durata filmului in minute sub forma de text</param>
        /// <param name="dataText">Data filmului sub forma de text</param>
        /// <param name="timeText">Ora filmului sub forma de text</param>
        /// <param name="durata">Variabila pentru a retine durata filmului</param>
        /// <param name="data">Variabila pentru a retine data filmului</param>
        /// <param name="time">Variabila pentru a retine ora filmului</param>
        /// <returns>Returneaza true daca toate datele sunt valide, altfel false</returns>
        private bool verificaFormularComplet(string name, string gen, string durataText, string dataText, string timeText, out int durata, out DateTime data, out DateTime time)
        {
            durata = 0;
            data = DateTime.MinValue;
            time = DateTime.MinValue;
            dateGresite = false;


            // Array cu toate campurile de verificat
            var fields = new[] { name, gen, durataText, dataText, timeText };
            var fieldNames = new[] { "denumirea filmului", "genul filmului", "durata filmului", "data filmului", "ora filmului" };


            // Verificarea completitudinii campurilor
            for (int i = 0; i < fields.Length; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                {
                    dateGresite = true;
                    MessageBox.Show($"Câmpul pentru {fieldNames[i]} este obligatoriu!");
                    return false;
                }
            }

            // Verificarea corectitudinii duratei
            if (!int.TryParse(durataText, out durata) || durata <= 0)
            {
                dateGresite = true;
                MessageBox.Show("Durata introdusă nu este validă. Introduceți o durată validă, în minute!");
                return false;
            }
            // Verificarea corectitudinii datei
            try
            {
                data = DateTime.ParseExact(dataText, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                dateGresite = true;
                MessageBox.Show("Data introdusă nu este validă! Introduceți o dată în formatul dd.MM.yyyy, unde dd = ziua, MM = luna, yyyy = anul");
                return false;
            }

            // Verificarea corectitudinii orei
            try
            {
                time = DateTime.ParseExact(timeText, "HH:mm", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                dateGresite = true;
                MessageBox.Show("Ora introdusă este invalidă! Introduceți o oră în formatul HH:mm, unde HH = ora, mm = minutele");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inchide fereastra curenta
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Close"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Minimizeaza fereastra curenta
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Mini"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Maximzeaza sau restaureaza fereastra curenta in functie de starea sa actuala
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
        /// Deschide fisierul de ajutor
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "About"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        /// <summary>
        /// Afiseaza un mesaj cu informatii despre proiect
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Help"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");
            
        }

        /// <summary>
        /// Metoda pentru actualizarea datelor filmului in baza de date
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Editeaza"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonEditeaza_Click(object sender, EventArgs e)
        {

            // Verifica daca datele din formular sunt completate corect
            if (verificaFormularComplet(textBoxDenumireFilm.Text, textBoxGenFilm.Text, textBoxDurataFilm.Text, textBoxDataFilm.Text, textBoxOraFilm.Text, out int durata, out DateTime data, out DateTime time))
            {
                try
                {
                    // Preia datele din campurile formularului
                    string name = textBoxDenumireFilm.Text;
                    string gen = textBoxGenFilm.Text;
                    string durataText = textBoxDurataFilm.Text;
                    string dataText = textBoxDataFilm.Text;
                    string timeText = textBoxOraFilm.Text;

                    // Creeaza si deschide conexiunea la baza de date
                    using (SqlConnection con = Conexiune.GetConexiune())
                    {
                        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IpComentat\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                        con.Open();

                        // Creeaza comanda SQL pentru actualizarea filmului
                        SqlCommand cmd = new SqlCommand("UPDATE Movies SET Name = @Name, Gen = @Gen, Durata = @Durata, Data = @Data, Time = @Time WHERE Id = @Id", con);
                        cmd.Parameters.AddWithValue("@Id", _filmId);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Gen", gen);
                        cmd.Parameters.AddWithValue("@Durata", durata);
                        cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Time", time.ToString("HH:mm"));

                        // Executa comanda de actualizare
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Filmul a fost actualizat cu succes!");

                        // Inchide formularul curent
                        this.Close();

                        // Actualizeaza datele in interfata administratorului
                        _admin.Actualizare();
                    }
                }
                catch (Exception ex)
                {
                    // Afiseaza un mesaj de eroare in caz de exceptie
                    MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
                }
            }
        }
        #endregion
    }
}

