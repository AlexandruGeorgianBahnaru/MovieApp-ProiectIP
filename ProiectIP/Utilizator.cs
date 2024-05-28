/**************************************************************************
 *                                                                        *
 *  File:        Utilizator.cs                                            *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea interfeței Utilizator, din care user-ul    *
 *  poate accesa filmele disponibile.                                     *
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
    /// Clasa care implementeaza interfata Utilizator, din care utilizatorul poate accesa filmele disponibile
    /// </summary>
    public partial class Utilizator : Form
    {
        #region Fields
        private Facade _facade;// Obiectul Facade pentru gestionarea actiunilor utilizatorului
        #endregion


        #region Methods


        /// <summary>
        /// Constructorul clasei Utilizator
        /// </summary>
        public Utilizator()
        {
            InitializeComponent();
            _facade = new Facade(this); // Initializarea obiectului Facade cu instanta curenta a clasei Utilizator
        }
        /// <summary>
        /// Metoda care se executa la apasarea butonului "Vezi Filme"
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Vezi filme"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonVeziFilme_Click(object sender, EventArgs e)
        {
            _facade.VeziFilme();// Apelarea metodei VeziFilme din obiectul Facade
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului "Delogare"
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Delogare"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonDelogareUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();// Initializarea unei noi instante a clasei Login
            login.Show(); // Afisarea formularului de login
            this.Hide();// Ascunderea formularului curent (Utilizator)
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului de redimensionare
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Resize"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonResize_Click(object sender, EventArgs e)
        {
            _facade.Resize();// Apelarea metodei Resize din obiectul Facade
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului de minimizare
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Mini"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            _facade.Mini();
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului de inchidere
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Close"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            _facade.Close();// Apelarea metodei Close din obiectul Facade
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului "About"
        /// </summary>
        ///  <param name="sender">Obiectul care a generat evenimentul, aici butonul "About"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            _facade.About(); // Apelarea metodei About din obiectul Facade
        }

        /// <summary>
        /// Metoda care se executa la apasarea butonului "Help"
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul, aici butonul "Help"</param>
        /// <param name="e">Argumentele asociate evenimentului de clic</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            _facade.Help();
        }


        #endregion
    }
}

























