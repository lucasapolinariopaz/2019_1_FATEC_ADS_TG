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
        string nomefunc, hierarquia;
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
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@nome", "nome"));
                    cmd.Parameters.Add(new SqlParameter("@tipo", "tipo"));
                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    while (dados.Read())
                    {
                        nomefunc = dados["nome"].ToString();
                        hierarquia = dados["tipo"].ToString();

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

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            bool Logado = false;
            bool result = VerificaLogin();

            Logado = result;

            if (result)
            {

                // MessageBox.Show("Seja bem vindo!");
                MessageBox.Show(nomefunc, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (hierarquia == "ADMINISTRADOR") { aDMINUSTRAÇAOToolStripMenuItem.Visible = true; }
                menuStrip1.Visible = true;
                groupBox1.Visible = false;
                btnlogar.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrodecategoria novo = new cadastrodecategoria();
            novo.Show();
        }

        private void mARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastromarcas novo = new cadastromarcas();
            novo.Show();
        }

        private void cADASTROToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastrodefornecedor novo = new cadastrodefornecedor();
            novo.Show();
        }

        private void pRODUTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastro_de_produtos novo = new cadastro_de_produtos();
            novo.Show();
        }

        private void pRODUTOSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CONSULTAPRODUTOS novo = new CONSULTAPRODUTOS();
            novo.Show();
        }

        private void cAIXAToolStripMenuItem_Click(object sender, EventArgs e)
        {
        caixapdv novo = new caixapdv();
            novo.Show();
        }

        private void fECHAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abertura novo = new abertura();
            novo.login = nomefunc;
            novo.cpfrecebido = txtlogcpf.Text;
            novo.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fechamentodecaixa novo = new fechamentodecaixa();
            novo.Show();
        }

        private void cONSULTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaFornecedores novo = new ConsultaFornecedores();
            novo.Show();
        }

        private void gERENCIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarProdutos novo = new GerenciarProdutos();
            novo.Show();
        }

        private void cADASTROToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clientes  novo = new Clientes();
            novo.Show();
        }

        private void sALVARNOTASFISCAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarNotas novo = new SalvarNotas();
            novo.Show();
        }

        private void cONSULTAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaClientes novo = new ConsultaClientes();
            novo.Show();
        }

        private void cADASTRAODEDEPENDENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dependentes novo = new Dependentes();
            novo.Show();
        }

        private void cONSULTARDEPENDENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarDependentes novo = new ConsultarDependentes();
            novo.Show();
        }

        private void cONTASARECEBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contasAreceber novo = new contasAreceber();
            novo.Show();
        }

        private void aLTERARDADOSDEACESSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaracesso novo = new consultaracesso();
            novo.Show();
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendas novo = new vendas();
            novo.Show();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; menuStrip1.Visible = false; btnlogar.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pRODUTOSMAISVENDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rankdeprodutos novo = new rankdeprodutos();
            novo.Show();
        }
    }
}
