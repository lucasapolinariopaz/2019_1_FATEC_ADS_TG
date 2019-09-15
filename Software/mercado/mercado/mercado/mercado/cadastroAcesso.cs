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
    public partial class cadastroAcesso : Form
    {
        public cadastroAcesso()
        {
            InitializeComponent();
        }

        string tipoAcesso;
        string envcpf;
        int chekCampomask = 0;
        bool VerificaLogin(string cp)
        {

            bool result = false;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select CPF_usuario from acesso where CPF_usuario='" + cp + "';", cn);
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
        public static string validarCpf(string cpf)
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

            ;

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
        private void cmbacesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbacesso.SelectedIndex == -1)
            { }
            else {
                tipoAcesso = cmbacesso.Text;
                txtcadacesso.Enabled = true;
            }
        }
        private void txtcadacesso_Click(object sender, EventArgs e)
        {
            if (cmbacesso.SelectedIndex == -1)
            { label6.Visible = true; }
            else { label6.Visible = false; }
            txtcadcpfacesso.Enabled = true;
        }

        private void txtcadcpfacesso_TextChanged(object sender, EventArgs e)
        {
            txtcadsenhaacesso.Enabled = true;
            chekCampomask = 1;
        }
  

        private void txtcadsenhaacesso_Click(object sender, EventArgs e)
        {
            
            if (chekCampomask == 1)
            {
                string cpff = txtcadcpfacesso.Text;
                string teste;
               
                cpff = cpff.Trim();
                cpff = cpff.Replace(".", "").Replace(",", "");
                cpff = cpff.Replace("-", "");
                cpff = cpff.Replace(" ", "");
              

               if (cpff.Length == 11)
                   {
                       teste = validarCpf(cpff);
                       if (teste.Equals("true"))
                       {
                           label8.Visible = true;
                           label8.ForeColor = Color.Green;
                           label8.Text = "Válido!";
                           chekCampomask = 0;
                            envcpf = cpff;
                        btnsalvaracesso.Enabled = true;
                        bool Logado = false;
                        bool result = VerificaLogin(envcpf);

                        Logado = result;

                        if (result)
                        {
                            btnsalvaracesso.Enabled = true;
                            MessageBox.Show("CPF já cadastrado no sistema");
                            txtcadsenhaacesso.Enabled = false;
                            txtcadsenhaacesso.Clear();
                            txtcadcpfacesso.Focus();
                            btnsalvaracesso.Enabled = false;
                        }
                       

                    }
                       else

                       {
                           label8.Visible = true;
                           label8.ForeColor = Color.Red;
                           label8.Text = "Inválido!";
                           chekCampomask = 0;
                           txtcadsenhaacesso.Enabled = false;
                           txtcadsenhaacesso.Clear();
                           txtcadcpfacesso.Focus();
                           btnsalvaracesso.Enabled = false;

                    }
                   }
                   else
                   {
                       MessageBox.Show("nao tem 11 digitos");
                       label8.Text = "";
                       txtcadsenhaacesso.Enabled = false;
                       txtcadsenhaacesso.Clear();
                       txtcadcpfacesso.Focus();
                   }
               
            }
        }
        private void btnsalvaracesso_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO acesso (CPF_usuario, senha_usuario, tipo, nome)  VALUES ( @cpfuser,@senhaacc,@tipo,@nome)";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@cpfuser", envcpf));
            cmd.Parameters.Add(new SqlParameter("@senhaacc", txtcadsenhaacesso.Text));
            cmd.Parameters.Add(new SqlParameter("@tipo",tipoAcesso));
            cmd.Parameters.Add(new SqlParameter("@nome", txtcadacesso.Text));

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

        private void btnsairacesso_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtcadsenhaacesso.Clear();
            cmbacesso.Refresh();
            txtcadacesso.Clear();
            txtcadcpfacesso.Clear();
            label8.Text = "";
        }
    }
}
      
        

        
    

