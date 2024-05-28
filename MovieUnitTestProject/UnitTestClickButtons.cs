/**************************************************************************
 *                                                                        *
 *  File:        UnitTestClickButtons.cs                                  *
 *  Copyright:   (c) 2024, Bahnaru, Butu, Chelea, Spiridon                *
 *  Description: Testarea butoanelor                                      *
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
            // Creeaza o instanta a formularului 'Inregistrare'
            Inregistrare inregistrare = new Inregistrare();
            // Obtine tipul (clasa) formularului 'Inregistrare' pentru a putea accesa membrii sai
            var type = typeof(Inregistrare);

            //MethodInfo - Obtine referinte la metode  private, folosind reflexia
            //FieldInfo - Obtine informatii despre campuei private din formularul 'Inregistrare', folosind reflexia
            //TextBox - Accesează controalele  din instante si le converteste la tipul TextBox
            MethodInfo inregistrareMethod = type.GetMethod("buttonInregistrare_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(inregistrare);
            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(inregistrare);
            FieldInfo numeField = type.GetField("textBoxNume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxNume = (TextBox)numeField.GetValue(inregistrare);
            FieldInfo prenumeField = type.GetField("textBoxPrenume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPrenume = (TextBox)prenumeField.GetValue(inregistrare);

            // Seteaza valori de test pentru fiecare TextBox
            textBoxNume.Text = "TestNume";
            textBoxPrenume.Text = "TestPrenume";
            textBoxEmail.Text = "test@exam+ple.com";
            textBoxParola.Text = "testparola";

            // Incearca sa apelezi metoda 'buttonInregistrare_Click' si sa verifici ca nu arunca nicio exceptie
            try
            {
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true, "Exception not thrown");
            }
            catch (Exception ex)
            {
                // Daca este aruncata vreo exceptie, testul esueaza
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea functionalitatii butonului Inregistrare din form-ul Inregistrare #2
        /// </summary>
        [TestMethod]
        public void buttonInregistrare_Click2()
        {
            // Creeaza o instanta a formularului 'Inregistrare'
            Inregistrare inregistrare = new Inregistrare();
            // Obtine tipul (clasa) formularului 'Inregistrare' pentru a putea accesa membrii sai
            var type = typeof(Inregistrare);

            //MethodInfo - Obtine referinte la metode private, folosind reflexia
            //FieldInfo - Obtine informatii despre campuei private din formularul 'Inregistrare', folosind reflexia
            //TextBox - Acceseaza controalele din instante si le converteste la tipul TextBox
            MethodInfo inregistrareMethod = type.GetMethod("buttonInregistrare_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(inregistrare);
            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(inregistrare);
            FieldInfo numeField = type.GetField("textBoxNume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxNume = (TextBox)numeField.GetValue(inregistrare);
            FieldInfo prenumeField = type.GetField("textBoxPrenume", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPrenume = (TextBox)prenumeField.GetValue(inregistrare);

            // Seteaza valori de test pentru fiecare TextBox
            textBoxNume.Text = "TestNume";
            textBoxPrenume.Text = "TestPrenume";
            textBoxEmail.Text = "test@example.com";
            textBoxParola.Text = "testparola";


            // Incearca sa apelezi metoda buttonInregistrare_Click pe instanta inregistrare
            try
            {
                inregistrareMethod.Invoke(inregistrare, new object[] { null, EventArgs.Empty });
                Assert.IsTrue(true,"Exception not thrown");
            }
            catch (Exception ex) 
            {
                // Daca este aruncata vreo exceptie, testul esueaza
                Assert.Fail("Exception thrown");
            }
        }


        /// <summary>
        /// Testarea functionalitatii butonului de login din formularul de login
        /// </summary>
        [TestMethod]
        public void buttonLogin_Click()
        {
            // Creeaza o instanta a clasei Login pentru a testa functionalitatile
            Login login = new Login();
            // Obtine tipul clasei Login pentru a putea accesa metodele si campurile acesteia prin reflexie
            var type = typeof(Login);

            //MethodInfo - Obtine referinte la metode private, folosind reflexia
            //FieldInfo - Obtine informatii despre campuei private din formularul 'Inregistrare', folosind reflexia
            //TextBox - Acceseaza controalele din instante si le converteste la tipul TextBox
            MethodInfo loginMethod = type.GetMethod("buttonLogin_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo emailField = type.GetField("textBoxEmail", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxEmail = (TextBox)emailField.GetValue(login);
            FieldInfo parolaField = type.GetField("textBoxParola", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxParola = (TextBox)parolaField.GetValue(login);

            // Seteaza valori in campurile textBox pentru email si parola
            textBoxEmail.Text = "jone.doe@example.com";
            textBoxParola.Text = "password456";

            try
            {
                // Invoca metoda de login simuland un click pe buton
                loginMethod.Invoke(login, new object[] { null, EventArgs.Empty });
                // Daca metoda a fost invocata fara erori, marcheaza testul ca fiind reusit pentru aceasta parte
                Assert.IsTrue(true, "Exception not thrown");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea functionalitatii butonului VeziFilme din form-ul Utilizator
        /// </summary>
        [TestMethod]
        public void buttonVeziFilme_Click()
        {

            // Creeaza o instanta a clasei Utilizator pentru a testa funcționalitatile
            Utilizator utilizator = new Utilizator();

            // Obtine tipul clasei Utilizator pentru a putea accesa metodele si campurile acesteia prin reflexie
            var type = typeof(Utilizator);

            // Obtine metoda buttonVeziFilme_Click folosind reflexia, accesibila doar in interiorul clasei
            MethodInfo loginMethod = type.GetMethod("buttonVeziFilme_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            try
            {
                // Invoca metoda de vizualizare filme simuland un click pe buton
                loginMethod.Invoke(utilizator, new object[] { null, EventArgs.Empty });
                // Daca metoda a fost invocata fara erori, marcheaza testul ca fiind reusit pentru aceasta parte
                Assert.IsTrue(true, "Exception not thrown");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea functionalitatii butonului AdaugaFilm din formularul Administrator
        /// </summary>
        [TestMethod]
        public void buttonAdaugaFilmAdmin_Click()
        {
            // Creeaza o instanta a clasei Administrator pentru a testa functionalitatile
            Administrator administrator = new Administrator();

            // Obtine tipul clasei Administrator pentru a putea accesa metodele si campurile acesteia prin reflexie
            var type = typeof(Administrator);

            // Obtine metoda buttonAdaugaFilmAdmin_Click folosind reflexia, accesibila doar in interiorul clasei
            MethodInfo adaugaMethod = type.GetMethod("buttonAdaugaFilmAdmin_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            {
                // Invoca metoda de adaugare film simuland un click pe buton
                adaugaMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });
                // Daca metoda a fost invocata fara erori, marcheaza testul ca fiind reusit pentru aceasta parte
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }
        }

        /// <summary>
        /// Testarea functionalitatii butonului EditeazaFilm din formularul Administrator
        /// </summary>
        [TestMethod]
        public void buttonEditeazaFilm_Click()
        {
            // Creeaza o instanta a clasei Administrator pentru a testa funcționalitatile
            Administrator administrator = new Administrator();
            // Obtine tipul clasei Administrator pentru a putea accesa metodele si campurile acesteia prin reflexie
            var type = typeof(Administrator);

            // Obtine metoda buttonEditeazaFilm_Click folosind reflexia, accesibila doar in interiorul clasei
            MethodInfo editeazaMethod = type.GetMethod("buttonEditeazaFilm_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            {
                // Invoca metoda de editare a filmului simuland un click pe buton
                editeazaMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });
                // Daca metoda a fost invocata fara erori, marcheaza testul ca fiind reusit pentru aceasta parte
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }
       
        }

        /// <summary>
        /// Testarea funcționalitatii butonului StergeFilm din formularul Administrator
        /// </summary>
        [TestMethod]
        public void buttonStergeFilm_Click()
        {
            // Creeaza o instanta a clasei Administrator pentru a testa functționalitatile
            Administrator administrator = new Administrator();
            // Obtine tipul clasei Administrator pentru a putea accesa metodele si campurile acesteia prin reflexie
            var type = typeof(Administrator);

            // Obtine metoda buttonStergeFilm_Click folosind reflexia, accesibila doar in interiorul clasei 
            MethodInfo stergeMethod = type.GetMethod("buttonStergeFilm_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            try
            {
                // Invoca metoda de stergere a filmului simuland un click pe buton
                stergeMethod.Invoke(administrator, new object[] { null, EventArgs.Empty });

                // Daca metoda a fost invocata fara erori, marcheaza testul ca fiind reusit pentru aceasta parte
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            { // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }

        }

        /// <summary>
        /// Testarea funcționalitatii butonului Adauga din formularul AdaugaFilm
        /// </summary>
        [TestMethod]
        public void buttonAdauga_Click()
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

            // Seteaza valorile necesare pentru adaugarea unui film
            textBoxName.Text = "NUMEFILM";
            textBoxGen.Text = "GenFIlM";
            textBoxDurata.Text = "120";
            textBoxData.Text = "2024-10-20";
            textBoxTime.Text = "14:00";

            try
            {
                // Invoca metoda de adaugare a filmului simuland un click pe buton
                adaugaMethod.Invoke(adaugaFilm, new object[] { null, EventArgs.Empty });
                // Daca metoda a fost invocata fara erori, marcheaza testul ca fiind reusit pentru aceasta parte
                Assert.IsTrue(true, "Exception Not Thrown");
            }
            catch (Exception ex)
            {
                // Daca se arunca o exceptie in timpul invocarii, marcheaza testul ca fiind nereusit
                Assert.Fail("Exception thrown");
            }

        }
    }
}
