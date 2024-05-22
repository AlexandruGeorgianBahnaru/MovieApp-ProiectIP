using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexiuneBazaDeDate
{
    public class Conexiune
    {
        #region Fields
        private static SqlConnection _connection;
     
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\IPproiectCopie\\ProiectIP\\ProiectIP\\MovieDatabase.mdf;Integrated Security = True";
        #endregion

        #region Methods
        /// <summary>
        /// Constructor privat - Singleton
        /// </summary>
        public Conexiune()
        {

        }

        /// <summary>
        /// Metoda pentru crearea unei conexiuni la baza de date
        /// </summary>
        /// <returns>Connection</returns>
        public static SqlConnection GetConexiune()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(connectionString);
            }
            return _connection;
        }
        #endregion
    }
}
