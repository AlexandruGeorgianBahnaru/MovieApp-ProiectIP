using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexiuneBazaDeDate
{
    /// <summary>
    /// Clasa pentru gestionarea conexiunii la baza de date
    /// </summary>
    public class Conexiune
    {
        #region Fields

        // Obiectul de conexiune la baza de date
        private static SqlConnection _conexiune;
        // Stringul de conexiune la baza de date
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IpComentat\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security=True";
        #endregion

        #region Methods
        /// <summary>
        /// Constructor privat pentru implementarea sablonului Singleton
        /// </summary>
        private Conexiune()
        {

        }

        /// <summary>
        /// Metoda pentru obtinerea conexiunii la baza de date
        /// </summary>
        /// <returns>Obiectul de conexiune la baza de date</returns>
        public static SqlConnection GetConexiune()
        {
            if (_conexiune == null)
            {
                _conexiune = new SqlConnection(connectionString);
            }
            return _conexiune;
        }
        #endregion
    }
}
