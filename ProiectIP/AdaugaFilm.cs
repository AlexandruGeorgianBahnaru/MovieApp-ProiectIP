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
    public partial class AdaugaFilm : Form
    {
        #region Fields
        private Administrator _admin;
        #endregion

        #region Methods
            /// <summary>
            /// Constructor prin care se trimit datele de la formul Administratorului la formul din AdaugaBilet
            /// </summary>
            /// <param name="admin">instanta administrator </param>
            /// 
            public AdaugaFilm(Administrator admin)
            {
                _admin = admin;
                InitializeComponent();
            }

            private void buttonAdauga_Click(object sender, EventArgs e)
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
                            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiec_ip_25.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO Movies (Name, Gen, Durata, Data, Time) VALUES (@Name, @Gen, @Durata, @Data, @Time)", con);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Gen", gen);
                            cmd.Parameters.AddWithValue("@Durata", durata);
                            cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Time", time.ToString("HH:mm"));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Filmul " + name + " a fost adăugat cu succes!");
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

            private bool verificaFormularComplet(string name, string gen, string durataText, string dataText, string timeText, out int durata, out DateTime data, out DateTime time)
            {
                durata = 0;
                data = DateTime.MinValue;
                time = DateTime.MinValue;


                var fields = new[] { name, gen, durataText, dataText, timeText };
                var fieldNames = new[] { "denumirea filmului", "genul filmului", "durata filmului", "data filmului", "ora filmului" };


                for (int i = 0; i < fields.Length; i++)
                {
                    if (string.IsNullOrEmpty(fields[i]))
                    {
                        MessageBox.Show($"Câmpul pentru {fieldNames[i]} este obligatoriu!");
                        return false;
                    }
                }

                if (!int.TryParse(durataText, out durata) || durata <= 0)
                {
                    MessageBox.Show("Durata introdusă nu este validă. Introduceți o durată validă, în minute!");
                    return false;
                }

                try
                {
                    data = DateTime.ParseExact(dataText, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Data introdusă nu este validă! Introduceți o dată în formatul dd.MM.yyyy, unde dd = ziua, MM = luna, yyyy = anul");
                    return false;
                }

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

        #endregion


    }

}


