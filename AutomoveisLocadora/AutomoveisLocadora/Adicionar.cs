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

            txtPlaca.Text = v.PlacaV;
            txtDesc.Text = v.DescV;
            txtMarca.Text = v.MarcaV;
            txtModelo.Text = v.ModeloV;
            txtPreco.Text = v.PrecoV.ToString();

            v.Salvar();
        }
    }
}
