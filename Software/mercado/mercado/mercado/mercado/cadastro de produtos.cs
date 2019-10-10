using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mercado
{
    public partial class cadastro_de_produtos : Form
    {
        string dd;
        string valor="0";
        int codf;
        string Tcodf;
        int cod;
        int codv;
        public cadastro_de_produtos()
        {
            InitializeComponent();
            
        }

        bool Verificacodbarras(string cp)
        {

            bool result = false;

            using (SqlConnection cn = conexao.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select codigo_barra from estoque where codigo_barra='" + cp + "';", cn);
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
        private void cadastro_de_produtos_Load(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;
             dd = dt.ToString("dd/MM/yyy");
            lbldata.Text = dd;
            txtporcen.Text = "0";
            // 
            // TODO: This line of code loads data into the 'mercado_tgDataSet8.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter1.FillBy(this.mercado_tgDataSet8.fornecedor);
            // TODO: This line of code loads data into the 'mercado_tgDataSet5.categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.FillBy1(this.mercado_tgDataSet5.categoria);
            // TODO: This line of code loads data into the 'mercado_tgDataSet4.categoria' table. You can move, or remove it, as needed.
            this.marcasTableAdapter1.FillBy2(this.mercado_tgDataSet7.marcas);
            // TODO: This line of code loads data into the 'mercado_tgDataSet3.marcas' table. You can move, or remove it, as needed.


        }

        private void btnaddmarca_Click(object sender, EventArgs e)
        {
            cadastromarcas novo = new cadastromarcas();
            novo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.marcasTableAdapter1.FillBy2(this.mercado_tgDataSet7.marcas);

        }

        private void txtunidades_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand comm = new SqlCommand("select estoque_atualprod,descricao_prod from estoque where   descricao_prod='" + txtcaddescprod.Text + "';", conn);
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new SqlParameter("@estoque_atualprod", "estoque_atualprod"));



            conexao.obterConexao();
            SqlDataReader drr = comm.ExecuteReader();
            while (drr.Read())
            {
                txtunidadesatual.Text = drr["estoque_atualprod"].ToString();
                

            }
            conexao.fecharConexao();
           
            
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

        private void txtporcen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtporcen.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtpdvenda.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtpdvenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtpdvenda.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
          
            txtporcen.Text = "0";
        }

        private void txtporcen_TextChanged(object sender, EventArgs e)
        {
            string test = valor.Replace("R$", "");


            //MessageBox.Show(valor);
            double valoruni = double.Parse(valor);
            double valorunporc = double.Parse(txtporcen.Text);
            double resultvalorvenda;
            resultvalorvenda = valoruni + ((valoruni * valorunporc) / 100);
            txtpdvenda.Text = resultvalorvenda.ToString();
        }

        private void txtcaddescprod_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = true;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
           
            string codbarrasV = maskedTextBox1.Text;
                bool Logado = false;
                bool result = Verificacodbarras(codbarrasV);

                Logado = result;

                if (result)
                {
                cbnmarcas.Enabled = false;
                cbnfornecedor.Enabled = false;
                cbncateg.Enabled = false;
                if (MessageBox.Show("Codigo de Barras ja cadastrado!! Deseja Atualizar", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    //  MessageBox.Show(" ok clicado");
                    CONSULTAPRODUTOS novo = new CONSULTAPRODUTOS(maskedTextBox1.Text);
                    novo.Show();

                }
            }
                else {  cbnmarcas.Enabled = true;
                cbnfornecedor.Enabled = true;
                cbncateg.Enabled = true;
            } 

            
                
            }

        

        private void cbnmarcas_TextChanged(object sender, EventArgs e)
        {
            cbncateg.Enabled = true;
        }

        private void cbncateg_TextChanged(object sender, EventArgs e)
        {
            cbnfornecedor.Enabled = true;
        }

      

        private void btnsalvar_Click(object sender, EventArgs e)

        {
           
            //codf = Convert.ToInt32(Tcodf);
            codf = int.Parse(Tcodf);
            string pccaracter = textBox1.Text;
            pccaracter = pccaracter.Replace("R$", "");
            decimal pc = Convert.ToDecimal(pccaracter);
            decimal pv = Convert.ToDecimal(txtpdvenda.Text);
            decimal un = Convert.ToDecimal(txtunidades.Text);
            decimal unat = Convert.ToDecimal(txtunidadesatual.Text);
            string sql = "INSERT INTO produtoentrada (codigo_barra,descricao_prod ,categoria_prod,marca_prod,preco_custo ,preco_venda,estoque_atualprod ,validade_prod ,codprod_fornec ,unidades,data_entrada)  VALUES (@codigo_barra, @descricao_prod, @categoria_prod, @marca_prod, @preco_custo, @preco_venda, @estoque_atualprod, @validade_prod, @codprod_fornec, @unidades, @data_entrada)";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@codigo_barra", maskedTextBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@descricao_prod", txtcaddescprod.Text));
            cmd.Parameters.Add(new SqlParameter("@categoria_prod", cbncateg.Text));
            cmd.Parameters.Add(new SqlParameter("@marca_prod", cbnmarcas.Text));
            cmd.Parameters.Add(new SqlParameter("@preco_custo", pc));
            cmd.Parameters.Add(new SqlParameter("@preco_venda", pv));
            cmd.Parameters.Add(new SqlParameter("@estoque_atualprod", unat));
            cmd.Parameters.Add(new SqlParameter("@validade_prod", maskedTextBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@codprod_fornec", codf));
            cmd.Parameters.Add(new SqlParameter("@unidades", un));
            cmd.Parameters.Add(new SqlParameter("@data_entrada", lbldata.Text));
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

        private void cbnfornecedor_Click(object sender, EventArgs e)
        {
            txtunidades.Enabled = true;
            txtunidadesatual.Enabled = false;
            maskedTextBox4.Enabled = true;
            textBox1.Enabled = true;
            txtporcen.Enabled = true;
            txtpdvenda.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcaddescprod.Clear();
            txtunidades.Clear();
            txtunidadesatual.Clear();
            maskedTextBox4.Clear();
            maskedTextBox1.Clear();
            textBox1.Clear();
            txtporcen.Text="0";
            txtpdvenda.Clear();
            cbncateg.SelectedIndex = -1;
            cbnfornecedor.SelectedIndex = -1;
            cbnmarcas.SelectedIndex = -1;


        }

      

        private void cbnmarcas_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select cod_fornecdor,nome_fornecedor from fornecedor where   nome_fornecedor='" + cbnfornecedor.Text + "';", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@cod_fornecdor", "cod_fornecdor"));



            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            while (dr.Read())
            {
                Tcodf = dr["cod_fornecdor"].ToString();


            }
            conexao.fecharConexao();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastrodefornecedor novo = new cadastrodefornecedor();
            novo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cadastrodecategoria novo = new cadastrodecategoria();
            novo.Show();
        }

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            this.fornecedorTableAdapter1.FillBy(this.mercado_tgDataSet8.fornecedor);
        }

        private void btnatucateg_Click(object sender, EventArgs e)
        {
            this.categoriaTableAdapter.FillBy1(this.mercado_tgDataSet5.categoria);
        }

      
    }
}
