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
    public partial class Clientes : Form
    {
        int cod;
        //int chekCampomask = 0;
        string envcpf;

        public Clientes()
        {
            InitializeComponent();
        }

        void limparCampos()
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
        }

        bool validaCampos()
        {
            bool valida = false;

            if (txt_NomeCliente.Text.Length == 0) { MessageBox.Show("Campo Nome do Cliente vazio"); }
            else if (txt_RG.Text.Length == 0) { MessageBox.Show("Campo RG vazio"); }
            else if (masktxt_CPF.Text.Length == 0) { MessageBox.Show("Campo CPF vazio"); }
            else if (contDigitosCPF(masktxt_CPF.Text) < 11) { MessageBox.Show("CPF informado não tem 11 dígitos"); }
            else if (validarCPF(masktxt_CPF.Text).Equals("true")) { MessageBox.Show("CPF inválido"); }
            else if (VerificaCliente(masktxt_CPF.Text)) { MessageBox.Show("Cliente já registrado no sistema!!"); }
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

        int contDigitosCPF(string cpff)
        {
            int digitos;
                        
            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");
            digitos = cpff.Length;

            return digitos;
        }

        public static string validarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            string verific;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace(",", "");
            cpf = cpf.Replace("-", "");
            cpf = cpf.Replace(" ", "");

            tempCpf = cpf.Substring(0, 9);
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
            if (cpf == tempCpf)
            {
                verific = "true";
            }
            else
            {
                verific = "false";
            }

            return verific;
        }

        bool VerificaCliente(string CPF)
        {
            bool result = false;

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
            if (validaCampos())
            {
                string sql = "INSERT INTO clientes (nome_cli, datanasc_cli, telefone_cli, celular_cli, RG_cli, CPF_cli, endereco_cli, cidade_cli, bairro_cli, numero_cli)  " +
                    "VALUES (@nome_cli, @datanasc_cli, @telefone_cli, @celular_cli, @RG_cli, @CPF_cli, @endereco_cli, @cidade_cli, @bairro_cli, @numero_cli)";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@nome_cli", txt_NomeCliente.Text));
                cmd.Parameters.Add(new SqlParameter("@datanasc_cli", masktxt_dataNasc.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone_cli", txt_Telefone.Text));
                cmd.Parameters.Add(new SqlParameter("@celular_cli", txt_Celular.Text));
                cmd.Parameters.Add(new SqlParameter("@RG_cli", txt_RG.Text));
                cmd.Parameters.Add(new SqlParameter("@CPF_cli", masktxt_CPF.Text));
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

        private void masktxt_CPF_KeyUp(object sender, KeyEventArgs e)
        {
            string cpff = masktxt_CPF.Text;

            if (contDigitosCPF(cpff) < 11)
            {
                lbl_CPF.Visible = false;
            }
            else if (contDigitosCPF(cpff) == 11)
            {
                if (validarCPF(cpff).Equals("true"))
                {
                    lbl_CPF.Visible = true;
                    lbl_CPF.ForeColor = Color.Green;
                    lbl_CPF.Text = "Válido!";
                    envcpf = cpff;
                    bool result = VerificaCliente(envcpf);

                    if (result)
                    {
                        btn_Salvar.Enabled = false;
                        masktxt_CPF.Focus();
                        MessageBox.Show("CPF já cadastrado no sistema");
                    }
                }
                else
                {
                    lbl_CPF.Visible = true;
                    lbl_CPF.ForeColor = Color.Red;
                    lbl_CPF.Text = "Inválido!";
                    masktxt_CPF.Focus();
                }
            }
        }
    }
}
