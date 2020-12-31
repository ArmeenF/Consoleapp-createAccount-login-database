using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSharp_Login_And_Register
{
    /*
         * Download mysql connection
         * add the connector to our project
         * create a connection/object with mysql
         * open xampp and start mysql & apache
         * go to phpmyadmin and create the users database
         */

    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_users_db ");

        //create function to open connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create function to close connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //create function to return the connection
        public MySqlConnection GetSqlConnection()
        {
            return connection;
        }
    }
}
