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
    public partial class CONSULTAPRODUTOS : Form
    {
        bool result = false;
        string codEst,porc="0",codPen, Tcodf, valor="0", valor2="0";
        int codestoque,codforn,codentrada;
        public CONSULTAPRODUTOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand commn = new SqlCommand("select e.codigo_prod,e.codigo_barra, e.descricao_prod , e.categoria_prod , e.marca_prod, e.preco_custo , e.preco_venda , e.estoque_atualprod, e.validade_prod ,e.codprod_fornec, e.data_entrada , e.codprodentrada,f.nome_fornecedor from estoque e,fornecedor f where   codigo_barra='" + txtpesqprod.Text + "' and f.cod_fornecdor=e.codprod_fornec;", conn);
            commn.CommandType = CommandType.Text;
            commn.Parameters.Add(new SqlParameter("@codigo_prod", "codigo_prod"));
            commn.Parameters.Add(new SqlParameter("@codigo_barra", "codigo_barra"));
            commn.Parameters.Add(new SqlParameter("@descricao_prod", "descricao_prod"));
            commn.Parameters.Add(new SqlParameter("@categoria_prod", "categoria_prod"));
            commn.Parameters.Add(new SqlParameter("@marca_prod", "marca_prod"));
            commn.Parameters.Add(new SqlParameter("@preco_custo", "preco_custo"));
            commn.Parameters.Add(new SqlParameter("@preco_venda", "preco_venda"));
            commn.Parameters.Add(new SqlParameter("@estoque_atualprod", "estoque_atualprod"));
            commn.Parameters.Add(new SqlParameter("@validade_prod", "validade_prod"));
            commn.Parameters.Add(new SqlParameter("@codprod_fornec", "codprod_fornec"));
            commn.Parameters.Add(new SqlParameter("@nome_fornecedor", "nome_fornecedor"));
            commn.Parameters.Add(new SqlParameter("@codprodentrada", "codprodentrada"));
            commn.Parameters.Add(new SqlParameter("@data_entrada", "data_entrada"));
            conexao.obterConexao();
            SqlDataReader dr = commn.ExecuteReader();
            result = dr.HasRows;
            if (result==true)
            {
                while (dr.Read())
                {
                    //codEst= dr["codigo_prod"].ToString();
                    codestoque = int.Parse(dr["codigo_prod"].ToString());
                    // codF = dr["codprod_fornec"].ToString();
                    codforn = int.Parse(dr["codprod_fornec"].ToString());
                    Tcodf = codforn.ToString();
                    codPen = dr["codprodentrada"].ToString();
                    txtcaddescprod.Text = dr["descricao_prod"].ToString();
                    maskedTextBox1.Text = dr["codigo_barra"].ToString();
                    cbncateg.Text = dr["categoria_prod"].ToString();
                    cbnfornecedor.Text = dr["nome_fornecedor"].ToString();
                    cbnmarcas.Text = dr["marca_prod"].ToString();
                    txtpdvenda.Text = dr["preco_venda"].ToString();
                    txt_valorUni.Text = dr["preco_custo"].ToString();
                    txtunidadesatual.Text = dr["estoque_atualprod"].ToString();
                    maskedTextBox4.Text = dr["validade_prod"].ToString();
                    lbldata.Text = dr["data_entrada"].ToString();
                    valor = txt_valorUni.Text;


                }
                Decimal val, val1;
                    if (Decimal.TryParse(txt_valorUni.Text, out val))
                        txt_valorUni.Text = val.ToString("C");
                   if (Decimal.TryParse(txtpdvenda.Text, out val1))
                    txtpdvenda.Text = val1.ToString("C");
            }
            else
            {
                MessageBox.Show("Produto não encontrado!!");
            }
            
            conexao.fecharConexao();
            
        }

      

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            this.fornecedorTableAdapter.FillBy(this.mercado_tgDataSet9.fornecedor);

        }

        private void btnatucateg_Click(object sender, EventArgs e)
        {
            this.categoriaTableAdapter.FillBy(this.mercado_tgDataSet10.categoria);
        }

        private void btnatumarcas_Click(object sender, EventArgs e)
        {
            this.marcasTableAdapter.FillBy(this.mercado_tgDataSet11.marcas);
        }

        private void txt_valorUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt_valorUni.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txt_valorUni_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txt_valorUni.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txt_valorUni.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txt_valorUni.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txt_valorUni.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt_valorUni.Text.StartsWith("0,"))
                {
                    txt_valorUni.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt_valorUni.Text.Contains("00,"))
                {
                    txt_valorUni.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt_valorUni.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txt_valorUni.Text;
            txt_valorUni.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txt_valorUni.Select(txt_valorUni.Text.Length, 0);
        }

        private void txtporcen_TextChanged(object sender, EventArgs e)
        {
            porc=txtporcen.Text;
            if (txtporcen.TextLength == 0) { txtporcen.Text = "0"; }
             
            string test = valor.Replace("R$", "");

            decimal val, val1;
            //MessageBox.Show(valor);
            double valoruni = double.Parse(valor);
            double valorunporc = double.Parse(porc);
            double resultvalorvenda;
            resultvalorvenda = valoruni + ((valoruni * valorunporc) / 100); 
            txtpdvenda.Text = resultvalorvenda.ToString();
            
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
        }

        private void txtpdvenda_KeyUp(object sender, KeyEventArgs e)
        {
            valor2 = txtpdvenda.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor2.Length == 0)
            {
                txtpdvenda.Text = "0,00" + valor2;
            }
            if (valor2.Length == 1)
            {
                txtpdvenda.Text = "0,0" + valor2;
            }
            if (valor2.Length == 2)
            {
                txtpdvenda.Text = "0," + valor2;
            }
            else if (valor2.Length >= 3)
            {
                if (txtpdvenda.Text.StartsWith("0,"))
                {
                    txtpdvenda.Text = valor2.Insert(valor2.Length - 2, ",").Replace("0,", "");
                }
                else if (txtpdvenda.Text.Contains("00,"))
                {
                    txtpdvenda.Text = valor2.Insert(valor2.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtpdvenda.Text = valor2.Insert(valor2.Length - 2, ",");
                }
            }
            valor2 = txtpdvenda.Text;
            txtpdvenda.Text = string.Format("{0:C}", Convert.ToDouble(valor2));
            txtpdvenda.Select(txtpdvenda.Text.Length, 0);
        }

        private void txtpdvenda_Leave(object sender, EventArgs e)
        {
            valor2 = txtpdvenda.Text.Replace("R$", "");
            txtpdvenda.Text = string.Format("{0:C}", Convert.ToDouble(valor2));
        }

        private void txt_valorUni_Leave(object sender, EventArgs e)
        {
            valor = txt_valorUni.Text.Replace("R$", "");
            txt_valorUni.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void cbnfornecedor_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnaddmarca_Click(object sender, EventArgs e)
        {
            cadastromarcas novo = new cadastromarcas();
            novo.Show();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            string pccaracter = txt_valorUni.Text;
            pccaracter = pccaracter.Replace("R$", "");
            string precovd = txtpdvenda.Text;
            precovd = precovd.Replace("R$", "");
            decimal pc = Convert.ToDecimal(pccaracter);
            decimal pv = Convert.ToDecimal(precovd);
           // decimal un = Convert.ToDecimal(txtunidades.Text);
            decimal unat = Convert.ToDecimal(txtunidadesatual.Text);
            int cdf = Convert.ToInt32(Tcodf);

            string sql = "UPDATE estoque SET codigo_barra=@codigo_barra, descricao_prod=@descricao_prod , categoria_prod=@categoria_prod , marca_prod=@marca_prod, preco_custo=@preco_custo , preco_venda=@preco_venda , estoque_atualprod=@estoque_atualprod, validade_prod=@validade_prod ,codprod_fornec =@codprod_fornec WHERE codigo_prod = @codigo_prod";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(new SqlParameter("@codigo_prod", (codestoque)));
            comm.Parameters.Add(new SqlParameter("@codigo_barra", maskedTextBox1.Text));
            comm.Parameters.Add(new SqlParameter("@descricao_prod", txtcaddescprod.Text));
            comm.Parameters.Add(new SqlParameter("@categoria_prod", cbncateg.Text));
            comm.Parameters.Add(new SqlParameter("@marca_prod", cbnmarcas.Text));
            comm.Parameters.Add(new SqlParameter("@preco_custo", pc));
            comm.Parameters.Add(new SqlParameter("@preco_venda", pv));
            comm.Parameters.Add(new SqlParameter("@estoque_atualprod", unat));
            comm.Parameters.Add(new SqlParameter("@validade_prod", maskedTextBox4.Text));
            comm.Parameters.Add(new SqlParameter("@codprod_fornec", (cdf)));
               

            comm.CommandType = CommandType.Text;
            conexao.obterConexao();
            try
            {
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro atualizado com sucesso!");
                txtcaddescprod.Clear();
                txtunidadesatual.Clear();
                maskedTextBox4.Clear();
                maskedTextBox1.Clear();
                txt_valorUni.Clear();
                txtporcen.Text = "0";
                txtpdvenda.Clear();
                this.categoriaTableAdapter.FillBy(this.mercado_tgDataSet10.categoria);
                this.fornecedorTableAdapter.FillBy(this.mercado_tgDataSet9.fornecedor);
                this.marcasTableAdapter.FillBy(this.mercado_tgDataSet11.marcas);
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
