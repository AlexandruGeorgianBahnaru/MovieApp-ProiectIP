/**************************************************************************
 *                                                                        *
 *  File:        Facade.cs                                                *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementarea șabolunui de proiectare Facade pentru      *
 *  interfața Utilizator.                                                 *
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
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexiuneBazaDeDate;
using System.Windows.Forms;

namespace ProiectIP
{
    public class Facade
    {
        #region Fields
        private Filme _filme;
        private Utilizator _utilizator;
        public bool IsAboutWindowOpened { get; private set; }
        public bool IsHelpWindowOpened { get; private set; }
        #endregion

        #region Methods

        public Facade(Utilizator utilizator)
        {
            _filme=new Filme(); 
            _utilizator=utilizator;
        }
        public void VeziFilme()
        {
            if (_filme == null || _filme.IsDisposed)
            {
                _filme = new Filme();
            }
            _filme.Show();

        }

        public void About()
        {
            string title = "Despre";
            MessageBox.Show("Proiect IP 2024 - Rezervare Online bilete la cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", title);
            IsAboutWindowOpened = true;
        }
        public void Help()
        {
            IsHelpWindowOpened = true;
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }
        public void Close()
        {
            _utilizator.Close();

        }
        public void Mini()
        {
            _utilizator.WindowState = FormWindowState.Minimized;
        }
        public void Resize()
        {
            if (_utilizator.WindowState == FormWindowState.Normal)
                _utilizator.WindowState = FormWindowState.Maximized;
            else
                _utilizator.WindowState = FormWindowState.Normal;
        }
      
        #endregion
    }
}
