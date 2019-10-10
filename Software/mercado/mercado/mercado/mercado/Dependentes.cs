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
    public partial class Dependentes : Form
    {
        public Dependentes()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txt_ClienteCod.Clear();
            txt_DependenteNome.Clear();
            txt_DependenteParentesco.Clear();
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

        public bool validaCampos()
        {
            bool valida = false;

            if (txt_ClienteCod.Text.Length == 0) { MessageBox.Show("Cliente não informado"); }
            else if (txt_DependenteNome.Text.Length == 0) { MessageBox.Show("Campo Nome do dependente vazio"); }
            else if (txt_DependenteParentesco.Text.Length == 0) { MessageBox.Show("Campo grau de parentesco vazio"); }
            else { valida = true; }

            return valida;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string CPFf = masktxt_PesquisarCPF.Text;
            CPFf = CPFf.Trim();
            CPFf = CPFf.Replace(".", "").Replace(",", "");
            CPFf = CPFf.Replace("-", "");
            CPFf = CPFf.Replace(" ", "");

            if (CPFf.Length == 0) { MessageBox.Show("Informar CPF para consultar cliente"); }
            else if (contDigitosCPF(CPFf) < 11) { MessageBox.Show("CPF informado para consulta não tem 11 dígitos"); }
            else if (validarCPF(CPFf).Equals("false")) { MessageBox.Show("CPF informado para consulta é inválido"); }
            else
            {
                bool result = false;

                limparCampos();

                string consulta_sql = "SELECT codigo_cli FROM clientes WHERE CPF_cli = '" + CPFf + "';";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand commn = new SqlCommand(consulta_sql, conn);
                commn.CommandType = CommandType.Text;

                commn.Parameters.Add(new SqlParameter("@codigo_cli", "codigo_cli"));

                conexao.obterConexao();
                SqlDataReader dr = commn.ExecuteReader();
                result = dr.HasRows;

                if (result == true)
                {
                    while (dr.Read())
                    {
                        txt_ClienteCod.Text = dr["codigo_cli"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!!");
                }

                conexao.fecharConexao();
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
            if (validaCampos())
            {
                string sql = "INSERT INTO dependentes (nome, parentesco, cod_clidp) VALUES (@nome, @parentesco, @cod_clidp)";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@nome", txt_DependenteNome.Text));
                cmd.Parameters.Add(new SqlParameter("@parentesco", txt_DependenteParentesco.Text));
                cmd.Parameters.Add(new SqlParameter("@cod_clidp", int.Parse(txt_ClienteCod.Text)));

                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
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
}
