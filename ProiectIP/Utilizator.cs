/**************************************************************************
 *                                                                        *
 *  File:        Utilizator.cs                                            *
 *  Copyright:   (c) 2023, Butu Alexandra-Gabriela                       *
 *  Description: User class with its functionalities                      *
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
    ///  Aceasta clasa implementeaza metodele accesibile de un utilizator
    /// </summary>
    public partial class Utilizator : Form
    {
        #region Fields
      //  private Facade _facade;
        #endregion


        #region Methods
        /// <summary>
        /// Constructorul clasei Utilizator
        /// </summary>
        public Utilizator()
        {
            InitializeComponent();
         //   _facade = new Facade(this);

        }

        /// <summary>
        /// Metoda care afiseaza interfata cu rutele existente la apasarea butonului 'Vezi rute'
        /// </summary>
        private void buttonVeziRute_Click(object sender, EventArgs e)
        {
          //  _facade.VeziFilme();
        }

        /// <summary>
        ///Metoda pentru afisarea rutelor existente la incarcarea interfetei pentru utilizator
        /// </summary>
        private void Utilizator_Load(object sender, EventArgs e)
        {
          //  _facade.Load_User();
        }

        /// <summary>
        ///  Butonul About permite afisarea unor informatii despre proiect 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
           // _facade.About();
        }

        /// <summary>
        ///  La apasarea 'Help' se deschide un fisier .chm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Gestionarea biletelor de autobuz.chm");

        }

        /// <summary>
        ///  La apasarea butonului Close se inchide interfata curenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
           // _facade.Close();
        }

        /// <summary>
        ///  Butonul Resize este utilizat pentru a schimba dimensiunea ferestrei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResize_Click(object sender, EventArgs e)
        {
           // _facade.Resize();
        }

        /// <summary>
        ///  Butonul 'Mini' este folosit pentru minimizarea ferestrei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMini_Click(object sender, EventArgs e)
        {
            //_facade.Mini();
        }
        #endregion
    }
}
