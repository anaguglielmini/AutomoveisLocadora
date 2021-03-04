using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomoveisLocadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = DB.Read("SELECT id, model from cars WHERE LOWER(license_plate) LIKE LOWER(?search) OR LOWER(model) LIKE LOWER(?search);", new MySqlParameter[] { new MySqlParameter("search", ("%" + TxtGeneralSearch.Text) + "%") });

            if (reader != null)
            {

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(reader.GetString(0));
                    }
                }

                reader.Close();
            } 
        }
    }
}
