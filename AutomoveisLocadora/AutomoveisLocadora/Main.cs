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

                carro.Carregar(id);

                this.carro = carro;

                AtualizarCarro();
            }

        }
        private void AtualizarCarro()
        {
            lblMarcaResult.Text = carro.MarcaV;
            lblModeloResult.Text = carro.ModeloV;
            lblPlacaResult.Text = carro.PlacaV;
            lblPrecoResult.Text = carro.PrecoV.ToString();

            if (carro.StatusV)
            {
                lblMulta.ForeColor = Color.Black;
                lblDevolucao.ForeColor = Color.Black;

                lblRetirada.Text = "Retirada: " + carro.RetiradaV.ToShortDateString();
                lblDevolucao.Text = "Devolução: " + carro.DevolucaoV.ToShortDateString();

                lblMulta.Text = "";

                int diasAtraso = Convert.ToInt32(Math.Round((DateTime.Now - carro.DevolucaoV).TotalDays) - 1);

                if (diasAtraso > 0)
                {
                    lblMulta.ForeColor = Color.Red;
                    lblDevolucao.ForeColor = Color.Orange;
                    lblMulta.Text = "Atrasado, Multa: R$" + (carro.PrecoV * diasAtraso) * 1.7; // 70% more
                }
                else
                {
                    lblMulta.ForeColor = Color.Green;
                    lblMulta.Text = "Dentro do prazo";
                }


            }
            else
            {
                lblRetirada.Text = "";
                lblDevolucao.Text = "";

                lblMulta.ForeColor = Color.Green;
                lblMulta.Text = "Disponível";
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
