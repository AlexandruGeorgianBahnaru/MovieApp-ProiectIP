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

//Sablonul de proiectare structural Fatada asigura o interfata unificata la o multime de interfete dintr-un subsistem.
//Fatada defineste o interfata de nivel mai inalt care face subsistemul mai usor de utilizat

namespace ProiectIP
{
    /// <summary>
    /// Clasa Facade implementeaza sablonul de proiectare Facade pentru interfata Utilizator
    /// </summary>
    public class Facade
    {
        #region Fields
        /// Instanta a clasei Filme
        private Filme _filme;
        /// Instanta a clasei Utilizator
        private Utilizator _utilizator;

        #endregion

        #region Methods

        /// <summary>
        /// Constructor pentru clasa Facade
        /// </summary>
        /// <param name="utilizator">Instanta clasei Utilizator</param>
        public Facade(Utilizator utilizator)
        {
            _filme = new Filme();
            _utilizator = utilizator;
        }

        /// <summary>
        /// Metoda pentru afisarea ferestrei de filme
        /// </summary>
        public void VeziFilme()
        {
            // Verificare daca instanta de filme este null sau daca resursele utilizate de aceasta instanta au fost eliberate
            if (_filme == null || _filme.IsDisposed)
            {
                _filme = new Filme();   // Daca este, se creeaza o noua instanta de Filme
            }
            // Afisarea fereastrei de filme
            _filme.Show();

        }

        /// <summary>
        /// Afisarea informatiilor despre proiect
        /// </summary>
        public void About()
        {
            MessageBox.Show("Proiect IP 2024 - Gestiunea filmelor unui cinema. \nBahnaru George\nButu Alexandra\nChelea Diana \nSpiridon Bianca ", "About");
        }

        /// <summary>
        /// Deschiderea fisierului de help care ofera informatii despre utilizarea aplicatiei
        /// </summary>
        public void Help()
        {
            System.Diagnostics.Process.Start("RezervareOnlineCinema.chm");
        }

        /// <summary>
        /// Inchiderea aplicatiei (fereastra utilizatorului)
        /// </summary>
        public void Close()
        {
            _utilizator.Close();

        }

        /// <summary>
        /// Minimizarea fereastrei aplicatiei
        /// </summary>
        public void Mini()
        {
            _utilizator.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Schimbarea dimensiunii ferestrei aplicatiei intre normal si maximizat
        /// </summary>
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