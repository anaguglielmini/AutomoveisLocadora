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
    public partial class Editar : Form
    {
        Veiculo v;

        public Editar(Veiculo v)
        {
            this.v = v;
            InitializeComponent();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            comboBoxDisp.Items.Clear();
            comboBoxDisp.Items.Add("Não");
            comboBoxDisp.Items.Add("Sim");
            CarregarVeiculo();
        }

        private void CarregarVeiculo()
        {
            txtPlaca.Text = v.PlacaV;
            txtDesc.Text = v.DescV;
            txtMarca.Text = v.MarcaV;
            txtModelo.Text = v.ModeloV;
            txtPreco.Text = v.PrecoV.ToString();
            comboBoxDisp.SelectedIndex = v.AlugadoV? 0 : 1;

            if(v.AlugadoV){
                dateTimePickerEmp.Value = v.RetiradaV;
                dateTimePickerDev.Value = v.DevolucaoV;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtPreco.Text, out int preco)){
                MessageBox.Show("Preço precisa ser um número inteiro!");
                return ;
            }

            v.PlacaV = txtPlaca.Text;
            v.DescV = txtDesc.Text;
            v.MarcaV = txtMarca.Text;
            v.ModeloV = txtModelo.Text;
            v.PrecoV = preco;

            if(comboBoxDisp.SelectedIndex == 0){ //Alugado
                v.AlugadoV = true;
                v.RetiradaV = dateTimePickerEmp.Value;
                v.DevolucaoV = dateTimePickerDev.Value;
                
            }else{
                v.AlugadoV = false;

            }

            v.Salvar();

            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void comboBoxDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = comboBoxDisp.SelectedIndex == 0? true : false;
            panel1.Visible = comboBoxDisp.SelectedIndex == 0? true : false;
        }
    }
}
