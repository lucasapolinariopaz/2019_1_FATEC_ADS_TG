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
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet2 = new mercado.mercado_tgDataSet2();
            this.txtcadmarcas = new System.Windows.Forms.TextBox();
            this.btncadmarcas = new System.Windows.Forms.Button();
            this.categoriaTableAdapter = new mercado.mercado_tgDataSet2TableAdapters.categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(54, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOVA MARCA";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.mercado_tgDataSet2;
            // 
            // mercado_tgDataSet2
            // 
            this.mercado_tgDataSet2.DataSetName = "mercado_tgDataSet2";
            this.mercado_tgDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcadmarcas
            // 
            this.txtcadmarcas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcadmarcas.Location = new System.Drawing.Point(144, 46);
            this.txtcadmarcas.MaxLength = 50;
            this.txtcadmarcas.Name = "txtcadmarcas";
            this.txtcadmarcas.Size = new System.Drawing.Size(154, 20);
            this.txtcadmarcas.TabIndex = 8;
            // 
            // btncadmarcas
            // 
            this.btncadmarcas.Location = new System.Drawing.Point(85, 96);
            this.btncadmarcas.Name = "btncadmarcas";
            this.btncadmarcas.Size = new System.Drawing.Size(158, 23);
            this.btncadmarcas.TabIndex = 9;
            this.btncadmarcas.Text = "SALVAR";
            this.btncadmarcas.UseVisualStyleBackColor = true;
            this.btncadmarcas.Click += new System.EventHandler(this.btncadmarcas_Click);
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
            this.ClientSize = new System.Drawing.Size(346, 159);
            this.Controls.Add(this.btncadmarcas);
            this.Controls.Add(this.txtcadmarcas);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastromarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE MARCAS";
            this.Load += new System.EventHandler(this.cadastromarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcadmarcas;
        private System.Windows.Forms.Button btncadmarcas;
        private mercado_tgDataSet2 mercado_tgDataSet2;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private mercado_tgDataSet2TableAdapters.categoriaTableAdapter categoriaTableAdapter;
    }
}