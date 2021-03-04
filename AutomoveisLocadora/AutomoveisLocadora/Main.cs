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
    public partial class Main : Form
    {
        private Veiculo carro;
        public Main()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarVeiculos();
        }
        private void ListarVeiculos() {

            lbCarros.DataBindings.Clear();

            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            MySqlDataReader reader = DB.Read("SELECT id_veiculo, modelo_veiculo, marca_veiculo from cad_veiculo WHERE LOWER(placa_veiculo) LIKE LOWER(?search) OR LOWER(modelo_veiculo) LIKE LOWER(?search) OR LOWER(marca_veiculo) LIKE LOWER(?search);", new MySqlParameter[] { new MySqlParameter("search", ("%" + txtPesquisar.Text) + "%") });

            if (reader != null)
            {

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        KeyValuePair<string, string> data = new KeyValuePair<string, string>(reader.GetString(0), reader.GetString(1));

                        list.Add(data);
                    }
                }

                reader.Close();
            }
            lbCarros.DataSource = new BindingSource(list, null);
            lbCarros.ValueMember = "Key";
            lbCarros.DisplayMember = "Value";
        }
        private void lbCarros_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbCarros.SelectedItem != null)
            {

                KeyValuePair<string, string> item = (KeyValuePair<string, string>)lbCarros.SelectedItem;

                int id = Convert.ToInt32(item.Key);

                Veiculo carro = new Veiculo();

                carro.Load(id);

                this.carro = carro;

                UpdateCarInfo();
            }

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            this.Hide();
            add.Show();
        }
    }
}
