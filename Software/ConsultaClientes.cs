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
    public partial class ConsultaClientes : Form
    {
        int codigo_cli = 0;

        public ConsultaClientes()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txt_NomeCliente.Clear();
            txt_RG.Clear();
            masktxt_CPF.Clear();
            masktxt_dataNasc.Clear();
            txt_Endereco.Clear();
            txt_Cidade.Clear();
            txt_Bairro.Clear();
            txt_Numero.Clear();
            txt_Telefone.Clear();
            txt_Celular.Clear();
            codigo_cli = 0;
            lbl_CPF.Visible = false;
        }

        public bool validaCampos()
        {
            bool valida = false;

            if (codigo_cli == 0) { MessageBox.Show("Cliente não informado"); }
            else if (txt_NomeCliente.Text.Length == 0) { MessageBox.Show("Campo Nome do Cliente vazio"); }
            else if (txt_RG.Text.Length == 0) { MessageBox.Show("Campo RG vazio"); }
            else if (masktxt_CPF.Text.Length == 0) { MessageBox.Show("Campo CPF vazio"); }
            else if (contDigitosCPF(masktxt_CPF.Text) < 11) { MessageBox.Show("CPF informado não tem 11 dígitos"); }
            else if (validarCPF(masktxt_CPF.Text).Equals("false")) { MessageBox.Show("CPF inválido"); }
            else if (VerificaClienteUpdate(masktxt_CPF.Text, codigo_cli).Equals("false")) { MessageBox.Show("Cliente já registrado no sistema!!"); }
            else if (masktxt_dataNasc.Text.Length == 0) { MessageBox.Show("Campo Data de Nascimento vazio"); }
            else if (txt_Endereco.Text.Length == 0) { MessageBox.Show("Campo Endereço vazio"); }
            else if (txt_Cidade.Text.Length == 0) { MessageBox.Show("Campo Cidade vazio"); }
            else if (txt_Bairro.Text.Length == 0) { MessageBox.Show("Campo Bairro vazio"); }
            else if (txt_Numero.Text.Length == 0) { MessageBox.Show("Campo Número do Endereço vazio"); }
            else if (txt_Telefone.Text.Length == 0) { MessageBox.Show("Campo Telefone vazio"); }
            else if (txt_Celular.Text.Length == 0) { MessageBox.Show("Campo Celular vazio"); }
            else { valida = true; }

            return valida;
        }

        public string NoMask_CPF(string Mask_CPF)
        {
            string NoMask_CPF;

            NoMask_CPF = Mask_CPF.Trim();
            NoMask_CPF = NoMask_CPF.Replace(".", "").Replace(",", "");
            NoMask_CPF = NoMask_CPF.Replace("-", "");
            NoMask_CPF = NoMask_CPF.Replace(" ", "");

            return NoMask_CPF;
        }

        public int contDigitosCPF(string CPF)
        {
            int digitos;

            CPF = NoMask_CPF(CPF);
            digitos = CPF.Length;

            return digitos;
        }

        public string validarCPF(string CPF)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            string verific;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace(",", "");
            CPF = CPF.Replace("-", "");
            CPF = CPF.Replace(" ", "");

            tempCpf = CPF.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * (multiplicador1[i]);
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            tempCpf = tempCpf + resto;

            if (CPF == tempCpf)
            {
                verific = "true";
            }
            else
            {
                verific = "false";
            }

            return verific;
        }

        public bool VerificaClienteUpdate(string CPF, int codigo_cliente)
        {
            bool result = true;
            int cod;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT CPF_cli, codigo_cli FROM clientes WHERE CPF_cli ='" + CPF + "';", cn);
                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (dados.Read())
                    {
                        cod = int.Parse(dados["codigo_cli"].ToString());

                        //Para evitar duplicação de CPF de cliente
                        if (cod != codigo_cliente)
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

        public void statusCPF()
        {
            if (contDigitosCPF(masktxt_CPF.Text) < 11)
            {
                lbl_CPF.Visible = false;
            }
            else if (contDigitosCPF(masktxt_CPF.Text) == 11)
            {
                if (validarCPF(masktxt_CPF.Text).Equals("true"))
                {
                    lbl_CPF.Visible = true;
                    lbl_CPF.ForeColor = Color.Green;
                    lbl_CPF.Text = "Válido!";

                    /*
                    bool result = VerificaClienteUpdate(envcpf, codigo_cli);
                    if (result)
                    {
                        masktxt_CPF.Focus();
                        MessageBox.Show("CPF já cadastrado no sistema");
                    }
                    */
                }
                else
                {
                    lbl_CPF.Visible = true;
                    lbl_CPF.ForeColor = Color.Red;
                    lbl_CPF.Text = "Inválido!";
                }
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            /*
            string CPFf = masktxt_PesquisarCPF.Text;
            CPFf = CPFf.Trim();
            CPFf = CPFf.Replace(".", "").Replace(",", "");
            CPFf = CPFf.Replace("-", "");
            CPFf = CPFf.Replace(" ", "");
            */
            if (validaCampos())
            {
                string sql = "UPDATE clientes SET nome_cli = @nome_cli, RG_cli = @RG_cli, CPF_cli = @CPF_cli, datanasc_cli = @datanasc_cli, endereco_cli = @endereco_cli, cidade_cli = @cidade_cli, bairro_cli = @bairro_cli, numero_cli = @numero_cli, telefone_cli = @telefone_cli, celular_cli = @celular_cli " +
                    "WHERE codigo_cli = @codigo_cli;";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@codigo_cli", codigo_cli));
                cmd.Parameters.Add(new SqlParameter("@nome_cli", txt_NomeCliente.Text));
                cmd.Parameters.Add(new SqlParameter("@datanasc_cli", masktxt_dataNasc.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone_cli", txt_Telefone.Text));
                cmd.Parameters.Add(new SqlParameter("@celular_cli", txt_Celular.Text));
                cmd.Parameters.Add(new SqlParameter("@RG_cli", txt_RG.Text));
                cmd.Parameters.Add(new SqlParameter("@CPF_cli", NoMask_CPF(masktxt_CPF.Text)));
                cmd.Parameters.Add(new SqlParameter("@endereco_cli", txt_Endereco.Text));
                cmd.Parameters.Add(new SqlParameter("@cidade_cli", txt_Cidade.Text));
                cmd.Parameters.Add(new SqlParameter("@bairro_cli", txt_Bairro.Text));
                cmd.Parameters.Add(new SqlParameter("@numero_cli", int.Parse(txt_Numero.Text)));

                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro de cliente alterado com sucesso!");
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
            string CPFf = masktxt_PesquisarCPF.Text;
            CPFf = CPFf.Trim();
            CPFf = CPFf.Replace(".", "").Replace(",", "");
            CPFf = CPFf.Replace("-", "");
            CPFf = CPFf.Replace(" ", "");
            if (codigo_cli == 0)
            {
                MessageBox.Show("Cliente não informado");
            }
            else
            {
                string sql = "DELETE FROM clientes WHERE codigo_cli = @codigo_cli AND CPF_cli = @CPF_cli;";

                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@codigo_cli", codigo_cli));
                cmd.Parameters.Add(new SqlParameter("@CPF_cli", CPFf));

                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro de cliente excluído com sucesso!");
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

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string CPFf= masktxt_PesquisarCPF.Text;
            CPFf = CPFf.Trim();
            CPFf = CPFf.Replace(".", "").Replace(",", "");
            CPFf = CPFf.Replace("-", "");
            CPFf = CPFf.Replace(" ", "");
            if (CPFf.Length == 0) { MessageBox.Show("Informar CPF para consultar cliente"); }
            else if (contDigitosCPF(CPFf) < 11) { MessageBox.Show("CPF informado para consulta não tem 11 dígitos"); }
            else if (validarCPF(CPFf).Equals("false")) { MessageBox.Show("CPF informado para consulta é inválido"); }
            else
            {
                limparCampos();

                string consulta_sql = "SELECT codigo_cli, nome_cli, datanasc_cli, telefone_cli, celular_cli, RG_cli, CPF_cli, endereco_cli, cidade_cli, bairro_cli, numero_cli " +
                    "FROM clientes WHERE CPF_cli = '" + CPFf + "';";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand commn = new SqlCommand(consulta_sql, conn);
                commn.CommandType = CommandType.Text;

                commn.Parameters.Add(new SqlParameter("@codigo_cli", "codigo_cli"));
                commn.Parameters.Add(new SqlParameter("@nome_cli", "nome_cli"));
                commn.Parameters.Add(new SqlParameter("@datanasc_cli", "datanasc_cli"));
                commn.Parameters.Add(new SqlParameter("@telefone_cli", "telefone_cli"));
                commn.Parameters.Add(new SqlParameter("@celular_cli", "celular_cli"));
                commn.Parameters.Add(new SqlParameter("@RG_cli", "RG_cli"));
                commn.Parameters.Add(new SqlParameter("@CPF_cli", "CPF_cli"));
                commn.Parameters.Add(new SqlParameter("@endereco_cli", "endereco_cli"));
                commn.Parameters.Add(new SqlParameter("@cidade_cli", "cidade_cli"));
                commn.Parameters.Add(new SqlParameter("@bairro_cli", "bairro_cli"));
                commn.Parameters.Add(new SqlParameter("@numero_cli", "numero_cli"));

                conexao.obterConexao();
                SqlDataReader dr = commn.ExecuteReader();
                bool result = dr.HasRows;

                if (result == true)
                {
                    while (dr.Read())
                    {
                        codigo_cli = int.Parse(dr["codigo_cli"].ToString());
                        txt_NomeCliente.Text = dr["nome_cli"].ToString();
                        txt_RG.Text = dr["RG_cli"].ToString();
                        masktxt_CPF.Text = dr["CPF_cli"].ToString();
                        statusCPF();
                        masktxt_dataNasc.Text = dr["datanasc_cli"].ToString();
                        txt_Endereco.Text = dr["endereco_cli"].ToString();
                        txt_Cidade.Text = dr["cidade_cli"].ToString();
                        txt_Bairro.Text = dr["bairro_cli"].ToString();
                        txt_Numero.Text = dr["numero_cli"].ToString();
                        txt_Telefone.Text = dr["telefone_cli"].ToString();
                        txt_Celular.Text = dr["celular_cli"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!!");
                }

                conexao.fecharConexao();
            }
        }

        private void masktxt_CPF_KeyUp(object sender, KeyEventArgs e)
        {
            statusCPF();
        }
    }
}
