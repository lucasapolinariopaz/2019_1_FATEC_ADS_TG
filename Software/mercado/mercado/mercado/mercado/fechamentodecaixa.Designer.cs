namespace mercado
{
    partial class fechamentodecaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fechamentodecaixa));
            this.label5 = new System.Windows.Forms.Label();
            this.lblvaloratual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfunc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtretirada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpretirar = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(192, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 29;
            // 
            // lblvaloratual
            // 
            this.lblvaloratual.AutoSize = true;
            this.lblvaloratual.BackColor = System.Drawing.SystemColors.Info;
            this.lblvaloratual.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvaloratual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvaloratual.Location = new System.Drawing.Point(217, 61);
            this.lblvaloratual.Name = "lblvaloratual";
            this.lblvaloratual.Size = new System.Drawing.Size(0, 18);
            this.lblvaloratual.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "VALOR ATUAL DE FECHAMENTO";
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.BackColor = System.Drawing.SystemColors.Info;
            this.lblfunc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfunc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblfunc.Location = new System.Drawing.Point(103, 37);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(0, 15);
            this.lblfunc.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "FUNCIONARIO";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.SystemColors.Info;
            this.lbldata.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldata.Location = new System.Drawing.Point(12, 10);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 15);
            this.lbldata.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "RETIRADA DO CAIXA";
            // 
            // txtretirada
            // 
            this.txtretirada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtretirada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtretirada.Location = new System.Drawing.Point(195, 81);
            this.txtretirada.Name = "txtretirada";
            this.txtretirada.Size = new System.Drawing.Size(148, 25);
            this.txtretirada.TabIndex = 31;
            this.txtretirada.Text = "0,00";
            this.txtretirada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtretirada_KeyPress);
            this.txtretirada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtretirada_KeyUp);
            this.txtretirada.Leave += new System.EventHandler(this.txtretirada_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "PESSOA QUE RETIROU";
            // 
            // txtpretirar
            // 
            this.txtpretirar.Location = new System.Drawing.Point(195, 106);
            this.txtpretirar.Name = "txtpretirar";
            this.txtpretirar.Size = new System.Drawing.Size(206, 20);
            this.txtpretirar.TabIndex = 33;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(72, 148);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 34;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnup
            // 
            this.btnup.Enabled = false;
            this.btnup.Location = new System.Drawing.Point(163, 148);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 35;
            this.btnup.Text = "ATUALIZAR";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(256, 148);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 36;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // fechamentodecaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(447, 221);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtpretirar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtretirada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblvaloratual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fechamentodecaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FECHAMENTO DE CAIXA";
            this.Load += new System.EventHandler(this.fechamentodecaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblvaloratual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtretirada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpretirar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnsair;
    }
}