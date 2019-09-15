using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace mercado
{
    public partial class cadastromarcas : Form
    {
        int cod;
        int codv;
        public cadastromarcas()
        {
            InitializeComponent();
        }

        bool VerificaCateg()
        {

            bool result = false;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select m.nome_marcas,m.cod_categ_marcas,c.categ,c.cod_categoria from  marcas m,categoria c  where c.cod_categoria=m.cod_categ_marcas and m.nome_marcas='" + txtcadmarcas.Text + "'and c.categ='" + comboBox1.Text + "';", cn);

                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (dados.Read())
                    {
                        cod = int.Parse(dados["cod_categoria"].ToString());

                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                conexao.fecharConexao();
            }
            return result;

        }
        private void cadastromarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mercado_tgDataSet2.categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.mercado_tgDataSet2.categoria);

            

        }

        private void btncadmarcas_Click(object sender, EventArgs e)
        {
            bool Logado = false;
            bool result = VerificaCateg();

            Logado = result;

            if (result)
            {
                MessageBox.Show("ERRO!!marca ja registrada a Categoria selecionada!!");
            
            }
            else
            {
                if (txtcadmarcas.Text.Length == 0) { MessageBox.Show("Campo marca vazio"); }
                else {
                    
                    SqlConnection cn = conexao.obterConexao();
                    SqlCommand cmd = new SqlCommand("Select categ,cod_categoria from  categoria   where categ='" + comboBox1.Text + "';", cn);

                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (dados.Read())
                    {
                        codv = int.Parse(dados["cod_categoria"].ToString());
                        

                    }
                    string sql = "INSERT INTO marcas (nome_marcas,cod_categ_marcas)  VALUES (@nome,@codcategPK)";
                    SqlConnection conn = conexao.obterConexao();
                    SqlCommand cmdd = new SqlCommand(sql, conn);

                    cmdd.Parameters.Add(new SqlParameter("@nome", txtcadmarcas.Text));
                    cmdd.Parameters.Add(new SqlParameter("@codcategPK", (codv)));

                    cmdd.CommandType = CommandType.Text;
                    conexao.obterConexao();
                    try
                    {
                        int i = cmdd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.ToString());
                    }
                    finally
                    {
                        conexao.fecharConexao();
                    }


                }
                

                
            }
        }
    }
}
