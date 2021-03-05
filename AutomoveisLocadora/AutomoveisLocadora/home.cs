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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            CarregarVeiculo(Convert.ToInt32(dgVeiculos.Rows[0].Cells[0].Value));
            this.panelVeiculo.Visible = true;
        }

        private void CarregarDataGrid()
        {
            MySqlDataReader reader = DB.Read("SELECT id_veiculo, modelo_veiculo, placa_veiculo, marca_veiculo FROM cad_veiculo", new MySqlParameter[]{});

            if(reader!=null){

                if(reader.HasRows){

                    DataTable table = new DataTable();

                    table.Columns.Add("ID");
                    table.Columns.Add("Modelo");
                    table.Columns.Add("Placa");
                    table.Columns.Add("Marca");

                    while(reader.Read()){

                        string[] row = {
                            Convert.ToString(reader["id_veiculo"]),
                            Convert.ToString(reader["modelo_veiculo"]),
                            Convert.ToString(reader["placa_veiculo"]),
                            Convert.ToString(reader["marca_veiculo"])
                        };
                        
                        table.Rows.Add(row);
                    }

                    dgVeiculos.DataSource = table;
                    dgVeiculos.Columns[0].Visible = false;
                }

                reader.Close();
            }
            
        }

        private void CarregarVeiculo(int id)
        {
            Veiculo v = new Veiculo();

            v.Carregar(id);

            
        }

        private void dgVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarVeiculo(Convert.ToInt32(dgVeiculos.Rows[dgVeiculos.CurrentCell.RowIndex].Cells[0].Value));
        }

        private void S(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
