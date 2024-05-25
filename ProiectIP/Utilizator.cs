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
 
    public partial class Utilizator : Form
    {
        #region Fields
        private Facade _facade;
        #endregion


        #region Methods
        
        public Utilizator()
        {
            InitializeComponent();
            _facade = new Facade(this);

        }
      
        #endregion

        private void buttonDelogareUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void buttonAbout_Click_1(object sender, EventArgs e)
        {
            _facade.About();
        }

        private void buttonHelp_Click_1(object sender, EventArgs e)
        {
            _facade.Help();
        }

        private void buttonMini_Click_1(object sender, EventArgs e)
        {
            _facade.Mini();
        }

        private void buttonResize_Click_1(object sender, EventArgs e)
        {
            _facade.Resize();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            _facade.Close();
        }

        private void buttonVeziFilme_Click(object sender, EventArgs e)
        {
            _facade.VeziFilme();
        }
    }
}
