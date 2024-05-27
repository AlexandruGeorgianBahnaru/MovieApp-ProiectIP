/**************************************************************************
 *                                                                        *
 *  File:                                                                 *    
 *               UnitTestInvalidInputs.cs                                 *
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectIP;
using System.Reflection;
using System.Windows.Forms;

namespace MovieUnitTestProject
{
    [TestClass]
    public class UnitTestInvalidInputs
    {
        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm #Data invalida
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputDataInvalid()
        {
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
            textBoxData.Text = "100";
            textBoxTime.Text = "14:00";

            try
            {
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm #Data invalida 2
        /// </summary>
        [TestMethod]
        public void adaugaFilmDataInvalid2()
        {
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

            textBoxName.Text = "Nume";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "14:00";

            try
            {
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm #Time invalid
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputTimeInvalid()
        {
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
            textBoxDurata.Text = "-120";
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "25:00";

            try
            {
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm #Nume invalid
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputNumeInvalid()
        {
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

            textBoxName.Text = "";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "14:00";

            try
            {
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm #Gen invalid
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputGenInvalid()
        {
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

            textBoxName.Text = "DAD";
            textBoxGen.Text = "";
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "14:00";

            try
            {
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm #Durata invalida
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputDurataInvalid()
        {
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

            textBoxName.Text = "FILm";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "-120";
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "14:00";

            try
            {
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Login #Email invalid
        /// </summary>
        [TestMethod]
        public void loginInputEmailInvalid()
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

            textBoxEmail.Text = "jonoe@exmple.com";
            textBoxParola.Text = "password456";

            try
            {
                loginMethod.Invoke(login, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(Login.dateGresite == true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Login #Parola invalida
        /// </summary>
        [TestMethod]
        public void loginInputParolaInvalid()
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

            textBoxEmail.Text = "jane.doe@exmple.com";
            textBoxParola.Text = "password";

            try
            {
                loginMethod.Invoke(login, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(Login.dateGresite == true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Inregistrare #Email invalid
        /// </summary>
        [TestMethod]
        public void inregistreazaInputEmailInvalid()
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
            textBoxEmail.Text = "test@exae.com";
            textBoxParola.Text = "testparola";
            try
            {
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(Inregistrare.dateGresite == true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Inregistrare #Nume invalid
        /// </summary>
        [TestMethod]
        public void inregistreazaInputNumeInvalid()
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

            textBoxNume.Text = "";
            textBoxPrenume.Text = "TestPrenume";
            textBoxEmail.Text = "test@exae.com";
            textBoxParola.Text = "testparola";
            try
            {
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(Inregistrare.dateGresite == true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Inregistrare #Prenume invalid
        /// </summary>
        [TestMethod]
        public void inregistreazaInputPrenumeInvalid()
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
            textBoxPrenume.Text = "";
            textBoxEmail.Text = "test@exae.com";
            textBoxParola.Text = "testparola";
            try
            {
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(Inregistrare.dateGresite == true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Administrator
        /// </summary>
        [TestMethod]
        public void stergeFilmInputInvalid()
        {
            // arange
            Administrator administrator = new Administrator();
            var type = typeof(Administrator);
            // act
            MethodInfo stergeMethod = type.GetMethod("buttonStergeFilm_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            {
                stergeMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(Inregistrare.dateGresite == true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception thrown");
            }

        }


    }
}
