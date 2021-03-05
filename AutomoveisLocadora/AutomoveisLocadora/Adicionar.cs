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
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Veiculo v = new Veiculo();

            v.PlacaV = txtPlaca.Text;
            v.DescV = txtDesc.Text;
            v.MarcaV = txtMarca.Text;
            v.ModeloV = txtModelo.Text;
            v.PrecoV = Convert.ToInt32(txtPreco.Text);
            v.AlugadoV = false;
            
            v.Salvar();

            MessageBox.Show("Veiculo cadastrado!");

            Home h = new Home();
            this.Close();
            h.Show();
        }
    }
}
