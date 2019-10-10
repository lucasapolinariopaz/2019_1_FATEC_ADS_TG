using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{ 
    public partial class contasAreceber : Form
    {
        int codvendatemp = 99999, codvclii,codcli;
        bool result;
        string valorini, codvendacli,valor="0";
        decimal valorfecha;
      
        public contasAreceber()
        {
            InitializeComponent();
        }

        private void contasAreceber_Load(object sender, EventArgs e)
        {
            verificarsoma();
        }
        private void somaprodutos()
        {
            decimal resultado = 0, total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                resultado = (Convert.ToDecimal(row.Cells[3].Value));
                total += resultado;
            }
            valorini = Convert.ToString(total);
            label4.Text = "R$ "+valorini;
            //MessageBox.Show(valorini);
        }
        public void fechamento()
        {
            string pagamento = textBox1.Text;
            pagamento = pagamento.Replace("R$", "");
            string tr = textBox2.Text;
            tr = tr.Replace("R$", "");

            decimal valpg = Convert.ToDecimal(pagamento);
            decimal trocovl = Convert.ToDecimal(tr);
            string sql = "UPDATE fechamento SET valoraberturaf=(valoraberturaf+@pg)-@troco  WHERE estatus='ON'";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(new SqlParameter("@pg", valpg));
            comm.Parameters.Add(new SqlParameter("@troco", trocovl));

            conexao.obterConexao();
            try
            {
                int i = comm.ExecuteNonQuery();
                if (i > 0) { }
                   
               
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
        public decimal atufecha()
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select  valoraberturaf from fechamento where estatus='ON' ;", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@valoraberturaf", "valoraberturaf"));

            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    valorfecha = decimal.Parse(dr["valoraberturaf"].ToString());
                  
                }

            }
            else
            {
                MessageBox.Show("Debitos não encontrado!!");
            }

            conexao.fecharConexao();
            return valorfecha;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codvendacli = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            codvclii = int.Parse(codvendacli);
            detalhedebitos novo = new detalhedebitos();

            novo.cddnarra = codvendacli;
            novo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        private void Doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE debitoscli SET   estatus='OFF' WHERE cod_clideb='" + codcli + "'";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand comm = new SqlCommand(sql, conn);
          
         

            comm.CommandType = CommandType.Text;
            conexao.obterConexao();
            try
            {
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Pagamento realizado com sucesso!","AVISO");
                fechamento();
                textBox2.Clear();
                textBox3.Clear();
                label4.Text = "R$ 0,00";
                dataGridView1.Rows.Clear();
                textBox1.Clear();
                verificarsoma();

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
            string vl = label4.Text;
            vl = vl.Replace("R$", "");
            valor = valor.Replace("R$", "");
            decimal total = Convert.ToDecimal(vl) - Convert.ToDecimal(valor);
            textBox2.Text =Convert.ToString(total);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            valor = textBox1.Text.Replace("R$", "");
            textBox1.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        public void verificarsoma()
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select  sum(valordeb) as valor from debitoscli where estatus='ON' ;", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@valor", "valor"));

            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {

                    label2.Text = "R$ " + dr["valor"].ToString();

                }

            }
            else
            {
                MessageBox.Show("Debitos não encontrado!!");
            }

            conexao.fecharConexao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select  d.cod_clideb,c.nome_cli,d.datadeb,d.vendacli,d.valordeb from debitoscli d, clientes c where d.cod_clideb=c.codigo_cli and c.CPF_cli='" + textBox3.Text + "' and d.estatus='ON' ;", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@cod_clideb", "cod_clideb"));
            commn.Parameters.Add(new SqlParameter("@nome_cli", "nome_cli"));
            commn.Parameters.Add(new SqlParameter("@datadeb", "datadeb"));
            commn.Parameters.Add(new SqlParameter("@vendacli", "vendacli"));
            commn.Parameters.Add(new SqlParameter("@valordeb", "valordeb"));


            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {

                   codcli= int.Parse(dr["cod_clideb"].ToString());
                    string col1 = dr["vendacli"].ToString();
                    string col2 = dr["nome_cli"].ToString();
                    string col3 = dr["datadeb"].ToString();
                    string col4 = dr["valordeb"].ToString();

                    string[] dados = { col1, col2, col3, col4 };
                    this.dataGridView1.Rows.Add(dados);

                }
                somaprodutos();

            }
            else
            {
                MessageBox.Show("Débito não encontrado!!");
            }

            conexao.fecharConexao();
        }
    }
}
