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
    public partial class ConsultarDependentes : Form
    {
        int codigo_cliente = 0;
        List<int> lista_codigo_dependentes = new List<int>();

        public ConsultarDependentes()
        {
            InitializeComponent();
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

        public void limparCampos()
        {
            codigo_cliente = 0;
            lista_codigo_dependentes.Clear();
            dataGridView1.Rows.Clear();
            desabilitarCampos();
        }

        public void habilitarCampos()
        {
            btn_Alterar.Enabled = true;
            btn_Excluir.Enabled = true;
        }

        public void desabilitarCampos()
        {
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        public bool validaCamposDataGrid()
        {
            bool valida = false;
            int i, contador_verificador = 0;

            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null)
                {
                    MessageBox.Show("Informe todos os campos dos dependentes");
                    break;
                }
                else
                {
                    if (dataGridView1.Rows[i].Cells[1].Value == null)
                    {
                        MessageBox.Show("Informe todos os campos dos dependentes");
                        break;
                    }
                    else
                    {
                        contador_verificador++;
                    }
                }
            }

            if(contador_verificador == dataGridView1.Rows.Count)
            {
                valida = true;
            }

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

                string consulta_sql = "SELECT d.cod_dependentes, d.nome AS nome_dependente, d.parentesco, c.nome_cli AS nome_cliente, c.codigo_cli " +
                    "FROM clientes c, dependentes d WHERE c.codigo_cli = d.cod_clidp " +
                    "AND c.CPF_cli = '" + CPFf + "';";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand commn = new SqlCommand(consulta_sql, conn);
                commn.CommandType = CommandType.Text;

                commn.Parameters.Add(new SqlParameter("@nome_dependente", "nome_dependente"));
                commn.Parameters.Add(new SqlParameter("@parentesco", "parentesco"));
                commn.Parameters.Add(new SqlParameter("@nome_cliente", "nome_cliente"));
                commn.Parameters.Add(new SqlParameter("@codigo_cli", "codigo_cli"));
                commn.Parameters.Add(new SqlParameter("@cod_dependentes", "cod_dependentes"));

                conexao.obterConexao();
                SqlDataReader dr = commn.ExecuteReader();
                result = dr.HasRows;

                if (result == true)
                {
                    while (dr.Read())
                    {
                        codigo_cliente = int.Parse(dr["codigo_cli"].ToString());
                        lista_codigo_dependentes.Add(int.Parse(dr["cod_dependentes"].ToString()));

                        string col1 = dr["nome_dependente"].ToString();
                        string col2 = dr["parentesco"].ToString();
                        string col3 = dr["nome_cliente"].ToString();
                        string[] dados = { col1, col2, col3 };
                        this.dataGridView1.Rows.Add(dados);
                    }

                    habilitarCampos();
                }
                else
                {
                    MessageBox.Show("Dependentes de cliente não encontrados!!");
                }

                conexao.fecharConexao();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if(validaCamposDataGrid())
            {
                int contagem_registros = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string sql = "UPDATE dependentes SET nome = @nome, parentesco = @parentesco, cod_clidp = @cod_clidp " +
                            "WHERE cod_dependentes = @cod_dependentes;";
                    SqlConnection conn = conexao.obterConexao();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.Add(new SqlParameter("@nome", Convert.ToString(dataGridView1.Rows[i].Cells[0].Value).ToUpper()));
                    cmd.Parameters.Add(new SqlParameter("@parentesco", Convert.ToString(dataGridView1.Rows[i].Cells[1].Value).ToUpper()));
                    cmd.Parameters.Add(new SqlParameter("@cod_clidp", codigo_cliente));
                    cmd.Parameters.Add(new SqlParameter("@cod_dependentes", lista_codigo_dependentes[i]));

                    cmd.CommandType = CommandType.Text;
                    conexao.obterConexao();
                    try
                    {
                        int j = cmd.ExecuteNonQuery();
                        if (j > 0)
                            contagem_registros++;
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

                if (contagem_registros == dataGridView1.Rows.Count)
                {
                    MessageBox.Show("Dependentes alterados com sucesso!");
                    limparCampos();
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Selected.Equals(false))
            {
                MessageBox.Show("Selecione um dependente para excluir");
            }
            else
            {
                int indice = dataGridView1.CurrentRow.Index;

                string sql = "DELETE FROM dependentes WHERE cod_dependentes = @cod_dependentes;";

                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@cod_dependentes", lista_codigo_dependentes[indice]));

                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Dependente excluído com sucesso!");
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

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
