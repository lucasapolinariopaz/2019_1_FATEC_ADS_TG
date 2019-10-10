namespace mercado
{
    partial class consultaracesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaracesso));
            this.txtcadcpfacesso = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsairacesso = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvaracesso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbacesso = new System.Windows.Forms.ComboBox();
            this.txtcadsenhaacesso = new System.Windows.Forms.TextBox();
            this.txtcadacesso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcadcpfacesso
            // 
            this.txtcadcpfacesso.Location = new System.Drawing.Point(113, 126);
            this.txtcadcpfacesso.Mask = "000.000.000-00";
            this.txtcadcpfacesso.Name = "txtcadcpfacesso";
            this.txtcadcpfacesso.Size = new System.Drawing.Size(85, 20);
            this.txtcadcpfacesso.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(268, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "*";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(204, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 28;
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(268, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            this.label6.Visible = false;
            // 
            // btnsairacesso
            // 
            this.btnsairacesso.Location = new System.Drawing.Point(331, 205);
            this.btnsairacesso.Name = "btnsairacesso";
            this.btnsairacesso.Size = new System.Drawing.Size(75, 23);
            this.btnsairacesso.TabIndex = 26;
            this.btnsairacesso.Text = "SAIR";
            this.btnsairacesso.UseVisualStyleBackColor = true;
            this.btnsairacesso.Click += new System.EventHandler(this.btnsairacesso_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(226, 205);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 25;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvaracesso
            // 
            this.btnsalvaracesso.Enabled = false;
            this.btnsalvaracesso.Location = new System.Drawing.Point(123, 205);
            this.btnsalvaracesso.Name = "btnsalvaracesso";
            this.btnsalvaracesso.Size = new System.Drawing.Size(75, 23);
            this.btnsalvaracesso.TabIndex = 24;
            this.btnsalvaracesso.Text = "SALVAR";
            this.btnsalvaracesso.UseVisualStyleBackColor = true;
            this.btnsalvaracesso.Click += new System.EventHandler(this.btnsalvaracesso_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "TIPO DE USUÁRIO";
            // 
            // cmbacesso
            // 
            this.cmbacesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbacesso.FormattingEnabled = true;
            this.cmbacesso.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "OPERADOR DE CAIXA"});
            this.cmbacesso.Location = new System.Drawing.Point(113, 73);
            this.cmbacesso.Name = "cmbacesso";
            this.cmbacesso.Size = new System.Drawing.Size(149, 21);
            this.cmbacesso.TabIndex = 22;
            // 
            // txtcadsenhaacesso
            // 
            this.txtcadsenhaacesso.Enabled = false;
            this.txtcadsenhaacesso.Location = new System.Drawing.Point(113, 152);
            this.txtcadsenhaacesso.Name = "txtcadsenhaacesso";
            this.txtcadsenhaacesso.Size = new System.Drawing.Size(149, 20);
            this.txtcadsenhaacesso.TabIndex = 21;
            // 
            // txtcadacesso
            // 
            this.txtcadacesso.Enabled = false;
            this.txtcadacesso.Location = new System.Drawing.Point(113, 101);
            this.txtcadacesso.Name = "txtcadacesso";
            this.txtcadacesso.Size = new System.Drawing.Size(227, 20);
            this.txtcadacesso.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(5, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "SENHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(5, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(5, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOME";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(56, 11);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBox1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "CPF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // consultaracesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(433, 245);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcadcpfacesso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultaracesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR ACESSO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtcadcpfacesso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsairacesso;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvaracesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbacesso;
        private System.Windows.Forms.TextBox txtcadsenhaacesso;
        private System.Windows.Forms.TextBox txtcadacesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}