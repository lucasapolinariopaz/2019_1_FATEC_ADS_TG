using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{
    public partial class SalvarNotas : Form
    {
        string dd;
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        public SalvarNotas()
        {
            InitializeComponent();
        }





        protected void CarregaImagem()
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.picImagem.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            CarregaImagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {

            try
            {

                //Load the image from the file
          
                Image img = picImagem.Image;
              

                //Adjust the size of the image to the page to print the full image without loosing any part of it
                Rectangle m = e.MarginBounds;

                if ((double)img.Width / (double)img.Height > (double)m.Width / (double)m.Height) // image is wider
                {
                    m.Height = (int)((double)img.Height / (double)img.Width * (double)m.Width);
                }
                else
                {
                    m.Width = (int)((double)img.Width / (double)img.Height * (double)m.Height);
                }
                e.Graphics.DrawImage(img, m);

            }
            catch (Exception)
            {

            }



        }

        private void SalvarNotas_Load(object sender, EventArgs e)
        {
           
            DateTime dt = DateTime.Now;
            dd = dt.ToString("dd/MM/yyy");
           
            
        }
      /*  void getImagensSQLServer(SqlConnection conexaoSQLServer)
        {
            try
            {
                //Inicializar o SQL adapter.
                SqlDataAdapter ADAP = new SqlDataAdapter("Select Id,descricao,imagem from Imagens", conexaoSQLServer);

                //Inicializa o  Dataset.
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "Imagens");

                //preenche o datagridviewe com o dataset.
                gdvImagens.DataSource = DS.Tables["Imagens"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
*/


        public void dtvgexibir()
        { this.notasfiscaisTableAdapter1.Fill(this.mercado_tgDataSet13.notasfiscais); }


        private void btnSalvarImagemBD_Click(object sender, EventArgs e)
        {
            try
            { string sql = "INSERT INTO [notasfiscais](datanota,descricao,imagemnota) values(@datanota,@descricao,@imagem)";
                 
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@datanota", dd));
                cmd.Parameters.Add(new SqlParameter("@descricao", txtDescricaoImagem.Text));
                cmd.Parameters.Add(new SqlParameter("@imagem", vetorImagens));

                cmd.CommandType = CommandType.Text;
                conexao.obterConexao();
                int iresultado = cmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao incluir imagem no banco de dados.");
                dtvgexibir();
                picImagem.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.fecharConexao();
            }
        }

        private void btnRetornarImagemBD_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select imagemnota from notasfiscais where idnota=@ID";
                SqlConnection conn = conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int, 4);
                cmd.Parameters["@ID"].Value = this.txtCodigoImagem.Text;

                byte[] vetorImagem = (byte[])cmd.ExecuteScalar();
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagem, 0, vetorImagem.Length);
                fs.Flush();
                fs.Close();

                picImagem.Image = Image.FromFile(strNomeArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.fecharConexao();

            }
        }

        private void gdvImagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoImagem.Text = (gdvImagens.Rows[e.RowIndex].Cells["idnota"].Value).ToString();

        }

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            dtvgexibir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM notasfiscais WHERE idnota = @ID";
            SqlConnection conn = conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ID", SqlDbType.Int, 4);
            cmd.Parameters["@ID"].Value = this.txtCodigoImagem.Text;
           

            cmd.CommandType = CommandType.Text;
            conexao.obterConexao();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Imagem excluída com sucesso!");
                dtvgexibir();
                txtCodigoImagem.Clear();

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
