namespace mercado
{
    partial class ConsultarDependentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarDependentes));
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.masktxt_PesquisarCPF = new System.Windows.Forms.MaskedTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(237, 7);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(78, 23);
            this.btn_Pesquisar.TabIndex = 168;
            this.btn_Pesquisar.Text = "PESQUISAR";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(1, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 166;
            this.label11.Text = "CPF DO CLIENTE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(5, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 150);
            this.dataGridView1.TabIndex = 169;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Location = new System.Drawing.Point(51, 205);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 170;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Enabled = false;
            this.btn_Alterar.Location = new System.Drawing.Point(156, 206);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 171;
            this.btn_Alterar.Text = "ALTERAR";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(359, 205);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 172;
            this.btn_Fechar.Text = "FECHAR";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // masktxt_PesquisarCPF
            // 
            this.masktxt_PesquisarCPF.Location = new System.Drawing.Point(146, 9);
            this.masktxt_PesquisarCPF.Mask = "000.000.000-00";
            this.masktxt_PesquisarCPF.Name = "masktxt_PesquisarCPF";
            this.masktxt_PesquisarCPF.Size = new System.Drawing.Size(85, 20);
            this.masktxt_PesquisarCPF.TabIndex = 176;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOME DO DEPENDENTE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "GRAU DE PARENTESCO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NOME DO CLIENTE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(259, 205);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 177;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // ConsultarDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(515, 241);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.masktxt_PesquisarCPF);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarDependentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR DEPENDENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pesquisar;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.MaskedTextBox masktxt_PesquisarCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_Limpar;
    }
}