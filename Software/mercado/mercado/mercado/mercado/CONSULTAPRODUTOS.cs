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
    public partial class CONSULTAPRODUTOS : Form
    {
        public CONSULTAPRODUTOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select e.codigo_barra, e.descricao_prod , e.categoria_prod , e.marca_prod, e.preco_custo , e.preco_venda , e.estoque_atualprod, e.validade_prod ,e.codprod_fornec, e.data_entrada , e.codprodentrada,f.nome_fornecedor from estoque e,fornecedor f where   codigo_barra='" + txtpesqprod.Text + "' and f.cod_fornecdor=e.codprod_fornec;", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@codigo_barra", "codigo_barra"));
            commn.Parameters.Add(new SqlParameter("@descricao_prod", "descricao_prod"));
            commn.Parameters.Add(new SqlParameter("@categoria_prod", "categoria_prod"));
            commn.Parameters.Add(new SqlParameter("@marca_prod", "marca_prod"));
            commn.Parameters.Add(new SqlParameter("@preco_custo", "preco_custo"));
            commn.Parameters.Add(new SqlParameter("@preco_venda", "preco_venda"));
            commn.Parameters.Add(new SqlParameter("@estoque_atualprod", "estoque_atualprod"));
            commn.Parameters.Add(new SqlParameter("@validade_prod", "validade_prod"));
            commn.Parameters.Add(new SqlParameter("@nome_fornecedor", "nome_fornecedor"));
           commn.Parameters.Add(new SqlParameter("@data_entrada", "data_entrada"));
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            while (dr.Read())
            {
                txtcaddescprod.Text = dr["descricao_prod"].ToString();
                maskedTextBox1.Text = dr["codigo_barra"].ToString();
                cbncateg.Text = dr["categoria_prod"].ToString();
                cbnfornecedor.Text = dr["nome_fornecedor"].ToString();
                cbnmarcas.Text = dr["marca_prod"].ToString();
                txtpdvenda.Text= dr["preco_venda"].ToString();
                txt_valorUni.Text = dr["preco_custo"].ToString();
                txtunidadesatual.Text = dr["estoque_atualprod"].ToString();     
                maskedTextBox4.Text = dr["validade_prod"].ToString();
                lbldata.Text= dr["data_entrada"].ToString();

            }
            conexao.fecharConexao();
        }
    }
}
