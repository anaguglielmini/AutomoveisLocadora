using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomoveisLocadora
{
    class Veiculo
    {
        public string PlacaV, DescV, MarcaV, ModeloV;
        public int Id;
        public double PrecoV;
        public bool StatusV;
        public DateTime RetiradaV, DevolucaoV = DateTime.Now.Date;
        public void Adicionar(string placaV, string descV, string marcaV, string modeloV, double precoV)
        {
            this.Id = 0;
            this.PlacaV = placaV;
            this.DescV = descV;
            this.MarcaV = marcaV;
            this.ModeloV = modeloV;
            this.PrecoV = precoV;
            this.StatusV = false;
        }
        public void Carregar(int id)
        {
            MySqlDataReader reader = DB.Read("select id_veiculo, placa_veiculo, desc_veiculo, marca_veiculo, modelo_veiculo, preco_veiculo, stts_veiculo, data_emprestimo, data_devolucao from cad_veiculo where cad_veiculo.id = ?id", new MySqlParameter[] {new MySqlParameter("id", id)});

            if (reader != null)
            {
                while (reader.Read())
                {
                    this.Id = reader.GetInt32(0);
                    this.PlacaV = reader.GetString(1);
                    this.DescV = reader.GetString(2);
                    this.MarcaV = reader.GetString(3);
                    this.ModeloV = reader.GetString(4);
                    this.PrecoV = reader.GetInt32(5);

                    if (!reader.IsDBNull(6))
                    {
                        this.StatusV = true;
                        this.RetiradaV = reader.GetDateTime(6);
                        this.DevolucaoV = reader.GetDateTime(7);
                    }
                    else
                    {
                        this.StatusV = false;
                    }
                }
                reader.Close();
            }
        }
    }
}
