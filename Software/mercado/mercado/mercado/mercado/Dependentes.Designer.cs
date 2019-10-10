namespace mercado
{
    partial class Dependentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dependentes));
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DependenteNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DependenteParentesco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ClienteCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.masktxt_PesquisarCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(241, 14);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(78, 23);
            this.btn_Pesquisar.TabIndex = 165;
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
            this.label11.Location = new System.Drawing.Point(5, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 163;
            this.label11.Text = "CPF DO CLIENTE";
            // 
            // txt_DependenteNome
            // 
            this.txt_DependenteNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_DependenteNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_DependenteNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DependenteNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DependenteNome.Location = new System.Drawing.Point(64, 86);
            this.txt_DependenteNome.MaxLength = 50;
            this.txt_DependenteNome.Name = "txt_DependenteNome";
            this.txt_DependenteNome.Size = new System.Drawing.Size(240, 22);
            this.txt_DependenteNome.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(5, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 166;
            this.label1.Text = "NOME";
            // 
            // txt_DependenteParentesco
            // 
            this.txt_DependenteParentesco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_DependenteParentesco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_DependenteParentesco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DependenteParentesco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DependenteParentesco.Location = new System.Drawing.Point(433, 86);
            this.txt_DependenteParentesco.MaxLength = 50;
            this.txt_DependenteParentesco.Name = "txt_DependenteParentesco";
            this.txt_DependenteParentesco.Size = new System.Drawing.Size(240, 22);
            this.txt_DependenteParentesco.TabIndex = 169;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(312, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 168;
            this.label2.Text = "PARENTESCO";
            // 
            // txt_ClienteCod
            // 
            this.txt_ClienteCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_ClienteCod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_ClienteCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ClienteCod.Enabled = false;
            this.txt_ClienteCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClienteCod.Location = new System.Drawing.Point(187, 58);
            this.txt_ClienteCod.MaxLength = 13;
            this.txt_ClienteCod.Name = "txt_ClienteCod";
            this.txt_ClienteCod.Size = new System.Drawing.Size(117, 22);
            this.txt_ClienteCod.TabIndex = 171;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 170;
            this.label3.Text = "CÓDIGO DO CLIENTE";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(421, 137);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 174;
            this.btn_Fechar.Text = "FECHAR";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(297, 137);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 173;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(177, 137);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 172;
            this.btn_Salvar.Text = "SALVAR";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // masktxt_PesquisarCPF
            // 
            this.masktxt_PesquisarCPF.Location = new System.Drawing.Point(150, 16);
            this.masktxt_PesquisarCPF.Mask = "000.000.000-00";
            this.masktxt_PesquisarCPF.Name = "masktxt_PesquisarCPF";
            this.masktxt_PesquisarCPF.Size = new System.Drawing.Size(85, 20);
            this.masktxt_PesquisarCPF.TabIndex = 175;
            // 
            // Dependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(677, 184);
            this.Controls.Add(this.masktxt_PesquisarCPF);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_ClienteCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DependenteParentesco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DependenteNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dependentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dependentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pesquisar;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txt_DependenteNome;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txt_DependenteParentesco;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_ClienteCod;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.MaskedTextBox masktxt_PesquisarCPF;
    }
}