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
                    SqlCommand cmd = new SqlCommand("Select nome_marcas from  marcas  where nome_marcas='" + txtcadmarcas.Text  + "';", cn);

                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (dados.Read())
                    {
                       
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
                    
                   
                    string sql = "INSERT INTO marcas (nome_marcas)  VALUES (@nome)";
                    SqlConnection conn = conexao.obterConexao();
                    SqlCommand cmdd = new SqlCommand(sql, conn);

                    cmdd.Parameters.Add(new SqlParameter("@nome", txtcadmarcas.Text));
                    

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
