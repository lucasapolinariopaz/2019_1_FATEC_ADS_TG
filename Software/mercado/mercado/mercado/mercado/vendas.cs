using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mercado
{
    public partial class vendas : Form
    {
        string valorini;
        bool result;

        public vendas()
        {
            InitializeComponent();
        }

        private void somaprodutos()
        {
            decimal resultado = 0, total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                resultado = (Convert.ToDecimal(row.Cells[2].Value));
                total += resultado;
            }
            valorini = Convert.ToString(total);
            lbl_ValorTotal.Text = "R$ " + valorini;
        }

        private void carregarCombobox(object sender, EventArgs e)
        {
            cb_pagamento.Items.Add("");
            cb_data.Items.Add("");
            string consulta_sql = "SELECT v.datavenda FROM Venda v GROUP BY v.datavenda;";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand(consulta_sql, conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@datavenda", "datavenda"));
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    cb_data.Items.Add(dr["datavenda"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Não há vendas!!");
            }

            conexao.fecharConexao();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string consulta_sql = "SELECT v.cod_venda, v.datavenda, v.valTotal, v.forPagamento FROM Venda v";

            //lógica para definir a string da consulta sql
            if (cb_data.Text.Length == 0 && cb_pagamento.Text.Length == 0)
            {
                consulta_sql = consulta_sql + ";";
            }
            else
            {
                int quant_filtro = 0;

                if (cb_data.Text.Length != 0)
                {
                    consulta_sql = consulta_sql + " WHERE v.datavenda = '" + cb_data.Text + "'";
                    quant_filtro++;
                }

                if (cb_pagamento.Text.Length != 0)
                {
                    if (quant_filtro > 0)
                    {
                        consulta_sql = consulta_sql + " AND v.forPagamento = '" + cb_pagamento.Text + "'";
                    }
                    else
                    {
                        consulta_sql = consulta_sql + " WHERE v.forPagamento = '" + cb_pagamento.Text + "'";
                    }
                }

                //enfim fecha a consulta sql
                consulta_sql = consulta_sql + ";";
            }

            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand(consulta_sql, conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@cod_venda", "cod_venda"));
            commn.Parameters.Add(new SqlParameter("@datavenda", "datavenda"));
            commn.Parameters.Add(new SqlParameter("@valTotal", "valTotal"));
            commn.Parameters.Add(new SqlParameter("@forPagamento", "forPagamento"));
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    string col1 = dr["cod_venda"].ToString();
                    string col2 = dr["datavenda"].ToString();
                    string col3 = dr["valTotal"].ToString();
                    string col4 = dr["forPagamento"].ToString();
                    string[] dados = { col1, col2, col3, col4};
                    this.dataGridView1.Rows.Add(dados);
                }

                somaprodutos();
            }
            else
            {
                MessageBox.Show("Não há vendas!!");
            }

            conexao.fecharConexao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
