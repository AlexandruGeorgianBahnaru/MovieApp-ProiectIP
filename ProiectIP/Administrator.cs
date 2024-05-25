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
        private List<string> _lista_id;
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
            _lista_id = new List<string>();
        }

        /// <summary>
        /// Metoda pentru aparitia interfetei pentru Adaugarea unui nou bilet la apasarea butonului 'Adauga Bilet'
        /// </summary>
        private void buttonAdaugaFilmAdmin_Click(object sender, EventArgs e)
        {
            _adaugaFilm = new AdaugaFilm(this);
            _adaugaFilm.Show();
        }

       
        /// <summary>
        /// Metoda care permite sa fie vizibila orice actualizare facuta pentru bilete: adaugarea/stergere/editarea
        /// </summary>
        public void ReloadTable()
        {
            SqlConnection con = Conexiune.GetConexiune();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Movies", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewAdmin.DataSource = dt;
            con.Close();
        }

        

        /// <summary>
        /// Metoda care prelueaza id-ul biletului din coloana selectata
        /// </summary>
        /// <returns>List of ids</returns>
        public List<string> GetId()
        {
           foreach (DataGridViewRow row in dataGridViewAdmin.SelectedRows)
            {
                _lista_id.Add(row.Cells["Id"].Value.ToString());
            }
            return _lista_id;
        }

        /// <summary>
        /// Stergere id-uri din lista - la terminarea editarii unui bilet eliberez lista de id-uri
        /// </summary>
        public void ClearIds()
        {
            _lista_id.Clear();
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

        public AdaugaFilm GetFilm()
        {
            return _adaugaFilm;
        }


        #endregion

        private void buttonFilmeAdmin_Click_1(object sender, EventArgs e)
        {

            Filme filme = new Filme();
            filme.Show();
        }

        private void buttonEditeazaFilm_Click(object sender, EventArgs e)
        {
            EditeazaFilm editeaza = new EditeazaFilm(this);
           editeaza.Show();
        }

        private void buttonStergeFilm_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewAdmin.SelectedRows)
            {
                SqlConnection con = Conexiune.GetConexiune();
                SqlCommand cmd = con.CreateCommand();
                int id = Convert.ToInt32(dataGridViewAdmin.SelectedRows[0].Cells[0].Value);
                cmd.CommandText = "Delete from Movies where id='" + id + "'";
                dataGridViewAdmin.Rows.RemoveAt(this.dataGridViewAdmin.SelectedRows[0].Index);
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiect_ip_24.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }

        private void Administrator_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = Conexiune.GetConexiune();
            string query = "SELECT * FROM Movies";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            _dataTable = new DataTable();
            da.Fill(_dataTable);
            dataGridViewAdmin.DataSource = _dataTable;
            con.Close();
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            string title = "Despre";
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", title);

        }
    }
}
