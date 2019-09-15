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
    public partial class cadastrodecategoria : Form
    {
        int cod;
        public cadastrodecategoria()
        {
            InitializeComponent();
        }
        bool VerificaCateg(string cp)
        {

            bool result = false;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select categ,cod_categoria from categoria where categ='" + cp + "';", cn);
                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (dados.Read())
                    {

                        cod = int.Parse(dados["cod_categoria"].ToString());
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
        private void btncadcateg_Click(object sender, EventArgs e)
        {
            bool Logado = false;
            string cateM = txtcadcateg.Text;
            cateM = cateM.ToUpper();
            bool result = VerificaCateg(cateM);

            Logado = result;

            if (result)
            {
                MessageBox.Show("ERRO!!Categoria ja registrada no sistema!!");

            }
            else
            {
                if (txtcadcateg.Text.Length == 0) { MessageBox.Show("Campo marca vazio"); }
                else { 
                string sql = "INSERT INTO categoria (categ)  VALUES (@nome)";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@nome", cateM));

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
        }
    }
}
