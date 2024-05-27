/**************************************************************************
 *                                                                        *
 *  File:        UnitTestClickButtons.cs                                  *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Implementează adăugarea înregistrărilor în tabela Movies *
 *  de către admin.                                                       *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Windows.Forms;
using ProiectIP;
namespace MovieUnitTestProject
{
    /// <summary>
    /// Testarea functionalitatii butonului Inregistrare din form-ul Inregistrare
    /// </summary>
    [TestClass]
    public class UnitTestClickButtons
    {
        [TestMethod]
        public void buttonInregistrare_Click()
        {
            // arange
            Inregistrare inregistrare = new Inregistrare();
            var type = typeof(Inregistrare);
            // act
            MethodInfo inregistrareMethod = type.GetMethod("buttonInregistrare_Click", BindingFlags.NonPublic | BindingFlags.Instance);   
            
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(inregistrare);
            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(inregistrare);
            FieldInfo numeField = type.GetField("textBoxNume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxNume = (TextBox)numeField.GetValue(inregistrare);
            FieldInfo prenumeField = type.GetField("textBoxPrenume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPrenume = (TextBox)prenumeField.GetValue(inregistrare);

            textBoxNume.Text = "TestNume";
            textBoxPrenume.Text = "TestPrenume";
            textBoxEmail.Text = "test@exam+ple.com";
            textBoxParola.Text = "testparola";

            try
            {
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception not thrown");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea functionalitatii butonului Inregistrare din form-ul Inregistrare #2
        /// </summary>
        [TestMethod]
        public void buttonInregistrare_Click2()
        {
            // arange
            Inregistrare inregistrare = new Inregistrare();
            var type = typeof(Inregistrare);
            // act
            MethodInfo inregistrareMethod = type.GetMethod("buttonInregistrare_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(inregistrare);
            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(inregistrare);
            FieldInfo numeField = type.GetField("textBoxNume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxNume = (TextBox)numeField.GetValue(inregistrare);
            FieldInfo prenumeField = type.GetField("textBoxPrenume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPrenume = (TextBox)prenumeField.GetValue(inregistrare);

            textBoxNume.Text = "TestNume";
            textBoxPrenume.Text = "TestPrenume";
            textBoxEmail.Text = "test@example.com";
            textBoxParola.Text = "testparola";
            try
            {
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true,"Exception not thrown");
            }
            catch (Exception ex) 
            {
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea functionalitatii butonului Login din form-ul Login
        /// </summary>
        [TestMethod]
        public void buttonLogin_Click()
        {
            // arange
            Login login = new Login();
            var type = typeof(Login);
            // act
            MethodInfo loginMethod = type.GetMethod("buttonLogin_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(login);
            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(login);

            textBoxEmail.Text = "jone.doe@example.com";
            textBoxParola.Text = "password456";

            try
            {
                loginMethod.Invoke(login, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception not thrown");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea functionalitatii butonului VeziFilme din form-ul Utilizator
        /// </summary>
        [TestMethod]
        public void buttonVeziFilme_Click()
        {
            // arange
            Utilizator utilizator = new Utilizator();
            var type = typeof(Utilizator);
            // act
            MethodInfo loginMethod = type.GetMethod("buttonVeziFilme_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            try
            { 
                loginMethod.Invoke(utilizator, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception not thrown");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea functionalitatii butonului AdaugaFilm din form-ul Administrator
        /// </summary>
        [TestMethod]
        public void buttonAdaugaFilmAdmin_Click()
        {
            // arange
            Administrator administrator = new Administrator();
            var type = typeof(Administrator);
            // act
            MethodInfo adaugaMethod = type.GetMethod("buttonAdaugaFilmAdmin_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            {
                adaugaMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea functionalitatii butonului EditeazaFilm din form-ul Administrator
        /// </summary>
        [TestMethod]
        public void buttonEditeazaFilm_Click()
        {
            // arange
            Administrator administrator = new Administrator();
            var type = typeof(Administrator);
            // act
            MethodInfo editeazaMethod = type.GetMethod("buttonEditeazaFilm_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            {
                editeazaMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }
       
        }

        /// <summary>
        /// Testarea functionalitatii butonului StergeFilm din form-ul Administrator
        /// </summary>
        [TestMethod]
        public void buttonStergeFilm_Click()
        {
            // arange
            Administrator administrator = new Administrator();
            var type = typeof(Administrator);
            // act
            MethodInfo stergeMethod = type.GetMethod("buttonStergeFilm_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            {
                stergeMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea functionalitatii butonului Adauga din form-ul A
        /// </summary>
        [TestMethod]
        public void buttonAdauga_Click()
        {
            // arange
            AdaugaFilm adaugaFilm = new AdaugaFilm(new Administrator());
            var type = typeof(AdaugaFilm);
            // act
            MethodInfo adaugaMethod = type.GetMethod("buttonAdauga_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo nameField = type.GetField("textBoxDenumireFilm", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxName = (TextBox)nameField.GetValue(adaugaFilm);
            FieldInfo genField = type.GetField("textBoxGenFilm", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxGen = (TextBox)genField.GetValue(adaugaFilm);
            FieldInfo durataField = type.GetField("textBoxDurataFilm", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxDurata = (TextBox)durataField.GetValue(adaugaFilm);
            FieldInfo dataField = type.GetField("textBoxDataFilm", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxData = (TextBox)dataField.GetValue(adaugaFilm);
            FieldInfo timeField = type.GetField("textBoxOraFilm", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxTime = (TextBox)timeField.GetValue(adaugaFilm);

            textBoxName.Text = "NUMEFILM";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-10-20";
            textBoxTime.Text = "14:00";

            try
            {
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }
    }
}
