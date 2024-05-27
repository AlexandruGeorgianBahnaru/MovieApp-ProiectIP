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
        public partial class EditeazaFilm : Form
        {
            #region Fields
            private Administrator _admin;
            private int _filmId;
            private DataRow _filmData;
            public static bool dateGresite = false;

        #endregion

        #region Methods

        public EditeazaFilm(Administrator admin, int filmId, DataRow filmData)
        {
            _admin = admin;
            _filmId = filmId;
            _filmData = filmData;
            InitializeComponent();
            FormularEditare();
        }

        private void FormularEditare()
        {
            if (_filmData != null)
            {
                textBoxDenumireFilm.Text = _filmData["Name"].ToString();
                textBoxGenFilm.Text = _filmData["Gen"].ToString();
                textBoxDurataFilm.Text = _filmData["Durata"].ToString();
                textBoxDataFilm.Text = ((DateTime)_filmData["Data"]).ToString("dd.MM.yyyy");
                textBoxOraFilm.Text = _filmData["Time"].ToString();
            }
            else
            {
                MessageBox.Show("Nu s-a găsit filmul!");
            }
        }
        
        private bool verificaFormularComplet(string name, string gen, string durataText, string dataText, string timeText, out int durata, out DateTime data, out DateTime time)
        {
            durata = 0;
            data = DateTime.MinValue;
            time = DateTime.MinValue;
            dateGresite = false;

            var fields = new[] { name, gen, durataText, dataText, timeText };
            var fieldNames = new[] { "denumirea filmului", "genul filmului", "durata filmului", "data filmului", "ora filmului" };


            for (int i = 0; i < fields.Length; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                {
                    dateGresite = true;
                    MessageBox.Show($"Câmpul pentru {fieldNames[i]} este obligatoriu!");
                    return false;
                }
            }

            if (!int.TryParse(durataText, out durata) || durata <= 0)
            {
                dateGresite = true;
                MessageBox.Show("Durata introdusă nu este validă. Introduceți o durată validă, în minute!");
                return false;
            }

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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");

        }

        private void buttonEditeaza_Click(object sender, EventArgs e)
        {
            if (verificaFormularComplet(textBoxDenumireFilm.Text, textBoxGenFilm.Text, textBoxDurataFilm.Text, textBoxDataFilm.Text, textBoxOraFilm.Text, out int durata, out DateTime data, out DateTime time))
            {
                try
                {
                    string name = textBoxDenumireFilm.Text;
                    string gen = textBoxGenFilm.Text;
                    string durataText = textBoxDurataFilm.Text;
                    string dataText = textBoxDataFilm.Text;
                    string timeText = textBoxOraFilm.Text;
                    using (SqlConnection con = Conexiune.GetConexiune())
                    {
                        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Facultate\\IP\\ProiectIP\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Movies SET Name = @Name, Gen = @Gen, Durata = @Durata, Data = @Data, Time = @Time WHERE Id = @Id", con);
                        cmd.Parameters.AddWithValue("@Id", _filmId);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Gen", gen);
                        cmd.Parameters.AddWithValue("@Durata", durata);
                        cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Time", time.ToString("HH:mm"));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Filmul a fost actualizat cu succes!");
                        this.Close();
                        _admin.Actualizare();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
                }
            }
        }
        #endregion
    }
}

