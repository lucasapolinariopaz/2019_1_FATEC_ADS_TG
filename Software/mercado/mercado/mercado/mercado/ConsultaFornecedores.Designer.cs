namespace mercado
{
    partial class ConsultaFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFornecedores));
            this.masktxt_PesquisarCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_UF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_RazaoSocial = new System.Windows.Forms.TextBox();
            this.masktxt_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_PesquisarCNPJ = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_ViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masktxt_PesquisarCNPJ
            // 
            this.masktxt_PesquisarCNPJ.Location = new System.Drawing.Point(60, 18);
            this.masktxt_PesquisarCNPJ.Mask = "00.000.000/0000-00";
            this.masktxt_PesquisarCNPJ.Name = "masktxt_PesquisarCNPJ";
            this.masktxt_PesquisarCNPJ.Size = new System.Drawing.Size(135, 20);
            this.masktxt_PesquisarCNPJ.TabIndex = 50;
            // 
            // btn_Sair
            // 
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sair.Location = new System.Drawing.Point(464, 189);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 49;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancelar.Location = new System.Drawing.Point(361, 189);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(86, 23);
            this.btn_Cancelar.TabIndex = 48;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Salvar.Location = new System.Drawing.Point(271, 189);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 47;
            this.btn_Salvar.Text = "SALVAR";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(345, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "CELULAR";
            // 
            // txt_Celular
            // 
            this.txt_Celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Celular.Location = new System.Drawing.Point(408, 132);
            this.txt_Celular.MaxLength = 15;
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(125, 20);
            this.txt_Celular.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(95, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "TELEFONE";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Telefone.Location = new System.Drawing.Point(163, 129);
            this.txt_Telefone.MaxLength = 15;
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(125, 20);
            this.txt_Telefone.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(7, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "UF";
            // 
            // txt_UF
            // 
            this.txt_UF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_UF.Location = new System.Drawing.Point(35, 134);
            this.txt_UF.MaxLength = 2;
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(28, 20);
            this.txt_UF.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(540, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "BAIRRO";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Bairro.Location = new System.Drawing.Point(596, 105);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(125, 20);
            this.txt_Bairro.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(354, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "CIDADE";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Cidade.Location = new System.Drawing.Point(409, 105);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(125, 20);
            this.txt_Cidade.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(5, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "ENDEREÇO";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Endereco.Location = new System.Drawing.Point(100, 101);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(248, 20);
            this.txt_Endereco.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(563, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "IE";
            // 
            // txt_IE
            // 
            this.txt_IE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_IE.Location = new System.Drawing.Point(596, 74);
            this.txt_IE.Name = "txt_IE";
            this.txt_IE.Size = new System.Drawing.Size(125, 20);
            this.txt_IE.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(5, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "RAZÃO SOCIAL";
            // 
            // txt_RazaoSocial
            // 
            this.txt_RazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_RazaoSocial.Location = new System.Drawing.Point(100, 74);
            this.txt_RazaoSocial.Name = "txt_RazaoSocial";
            this.txt_RazaoSocial.Size = new System.Drawing.Size(248, 20);
            this.txt_RazaoSocial.TabIndex = 30;
            // 
            // masktxt_CNPJ
            // 
            this.masktxt_CNPJ.Location = new System.Drawing.Point(409, 73);
            this.masktxt_CNPJ.Mask = "00.000.000/0000-00";
            this.masktxt_CNPJ.Name = "masktxt_CNPJ";
            this.masktxt_CNPJ.Size = new System.Drawing.Size(135, 20);
            this.masktxt_CNPJ.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(354, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "CNPJ";
            // 
            // btn_PesquisarCNPJ
            // 
            this.btn_PesquisarCNPJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_PesquisarCNPJ.Location = new System.Drawing.Point(215, 18);
            this.btn_PesquisarCNPJ.Name = "btn_PesquisarCNPJ";
            this.btn_PesquisarCNPJ.Size = new System.Drawing.Size(84, 23);
            this.btn_PesquisarCNPJ.TabIndex = 53;
            this.btn_PesquisarCNPJ.Text = "PESQUISAR";
            this.btn_PesquisarCNPJ.UseVisualStyleBackColor = true;
            this.btn_PesquisarCNPJ.Click += new System.EventHandler(this.btn_PesquisarCNPJ_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Excluir.Location = new System.Drawing.Point(176, 189);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 54;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ViewAll.Location = new System.Drawing.Point(596, 16);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Size = new System.Drawing.Size(123, 23);
            this.btn_ViewAll.TabIndex = 55;
            this.btn_ViewAll.Text = "VISUALIZAR TODOS";
            this.btn_ViewAll.UseVisualStyleBackColor = true;
            this.btn_ViewAll.Visible = false;
            this.btn_ViewAll.Click += new System.EventHandler(this.btn_ViewAll_Click);
            // 
            // ConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(731, 239);
            this.Controls.Add(this.btn_ViewAll);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_PesquisarCNPJ);
            this.Controls.Add(this.masktxt_CNPJ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.masktxt_PesquisarCNPJ);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_UF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_RazaoSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA FORNECEDORES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox masktxt_PesquisarCNPJ;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Celular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_UF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_RazaoSocial;
        private System.Windows.Forms.MaskedTextBox masktxt_CNPJ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_PesquisarCNPJ;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_ViewAll;
    }
}