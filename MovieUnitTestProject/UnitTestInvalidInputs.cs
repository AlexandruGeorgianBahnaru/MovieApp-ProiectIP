/**************************************************************************
 *                                                                        *
 *  File:                                                                 *    
 *               UnitTestInvalidInputs.cs                                 *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description:  Testarea inputurilor invalide                           *
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
        /// Testarea verificarii inputurilor din formularul AdaugaFilm pentru data invalida
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputDataInvalid()
        {
            // Creeaza o instanta a formularului AdaugaFilm, asociata cu un administrator pentru a simula adaugarea unui film
            AdaugaFilm adaugaFilm = new AdaugaFilm(new Administrator());
            // Obtine tipul clasei AdaugaFilm pentru a putea accesa metodele si campurile acesteia prin reflexie
            var type = typeof(AdaugaFilm);

            // Obtine metoda buttonAdauga_Click folosind reflexia, accesibila doar in interiorul clasei
            MethodInfo adaugaMethod = type.GetMethod("buttonAdauga_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul AdaugaFilm pentru a putea seta valorile necesare pentru adaugarea filmului
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

            // Seteaza valorile necesare pentru adaugarea unui film, inclusiv o data invalida
            textBoxName.Text = "NUMEFILM";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "120";
            textBoxData.Text = "100";  // Data invalida
            textBoxTime.Text = "14:00";

            try
            {
                // Invoca metoda de adaugare a filmului simuland un click pe buton
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                // Verifica dacă flag-ul pentru date gresite este setat corespunzator dupa validarea inputului
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }

        }


        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm pentru o a doua data invalida
        /// </summary>
        [TestMethod]
        public void adaugaFilmDataInvalid2()
        {
            // Creeaza o instanta a formularului AdaugaFilm, asociata cu un administrator pentru a simula adaugarea unui film
            AdaugaFilm adaugaFilm = new AdaugaFilm(new Administrator());
            // Obtine tipul clasei AdaugaFilm pentru a putea accesa metodele si campurile acesteia prin reflexie
            var type = typeof(AdaugaFilm);


            // Obtine metoda buttonAdauga_Click folosind reflexia, accesibila doar in interiorul clasei
            MethodInfo adaugaMethod = type.GetMethod("buttonAdauga_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul AdaugaFilm pentru a putea seta valorile necesare pentru adaugarea filmului
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


            // Seteaza valorile necesare pentru adaugarea unui film, inclusiv o a doua data invalida
            textBoxName.Text = "Nume";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-11-10";// A doua data invalida
            textBoxTime.Text = "14:00";

            try
            {
                // Invoca metoda de adaugare a filmului simuland un click pe buton
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                // Verifica daca flag-ul pentru date gresite este setat corespunzator dupa validarea inputului
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm #Time invalid
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputTimeInvalid()
        {
            // Creeaza o instanta a formularului AdaugaFilm, asociat unui administrator
            AdaugaFilm adaugaFilm = new AdaugaFilm(new Administrator());
            // Obtine tipul formularului AdaugaFilm
            var type = typeof(AdaugaFilm);

            // Obtine metoda buttonAdauga_Click folosind reflectie
            MethodInfo adaugaMethod = type.GetMethod("buttonAdauga_Click", BindingFlags.NonPublic | BindingFlags.Instance);


            // Obtine campurile private din formularul AdaugaFilm folosind reflectie
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

            // Seteaza valorile campurilor de text pentru a testa un input invalid
            textBoxName.Text = "NUMEFILM";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "-120"; // Durata negativa, input invalid
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "25:00";// Ora invalida

            try
            {
                // Invoca metoda buttonAdauga_Click pentru a testa comportamentul cu inputuri invalide
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                // Verifica daca flagul dateGresite este setat la true
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul AdaugaFilm pentru un nume invalid
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputNumeInvalid()
        {
            // Creeaza o instanta a formularului AdaugaFilm, asociat unui administrator
            AdaugaFilm adaugaFilm = new AdaugaFilm(new Administrator());

            // Obtine tipul formularului AdaugaFilm
            var type = typeof(AdaugaFilm);

            // Obtine metoda buttonAdauga_Click folosind reflectie            
            MethodInfo adaugaMethod = type.GetMethod("buttonAdauga_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul AdaugaFilm folosind reflectie
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


            // Seteaza valorile campurilor de text pentru a testa un input invalid
            textBoxName.Text = ""; // Nume film gol, input invalid
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "14:00";

            try
            {
                // Invoca metoda buttonAdauga_Click pentru a testa comportamentul cu inputuri invalide
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });

                // Verifica daca flagul dateGresite este setat la true
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul AdaugaFilm pentru un gen invalid
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputGenInvalid()
        {
            // Creeaza o instanta a formularului AdaugaFilm, asociat unui administrator
            AdaugaFilm adaugaFilm = new AdaugaFilm(new Administrator());

            // Obtine tipul formularului AdaugaFilm
            var type = typeof(AdaugaFilm);

            // Obtine metoda buttonAdauga_Click folosind reflectie
            MethodInfo adaugaMethod = type.GetMethod("buttonAdauga_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul AdaugaFilm folosind reflectie
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

            // Seteaza valorile campurilor de text pentru a testa un input invalid
            textBoxName.Text = "DAD";  // Nume film valid
            textBoxGen.Text = "";  // Gen film gol, input invalid
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "14:00";

            try
            {
                // Invoca metoda buttonAdauga_Click pentru a testa comportamentul cu inputuri invalide
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                // Verifica daca flagul dateGresite este setat la true
                Assert.IsTrue(AdaugaFilm.dateGresite == true);

            }
            catch (Exception ex)
            { // Daca se arunca o exceptie, testul esueaza
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Adaugafilm pentru o durata invalida
        /// </summary>
        [TestMethod]
        public void adaugaFilmInputDurataInvalid()
        {
            // Creeaza o instanta a formularului AdaugaFilm, asociat unui administrator
            AdaugaFilm adaugaFilm = new AdaugaFilm(new Administrator());

            // Otine tipul formularului AdaugaFilm
            var type = typeof(AdaugaFilm);

            // Obtine metoda buttonAdauga_Click folosind reflectie
            MethodInfo adaugaMethod = type.GetMethod("buttonAdauga_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul AdaugaFilm folosind reflectie
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

            // Seteaza valorile campurilor de text pentru a testa un input invalid
            textBoxName.Text = "FILm"; // Nume film valid
            textBoxGen.Text = "GenFIlM"; // Gen film valid
            textBoxDurata.Text = "-120"; // Durata invalida
            textBoxData.Text = "2024-11-10";
            textBoxTime.Text = "14:00";

            try
            {
                // Invoca metoda buttonAdauga_Click pentru a testa comportamentul cu inputuri invalide
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });

                // Verifica daca flagul dateGresite este setat la true
                Assert.IsTrue(AdaugaFilm.dateGresite == true);
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail("Exception thrown");
            }
        }


        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Login #Email invalid
        /// </summary>
        [TestMethod]
        public void loginInputEmailInvalid()
        {
            // Creeaza o instanta a formularului Login
            Login login = new Login();

            // Obtine tipul formularului Login
            var type = typeof(Login);

            // Obtine metoda buttonLogin_Click folosind reflectie
            MethodInfo loginMethod = type.GetMethod("buttonLogin_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul Login folosind reflectie
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(login);

            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(login);

            // Seteaza valorile campurilor de text pentru a testa un input invalid (email)
            textBoxEmail.Text = "jonoe@exmple.com"; // Email invalid (format gresit)
            textBoxParola.Text = "password456"; // Parola valida

            try
            {
                // Invoca metoda buttonLogin_Click pentru a testa comportamentul cu inputuri invalide
                loginMethod.Invoke(login, new object[] { null, EventArgs.Empty });

                // Verifica daca variabila statica dateGresite este setata la true
                Assert.IsTrue(Login.dateGresite == true, "Email invalid, dateGresite ar trebui să fie true");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail($"Exception thrown: {ex.Message}");
            }
        }


        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Login #Parola invalida
        /// </summary>
        [TestMethod]
        public void loginInputParolaInvalid()
        {
            // Creeaza o instanta a formularului Login
            Login login = new Login();

            // Obtine tipul formularului Login
            var type = typeof(Login);

            // Obtine metoda buttonLogin_Click folosind reflectie
            MethodInfo loginMethod = type.GetMethod("buttonLogin_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul Login folosind reflectie
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(login);

            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(login);

            // Seteaza valorile campurilor de text pentru a testa un input invalid (parola)
            textBoxEmail.Text = "jane.doe@example.com"; // Email valid
            textBoxParola.Text = "password"; // Parola invalida (ex. prea scurta, nesigura etc.)

            try
            {
                // Invoca metoda buttonLogin_Click pentru a testa comportamentul cu inputuri invalide
                loginMethod.Invoke(login, new object[] { null, EventArgs.Empty });

                // Verifica daca variabila statica dateGresite este setata la true
                Assert.IsTrue(Login.dateGresite == true, "Parola invalidă, dateGresite ar trebui să fie true");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail($"Exception thrown: {ex.Message}");
            }
        }


        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Inregistrare #Email invalid
        /// </summary>
        [TestMethod]
        public void inregistreazaInputEmailInvalid()
        {
            // Creeaza o instanta a formularului Inregistrare
            Inregistrare inregistrare = new Inregistrare();

            // Obtine tipul formularului Inregistrare
            var type = typeof(Inregistrare);

            // Obtine metoda buttonInregistrare_Click folosind reflectie
            MethodInfo inregistrareMethod = type.GetMethod("buttonInregistrare_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul Inregistrare folosind reflectie
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(inregistrare);

            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(inregistrare);

            FieldInfo numeField = type.GetField("textBoxNume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxNume = (TextBox)numeField.GetValue(inregistrare);

            FieldInfo prenumeField = type.GetField("textBoxPrenume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPrenume = (TextBox)prenumeField.GetValue(inregistrare);

            // Seteaza valorile campurilor de text pentru a testa un input invalid (email)
            textBoxNume.Text = "TestNume";
            textBoxPrenume.Text = "TestPrenume";
            textBoxEmail.Text = "test@exae.com"; // Email invalid
            textBoxParola.Text = "testparola"; // Parola valida

            try
            {
                // Invoca metoda buttonInregistrare_Click pentru a testa comportamentul cu inputuri invalide
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });

                // Verifica daca variabila statica dateGresite este setata la true
                Assert.IsTrue(Inregistrare.dateGresite == true, "Email invalid, dateGresite ar trebui să fie true");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail($"Exception thrown: {ex.Message}");
            }
        }




        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Inregistrare #Nume invalid
        /// </summary>
        [TestMethod]
        public void inregistreazaInputNumeInvalid()
        {
            // Creeaza o instanta a formularului Inregistrare
            Inregistrare inregistrare = new Inregistrare();

            // Obtine tipul formularului Inregistrare
            var type = typeof(Inregistrare);

            // Obtine metoda buttonInregistrare_Click folosind reflectie
            MethodInfo inregistrareMethod = type.GetMethod("buttonInregistrare_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul Inregistrare folosind reflectie
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(inregistrare);

            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(inregistrare);

            FieldInfo numeField = type.GetField("textBoxNume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxNume = (TextBox)numeField.GetValue(inregistrare);

            FieldInfo prenumeField = type.GetField("textBoxPrenume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPrenume = (TextBox)prenumeField.GetValue(inregistrare);

            // Seteaza valorile campurilor de text pentru a testa un input invalid (nume)
            textBoxNume.Text = ""; // Nume invalid
            textBoxPrenume.Text = "TestPrenume";
            textBoxEmail.Text = "test@exae.com";
            textBoxParola.Text = "testparola";

            try
            {
                // Invoca metoda buttonInregistrare_Click pentru a testa comportamentul cu inputuri invalide
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });

                // Verifica daca variabila statica dateGresite este setata la true
                Assert.IsTrue(Inregistrare.dateGresite == true, "Nume invalid, dateGresite ar trebui să fie true");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail($"Exception thrown: {ex.Message}");
            }
        }


        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Inregistrare #Prenume invalid
        /// </summary>
        [TestMethod]
        public void inregistreazaInputPrenumeInvalid()
        {
            // Creeaza o instanta a formularului Inregistrare
            Inregistrare inregistrare = new Inregistrare();

            // Obtine tipul formularului Inregistrare
            var type = typeof(Inregistrare);

            // Obtine metoda buttonInregistrare_Click folosind reflectie
            MethodInfo inregistrareMethod = type.GetMethod("buttonInregistrare_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Obtine campurile private din formularul Inregistrare folosind reflectie
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(inregistrare);

            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(inregistrare);

            FieldInfo numeField = type.GetField("textBoxNume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxNume = (TextBox)numeField.GetValue(inregistrare);

            FieldInfo prenumeField = type.GetField("textBoxPrenume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPrenume = (TextBox)prenumeField.GetValue(inregistrare);

            // Seteaza valorile câmpurilor de text pentru a testa un input invalid (prenume)
            textBoxNume.Text = "TestNume"; // Nume valid
            textBoxPrenume.Text = ""; // Prenume invalid
            textBoxEmail.Text = "test@exae.com";
            textBoxParola.Text = "testparola";

            try
            {
                // Invoca metoda buttonInregistrare_Click pentru a testa comportamentul cu inputuri invalide
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });

                // Verifica daca variabila statica dateGresite este setata la true
                Assert.IsTrue(Inregistrare.dateGresite == true, "Prenume invalid, dateGresite ar trebui să fie true");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie, testul esueaza
                Assert.Fail($"Exception thrown: {ex.Message}");
            }
        }

        /// <summary>
        /// Testarea verificarii inputurilor din form-ul Administrator pentru stergerea unui film
        /// </summary>
        [TestMethod]
        public void stergeFilmInputInvalid()
        {
            // Initializarea formularului Administrator
            Administrator administrator = new Administrator();
            var type = typeof(Administrator);

            // Obtinerea metodei de stergere a filmului
            MethodInfo stergeMethod = type.GetMethod("buttonStergeFilm_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            { // Apelarea metodei de stergere a filmului
                stergeMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(Inregistrare.dateGresite == true);
            }
            catch (Exception ex)
            {
                // Testul va esua daca in timpul operatiei de stergere a filmului este aruncata o exceptie
                Assert.Fail("Exception thrown");
            }

        }


    }
}
