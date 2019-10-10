using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{
    public partial class detalhedebitos : Form
    {
        public detalhedebitos()
        {
            InitializeComponent();
        }
        public string cddnarra { get; set; }
        int recbarra;
        bool result;
        private void detalhedebitos_Load(object sender, EventArgs e)
        {
            recbarra = int.Parse(cddnarra);
            try
            {
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand("select d.descProdV,d.marca,d.valorUniV,d.unidades,d.subValortotal from detalheVenda d ,venda v where d.codDetV= v.cod_venda and v.cod_venda='" + recbarra + "';", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@descProdV", "descProdV"));
                cmd.Parameters.Add(new SqlParameter("@marca", "marca"));
                cmd.Parameters.Add(new SqlParameter("@valorUniV", "valorUniV"));
                cmd.Parameters.Add(new SqlParameter("@unidades", "unidades"));
                cmd.Parameters.Add(new SqlParameter("@subValortotal", "subValortotal"));

                conexao.obterConexao();
                SqlDataReader dr = cmd.ExecuteReader();
                result = dr.HasRows;
                while (dr.Read())
                {
                    string col1 = dr["descProdV"].ToString();
                    string col2 = dr["marca"].ToString();
                    string col3 = dr["valorUniV"].ToString();
                    string col4 = dr["unidades"].ToString();
                    string col5 = dr["subValortotal"].ToString();
                    string col0 = cddnarra;

                    string[] dados = { col0, col1, col2, col3, col4, col5 };
                    this.dataGridView1.Rows.Add(dados);


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            conexao.fecharConexao();
        }
    }
}
