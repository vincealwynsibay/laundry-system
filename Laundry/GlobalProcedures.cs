﻿using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laundry
{
    internal class GlobalProcedure
    {
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;

        public MySqlConnection conLaundry;
        public MySqlCommand sqlCommand;
        public string strConnection;

        public bool fncConnectToDatabase()
        {
            try
            {
                servername = "localhost";
                databasename = "laundry";
                username = "root";
                password = "";
                port = "3306";

                strConnection = "Server=" + servername + ";" +
                        "Database=" + databasename + ";" +
                        "User=" + username + ";" +
                        "Password=" + password + ";" +
                        "Port=" + port + ";" +
                        "Convert Zero Datetime=true";
                conLaundry = new MySqlConnection(strConnection);
                sqlCommand = new MySqlCommand(strConnection, conLaundry);

                if (conLaundry.State == System.Data.ConnectionState.Closed)
                {
                    sqlCommand.Connection = conLaundry;
                    conLaundry.Open();
                    return true;
                }
                else
                {
                    conLaundry.Close();
                    return false;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error Message " + err.Message);
            }
            return false;
        }

        public void checkDatabaseConnection()
        {
            if (fncConnectToDatabase().Equals(false))
            {  
                conLaundry.Open() ;        
            } else
            {
            }
        }
    }

}