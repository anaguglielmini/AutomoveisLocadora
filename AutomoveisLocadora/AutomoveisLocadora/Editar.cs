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
            CarregarVeiculo();
        }

        private void CarregarVeiculo()
        {
            // TXTbox.text = attrs do v
        }

        private void SalvarCarro(){
            v.Salvar();
        }

    }
}
