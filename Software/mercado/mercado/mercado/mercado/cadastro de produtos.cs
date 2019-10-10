using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{
    public partial class cadastro_de_produtos : Form
    {
        public cadastro_de_produtos()
        {
            InitializeComponent();
        }

        private void cadastro_de_produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mercado_tgDataSet6.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.mercado_tgDataSet6.fornecedor);
            // TODO: This line of code loads data into the 'mercado_tgDataSet5.categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.mercado_tgDataSet5.categoria);
            // TODO: This line of code loads data into the 'mercado_tgDataSet4.categoria' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'mercado_tgDataSet3.marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.mercado_tgDataSet3.marcas);

        }
    }
}
