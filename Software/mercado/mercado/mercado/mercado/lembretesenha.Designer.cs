namespace mercado
{
    partial class lembretesenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lembretesenha));
            this.btnatualizarrecup = new System.Windows.Forms.Button();
            this.txtcpfrecup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscarrecup = new System.Windows.Forms.Button();
            this.txtrecuperar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnatualizarrecup
            // 
            this.btnatualizarrecup.Location = new System.Drawing.Point(115, 102);
            this.btnatualizarrecup.Name = "btnatualizarrecup";
            this.btnatualizarrecup.Size = new System.Drawing.Size(75, 23);
            this.btnatualizarrecup.TabIndex = 0;
            this.btnatualizarrecup.Text = "ATUALIZAR";
            this.btnatualizarrecup.UseVisualStyleBackColor = true;
            this.btnatualizarrecup.Visible = false;
            this.btnatualizarrecup.Click += new System.EventHandler(this.btnatualizarrecup_Click);
            // 
            // txtcpfrecup
            // 
            this.txtcpfrecup.Location = new System.Drawing.Point(115, 63);
            this.txtcpfrecup.Name = "txtcpfrecup";
            this.txtcpfrecup.PasswordChar = '*';
            this.txtcpfrecup.Size = new System.Drawing.Size(131, 20);
            this.txtcpfrecup.TabIndex = 1;
            this.txtcpfrecup.Visible = false;
            this.txtcpfrecup.TextChanged += new System.EventHandler(this.txtcpfrecup_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOVA SENHA";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "INSIRA SEU CPF";
            // 
            // btnbuscarrecup
            // 
            this.btnbuscarrecup.Location = new System.Drawing.Point(206, 12);
            this.btnbuscarrecup.Name = "btnbuscarrecup";
            this.btnbuscarrecup.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarrecup.TabIndex = 6;
            this.btnbuscarrecup.Text = "BUSCAR";
            this.btnbuscarrecup.UseVisualStyleBackColor = true;
            this.btnbuscarrecup.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtrecuperar
            // 
            this.txtrecuperar.Location = new System.Drawing.Point(115, 14);
            this.txtrecuperar.Mask = "000.000.000-00";
            this.txtrecuperar.Name = "txtrecuperar";
            this.txtrecuperar.Size = new System.Drawing.Size(85, 20);
            this.txtrecuperar.TabIndex = 17;
            // 
            // lembretesenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(331, 126);
            this.Controls.Add(this.txtrecuperar);
            this.Controls.Add(this.btnbuscarrecup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcpfrecup);
            this.Controls.Add(this.btnatualizarrecup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "lembretesenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECUPERAÇÃO DE SENHA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnatualizarrecup;
        private System.Windows.Forms.TextBox txtcpfrecup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscarrecup;
        private System.Windows.Forms.MaskedTextBox txtrecuperar;
    }
}