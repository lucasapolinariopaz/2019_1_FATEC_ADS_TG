namespace mercado
{
    partial class SalvarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalvarNotas));
            this.gdvImagens = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoImagem = new System.Windows.Forms.TextBox();
            this.txtCodigoImagem = new System.Windows.Forms.TextBox();
            this.btnRetornarImagemBD = new System.Windows.Forms.Button();
            this.btnSalvarImagemBD = new System.Windows.Forms.Button();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvImagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvImagens
            // 
            this.gdvImagens.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.gdvImagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvImagens.Location = new System.Drawing.Point(72, 321);
            this.gdvImagens.Margin = new System.Windows.Forms.Padding(2);
            this.gdvImagens.Name = "gdvImagens";
            this.gdvImagens.RowTemplate.Height = 24;
            this.gdvImagens.Size = new System.Drawing.Size(432, 131);
            this.gdvImagens.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(320, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descrição da Imagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(320, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código da Imagem";
            // 
            // txtDescricaoImagem
            // 
            this.txtDescricaoImagem.Location = new System.Drawing.Point(320, 133);
            this.txtDescricaoImagem.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoImagem.Multiline = true;
            this.txtDescricaoImagem.Name = "txtDescricaoImagem";
            this.txtDescricaoImagem.Size = new System.Drawing.Size(183, 122);
            this.txtDescricaoImagem.TabIndex = 17;
            // 
            // txtCodigoImagem
            // 
            this.txtCodigoImagem.Location = new System.Drawing.Point(320, 89);
            this.txtCodigoImagem.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoImagem.Name = "txtCodigoImagem";
            this.txtCodigoImagem.Size = new System.Drawing.Size(182, 20);
            this.txtCodigoImagem.TabIndex = 16;
            // 
            // btnRetornarImagemBD
            // 
            this.btnRetornarImagemBD.Location = new System.Drawing.Point(316, 25);
            this.btnRetornarImagemBD.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetornarImagemBD.Name = "btnRetornarImagemBD";
            this.btnRetornarImagemBD.Size = new System.Drawing.Size(188, 31);
            this.btnRetornarImagemBD.TabIndex = 15;
            this.btnRetornarImagemBD.Text = "Obter Imagem do Banco de dados";
            this.btnRetornarImagemBD.UseVisualStyleBackColor = true;
            // 
            // btnSalvarImagemBD
            // 
            this.btnSalvarImagemBD.Location = new System.Drawing.Point(320, 273);
            this.btnSalvarImagemBD.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarImagemBD.Name = "btnSalvarImagemBD";
            this.btnSalvarImagemBD.Size = new System.Drawing.Size(188, 31);
            this.btnSalvarImagemBD.TabIndex = 14;
            this.btnSalvarImagemBD.Text = "Salvar Imagem no Banco de dados";
            this.btnSalvarImagemBD.UseVisualStyleBackColor = true;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(72, 273);
            this.btnCarregarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(237, 31);
            this.btnCarregarImagem.TabIndex = 13;
            this.btnCarregarImagem.Text = "Carregar Imagem ";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picImagem.Location = new System.Drawing.Point(72, 25);
            this.picImagem.Margin = new System.Windows.Forms.Padding(2);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(236, 243);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 12;
            this.picImagem.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(72, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Deletar Imagem ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(316, 456);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 31);
            this.button2.TabIndex = 22;
            this.button2.Text = "Imprimir Imagem ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SalvarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(612, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gdvImagens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoImagem);
            this.Controls.Add(this.txtCodigoImagem);
            this.Controls.Add(this.btnRetornarImagemBD);
            this.Controls.Add(this.btnSalvarImagemBD);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.picImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SalvarNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salvar Notas";
            ((System.ComponentModel.ISupportInitialize)(this.gdvImagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvImagens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoImagem;
        private System.Windows.Forms.TextBox txtCodigoImagem;
        private System.Windows.Forms.Button btnRetornarImagemBD;
        private System.Windows.Forms.Button btnSalvarImagemBD;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}