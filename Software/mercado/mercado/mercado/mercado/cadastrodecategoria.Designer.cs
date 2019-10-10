namespace mercado
{
    partial class cadastrodecategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrodecategoria));
            this.label3 = new System.Windows.Forms.Label();
            this.txtcadcateg = new System.Windows.Forms.TextBox();
            this.btncadcateg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOVA CATEGORIA";
            // 
            // txtcadcateg
            // 
            this.txtcadcateg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcadcateg.Location = new System.Drawing.Point(122, 30);
            this.txtcadcateg.Name = "txtcadcateg";
            this.txtcadcateg.Size = new System.Drawing.Size(180, 20);
            this.txtcadcateg.TabIndex = 6;
            // 
            // btncadcateg
            // 
            this.btncadcateg.Location = new System.Drawing.Point(122, 79);
            this.btncadcateg.Name = "btncadcateg";
            this.btncadcateg.Size = new System.Drawing.Size(119, 23);
            this.btncadcateg.TabIndex = 7;
            this.btncadcateg.Text = "SALVAR";
            this.btncadcateg.UseVisualStyleBackColor = true;
            this.btncadcateg.Click += new System.EventHandler(this.btncadcateg_Click);
            // 
            // cadastrodecategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(333, 125);
            this.Controls.Add(this.btncadcateg);
            this.Controls.Add(this.txtcadcateg);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastrodecategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE CATEGORIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcadcateg;
        private System.Windows.Forms.Button btncadcateg;
    }
}