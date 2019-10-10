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
    public partial class fechamentodecaixa : Form
    {

        string cpffech,codaberfech,valor="0";
        public fechamentodecaixa()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtretirada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtretirada.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtretirada_Leave(object sender, EventArgs e)
        {
            valor = txtretirada.Text.Replace("R$", "");
            txtretirada.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string status = "OFF";
            if (MessageBox.Show("DESEJA REALMENTE FECHAR CAIXA!!", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string pccaracter = txtretirada.Text;
                pccaracter = pccaracter.Replace("R$", "");
                decimal pc = Convert.ToDecimal(pccaracter);
                string valabertufechamento = lblvaloratual.Text;
                valabertufechamento = valabertufechamento.Replace("R$", "");
                decimal pv = Convert.ToDecimal(valabertufechamento);           
                string sql = "INSERT INTO fechamento ( nomefunc,cpffunc,dataaber,valoraberturaf ,saida,valorsaida,estatus)  VALUES (@nomefunc, @cpffunc, @dataaber, @valoraberturaf, @saida, @valorsaida, @estatus)";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@nomefunc", lblfunc.Text));
                cmd.Parameters.Add(new SqlParameter("@cpffunc", cpffech));
                cmd.Parameters.Add(new SqlParameter("@dataaber", lbldata.Text));
                cmd.Parameters.Add(new SqlParameter("@estatus", status));
                cmd.Parameters.Add(new SqlParameter("@valoraberturaf", pv));
                cmd.Parameters.Add(new SqlParameter("@valorsaida", pc));
                cmd.Parameters.Add(new SqlParameter("@saida", txtpretirar.Text));
               
                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Caixa Fechado com sucesso!","AVISO");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conexao.fecharConexao();
                }
                ///MessageBox.Show("caixa fechado ");

            }

            else {/// MessageBox.Show("caixa aberto ainda");
                this.Close();
            }



        }

        private void txtretirada_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtretirada.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtretirada.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtretirada.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtretirada.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtretirada.Text.StartsWith("0,"))
                {
                    txtretirada.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtretirada.Text.Contains("00,"))
                {
                    txtretirada.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtretirada.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtretirada.Text;
            txtretirada.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtretirada.Select(txtretirada.Text.Length, 0);
        }

        private void fechamentodecaixa_Load(object sender, EventArgs e)
        {
            bool result = false;
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select codAber,nomefunc,cpffunc,dataaber,valorabertura  from abertura where estatus='ON';", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@codAber", "codAber"));
            commn.Parameters.Add(new SqlParameter("@nomefunc", "nomefunc"));
            commn.Parameters.Add(new SqlParameter("@cpffunc", "cpffunc"));
            commn.Parameters.Add(new SqlParameter("@dataaber", "dataaber"));
            commn.Parameters.Add(new SqlParameter("@valorabertura", "valorabertura"));
            
           
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                
                 //   codforn = int.Parse(dr["codprod_fornec"].ToString());
                 //   Tcodf = codforn.ToString();
             
                    lbldata.Text = dr["dataaber"].ToString();
                    lblfunc.Text = dr["nomefunc"].ToString();
                    cpffech = dr["cpffunc"].ToString();
                    lblvaloratual.Text = dr["valorabertura"].ToString();
                    codaberfech = dr["codAber"].ToString();

                }
                Decimal val, val1;
                if (Decimal.TryParse(lblvaloratual.Text, out val))
                    lblvaloratual.Text = val.ToString("C");
                if (Decimal.TryParse(lblvaloratual.Text, out val1))
                    lblvaloratual.Text = val1.ToString("C");
                btnup.Enabled = true;
            }
            else
            {
                MessageBox.Show(" Não há Abertura de caixa no momento!!");
                //lbldata.Text = ("            ");
                lblfunc.Text = ("                                 ");
                cpffech = ("            ");
                lblvaloratual.Text = ("            ");
                btnup.Enabled = false;
            }

            conexao.fecharConexao();
        }
    }



}
