    /**************************************************************************
     *                                                                        *
     *  File:        EditeazaBilet.cs                                         *
     *  Copyright:   (c) 2023, Butu Alexandra-Gabriela                        *
     *  Description: Class for movie editing                                 *           
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
            #endregion

            #region Methods
        
            public EditeazaFilm()
            {
                InitializeComponent();
            }

            public EditeazaFilm(Administrator admin)
            {
                _admin = admin;
                InitializeComponent();
            GetMovieInfo();
            }



        /// <summary>
        /// Metoda folosita pentru a afisa informatiile referitoare la un bilet cand se doreste editarea acestuia
        /// </summary>
        private void GetMovieInfo()
        {
            try
            {
                List<string> lista_id = _admin.GetId();

                if (lista_id.Count == 0)
                {
                    MessageBox.Show("Selectează un film!");
                    return;
                }

                int id = Convert.ToInt32(lista_id[0]);

                using (SqlConnection con = Conexiune.GetConexiune())
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Movies WHERE Id = @Id", con);
                    da.SelectCommand.Parameters.AddWithValue("@Id", id);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxDenumireFilm.Text = dt.Rows[0]["Name"].ToString();
                        textBoxGenFilm.Text = dt.Rows[0]["Gen"].ToString();
                        textBoxDurataFilm.Text = dt.Rows[0]["Durata"].ToString();
                        textBoxDataFilm.Text = ((DateTime)dt.Rows[0]["Data"]).ToString("dd.MM.yyyy");
                        textBoxOraFilm.Text = dt.Rows[0]["Time"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a găsit filmul!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la conectarea cu baza de date: " + ex.Message);
            }

            _admin.ClearIds();
        }

        /// <summary>
        /// Butonul About permite afisarea unor informatii despre proiect 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
            {
                string title = "Despre";
       MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", title);        }

            /// <summary>
            /// La apasarea 'Help' se deschide un fisier .chm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonHelp_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("Gestionarea biletelor de autobuz.chm");
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
            ///  Butonul Resize este utilizat pentru a schimba dimensiunea ferestrei
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
            ///  Butonul 'Mini' este folosit pentru minimizarea ferestrei
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonMini_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            /// <summary>
            /// Metoda utilizata pentru design-ul EditeazaBilet
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void EditeazaBilet_Load(object sender, EventArgs e)
            {
                labelEditeazaFilm.ForeColor = Color.White;
                panelDate.BackColor = Color.FromArgb(150, 0, 0, 0);
                labelDenumireFilm.ForeColor = Color.White;
                labelGenFilm.ForeColor = Color.White;
                labelDataFilm.ForeColor = Color.White;
                labelDurataFilm.ForeColor = Color.White;
                labelOraFilm.ForeColor = Color.White;
            }
            #endregion

            private void buttonEditeaza_Click_1(object sender, EventArgs e)
            {
          
                    string name = textBoxDenumireFilm.Text;
                    string gen = textBoxGenFilm.Text;
                    string durataText = textBoxDurataFilm.Text;
                    string dataText = textBoxDataFilm.Text;
                    string timeText = textBoxOraFilm.Text;
                    int durata;

                    // Validarea intrărilor
                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gen) || string.IsNullOrEmpty(durataText) ||
                        string.IsNullOrEmpty(dataText) || string.IsNullOrEmpty(timeText))
                    {
                        MessageBox.Show("Toate câmpurile sunt obligatorii!");
                        return;
                    }

                    // Validarea și conversia duratei
                    if (!int.TryParse(durataText, out durata) || durata <= 0)
                    {
                        MessageBox.Show("Introdu o durată validă.");
                        return;
                    }

                    // Validarea și conversia datelor
                    DateTime data;
                    DateTime time;

                    try
                    {
                        data = DateTime.ParseExact(dataText, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Dată invalidă! Formatul este: dd.MM.yyyy");
                        return;
                    }

                    try
                    {
                        time = DateTime.ParseExact(timeText, "HH:mm", CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Ora invalidă! Formatul este: HH:mm");
                        return;
                    }

                    // Editarea în baza de date
                    try
                    {
                        List<string> lista_id = _admin.GetId();
                        using (SqlConnection con = Conexiune.GetConexiune())
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE Movies SET Name = @Name, Gen = @Gen, Durata = @Durata, Data = @Data, Time = @Time WHERE Id = @Id", con);
                            cmd.Parameters.AddWithValue("@Id", lista_id[0]);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Gen", gen);
                            cmd.Parameters.AddWithValue("@Durata", durata);
                            cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Time", time.ToString("HH:mm"));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Filmul a fost actualizat cu succes!");
                            this.Close();
                            _admin.ReloadTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
                    }
                }

            }
        }

