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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        void limparCampos()
        {
            masktxt_PesquisarCPF.Clear();
            txt_NomeCliente.Clear();
            txt_RG.Clear();
            masktxt_CPF.Clear();
            masktxt_dataNasc.Clear();
            txt_Endereco.Clear();
            txt_Cidade.Clear();
            txt_Bairro.Clear();
            txt_Numero.Clear();
            txt_Telefone.Clear();
            txt_Celular.Clear();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
