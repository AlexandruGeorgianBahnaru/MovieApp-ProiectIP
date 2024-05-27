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
    public partial class Filme : Form
    {
        #region Fields
        private DataTable _dataTable;

        #endregion

        #region Methods
        /// <summary>
        /// Constructorul clasei Rute
        /// </summary>
        public Filme()
        {
            InitializeComponent();
            this.ControlBox = false;
        }


        private void Filme_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = Conexiune.GetConexiune();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Facultate\\IP\\ProiectIP\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
                con.Open();

                string query = "SELECT * FROM Movies";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridViewFilme.Rows.Clear();
                //ne asiguram ca nu e nimic in spatiul respectiv si formam mai intai coloanele
                if (dataGridViewFilme.Columns.Count == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        //functie Add are 2 parametri , primul parametru e valoarea , al 2 lea numele coloanei
                        dataGridViewFilme.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }
                }

                while (reader.Read())
                {
                    //punem in linie valorile din fiecare coloana pe rand
                    object[] linie = new object[reader.FieldCount];
                    reader.GetValues(linie);
                    dataGridViewFilme.Rows.Add(linie);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nu s-a putut incarca lista de filme: " + exception.Message);
            }
            finally
            {
                con.Close();
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}