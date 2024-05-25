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
            public AdaugaFilm(Administrator admin)
           {
               _admin = admin;
               InitializeComponent();
           }

            /// <summary>
            /// La apasarea butonului Close se inchide interfata curenta
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonClose_Click_1(object sender, EventArgs e)
                    {
                        this.Close();
                    }

            /// <summary>
            /// Butonul Resize este utilizat pentru a schimba dimensiunea ferestrei
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonResize_Click_1(object sender, EventArgs e)
            {
                if (WindowState == FormWindowState.Normal)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
            }

            /// <summary>
            /// Butonul 'Mini' este folosit pentru minimizarea ferestrei
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonMini_Click_1(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            /// <summary>
            /// Butonul About permite afisarea unor informatii despre proiect 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 
            private void buttonAbout_Click_1(object sender, EventArgs e)
            {
                string title = "Despre";
                MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", title);
            }

            /// <summary>
            /// La apasarea 'Help' se deschide un fisier .chm
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonHelp_Click_1(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
            }

            /// <summary>
            /// Metoda utilizata pentru design-ul interfetei AdaugaBilet
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
   
            private void AdaugaFilm_Load(object sender, EventArgs e)
            {
                labelAdaugaFilm.ForeColor = Color.White;
                panel2.BackColor = Color.FromArgb(150, 0, 0, 0);
                labelOraFilm.ForeColor = Color.White;
                labelDataFilm.ForeColor = Color.White;
                labelDurataFilm.ForeColor = Color.White;
                labelGenFilm.ForeColor = Color.White;
                labelDenumireFilm.ForeColor = Color.White;
            }
        #endregion

        private void buttonAdauga_Click_1(object sender, EventArgs e)
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

            // Inserarea în baza de date
            try
            {
                using (SqlConnection con = Conexiune.GetConexiune())
                {
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Z:\\proiect_mai_tb_codu_mod\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Movies (Name, Gen, Durata, Data, Time) VALUES (@Name, @Gen, @Durata, @Data, @Time)", con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Gen", gen);
                    cmd.Parameters.AddWithValue("@Durata", durata);
                    cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Time", time.ToString("HH:mm"));


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Film adăugat cu succes!");
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
