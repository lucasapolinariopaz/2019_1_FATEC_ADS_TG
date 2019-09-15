namespace mercado
{
    partial class cadastromarcas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastromarcas));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtcadmarcas = new System.Windows.Forms.TextBox();
            this.btncadmarcas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mercado_tgDataSet2 = new mercado.mercado_tgDataSet2();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new mercado.mercado_tgDataSet2TableAdapters.categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOVA MARCA";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoriaBindingSource;
            this.comboBox1.DisplayMember = "categ";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "cod_categoria";
            // 
            // txtcadmarcas
            // 
            this.txtcadmarcas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcadmarcas.Location = new System.Drawing.Point(12, 50);
            this.txtcadmarcas.Name = "txtcadmarcas";
            this.txtcadmarcas.Size = new System.Drawing.Size(128, 20);
            this.txtcadmarcas.TabIndex = 8;
            // 
            // btncadmarcas
            // 
            this.btncadmarcas.Location = new System.Drawing.Point(120, 108);
            this.btncadmarcas.Name = "btncadmarcas";
            this.btncadmarcas.Size = new System.Drawing.Size(158, 23);
            this.btncadmarcas.TabIndex = 9;
            this.btncadmarcas.Text = "SALVAR";
            this.btncadmarcas.UseVisualStyleBackColor = true;
            this.btncadmarcas.Click += new System.EventHandler(this.btncadmarcas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(224, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "SELECIONE A CATEGORIA";
            // 
            // mercado_tgDataSet2
            // 
            this.mercado_tgDataSet2.DataSetName = "mercado_tgDataSet2";
            this.mercado_tgDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.mercado_tgDataSet2;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // cadastromarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(400, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadmarcas);
            this.Controls.Add(this.txtcadmarcas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastromarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE MARCAS";
            this.Load += new System.EventHandler(this.cadastromarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtcadmarcas;
        private System.Windows.Forms.Button btncadmarcas;
        private System.Windows.Forms.Label label1;
        private mercado_tgDataSet2 mercado_tgDataSet2;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private mercado_tgDataSet2TableAdapters.categoriaTableAdapter categoriaTableAdapter;
    }
}