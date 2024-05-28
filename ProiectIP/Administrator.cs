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

    /// <summary>
    /// Clasa care implementeaza functionalitatea interfetei pentru administrator,
    /// oferind optiuni pentru adaugarea, stergerea, editarea si vizualizarea filmelor
    /// </summary>
    public partial class Administrator : Form
    {
        #region Fields

        private DataTable _dataTable; // Obiect pentru gestionarea datelor tabelare
        public AdaugaFilm _adaugaFilm; // Referinta catre formularul pentru adaugarea filmelor
        #endregion
        public static bool dateGresite = false;// Variabila pentru a verifica daca exista date gresite

        #region Methods

        /// <summary>
        /// Constructorul clasei Administrator
        /// </summary>
        public Administrator()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// Metoda pentru afisarea interfetei de adaugare a unui nou film la apasarea butonului 'Adauga Film'
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "AdaugaFilm"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonAdaugaFilmAdmin_Click(object sender, EventArgs e)
        {
            _adaugaFilm = new AdaugaFilm(this);
            _adaugaFilm.Show();
        }


        /// <summary>
        /// Metoda pentru actualizarea datelor din DataGridView-ul administratorului
        /// </summary>
        public void Actualizare()
        {
            // Interogare SQL pentru a selecta toate filmele din baza de date
            string query = "SELECT * FROM Movies";

            try
            {
                // Creeaza o conexiune si un obiect SqlCommand
                using (SqlConnection con = Conexiune.GetConexiune())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                 

                    // Creeaza un adaptor de date pentru a umple un DataSet
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Creeaza un DataSet
                        DataSet dataSet = new DataSet();

                        // Umple DataSet-ul cu datele din baza de date
                        adapter.Fill(dataSet);

                        // Verifica daca exista cel putin o tabela in DataSet
                        if (dataSet.Tables.Count > 0)
                        {
                            // Atribuie sursa de date pentru dataGridViewAdmin la prima tabela din DataSet
                            dataGridViewAdmin.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestioneaza orice exceptie si afiseaza un mesaj de eroare
                MessageBox.Show("A apărut o eroare în încărcarea datelor: " + ex.Message);
            }

        }


        /// <summary>
        /// Inchiderea aplicatiei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Close"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        /// Minimizarea aplicatiei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Mini"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// Metoda pentru editarea unui film selectat la apasarea butonului 'Editeaza Film'
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Editeaza Film"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonEditeazaFilm_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 1)
            {
                // Obtine randul selectat si id-ul filmului selectat
                DataGridViewRow filmSelectat = dataGridViewAdmin.SelectedRows[0];
                int idFilmSelectat = Convert.ToInt32(filmSelectat.Cells["Id"].Value);

                // Obtine datele filmului selectat
                DataRow filmData = ((DataRowView)filmSelectat.DataBoundItem).Row;

                // Creeaza o instanta a formularului EditeazaFilm si o afiseaza
                EditeazaFilm editeaza = new EditeazaFilm(this, idFilmSelectat, filmData);
                editeaza.Show();
            }
            else
            {
                MessageBox.Show("Selectează un singur film pentru a-l edita!");
            }
        }

        /// <summary>
        /// Metoda pentru stergerea unui film selectat la apasarea butonului 'Sterge Film'.
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul 'Sterge Film'.</param>
        /// <param name="e">Argumentele asociate evenimentului de click.</param>
        private void buttonStergeFilm_Click(object sender, EventArgs e)
        {

            dateGresite = false;// Resetarea flag-ului pentru date gresite

            // Verifica daca exact un rand este selectat in dataGridViewAdmin
            if (dataGridViewAdmin.SelectedRows.Count == 1) 
            {
                // Obtine randul selectat si id-ul filmului selectat
                DataGridViewRow filmSelectat = dataGridViewAdmin.SelectedRows[0];
                int idFilmSelectat = Convert.ToInt32(filmSelectat.Cells["Id"].Value);
                string deleteQuery = "DELETE FROM Movies WHERE id=@id"; //Stergerea filmului

                try
                { 
                    // Creeaza o conexiune si un obiect SqlCommand
                    using (SqlConnection con = Conexiune.GetConexiune())
                    {
                        SqlCommand cmd = new SqlCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@id", idFilmSelectat);
                        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IpComentat\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    // Sterge randul din DataGridView
                    dataGridViewAdmin.Rows.Remove(filmSelectat);
                }
                catch (Exception ex)
                { // Afiseaza un mesaj de eroare in caz de exceptie
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
            else
            { // Seteaza flag-ul pentru date gresite si afiseaza un mesaj de avertizare
                dateGresite = true;
                MessageBox.Show("Selectează un singur film pentru a-l șterge!");
            }
        }


        /// <summary>
        /// Metoda apelata la incarcarea formularului Administrator pentru a incarca datele filmelor
        /// </summary>
        ///  <param name="sender">Obiectul care a generat evenimentul </param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void Administrator_Load(object sender, EventArgs e)
        {
            // Interogare SQL pentru a selecta toate filmele din baza de date
            string query = "SELECT * FROM Movies";

            try
            {
                // Creaza o conexiune si un obiect SqlCommand
                using (SqlConnection con = Conexiune.GetConexiune())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    // Creeaza un adaptor de date pentru a umple un DataSet
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Creeaza un DataSet
                        DataSet dataSet = new DataSet();

                        // Umple DataSet-ul cu datele din baza de date
                        adapter.Fill(dataSet);

                        // Verifica daca exista cel putin o tabela in DataSet
                        if (dataSet.Tables.Count > 0)
                        {
                            // Atribuie sursa de date pentru dataGridViewAdmin la prima tabela din DataSet
                            dataGridViewAdmin.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestioneaza orice exceptie si afiseaza un mesaj de eroare
                MessageBox.Show("A apărut o eroare în încărcarea datelor: " + ex.Message);
            }
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

        /// <summary>
        /// Afisarea informatiilor despre proiect
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "About"</param>
        /// <param name="e">Argumentele asociate evenimentului de click</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");
        }

        /// <summary>
        /// Metoda apelata la apasarea butonului 'Filme Admin' pentru a deschide interfata de vizualizare a filmelor
        /// </summary>
        /// <param name="sender">Obiectul care a declansat evenimentul</param>
        /// <param name="e">Datele evenimentului</param>
        private void buttonFilmeAdmin_Click(object sender, EventArgs e)
        {
            // Creeaza o noua instanta a formularului Filme
            Filme filme = new Filme();
            // Afiseaza formularul Filme
            filme.Show();
        }
    }
    #endregion
}
