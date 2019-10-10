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
    public partial class GerenciarProdutos : Form
    {
        bool result;
        public GerenciarProdutos()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            dataGridView01.Rows.Clear();

            string consulta_sql = "SELECT e.codigo_prod, e.codigo_barra, e.descricao_prod, e.categoria_prod, e.marca_prod, e.preco_custo, e.preco_venda, e.estoque_atualprod, e.validade_prod, e.codprod_fornec, e.data_entrada, e.codprodentrada FROM estoque e";

            //lógica para definir a string da consulta sql
            if (cb_cat.Text.Length == 0 && cb_marca.Text.Length == 0 && cb_data.Text.Length == 0)
            {
                consulta_sql = consulta_sql + ";";
            }
            else
            {
                int quant_filtro = 0;

                if (cb_cat.Text.Length != 0)
                {
                    consulta_sql = consulta_sql + " WHERE e.categoria_prod = '" + cb_cat.Text + "'";
                    quant_filtro++;
                }
                    
                if(cb_marca.Text.Length != 0)
                {
                    if (quant_filtro > 0)
                    {
                        consulta_sql = consulta_sql + " AND e.marca_prod = '" + cb_marca.Text + "'";
                    }
                    else
                    {
                        consulta_sql = consulta_sql + " WHERE e.marca_prod = '" + cb_marca.Text + "'";
                    }
                }

                if(cb_data.Text.Length != 0)
                {
                    if(cb_data.Text == "RECENTES")
                    {
                        consulta_sql = consulta_sql + " ORDER BY e.codigo_prod DESC";
                    }
                    else if(cb_data.Text == "ANTIGOS")
                    {
                        consulta_sql = consulta_sql + " ORDER BY e.codigo_prod ASC";
                    }
                    else if (cb_data.Text == "VALIDADE")
                    {
                        consulta_sql = consulta_sql + " ORDER BY e.validade_prod ASC";
                    }
                }

                //enfim fecha a consulta sql
                consulta_sql = consulta_sql + ";";
            }

            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand(consulta_sql, conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@codigo_prod", "codigo_prod"));
            commn.Parameters.Add(new SqlParameter("@codigo_barra", "codigo_barra"));
            commn.Parameters.Add(new SqlParameter("@descricao_prod", "descricao_prod"));
            commn.Parameters.Add(new SqlParameter("@categoria_prod", "categoria_prod"));
            commn.Parameters.Add(new SqlParameter("@marca_prod", "marca_prod"));
            commn.Parameters.Add(new SqlParameter("@preco_custo", "preco_custo"));
            commn.Parameters.Add(new SqlParameter("@preco_venda", "preco_venda"));
            commn.Parameters.Add(new SqlParameter("@estoque_atualprod", "estoque_atualprod"));
            commn.Parameters.Add(new SqlParameter("@validade_prod", "validade_prod"));
            commn.Parameters.Add(new SqlParameter("@codprod_fornec", "codprod_fornec"));
            commn.Parameters.Add(new SqlParameter("@codprodentrada", "codprodentrada"));
            commn.Parameters.Add(new SqlParameter("@data_entrada", "data_entrada"));
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    string col1 = dr["codigo_barra"].ToString();
                    string col2 = dr["descricao_prod"].ToString();
                    string col3 = dr["categoria_prod"].ToString();
                    string col4 = dr["marca_prod"].ToString();
                    string col5 = dr["estoque_atualprod"].ToString();
                    string col6 = dr["validade_prod"].ToString();
                    string col7 = dr["data_entrada"].ToString();
                    string[] dados = {col1, col2, col3, col4, col5, col6, col7};
                    this.dataGridView01.Rows.Add(dados);
                }
            }
            else
            {
                MessageBox.Show("Produto não encontrado!!");
            }

            conexao.fecharConexao();
        }

        private void carregarCombobox(object sender, EventArgs e)
        {
            cb_data.Items.Insert(0, "");

            cb_cat.Items.Add("");
            string consulta_sql = "SELECT c.categ FROM categoria c GROUP BY c.categ;";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand(consulta_sql, conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@categ", "categ"));
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    cb_cat.Items.Add(dr["categ"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Categorias de produtos não encontradas!!");
            }

            conexao.fecharConexao();

            cb_marca.Items.Add("");
            consulta_sql = "SELECT m.nome_marcas FROM marcas m GROUP BY m.nome_marcas;";
            conn = conexao.obterConexao();
            commn = new SqlCommand(consulta_sql, conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@nome_marcas", "nome_marcas"));
            conexao.obterConexao();
            dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    cb_marca.Items.Add(dr["nome_marcas"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Marcas de produtos não encontradas!!");
            }

            conexao.fecharConexao();
        }
    }
}
