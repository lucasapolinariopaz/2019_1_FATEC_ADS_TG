namespace mercado
{
    partial class cadastroAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroAcesso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcadacesso = new System.Windows.Forms.TextBox();
            this.txtcadsenhaacesso = new System.Windows.Forms.TextBox();
            this.cmbacesso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsalvaracesso = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsairacesso = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcadcpfacesso = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SENHA";
            // 
            // txtcadacesso
            // 
            this.txtcadacesso.Enabled = false;
            this.txtcadacesso.Location = new System.Drawing.Point(120, 49);
            this.txtcadacesso.Name = "txtcadacesso";
            this.txtcadacesso.Size = new System.Drawing.Size(227, 20);
            this.txtcadacesso.TabIndex = 3;
            this.txtcadacesso.Click += new System.EventHandler(this.txtcadacesso_Click);
            // 
            // txtcadsenhaacesso
            // 
            this.txtcadsenhaacesso.Enabled = false;
            this.txtcadsenhaacesso.Location = new System.Drawing.Point(120, 100);
            this.txtcadsenhaacesso.Name = "txtcadsenhaacesso";
            this.txtcadsenhaacesso.Size = new System.Drawing.Size(149, 20);
            this.txtcadsenhaacesso.TabIndex = 5;
            this.txtcadsenhaacesso.Click += new System.EventHandler(this.txtcadsenhaacesso_Click);
            // 
            // cmbacesso
            // 
            this.cmbacesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbacesso.FormattingEnabled = true;
            this.cmbacesso.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "OPERADOR DE CAIXA"});
            this.cmbacesso.Location = new System.Drawing.Point(120, 21);
            this.cmbacesso.Name = "cmbacesso";
            this.cmbacesso.Size = new System.Drawing.Size(149, 21);
            this.cmbacesso.TabIndex = 6;
            this.cmbacesso.SelectedIndexChanged += new System.EventHandler(this.cmbacesso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "TIPO DE USUÁRIO";
            // 
            // btnsalvaracesso
            // 
            this.btnsalvaracesso.Enabled = false;
            this.btnsalvaracesso.Location = new System.Drawing.Point(46, 154);
            this.btnsalvaracesso.Name = "btnsalvaracesso";
            this.btnsalvaracesso.Size = new System.Drawing.Size(75, 23);
            this.btnsalvaracesso.TabIndex = 8;
            this.btnsalvaracesso.Text = "SALVAR";
            this.btnsalvaracesso.UseVisualStyleBackColor = true;
            this.btnsalvaracesso.Click += new System.EventHandler(this.btnsalvaracesso_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(149, 154);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsairacesso
            // 
            this.btnsairacesso.Location = new System.Drawing.Point(254, 154);
            this.btnsairacesso.Name = "btnsairacesso";
            this.btnsairacesso.Size = new System.Drawing.Size(75, 23);
            this.btnsairacesso.TabIndex = 10;
            this.btnsairacesso.Text = "SAIR";
            this.btnsairacesso.UseVisualStyleBackColor = true;
            this.btnsairacesso.Click += new System.EventHandler(this.btnsairacesso_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(275, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(353, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(211, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 14;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(275, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "*";
            this.label9.Visible = false;
            // 
            // txtcadcpfacesso
            // 
            this.txtcadcpfacesso.Location = new System.Drawing.Point(120, 74);
            this.txtcadcpfacesso.Mask = "000.000.000-00";
            this.txtcadcpfacesso.Name = "txtcadcpfacesso";
            this.txtcadcpfacesso.Size = new System.Drawing.Size(85, 20);
            this.txtcadcpfacesso.TabIndex = 16;
            this.txtcadcpfacesso.TextChanged += new System.EventHandler(this.txtcadcpfacesso_TextChanged);
            // 
            // cadastroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(392, 199);
            this.Controls.Add(this.txtcadcpfacesso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsairacesso);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvaracesso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbacesso);
            this.Controls.Add(this.txtcadsenhaacesso);
            this.Controls.Add(this.txtcadacesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastroAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE ACESSO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcadacesso;
        private System.Windows.Forms.TextBox txtcadsenhaacesso;
        private System.Windows.Forms.ComboBox cmbacesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsalvaracesso;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsairacesso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcadcpfacesso;
    }
}