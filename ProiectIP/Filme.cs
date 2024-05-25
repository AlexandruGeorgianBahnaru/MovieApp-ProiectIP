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
    { private DataTable _dataTable;
        public bool IsHelpWindowOpened { get; private set; }
        public bool IsAboutWindowOpened { get; private set; }
       

        #region Methods
        /// <summary>
        /// Constructorul clasei Rute
        /// </summary>
        public Filme()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        /// <summary>
        /// Metoda pentru afisarea rutelor existente la incarcarea interfetei pentru Rute
        /// </summary>
        private void Filme_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = Conexiune.GetConexiune();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiect_ip_24.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";
            string query = "SELECT * FROM Movies";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            _dataTable = new DataTable();
            da.Fill(_dataTable);
            dataGridViewFilme.DataSource = _dataTable;
            con.Close();

            labelFilme.ForeColor = Color.White;
            panelDate.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

     
        #endregion

        private void buttonAbout_Click_1(object sender, EventArgs e)
        {
            string title = "Despre";
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", title);
            IsAboutWindowOpened = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            IsHelpWindowOpened = true;
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        private void dataGridViewFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonResize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
