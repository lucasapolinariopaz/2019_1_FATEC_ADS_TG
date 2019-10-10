using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{
    public partial class consultaracesso : Form
    {
        bool result;
        int codacesso;
        public consultaracesso()
        {
            InitializeComponent();
        }

        private void btnsairacesso_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            string cpff = maskedTextBox1.Text;
            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select cod_usuario,CPF_usuario,senha_usuario,tipo,nome from acesso  where   CPF_usuario='" + cpff + "';", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@cod_usuario", "cod_usuario"));
            commn.Parameters.Add(new SqlParameter("@CPF_usuario", "CPF_usuario"));
            commn.Parameters.Add(new SqlParameter("@senha_usuario", "senha_usuario"));
            commn.Parameters.Add(new SqlParameter("@tipo", "tipo"));
            commn.Parameters.Add(new SqlParameter("@nome", "nome"));

            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {

                    codacesso = int.Parse(dr["cod_usuario"].ToString());
                    txtcadcpfacesso.Text = dr["CPF_usuario"].ToString();
                    txtcadsenhaacesso.Text = dr["senha_usuario"].ToString();
                    cmbacesso.Text = dr["tipo"].ToString();
                    txtcadacesso.Text = dr["nome"].ToString();

                }


            }
            else
            {
             
            }

            conexao.fecharConexao();
        }

        private void btnsalvaracesso_Click(object sender, EventArgs e)
        {

            string cpff = txtcadcpfacesso.Text;
            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");

            string sql = "UPDATE acesso SET   CPF_usuario = @CPF_usuario, senha_usuario= @senha_usuario,nome=@nome,tipo=@tipo WHERE cod_usuario='"+codacesso+"'";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(new SqlParameter("@CPF_usuario", cpff));
            comm.Parameters.Add(new SqlParameter("@senha_usuario", txtcadsenhaacesso.Text));
            comm.Parameters.Add(new SqlParameter("@nome", txtcadacesso.Text));
            comm.Parameters.Add(new SqlParameter("@tipo", cmbacesso.Text));

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

        private void button1_Click(object sender, EventArgs e)
        {


            string cpff = maskedTextBox1.Text;
            cpff = cpff.Trim();
            cpff = cpff.Replace(".", "").Replace(",", "");
            cpff = cpff.Replace("-", "");
            cpff = cpff.Replace(" ", "");
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select cod_usuario,CPF_usuario,senha_usuario,tipo,nome from acesso  where   CPF_usuario='" + cpff + "';", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@cod_usuario", "cod_usuario"));
            commn.Parameters.Add(new SqlParameter("@CPF_usuario", "CPF_usuario"));
            commn.Parameters.Add(new SqlParameter("@senha_usuario", "senha_usuario"));
            commn.Parameters.Add(new SqlParameter("@tipo", "tipo"));
            commn.Parameters.Add(new SqlParameter("@nome", "nome"));
           
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                   
                    codacesso = int.Parse(dr["cod_usuario"].ToString());
                    txtcadcpfacesso.Text = dr["CPF_usuario"].ToString();
                    txtcadsenhaacesso.Text = dr["senha_usuario"].ToString();
                    cmbacesso.Text = dr["tipo"].ToString();
                    txtcadacesso.Text = dr["nome"].ToString();

                }
               
              
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado!!");
            }

            conexao.fecharConexao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM acesso WHERE codacesso = @ID";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@ID", codacesso));
         


            cmd.CommandType = CommandType.Text;
            conexao.obterConexao();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Usuário excluído com sucesso!");
                


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
