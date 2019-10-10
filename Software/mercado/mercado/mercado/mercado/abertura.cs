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
    public partial class abertura : Form
    {

        public abertura()
        {
            InitializeComponent();

        }
        public string login { get; set; }
        public string cpfrecebido { get; set; }
        string dd;
        string valor = "0";
        string cpfenviar;
        string status="ON";

        bool Verificaabertura()
        {

            bool result = false;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("Select estatus from abertura where estatus='ON';", cn);
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.Add(new SqlParameter("@nome", "nome"));
                    conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    while (dados.Read())
                    {
                       // nomefunc = dados["nome"].ToString();


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
        private void abertura_Load(object sender, EventArgs e)
        {
            bool Logado = false;
            bool result = Verificaabertura();

            Logado = result;

            if (result)
            {
                //criar tela de fechamento 
                MessageBox.Show("Estatus de Abertura de caixa aberto!!Feche para continuar", "AVISO");
                fechamentodecaixa novo =new fechamentodecaixa();
                novo.Show();
                this.Close();

            }
            else
            {



                if (!this.login.Equals(""))
                {
                    lblfunc.Text = this.login;
                    cpfenviar = this.cpfrecebido;
                }

                DateTime dt = DateTime.Now;
                dd = dt.ToString("dd/MM/yyy");
                lbldata.Text = dd;
            }
        }

        private void btnfec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (textBox1.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            valor = textBox1.Text.Replace("R$", "");
            textBox1.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            valor = textBox1.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                textBox1.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                textBox1.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                textBox1.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (textBox1.Text.StartsWith("0,"))
                {
                    textBox1.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (textBox1.Text.Contains("00,"))
                {
                    textBox1.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    textBox1.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = textBox1.Text;
            textBox1.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblvaloratual.Text = textBox1.Text;
        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0,00";
        }

        private void btnsalv_Click(object sender, EventArgs e)
        {
            string valorab = lblvaloratual.Text;
            valorab = valorab.Replace("R$", "");
            decimal valorfixo = Convert.ToDecimal(valorab);
            if (lblvaloratual.Text.Length==0 && lblfunc.Text.Length == 0 && lbldata.Text.Length == 0)
            {
                MessageBox.Show("Campos nao estão completados","AVISO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { if (valorab == "0,00")
                {
                    MessageBox.Show("Impossivel resgistrar Valor zero de Abertura ","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    string sql = "INSERT INTO abertura (nomefunc,cpffunc,dataaber,valorabertura,estatus)  VALUES (@nomefunc, @cpffunc,@dataaber, @valorabertura, @estatus)";
                    SqlConnection conn = conexao.obterConexao();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@nomefunc", lblfunc.Text));
                    cmd.Parameters.Add(new SqlParameter("@cpffunc", cpfenviar));
                    cmd.Parameters.Add(new SqlParameter("@dataaber", dd));
                    cmd.Parameters.Add(new SqlParameter("@valorabertura", valorfixo));
                    cmd.Parameters.Add(new SqlParameter("@estatus", status));
                    cmd.CommandType = CommandType.Text;
                    conexao.obterConexao();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                          if(  MessageBox.Show("Abertura de Caixa realizada com sucesso!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                this.Close();
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
}
