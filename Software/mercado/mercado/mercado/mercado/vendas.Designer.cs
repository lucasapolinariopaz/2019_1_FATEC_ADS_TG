namespace mercado
{
    partial class vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendas));
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pagamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_data = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_txtTotal = new System.Windows.Forms.Label();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(275, 59);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(148, 23);
            this.btn_Consultar.TabIndex = 22;
            this.btn_Consultar.Text = "CONSULTAR";
            this.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
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
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(130, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(425, 227);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CÓDIGO DA VENDA";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DATA DA VENDA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "VALOR TOTAL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "FORMA DE PAGAMENTO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(261, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "FORMA DE PAGAMENTO";
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.FormattingEnabled = true;
            this.cb_pagamento.Items.AddRange(new object[] {
            "DINHEIRO",
            "CARTÃO",
            "A PRAZO"});
            this.cb_pagamento.Location = new System.Drawing.Point(422, 12);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(152, 21);
            this.cb_pagamento.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(51, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "DATA";
            // 
            // cb_data
            // 
            this.cb_data.FormattingEnabled = true;
            this.cb_data.Location = new System.Drawing.Point(93, 12);
            this.cb_data.Name = "cb_data";
            this.cb_data.Size = new System.Drawing.Size(152, 21);
            this.cb_data.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "FECHAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_txtTotal
            // 
            this.lbl_txtTotal.AutoSize = true;
            this.lbl_txtTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txtTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_txtTotal.Location = new System.Drawing.Point(311, 342);
            this.lbl_txtTotal.Name = "lbl_txtTotal";
            this.lbl_txtTotal.Size = new System.Drawing.Size(44, 15);
            this.lbl_txtTotal.TabIndex = 18;
            this.lbl_txtTotal.Text = "TOTAL";
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.AutoSize = true;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_ValorTotal.Location = new System.Drawing.Point(361, 342);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(0, 15);
            this.lbl_ValorTotal.TabIndex = 18;
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(651, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_ValorTotal);
            this.Controls.Add(this.lbl_txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIAR VENDAS";
            this.Load += new System.EventHandler(this.carregarCombobox);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_txtTotal;
        private System.Windows.Forms.Label lbl_ValorTotal;
    }
}