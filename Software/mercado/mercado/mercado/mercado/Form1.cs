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
using System.Windows.Forms;

namespace mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool VerificaLogin()
        {

            bool result = false;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("Select CPF_usuario,senha_usuario,tipo,nome from acesso where CPF_usuario='" + txtlogcpf.Text + "'and senha_usuario='" + txtsenha.Text + "';", cn);
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

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            bool Logado = false;
            bool result = VerificaLogin();

            Logado = result;

            if (result)
            {

                MessageBox.Show("Seja bem vindo!");

                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }

        private void cADASTRODEACESSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroAcesso novo = new cadastroAcesso();
            novo.Show();
        }

        private void btnlembrete_Click(object sender, EventArgs e)
        {
            lembretesenha novo = new lembretesenha();
            novo.Show();
        }
    }
}
