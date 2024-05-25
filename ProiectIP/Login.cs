/**************************************************************************
 *                                                                        *
 *  File:        Login.cs                                                 *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea opțiunii de logare a utilizatorilor deja   *
 *  existenți în tabelul Users.                                           *
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
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexiuneBazaDeDate;
namespace ProiectIP
{
    public partial class Login : Form
    {
        #region Fields
       
        #endregion

        #region Methods
        /// <summary>
        /// Constructorul clasei Login
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
                SqlConnection con = null;
                try
                {
                    con = Conexiune.GetConexiune();
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\AN3_SEM2\\proiect_ip_24.05\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";
                    con.Open();

                    string email = textBoxEmail.Text;
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = '" + email + "'";

                    SqlCommand cmdEmail = new SqlCommand(query, con);
                    int contorEmail = (int)cmdEmail.ExecuteScalar();

                    if (contorEmail == 0)
                    {
                        MessageBox.Show("Email sau parola incorecte!");
                    }
                    else if (contorEmail == 1)
                    {
                        string parola = textBoxParola.Text;
                        string querySelect = "SELECT Admin FROM Users WHERE Email = '" + email + "' and Parola = '" + parola + "'";

                        SqlCommand cmd = new SqlCommand(querySelect, con);
                        object rezultat = cmd.ExecuteScalar();

                        if (rezultat != null && (bool)rezultat)
                        {
                            Administrator admin = new Administrator();
                            admin.Show();
                            this.Hide();
                        }
                        else if (rezultat != null && !(bool)rezultat)
                        {
                            Utilizator user = new Utilizator();
                            user.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Parola incorectă!");
                        }


                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Nu s-a putut efectua conexiunea la baza de date: " + exception.Message);
                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            
        }

        /// <summary>
        /// Butonul About permite afisarea unor informatii despre proiect 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "Despre");
        }
                
        /// <summary>
        /// La apasarea 'Help' se deschide un fisier .chm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
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
        /// La apasarea butonului Close se inchide interfata curenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            Inregistrare reg1 = new Inregistrare();
            reg1.Show();
        }


        #endregion
    }
}