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
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Veiculo v = new Veiculo();
            v.placaV = txtPlaca.Text;
            v.descV = txtDesc.Text;
            v.modeloV = txtModelo.Text;
            v.marcaV = txtMarca.Text;
            v.precoV = Convert.ToInt32(txtPreco.Text);
            string cmd = $"insert into cad_veiculo values('{v.placaV}','{v.descV}','{v.marcaV}','{v.modeloV}','{v.precoV}','0', null, null, null)";
            try
            {
                DB.Run(cmd);
                this.Close();
                MessageBox.Show("Veículo cadastrado");
                Main main = new Main();
                main.Show();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Erro no cadastro");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
