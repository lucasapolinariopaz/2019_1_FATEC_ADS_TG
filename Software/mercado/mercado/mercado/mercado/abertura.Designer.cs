namespace mercado
{
    partial class abertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abertura));
            this.lbldata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfunc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsalv = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.btnfec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblvaloratual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.SystemColors.Info;
            this.lbldata.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldata.Location = new System.Drawing.Point(2, 9);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 15);
            this.lbldata.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(2, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "FUNCIONARIO";
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.BackColor = System.Drawing.SystemColors.Info;
            this.lblfunc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfunc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblfunc.Location = new System.Drawing.Point(93, 36);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(0, 15);
            this.lblfunc.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(2, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "DIGITE VALOR DE INICIO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(165, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnsalv
            // 
            this.btnsalv.Location = new System.Drawing.Point(43, 161);
            this.btnsalv.Name = "btnsalv";
            this.btnsalv.Size = new System.Drawing.Size(75, 23);
            this.btnsalv.TabIndex = 16;
            this.btnsalv.Text = "SALVAR";
            this.btnsalv.UseVisualStyleBackColor = true;
            this.btnsalv.Click += new System.EventHandler(this.btnsalv_Click);
            // 
            // btncanc
            // 
            this.btncanc.Location = new System.Drawing.Point(138, 161);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(75, 23);
            this.btncanc.TabIndex = 17;
            this.btncanc.Text = "CANCELAR";
            this.btncanc.UseVisualStyleBackColor = true;
            this.btncanc.Click += new System.EventHandler(this.btncanc_Click);
            // 
            // btnfec
            // 
            this.btnfec.Location = new System.Drawing.Point(230, 161);
            this.btnfec.Name = "btnfec";
            this.btnfec.Size = new System.Drawing.Size(75, 23);
            this.btnfec.TabIndex = 18;
            this.btnfec.Text = "FECHAR";
            this.btnfec.UseVisualStyleBackColor = true;
            this.btnfec.Click += new System.EventHandler(this.btnfec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(2, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "VALOR ATUAL DE ABERTURA";
            // 
            // lblvaloratual
            // 
            this.lblvaloratual.AutoSize = true;
            this.lblvaloratual.BackColor = System.Drawing.SystemColors.Info;
            this.lblvaloratual.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvaloratual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvaloratual.Location = new System.Drawing.Point(177, 105);
            this.lblvaloratual.Name = "lblvaloratual";
            this.lblvaloratual.Size = new System.Drawing.Size(0, 18);
            this.lblvaloratual.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(182, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 21;
            // 
            // abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(361, 216);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblvaloratual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfec);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.btnsalv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblfunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABERTURA DE CAIXA";
            this.Load += new System.EventHandler(this.abertura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsalv;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Button btnfec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvaloratual;
        private System.Windows.Forms.Label label5;
    }
}