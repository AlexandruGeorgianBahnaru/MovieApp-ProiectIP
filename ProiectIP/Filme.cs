/**************************************************************************
 *                                                                        *
 *  File:        Filme.cs                                                 *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea secțiunii de vizualizare a filmelor        *
 *  disponibile în acel moment în baza de date.                           *
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
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ConexiuneBazaDeDate;

namespace ProiectIP
{
    /// <summary>
    /// Clasa care implementeaza sectiunea de vizualizare a filmelor disponibile
    /// </summary>
    public partial class Filme : Form
    {
        #region Fields
        private DataTable _dataTable;

        #endregion

        #region Methods

        /// <summary>
        /// Constructorul clasei Filme
        /// </summary>
        public Filme()
        {
            InitializeComponent();
            this.ControlBox = false; // Dezactiveaza butoanele de control (minimizare, maximizare, inchidere)
        }

        /// <summary>
        /// Metoda care se executa la incarcarea formularului Filme
        /// </summary>
        private void Filme_Load(object sender, EventArgs e)
        {
            SqlConnection con = null; // Declaratia conexiunii la baza de date
            try
            {
                con = Conexiune.GetConexiune();  // Obtinerea conexiunii din clasa Conexiune
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IpComentat\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                con.Open();

                string query = "SELECT * FROM Movies";// Interogarea pentru selectarea tuturor filmelor

                SqlCommand cmd = new SqlCommand(query, con); // Crearea unui SqlCommand pentru executarea interogarii
                SqlDataReader reader = cmd.ExecuteReader(); // Executarea interogarii si obtinerea unui SqlDataReader pentru citirea rezultatelor

                dataGridViewFilme.Rows.Clear(); // Golirea randurilor existente din dataGridView
                // Verificare daca dataGridView nu are coloane si adăugarea coloanelor in functie de rezultatele interogarii
                if (dataGridViewFilme.Columns.Count == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        //Adaugarea coloanelor in dataGridView - functia Add are 2 parametri , primul parametru e valoarea , al 2 lea numele coloanei
                        dataGridViewFilme.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }
                }

                // Citirea randurilor din SqlDataReader si adaugarea lor in dataGridView
                while (reader.Read())
                {
                    // Punem in linie valorile din fiecare coloana pe rand
                    object[] linie = new object[reader.FieldCount];
                    reader.GetValues(linie);
                    dataGridViewFilme.Rows.Add(linie);
                }
            }
            catch (Exception exception)
            {// Afisarea unui mesaj de eroare in caz de exceptie
                MessageBox.Show("Nu s-a putut incarca lista de filme: " + exception.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close(); // Inchiderea conexiunii in blocul finally pentru a asigura eliberarea resurselor
                }
            }
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului Help
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Help"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm"); // Deschiderea fisierului de ajutor
        }

        /// <summary>
        /// Afisarea informatiilor despre proiect
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "About"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Proiect IP 2024 - Gestiunea filmelor unui cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");

        }

        /// <summary>
        /// Minimizarea fereastrei aplicatiei
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Mini"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// Schimbarea dimensiunii ferestrei aplicatiei intre normal si maximizat
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Resize"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
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
        /// Inchiderea aplicatiei (fereastra utilizatorului)
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Close"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}