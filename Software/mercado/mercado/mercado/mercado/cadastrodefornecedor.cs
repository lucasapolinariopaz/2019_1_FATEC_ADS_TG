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
    public partial class cadastrodefornecedor : Form
    {
        string cnpj;
        bool VerificaFornecedor()
        {
            cnpj = txtcadcnpjfor.Text;
            bool result = false;
            
                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace(",", "");
                cnpj = cnpj.Replace("/", "");
                cnpj = cnpj.Replace("-", "");
                cnpj = cnpj.Replace(" ", "");
            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                   
                {
                    SqlCommand cmd = new SqlCommand("Select CNPJ from  fornecedor  where  CNPJ='"+ cnpj + "';", cn);

                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                   
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                conexao.fecharConexao();
            }
            return result;

        }
        public cadastrodefornecedor()
        {
            InitializeComponent();
        }

        private void btnsalvarcadfor_Click(object sender, EventArgs e)
        {
            if (txtcadempfor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else if (txtcadcnpjfor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else if (txtcadiefor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else if (txtcadendfor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else if (txtcadcidfor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else if (txtcadbarfor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else if (txtcaduffor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else if (txtcadtelfor.Text.Length == 0) { MessageBox.Show("Alguns dos campos não foi preenchido!!"); }
            else {  

            bool Logado = false;
            bool result = VerificaFornecedor();

            Logado = result;

            if (result)
            {
                MessageBox.Show("ERRO!!Fornecedor ja registrado no sistema!!");
                   

                }
            else
            {
                   

                    string sql = "INSERT INTO fornecedor (nome_fornecedor ,CNPJ ,IE,endereco ,cidade ,bairro ,estado ,telefone_fornec ,celular) VALUES (@nome_fornecedor ,@CNPJ,@IE,@endereco,@cidade,@bairro,@estado,@telefone_fornec ,@celular)";
                    SqlConnection conn = conexao.obterConexao();
                    SqlCommand cmdd = new SqlCommand(sql, conn);

                    cmdd.Parameters.Add(new SqlParameter("@nome_fornecedor", txtcadempfor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@CNPJ", cnpj));
                    cmdd.Parameters.Add(new SqlParameter("@IE", txtcadiefor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@endereco", txtcadendfor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@cidade", txtcadcidfor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@bairro", txtcadbarfor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@estado", txtcaduffor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@telefone_fornec", txtcadtelfor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@celular", txtcadcelfor.Text));


                    cmdd.CommandType = CommandType.Text;
                    conexao.obterConexao();
                    try
                    {
                        int i = cmdd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Cadastro realizado com sucesso!");
                        txtcadempfor.Clear();
                        txtcadcnpjfor.Clear();
                        txtcadiefor.Clear();
                        txtcadendfor.Clear();
                        txtcadcidfor.Clear();
                        txtcadbarfor.Clear();
                        txtcaduffor.Clear();
                        txtcadtelfor.Clear();
                        txtcadcelfor.Clear();
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
