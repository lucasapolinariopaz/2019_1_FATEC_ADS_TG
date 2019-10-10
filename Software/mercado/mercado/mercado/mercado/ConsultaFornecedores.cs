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
    public partial class ConsultaFornecedores : Form
    {
        int codigo_fornecedor = 0;

        public ConsultaFornecedores()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txt_RazaoSocial.Clear();
            masktxt_CNPJ.Clear();
            txt_IE.Clear();
            txt_Endereco.Clear();
            txt_Cidade.Clear();
            txt_Bairro.Clear();
            txt_UF.Clear();
            txt_Telefone.Clear();
            txt_Celular.Clear();
            desabilitarCampos();
        }

        public bool validaCampos()
        {
            bool valida = false;

            if (codigo_fornecedor == 0) { MessageBox.Show("Fornecedor não informado"); }
            else if (txt_RazaoSocial.Text.Length == 0) { MessageBox.Show("Campo Razão Social vazio!!"); }
            else if (masktxt_CNPJ.Text.Length == 0) { MessageBox.Show("Campo CNPJ vazio!!"); }
            else if (verificaFornecedorUpdate(masktxt_CNPJ.Text, codigo_fornecedor).Equals("false")) { MessageBox.Show("Fornecedor já registrado no sistema!!"); }
            else if (txt_IE.Text.Length == 0) { MessageBox.Show("Campo IE vazio!!"); }
            else if (txt_Endereco.Text.Length == 0) { MessageBox.Show("Campo Endereço vazio!!"); }
            else if (txt_Cidade.Text.Length == 0) { MessageBox.Show("Campo Cidade vazio!!"); }
            else if (txt_Bairro.Text.Length == 0) { MessageBox.Show("Campo Bairro vazio!!"); }
            else if (txt_UF.Text.Length == 0) { MessageBox.Show("Campo UF vazio!!"); }
            else if (txt_Telefone.Text.Length == 0) { MessageBox.Show("Campo Telefone vazio!!"); }
            else if (txt_Celular.Text.Length == 0) { MessageBox.Show("Campo Celular vazio!!"); }
            else { valida = true; }

            return valida;
        }

        public bool verificaFornecedorUpdate(string CNPJ, int codigo_fornec)
        {
            bool result = true;
            int cod;

            /*
            CNPJ = CNPJ.Trim();
            CNPJ = CNPJ.Replace(".", "").Replace(",", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");
            CNPJ = CNPJ.Replace(" ", "");
            */

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT cod_fornecdor, CNPJ FROM fornecedor WHERE CNPJ = '" + CNPJ + "';", cn);

                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (dados.Read())
                    {
                        cod = int.Parse(dados["cod_fornecdor"].ToString());

                        //Para evitar duplicação de CNPJ
                        if (cod != codigo_fornec)
                        {
                            result = false;
                        }
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

        public void habilitarCampos()
        {
            btn_Salvar.Enabled = true;
            btn_Excluir.Enabled = true;
        }

        public void desabilitarCampos()
        {
            btn_Salvar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_PesquisarCNPJ_Click(object sender, EventArgs e)
        {
            bool result = false;
            string cpff = masktxt_PesquisarCNPJ.Text;


            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");
            cpff = cpff.Replace("/", "");
            limparCampos();

            string consulta_sql = "SELECT cod_fornecdor, nome_fornecedor, CNPJ, IE, endereco, cidade, bairro, estado, telefone_fornec, celular " +
                    "FROM fornecedor WHERE CNPJ = '" + cpff + "';";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand(consulta_sql, conn);
            commn.CommandType = CommandType.Text;

            commn.Parameters.Add(new SqlParameter("@cod_fornecdor", "cod_fornecdor"));
            commn.Parameters.Add(new SqlParameter("@nome_fornecedor", "nome_fornecedor"));
            commn.Parameters.Add(new SqlParameter("@CNPJ", "CNPJ"));
            commn.Parameters.Add(new SqlParameter("@IE", "IE"));
            commn.Parameters.Add(new SqlParameter("@endereco", "endereco"));
            commn.Parameters.Add(new SqlParameter("@cidade", "cidade"));
            commn.Parameters.Add(new SqlParameter("@bairro", "bairro"));
            commn.Parameters.Add(new SqlParameter("@estado", "estado"));
            commn.Parameters.Add(new SqlParameter("@telefone_fornec", "telefone_fornec"));
            commn.Parameters.Add(new SqlParameter("@celular", "celular"));

            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;

            if (result == true)
            {
                while (dr.Read())
                {
                    codigo_fornecedor = int.Parse(dr["cod_fornecdor"].ToString());
                    txt_RazaoSocial.Text = dr["nome_fornecedor"].ToString();
                    masktxt_CNPJ.Text = dr["CNPJ"].ToString();
                    txt_IE.Text = dr["IE"].ToString();
                    txt_Endereco.Text = dr["endereco"].ToString();
                    txt_Cidade.Text = dr["cidade"].ToString();
                    txt_Bairro.Text = dr["bairro"].ToString();
                    txt_UF.Text = dr["estado"].ToString();
                    txt_Telefone.Text = dr["telefone_fornec"].ToString();
                    txt_Celular.Text = dr["celular"].ToString();

                    habilitarCampos();
                }
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado!!");
            }

            conexao.fecharConexao();
        }

        private void btn_ViewAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string cpff = masktxt_CNPJ.Text;


            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");
            cpff = cpff.Replace("/", "");
            if (validaCampos())
            {
                string sql = "UPDATE fornecedor SET nome_fornecedor = @nome_fornecedor, CNPJ = @CNPJ, IE = @IE, endereco = @endereco, cidade = @cidade, bairro = @bairro, estado = @estado, telefone_fornec = @telefone_fornec, celular = @celular " +
                    "WHERE cod_fornecdor = @cod_fornecdor;";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@cod_fornecdor", codigo_fornecedor));
                cmd.Parameters.Add(new SqlParameter("@nome_fornecedor", txt_RazaoSocial.Text));
                cmd.Parameters.Add(new SqlParameter("@CNPJ", cpff));
                cmd.Parameters.Add(new SqlParameter("@IE", txt_IE.Text));
                cmd.Parameters.Add(new SqlParameter("@endereco", txt_Endereco.Text));
                cmd.Parameters.Add(new SqlParameter("@cidade", txt_Cidade.Text));
                cmd.Parameters.Add(new SqlParameter("@bairro", txt_Bairro.Text));
                cmd.Parameters.Add(new SqlParameter("@estado", txt_UF.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone_fornec", txt_Telefone.Text));
                cmd.Parameters.Add(new SqlParameter("@celular", txt_Celular.Text));

                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro de fornecedor alterado com sucesso!");
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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            string cpff = masktxt_CNPJ.Text;


            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");
            cpff = cpff.Replace("/", "");
            if (codigo_fornecedor == 0)
            {
                MessageBox.Show("Fornecedor não informado");
            }
            else
            {
                string sql = "DELETE FROM fornecedor WHERE cod_fornecdor = @cod_fornecdor AND CNPJ = @CNPJ;";

                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@cod_fornecdor", codigo_fornecedor));
                cmd.Parameters.Add(new SqlParameter("@CNPJ", cpff));

                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro de fornecedor excluído com sucesso!");
                    limparCampos();
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
