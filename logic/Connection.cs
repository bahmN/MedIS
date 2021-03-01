using System;
using MySql.Data.MySqlClient;
namespace MedIS.logic
{
    class Connection
    {

        public MySqlConnection connect() 
        {
            try {
                MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; port = 3306; user = root; password = Vfhnvfhn23@; database = mis; sslmode = none;");
                connection.Open();
                return connection;
            }
            catch{
                return null;
            }
        }
    }
}
