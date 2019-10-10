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
    public partial class caixapdv : Form
    {
        double Ptotal = 0;
        string valorini;
        bool result = false;
        string codprod,marca;
        decimal res1, troco;
        string dd,codcc, nomedec,cl1,cl2, cl3,cl4,cl5;
        int codcli;
        int codvendatemp=99999;
        decimal desconto;
   

        public caixapdv()
        {
            InitializeComponent();
        }


public void esconderCampos()
        {
            Label1.Visible = false;
            Label2.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            Label12.Visible = false;
            Label11.Visible = false;
            Label13.Visible = false;
            Label14.Visible = false;
            Label15.Visible = false;
            Label16.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            Label6.Visible = false;
            Label5.Visible = false;
            Label7.Visible = false;
            Label9.Visible = false;
            Btnbusca.Visible = false;
            buscprods.Visible = false;
            txtdescricao.Visible = false;
            txtprecouni.Visible = false;
            txtquant.Visible = false;
            txttotal.Visible = false;
            datalistado.Visible = false;
            BtnAcrescer.Visible = false;
            tnExcluir.Visible = false;
            button2.Visible = false;
            cbmfmpg.Visible = false;
            textBox3.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            txtvalortotal.Visible = false;
            comboBox2.Visible = false;
            txtcli.Visible = false;
            BtnSair.Visible = false;
            BtnFinalizarVenda.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
        }
        public void mostrarCampos()
        {
            Label1.Visible = true;
            Label2.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            Label12.Visible = true;
            Label11.Visible = true;
            Label13.Visible = true;
            Label14.Visible = true;
            Label15.Visible = true;
            Label16.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            Label6.Visible = true;
            Label5.Visible = true;
            Label7.Visible = true;
            Label9.Visible = true;
            Btnbusca.Visible = true;
            buscprods.Visible = true;
            txtdescricao.Visible = true;
            txtprecouni.Visible = true;
            txtquant.Visible = true;
            txttotal.Visible = true;
            datalistado.Visible = true;
            BtnAcrescer.Visible = true;
            tnExcluir.Visible = true;
            button2.Visible = true;
            cbmfmpg.Visible = true;
            textBox3.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            txtvalortotal.Visible = true;
            comboBox2.Visible = true;
            txtcli.Visible = true;
            BtnSair.Visible = true;
            BtnFinalizarVenda.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            List1.Visible = false;
            button4.Visible = false;
        }
        public void cupom()
        {
            List1.Visible = true;
            string data;
            DateTime dt = DateTime.Now;
            data = dt.ToString("dd/MM/yyy");
            List1.Height = 400;
            List1.Width = 250;
            List1.Items.Add("                       RAZÃO SOCIAL");
            List1.Items.Add(data);
            List1.Items.Add("                    CUPOM  NÃO FISCAL");
            List1.Items.Add(" ITEM   CÓDIGO        DESCRIÇÃO");
            List1.Items.Add("     QNT.       VL.UNIT(  R$)   ST    VL.ITEM(  R$)");
            List1.Items.Add("-----------------------------------------------------------------------------------------------");
            for (int i = 0; i < datalistado.Rows.Count; i++)
            {
                DataGridViewCell c1 = datalistado.Rows[i].Cells[0];
                DataGridViewCell c2 = datalistado.Rows[i].Cells[1];
                DataGridViewCell c3 = datalistado.Rows[i].Cells[2];
                DataGridViewCell c4 = datalistado.Rows[i].Cells[3];
                DataGridViewCell c5 = datalistado.Rows[i].Cells[4];
                if (c1.Value != null && c2.Value != null && c3.Value != null && c4.Value != null && c5.Value != null)
                {
                    // List1.Items.Add(c.Value.ToString());  List1.Items.Add(c2.Value.ToString());
                    cl1 = c1.Value.ToString();
                    cl2 = c2.Value.ToString();
                    cl3 = c3.Value.ToString();
                    cl4 = c4.Value.ToString();
                    cl5 = c5.Value.ToString();
                }
                List1.Items.Add(("0000") + cl1 + "   " + cl3+" "+cl2);
                List1.Items.Add("R$"+cl4 + "  " + cl5 + "Un x  ");
            }
            List1.Items.Add("CLiENTE " + txtcli.Text);
            List1.Items.Add("VALOR TOTAL "+ txtvalortotal.Text);
            List1.Items.Add("VALOR PAGO " + "R$ " + TextBox6.Text);
            List1.Items.Add("TROCO " + "R$ " + TextBox7.Text);
            esconderCampos();

        }
        private void caixapdv_Load(object sender, EventArgs e)
        {

           
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
          
          toolTip1.SetToolTip(this.button3,"Consulte Cliente");
          toolTip1.SetToolTip(this.button1, "Consulte Depedentes");
        }


        private void somaprodutos()
        {
            decimal resultado = 0, total = 0, resultado2 = 0, total2 = 0;
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                resultado = (Convert.ToDecimal(row.Cells[5].Value));
                total += resultado;           
           }  
                valorini = Convert.ToString(total);
                txtvalortotal.Text = valorini;
                //MessageBox.Show(valorini);
        }
        public void SalvarDados()
        {
            
                if (datalistado.Rows.Count > 0)
                {
                for (int i = 0; i <= datalistado.Rows.Count - 1; i++)
                {
                    int col1 = Convert.ToInt32(datalistado.Rows[i].Cells[0].Value); //id
                    string col2 = datalistado.Rows[i].Cells[1].Value.ToString(); //marca 
                    string col3 = datalistado.Rows[i].Cells[2].Value.ToString(); //Descricao 
                    decimal col4 = Convert.ToDecimal(datalistado.Rows[i].Cells[3].Value); //Preco 
                    int col5 = Convert.ToInt32(datalistado.Rows[i].Cells[4].Value); //Quantidade
                    decimal col6 = Convert.ToDecimal(datalistado.Rows[i].Cells[5].Value); //Total

                    string insert = "INSERT INTO detalheVendatemp(codProdV,codDetV,marca,descProdV,valorUniV,unidades,subValortotal) VALUES (@codProdV,@codDetV,@marca,@descProdV,@valorUniV,@unidades,@subValortotal)";
                    SqlConnection con = conexao.obterConexao();
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@codProdV", col1); 
                    cmd.Parameters.AddWithValue("@codDetV", codvendatemp);
                    cmd.Parameters.AddWithValue("@marca", col2);
                    cmd.Parameters.AddWithValue("@descProdV", col3);
                    cmd.Parameters.AddWithValue("@valorUniV", col4);
                    cmd.Parameters.AddWithValue("@unidades", col5);
                    cmd.Parameters.AddWithValue("@subValortotal", col6);
                    cmd.CommandType = CommandType.Text;
                    conexao.obterConexao();
                    try
                    {
                        int ix = cmd.ExecuteNonQuery();
                        if (ix > 0) {
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
        private void limpar()
        {
            txtdescricao.Clear(); txtprecouni.Clear(); txtquant.Clear(); txttotal.Clear(); buscprods.Clear();
            comboBox2.SelectedIndex = -1; txtcli.Clear(); cbmfmpg.SelectedIndex = -1; textBox3.Clear();
            TextBox6.Clear(); TextBox7.Clear(); txtvalortotal.Clear();
            datalistado.Rows.Clear();
        }
        private void BtnAcrescer_Click(object sender, EventArgs e)
        {
            if (txtquant.Text.Length == 0 && txttotal.Text.Length == 00)
            {
                MessageBox.Show(" Campos não preenchido","AVISO");
            }
            else {
                datalistado.Rows.Add(codprod, marca,txtdescricao.Text, txtprecouni.Text, txtquant.Text, txttotal.Text);
                somaprodutos();
                txtdescricao.Clear(); txtprecouni.Clear(); txtquant.Clear(); txttotal.Clear(); buscprods.Clear();
            }


        }

        private void Btnbusca_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select codigo_prod,codigo_barra, descricao_prod , marca_prod, preco_venda from estoque  where   codigo_barra='" + buscprods.Text + "';", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@codigo_prod", "codigo_prod"));
            commn.Parameters.Add(new SqlParameter("@codigo_barra", "codigo_barra"));
            commn.Parameters.Add(new SqlParameter("@descricao_prod", "descricao_prod"));
            commn.Parameters.Add(new SqlParameter("@marca_prod", "marca_prod"));
            commn.Parameters.Add(new SqlParameter("@preco_venda", "preco_venda"));
           
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    codprod= dr["codigo_prod"].ToString();                   
                    marca= dr["marca_prod"].ToString();
                    txtdescricao.Text = dr["descricao_prod"].ToString();
                    txtprecouni.Text = dr["preco_venda"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Produto não encontrado!!");
            }

            conexao.fecharConexao();

        }

        private void tnExcluir_Click(object sender, EventArgs e)
        {
            datalistado.Rows.Remove(datalistado.CurrentRow);
            somaprodutos();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mostrarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datalistado.Rows.Clear();
            txtvalortotal.Clear();
            txtdescricao.Clear();
            txtprecouni.Clear();
            txtquant.Clear();
            txttotal.Clear();
            txtvalortotal.Clear();
            buscprods.Clear();
            textBox3.Clear();
            TextBox6.Clear();
            TextBox7.Clear();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0)
            {

            
                decimal vlu = Convert.ToDecimal(valorini), des = Convert.ToDecimal(textBox3.Text);
                res1 = vlu - ((vlu * des) / 100);
                txtvalortotal.Text = Convert.ToString(res1);
              txtvalortotal.Text = string.Format("{0:C}", Convert.ToDecimal(res1));

            }
           else { textBox3.Text = "0"; }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            valorini = txtvalortotal.Text;
            valorini = valorini.Replace("R$", "");
            if (TextBox6.Text.Length != 0)
            {
                decimal vlu = Convert.ToDecimal(valorini), pago = Convert.ToDecimal(TextBox6.Text), res;
                string vlf;
                res =   pago-vlu;
                TextBox7.Text = Convert.ToString(res);
            }
            else { TextBox7.Text = "0,00"; }
        }

        private void BtnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (cbmfmpg.Text.Length == 0)
            {
                MessageBox.Show("Nehuma Forma de Pagamento Escolhida", "AVISO");
            }
            else if (cbmfmpg.Text == "DINHEIRO")
            {
                if (TextBox6.Text.Length == 0)
                {
                    MessageBox.Show("Campo Pagamento Vazio", "AVISO");
                }
                else {
                    SalvarDados();
                    DateTime dt = DateTime.Now;
                    dd = dt.ToString("dd/MM/yyy");
                    string data = dd;
                    decimal valenv = Convert.ToDecimal(txtvalortotal.Text);
                    string frmpg = cbmfmpg.Text;
                     codcli = 1; 
                    string nomecli = comboBox2.Text;
                    decimal valpag = Convert.ToDecimal(TextBox6.Text);
                    decimal troco = Convert.ToDecimal(TextBox7.Text);

                    if (textBox3.Text.Length == 0)
                    {
                        textBox3.Text = "0";
                        desconto = Convert.ToDecimal(textBox3.Text);
                    }
                    else { desconto = Convert.ToDecimal(textBox3.Text); }

                    string insert = "INSERT INTO Venda(datavenda ,valTotal,forPagamento,codcliV,nomeclienteDep,valpago,troco,desconto) VALUES (@datavenda,@valTotal,@forPagamento,@codcliV,@nomeclienteDep,@valpago,@troco,@desconto)";
                    SqlConnection con = conexao.obterConexao();
                    SqlCommand cmd = new SqlCommand(insert, con);

                    cmd.Parameters.AddWithValue("@datavenda", data);
                    cmd.Parameters.AddWithValue("@valTotal", valenv);
                    cmd.Parameters.AddWithValue("@forPagamento", frmpg);
                    cmd.Parameters.AddWithValue("@codcliV", codcli);
                    cmd.Parameters.AddWithValue("@nomeclienteDep", nomecli);
                    cmd.Parameters.AddWithValue("@valpago", valpag);
                    cmd.Parameters.AddWithValue("@troco", troco);
                    cmd.Parameters.AddWithValue("@desconto", desconto);


                    cmd.CommandType = CommandType.Text;
                    conexao.obterConexao();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Venda realizada com sucesso!","AVISO");
                            cupom();
                            limpar();

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
            else if(cbmfmpg.Text == "CARTÃO")
            {

                SalvarDados();

                TextBox7.Text = "0,00";
                decimal troco = Convert.ToDecimal(TextBox7.Text);
                DateTime dt = DateTime.Now;
                dd = dt.ToString("dd/MM/yyy");
                string data = dd;
                valorini = txtvalortotal.Text;
                valorini = valorini.Replace("R$", "");
                decimal valenv = Convert.ToDecimal(valorini);
                string frmpg = cbmfmpg.Text;
                codcli = 1;
                string nomecli = comboBox2.Text;

                decimal valpag = valenv;
               

                if (textBox3.Text.Length == 0)
                {
                    textBox3.Text = "0";
                    desconto = Convert.ToDecimal(textBox3.Text);
                }
                else { desconto = Convert.ToDecimal(textBox3.Text); }

                string insert = "INSERT INTO Venda(datavenda ,valTotal,forPagamento,codcliV,nomeclienteDep,valpago,troco,desconto) VALUES (@datavenda,@valTotal,@forPagamento,@codcliV,@nomeclienteDep,@valpago,@troco,@desconto)";
                SqlConnection con = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(insert, con);

                cmd.Parameters.AddWithValue("@datavenda", data);
                cmd.Parameters.AddWithValue("@valTotal", valenv);
                cmd.Parameters.AddWithValue("@forPagamento", frmpg);
                cmd.Parameters.AddWithValue("@codcliV", codcli);
                cmd.Parameters.AddWithValue("@nomeclienteDep", nomecli);
                cmd.Parameters.AddWithValue("@valpago", valpag);
                cmd.Parameters.AddWithValue("@troco", troco);
                cmd.Parameters.AddWithValue("@desconto", desconto);


                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Venda realizada com sucesso!", "AVISO");
                    cupom();
                    limpar();


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
            else if(cbmfmpg.Text == "A PRAZO")

            {
                
                if (txtcli.Text.Length == 0)
                {
                    MessageBox.Show("Campo Cliente Não preenchido", "AVISO");
                }
                else
                {
                    SalvarDados();
                    DateTime dt = DateTime.Now;
                    dd = dt.ToString("dd/MM/yyy");
                    string data = dd;
                    decimal valenv = Convert.ToDecimal(txtvalortotal.Text);
                    codcli = int.Parse(codcc);
                    string frmpg = cbmfmpg.Text;
                    string nomecli = comboBox2.Text;
                    decimal valpag = Convert.ToDecimal(txtvalortotal.Text);
                    if (TextBox7.Text.Length == 0)
                    {
                        TextBox7.Text = "0";
                         troco = Convert.ToDecimal(TextBox7.Text);
                    }
                    else
                    {
                         troco = Convert.ToDecimal(TextBox7.Text);
                    }
                    if (textBox3.Text.Length == 0)
                    {
                        textBox3.Text = "0";
                        desconto = Convert.ToDecimal(textBox3.Text);
                    }
                    else { desconto = Convert.ToDecimal(textBox3.Text); }

                    string insert = "INSERT INTO Venda(datavenda ,valTotal,forPagamento,codcliV,nomeclienteDep,valpago,troco,desconto) VALUES (@datavenda,@valTotal,@forPagamento,@codcliV,@nomeclienteDep,@valpago,@troco,@desconto)";
                    SqlConnection con = conexao.obterConexao();
                    SqlCommand cmd = new SqlCommand(insert, con);

                    cmd.Parameters.AddWithValue("@datavenda", data);
                    cmd.Parameters.AddWithValue("@valTotal", valenv);
                    cmd.Parameters.AddWithValue("@forPagamento", frmpg);
                    cmd.Parameters.AddWithValue("@codcliV", codcli);
                    cmd.Parameters.AddWithValue("@nomeclienteDep", nomecli);
                    cmd.Parameters.AddWithValue("@valpago", valpag);
                    cmd.Parameters.AddWithValue("@troco", troco);
                    cmd.Parameters.AddWithValue("@desconto", desconto);

                    cmd.CommandType = CommandType.Text;
                    conexao.obterConexao();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Venda realizada com sucesso!", "AVISO");
                        cupom();
                        limpar();

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

        private void button1_Click(object sender, EventArgs e)
        {
            // this.label4.Text = this.datalistado.Rows.Count.ToString();
//
  //          Form2 novo = new Form2();
          //  novo.Show();
        }

          private void preencherCBDescricao(string cod)

        {
            
            SqlConnection conn = conexao.obterConexao();
            String scom = "Select c.nome_cli,c.codigo_cli,d.cod_dependentes,d.cod_clidp,d.nome from dependentes d,clientes c where d.cod_clidp=c.codigo_cli and c.nome_cli='" + cod + "' order by [nome] asc";
            conexao.obterConexao();
            SqlDataAdapter da = new SqlDataAdapter(scom, conn);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            comboBox2.DataSource = null;
            da.Fill(dtResultado);
            comboBox2.DataSource = dtResultado;
            comboBox2.ValueMember = "cod_dependentes";
            comboBox2.DisplayMember = "nome";
            comboBox2.SelectedItem = "";
            comboBox2.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string codclidepe = txtcli.Text;
            if (txtcli.Text.Length > 3) { preencherCBDescricao(codclidepe); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand(" Select [codigo_cli],[nome_cli] from[clientes] WHERE nome_cli='" + txtcli.Text + "'  order by [nome_cli] asc", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@nome_cli", "nome_cli"));
            commn.Parameters.Add(new SqlParameter("@codigo_cli", "codigo_cli"));

            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result == true)
            {
                while (dr.Read())
                {
                    nomedec = dr["nome_cli"].ToString();
                    codcc = dr["codigo_cli"].ToString();
                 
                }
                MessageBox.Show("Cliente encontrado!!","AVISO");

            }
            else
            {
                MessageBox.Show("nao encontrado", "AVISO");
            }

            dr.Close();
        }

       

        private void txtquant_TextChanged(object sender, EventArgs e)
        {
           if(txtquant.Text.Length!=0)
            {
                decimal vlu = Convert.ToDecimal(txtprecouni.Text), qtd = Convert.ToDecimal(txtquant.Text), res;
                string vlf;
                res = vlu * qtd;
                txttotal.Text = Convert.ToString(res);

            }
           else { txttotal.Text = "0,00"; }
        }











































    }
}
