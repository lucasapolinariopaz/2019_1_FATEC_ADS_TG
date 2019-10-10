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
    public partial class lembretesenha : Form
    {
        int contarcamposmudados = 0,cod;

        public lembretesenha()
        {
            InitializeComponent();
        }
        bool VerificaLogin(string cp)
        {

            bool result = false;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select CPF_usuario,cod_usuario from acesso where CPF_usuario='" + cp + "';", cn);
                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (dados.Read())
                    {
                       
                        cod = int.Parse(dados["cod_usuario"].ToString());
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
        private void button2_Click(object sender, EventArgs e)
        {
            string cpff = txtrecuperar.Text;
            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");
            bool Logado = false;
            bool result = VerificaLogin(cpff);

            Logado = result;

            if (result)
            {
                /*string str = Convert.ToString(cod);
                MessageBox.Show("Seja bem vindo!");
                MessageBox.Show(str);*/
                txtcpfrecup.Visible = true;
                btnatualizarrecup.Visible = true;
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!!");
            }
        }

        private void txtcpfrecup_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados = 1;
        }

        private void btnatualizarrecup_Click(object sender, EventArgs e)
        {
            if ((contarcamposmudados == 0)||(txtcpfrecup.Text==""))
            {
                MessageBox.Show("Campo senha vazio");
            }
            else
            {
                string sql = "UPDATE acesso SET senha_usuario = @senha WHERE cod_usuario = @cod_usuario";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand comm = new SqlCommand(sql, conn);
                
                comm.Parameters.Add(new SqlParameter("@senha", txtcpfrecup.Text));
                comm.Parameters.Add(new SqlParameter("@cod_usuario", (cod)));
                comm.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = comm.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
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
