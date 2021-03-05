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

        Veiculo v;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            this.panelVeiculo.Visible = true;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            dgVeiculos.AllowUserToAddRows = false;
        }

        public void CarregarDataGrid()
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

                    this.dgVeiculos.ReadOnly = true;
                    dgVeiculos.Columns[0].Visible = false;
                }

                reader.Close();
            }
            CarregarVeiculo(Convert.ToInt32(dgVeiculos.Rows[0].Cells[0].Value));
        }

        private void CarregarVeiculo(int id)
        {
            v = new Veiculo();

            v.Carregar(id);

            lbId.Text = v.Id.ToString();
            lbPlaca.Text = v.PlacaV;
            lbDesc.Text = v.DescV;
            lbMarca.Text = v.MarcaV;
            lbModelo.Text = v.ModeloV;
            lbPreco.Text = v.PrecoV.ToString();

            lbDisponivel.Text = v.AlugadoV? "Alugado" : "Disponível";

            if(v.AlugadoV){

                lbMulta.Visible = false;
                lbDias.Visible = false;
                lblEmprestimo.Visible = true;
                lblDevolucao.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                dateTimePicker1.Value = v.RetiradaV;
                dateTimePicker2.Value = v.DevolucaoV;

                double days = Math.Round((DateTime.Now - v.DevolucaoV).TotalDays);

                if(days > 0){

                    lbMulta.Visible = true;
                    lbDias.Visible = true;
                    lblMulta.Text = ((days * v.PrecoV) * 1.7).ToString();
                    lblDias.Text = days + " dias";
                }else{

                    lblMulta.Text = "";
                    lblDias.Text = "";
                }

            }else{
                lblMulta.Text = "";
                lblDias.Text = "";

                lbMulta.Visible = false;
                lbDias.Visible = false;
                lblEmprestimo.Visible = false;
                lblDevolucao.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }

        private void dgVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarVeiculo(Convert.ToInt32(dgVeiculos.Rows[dgVeiculos.CurrentCell.RowIndex].Cells[0].Value));
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            add.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            v.Excluir();
            MessageBox.Show("Veiculo deletado!");
            CarregarDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar edit = new Editar(v);
            edit.Show();
            this.Hide();
        }
    }
}
