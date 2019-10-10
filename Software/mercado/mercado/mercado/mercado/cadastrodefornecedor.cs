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
    public partial class cadastrodefornecedor : Form
    {
        //string cnpj;
        
        public cadastrodefornecedor()
        {
            InitializeComponent();
        }

        public string NoMaskCNPJ(string CNPJ)
        {
            string result;

            result = CNPJ.Trim();
            result = result.Replace(".", "").Replace(",", "");
            result = result.Replace("/", "");
            result = result.Replace("-", "");
            result = result.Replace(" ", "");

            return result;
        }

        bool VerificaFornecedor()
        {
            //cnpj = NoMaskCNPJ(txtcadcnpjfor.Text);

            bool result = false;
        
            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT CNPJ FROM fornecedor WHERE CNPJ = '" + txtcadcnpjfor.Text + "';", cn);

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

        public void limparCampos()
        {
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

        bool validarCampos()
        {
            bool result = false;

            if (txtcadempfor.Text.Length == 0) { MessageBox.Show("Campo Razão Social não foi informado!!"); }
            else if (txtcadcnpjfor.Text.Length == 0) { MessageBox.Show("Campo CNPJ não foi informado!!"); }
            else if (txtcadiefor.Text.Length == 0) { MessageBox.Show("Campo IE não foi informado!!"); }
            else if (txtcadendfor.Text.Length == 0) { MessageBox.Show("Campo Endereço não foi informado!!"); }
            else if (txtcadcidfor.Text.Length == 0) { MessageBox.Show("Campo Cidade não foi informado!!"); }
            else if (txtcadbarfor.Text.Length == 0) { MessageBox.Show("Campo Bairro não foi informado!!"); }
            else if (txtcaduffor.Text.Length == 0) { MessageBox.Show("Campo UF não foi informado!!"); }
            else if (txtcadtelfor.Text.Length == 0) { MessageBox.Show("Campo Telefone não foi informado!!"); }
            else if (txtcadcelfor.Text.Length == 0) { MessageBox.Show("Campo Celular não foi informado!!"); }
            else
            {
                result = true;
            }

            return result;
        }

        private void btnsalvarcadfor_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {  
                bool Logado = false;
                bool result = VerificaFornecedor();

                Logado = result;

                if (result)
                {
                    MessageBox.Show("ERRO!!Fornecedor já registrado no sistema!!");
                }
                else
                {
                    string sql = "INSERT INTO fornecedor (nome_fornecedor , CNPJ, IE, endereco, cidade, bairro, estado, telefone_fornec, celular) VALUES (@nome_fornecedor, @CNPJ, @IE, @endereco, @cidade, @bairro, @estado, @telefone_fornec, @celular)";
                    SqlConnection conn = conexao.obterConexao();
                    SqlCommand cmdd = new SqlCommand(sql, conn);

                    cmdd.Parameters.Add(new SqlParameter("@nome_fornecedor", txtcadempfor.Text));
                    cmdd.Parameters.Add(new SqlParameter("@CNPJ", txtcadcnpjfor.Text));
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
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!");
                            limparCampos();
                        }
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
