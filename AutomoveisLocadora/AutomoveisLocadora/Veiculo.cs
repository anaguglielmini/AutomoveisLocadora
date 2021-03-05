﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MySqlDataReader reader = DB.Read("select id_veiculo, placa_veiculo, desc_veiculo, marca_veiculo, modelo_veiculo, preco_veiculo, stts_veiculo, data_emprestimo, data_devolucao from cad_veiculo where cad_veiculo.id_veiculo = ?id_veiculo", new MySqlParameter[] {new MySqlParameter("id_veiculo", id)});

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
        public void Excluir()
        {
            MySqlDataReader reader = DB.Read("select id_veiculo from cad_veiculo where cad_veiculo.id_veiculo = ?id_veiculo", new MySqlParameter[] { new MySqlParameter("id_veiculo", Id) });

            if(reader != null)
            {
                if (reader.HasRows)
                {
                    reader.Close();
                    DB.Run("delete from cad_veiculo where cad_viculo.id_veiculo = ?id_veiculo", new MySqlParameter[] { new MySqlParameter("id_veiculo", Id) });
                }
                else
                {
                    MessageBox.Show("Carro inexistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
        }
        public void Salvar()
        {
            MySqlDataReader reader = DB.Read("select id_veiculo from cad_veiculo where cad_veiculo.id_veiculo = ?id_veiculo", new MySqlParameter[] { new MySqlParameter("id_veiculo", Id)});

            if (reader != null)
            {
                bool hasRows = reader.HasRows;
                reader.Close();

                if (hasRows)
                {
                    DB.Run($"update cad_veiculo set placa_veiculo = ?placa_veiculo,{(StatusV ? "data_emprestimo = ?data_emprestimo, data_devolucao = ?data_devolucao," : "data_emprestimo = null, data devolucao = null,")} desc_veiculo = ?desc_veiculo, modelo_veiculo = ?modelo_veiculo, marca_veiculo = ?marca_veiculo where id_veiculo = ?id_veiculo", GetQueryParameters());

                }
                else
                {
                    DB.Run("insert into cad_veiculo (placa_veiculo, desc_veiculo, marca_veiculo, modelo_veiculo, preco_veiculo, stts_veiculo, data_emprestimo, data_devolucao)" +
                           $"values (?placa_veiculo, ?desc_veiculo, ?marca_veiculo, ?modelo_veiculo, ?preco_veiculo,{(StatusV ? "?data_emprestimo, ?data_devolucao," : "null, null,")})", GetQueryParameters());

                }
            }
        }
        private MySqlParameter[] GetQueryParameters()
        {

            return new MySqlParameter[] {
                new MySqlParameter("id_veiculo", Id),
                new MySqlParameter("placa_veiculo", PlacaV),
                new MySqlParameter("modelo_veiculo", ModeloV),
                new MySqlParameter("marca_veiculo", MarcaV),
                new MySqlParameter("desc_veiculo", DescV),
                new MySqlParameter("preco_veiculo", PrecoV),
                new MySqlParameter("data_emprestimo", RetiradaV.ToString("yyyy-MM-dd")),
                new MySqlParameter("data_devolucao", DevolucaoV.ToString("yyyy-MM-dd"))
            };
        }
    }
}
