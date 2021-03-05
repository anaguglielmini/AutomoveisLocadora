using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AutomoveisLocadora
{
    public static class DB
    {
        private static string connStr;
        private static MySqlConnection conn;

        public static void Start()
        {
            connStr = "server=localhost;user=root;database=locadoradb;port=3306;password=root;convert zero datetime=True;";
            conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
            }
            catch (Exception ex)
            {

                ThrowDatabaseFatalError(ex);

            }

            Console.WriteLine("Connection Done.");
        }

        public static void Run(string strSQL, MySqlParameter[] parameters)
        {
            try
            {
                CheckState();

                MySqlCommand cmd = new MySqlCommand(strSQL, conn);
                foreach (MySqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ThrowDatabaseError(ex);
            }
        }

        public static MySqlDataReader Read(string strSQL, MySqlParameter[] mySqlParameter)
        {
            try
            {
                CheckState();

                MySqlCommand cmd = new MySqlCommand(strSQL, conn);
                foreach (MySqlParameter param in mySqlParameter)
                {
                    cmd.Parameters.Add(param);
                }

                MySqlDataReader rdr = cmd.ExecuteReader(); // REMEMBER TO CLOSE READER AFTER DOING ANY OTHER SQL OPERATION PLEASE!!!

                return rdr;
            }
            catch (Exception ex)
            {

                ThrowDatabaseError(ex);

                return null;
            }
        }

        private static void CheckState()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return;
            }

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                ThrowDatabaseFatalError(ex);
            }
        }

        private static void ThrowDatabaseError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro com o banco!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ThrowDatabaseFatalError(Exception ex)
        {
            DialogResult result = MessageBox.Show(ex.Message, "Erro com o banco!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
