/**************************************************************************
 *                                                                        *
 *  File:        Administrator.cs                                         *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea interfeței cu opțiunile disponibile pentru *
 *  admin: adăugare filme, ștergere filme, editare filme și vizualizare   *
 *  filme.                                                                *
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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ConexiuneBazaDeDate;
namespace ProiectIP
{
    public partial class Administrator : Form
    {
        #region Fields

        private DataTable _dataTable;
        public AdaugaFilm _adaugaFilm;
        #endregion


        #region Methods
        /// <summary>
        /// Constructorul clasei Administrator
        /// </summary>
        public Administrator()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Metoda pentru aparitia interfetei pentru Adaugarea unui nou bilet la apasarea butonului 'Adauga Bilet'
        /// </summary>
        private void buttonAdaugaFilmAdmin_Click(object sender, EventArgs e)
        {
            _adaugaFilm = new AdaugaFilm(this);
            _adaugaFilm.Show();
        }


        
       public void Actualizare()
        {
            // Interogare SQL pentru a selecta toate filmele din baza de date
            string query = "SELECT * FROM Movies";

            try
            {
                // Crează o conexiune și un obiect SqlCommand
                using (SqlConnection con = Conexiune.GetConexiune())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Deschide conexiunea
                    

                    // Creează un adaptor de date pentru a umple un DataSet
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Creează un DataSet
                        DataSet dataSet = new DataSet();

                        // Umple DataSet-ul cu datele din baza de date
                        adapter.Fill(dataSet);

                        // Verifică dacă există cel puțin o tabelă în DataSet
                        if (dataSet.Tables.Count > 0)
                        {
                            // Atribuie sursa de date pentru dataGridViewAdmin la prima tabelă din DataSet
                            dataGridViewAdmin.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestionează orice excepție și afișează un mesaj de eroare
                MessageBox.Show("A apărut o eroare în încărcarea datelor: " + ex.Message);
            }

        }



        /// <summary>
        /// La apasarea butonului Close se inchide interfata curenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Butonul Resize este utilizat pentru a schimba dimensiunea ferestrei
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
        /// Butonul 'Mini' este folosit pentru minimizarea ferestrei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void buttonEditeazaFilm_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 1)
            {
                DataGridViewRow filmSelectat = dataGridViewAdmin.SelectedRows[0];
                int idFilmSelectat = Convert.ToInt32(filmSelectat.Cells["Id"].Value);

                DataRow filmData = ((DataRowView)filmSelectat.DataBoundItem).Row;

                EditeazaFilm editeaza = new EditeazaFilm(this, idFilmSelectat, filmData);
                editeaza.Show();
            }
            else
            {
                MessageBox.Show("Selectează un singur film pentru a-l edita!");
            }
        }


        private void buttonStergeFilm_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 1) 
            {
                DataGridViewRow filmSelectat = dataGridViewAdmin.SelectedRows[0];
                int idFilmSelectat = Convert.ToInt32(filmSelectat.Cells["Id"].Value);
                string deleteQuery = "DELETE FROM Movies WHERE id=@id";

                try
                {
                    using (SqlConnection con = Conexiune.GetConexiune())
                    {
                        SqlCommand cmd = new SqlCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@id", idFilmSelectat);
                        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiec_ip_25.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    dataGridViewAdmin.Rows.Remove(filmSelectat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selectează un singur film pentru a-l șterge!");
            }
        }



        private void Administrator_Load(object sender, EventArgs e)
        {
            // Interogare SQL pentru a selecta toate filmele din baza de date
            string query = "SELECT * FROM Movies";

            try
            {
                // Crează o conexiune și un obiect SqlCommand
                using (SqlConnection con = Conexiune.GetConexiune())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Deschide conexiunea
                 

                    // Creează un adaptor de date pentru a umple un DataSet
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Creează un DataSet
                        DataSet dataSet = new DataSet();

                        // Umple DataSet-ul cu datele din baza de date
                        adapter.Fill(dataSet);

                        // Verifică dacă există cel puțin o tabelă în DataSet
                        if (dataSet.Tables.Count > 0)
                        {
                            // Atribuie sursa de date pentru dataGridViewAdmin la prima tabelă din DataSet
                            dataGridViewAdmin.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestionează orice excepție și afișează un mesaj de eroare
                MessageBox.Show("A apărut o eroare în încărcarea datelor: " + ex.Message);
            }
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");
        }

        private void buttonFilmeAdmin_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Show();
        }
    }
    #endregion
}
