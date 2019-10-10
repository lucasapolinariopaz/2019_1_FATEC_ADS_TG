namespace mercado
{
    partial class cadastro_de_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_de_produtos));
            this.label4 = new System.Windows.Forms.Label();
            this.txtcaddescprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnmarcas = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet7 = new mercado.mercado_tgDataSet7();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbncateg = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet5 = new mercado.mercado_tgDataSet5();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbnfornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet8 = new mercado.mercado_tgDataSet8();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet6 = new mercado.mercado_tgDataSet6();
            this.marcasTableAdapter = new mercado.mercado_tgDataSet3TableAdapters.marcasTableAdapter();
            this.categoriaTableAdapter = new mercado.mercado_tgDataSet5TableAdapters.categoriaTableAdapter();
            this.fornecedorTableAdapter = new mercado.mercado_tgDataSet6TableAdapters.fornecedorTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtunidades = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtunidadesatual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.btnaddmarca = new System.Windows.Forms.Button();
            this.btnatumarcas = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dicas = new System.Windows.Forms.ToolTip(this.components);
            this.btnatucateg = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.marcasTableAdapter1 = new mercado.mercado_tgDataSet7TableAdapters.marcasTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtporcen = new System.Windows.Forms.TextBox();
            this.txtpdvenda = new System.Windows.Forms.TextBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.fornecedorTableAdapter1 = new mercado.mercado_tgDataSet8TableAdapters.fornecedorTableAdapter();
            this.txt_CodBarras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(0, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // txtcaddescprod
            // 
            this.txtcaddescprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcaddescprod.Location = new System.Drawing.Point(93, 43);
            this.txtcaddescprod.MaxLength = 50;
            this.txtcaddescprod.Name = "txtcaddescprod";
            this.txtcaddescprod.Size = new System.Drawing.Size(252, 20);
            this.txtcaddescprod.TabIndex = 9;
            this.txtcaddescprod.TextChanged += new System.EventHandler(this.txtcaddescprod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(351, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "CÓDIGO DE BARRAS";
            // 
            // cbnmarcas
            // 
            this.cbnmarcas.DataSource = this.marcasBindingSource1;
            this.cbnmarcas.DisplayMember = "nome_marcas";
            this.cbnmarcas.FormattingEnabled = true;
            this.cbnmarcas.Location = new System.Drawing.Point(94, 122);
            this.cbnmarcas.Name = "cbnmarcas";
            this.cbnmarcas.Size = new System.Drawing.Size(148, 21);
            this.cbnmarcas.TabIndex = 14;
            this.cbnmarcas.ValueMember = "cod_marca";
            this.cbnmarcas.TextChanged += new System.EventHandler(this.cbnmarcas_TextChanged);
            this.cbnmarcas.Click += new System.EventHandler(this.cbnmarcas_Click);
            // 
            // marcasBindingSource1
            // 
            this.marcasBindingSource1.DataMember = "marcas";
            this.marcasBindingSource1.DataSource = this.mercado_tgDataSet7;
            // 
            // mercado_tgDataSet7
            // 
            this.mercado_tgDataSet7.DataSetName = "mercado_tgDataSet7";
            this.mercado_tgDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbncateg
            // 
            this.cbncateg.DataSource = this.categoriaBindingSource;
            this.cbncateg.DisplayMember = "categ";
            this.cbncateg.FormattingEnabled = true;
            this.cbncateg.Location = new System.Drawing.Point(93, 95);
            this.cbncateg.Name = "cbncateg";
            this.cbncateg.Size = new System.Drawing.Size(148, 21);
            this.cbncateg.TabIndex = 15;
            this.cbncateg.ValueMember = "categ";
            this.cbncateg.TextChanged += new System.EventHandler(this.cbncateg_TextChanged);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.mercado_tgDataSet5;
            // 
            // mercado_tgDataSet5
            // 
            this.mercado_tgDataSet5.DataSetName = "mercado_tgDataSet5";
            this.mercado_tgDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(1, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "MARCA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(-1, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(-1, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "FORNECEDOR";
            // 
            // cbnfornecedor
            // 
            this.cbnfornecedor.DataSource = this.fornecedorBindingSource1;
            this.cbnfornecedor.DisplayMember = "nome_fornecedor";
            this.cbnfornecedor.FormattingEnabled = true;
            this.cbnfornecedor.Location = new System.Drawing.Point(93, 70);
            this.cbnfornecedor.Name = "cbnfornecedor";
            this.cbnfornecedor.Size = new System.Drawing.Size(148, 21);
            this.cbnfornecedor.TabIndex = 18;
            this.cbnfornecedor.ValueMember = "cod_fornecdor";
            this.cbnfornecedor.Click += new System.EventHandler(this.cbnfornecedor_Click);
            // 
            // fornecedorBindingSource1
            // 
            this.fornecedorBindingSource1.DataMember = "fornecedor";
            this.fornecedorBindingSource1.DataSource = this.mercado_tgDataSet8;
            // 
            // mercado_tgDataSet8
            // 
            this.mercado_tgDataSet8.DataSetName = "mercado_tgDataSet8";
            this.mercado_tgDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.mercado_tgDataSet6;
            // 
            // mercado_tgDataSet6
            // 
            this.mercado_tgDataSet6.DataSetName = "mercado_tgDataSet6";
            this.mercado_tgDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(0, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "PREÇO DE CUSTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(433, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "PREÇO DE VENDA R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(215, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "PORCENTAGEM DE VENDA %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(0, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "UNIDADES";
            // 
            // txtunidades
            // 
            this.txtunidades.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtunidades.Location = new System.Drawing.Point(109, 149);
            this.txtunidades.Name = "txtunidades";
            this.txtunidades.Size = new System.Drawing.Size(100, 20);
            this.txtunidades.TabIndex = 25;
            this.txtunidades.Text = "0";
            this.txtunidades.TextChanged += new System.EventHandler(this.txtunidades_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(212, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "ESTOQUE ATUAL";
            // 
            // txtunidadesatual
            // 
            this.txtunidadesatual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtunidadesatual.Enabled = false;
            this.txtunidadesatual.Location = new System.Drawing.Point(316, 150);
            this.txtunidadesatual.Name = "txtunidadesatual";
            this.txtunidadesatual.Size = new System.Drawing.Size(105, 20);
            this.txtunidadesatual.TabIndex = 27;
            this.txtunidadesatual.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(430, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "VALIDADE DO PRODUTO";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(576, 151);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBox4.TabIndex = 31;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // btnaddmarca
            // 
            this.btnaddmarca.BackColor = System.Drawing.Color.Transparent;
            this.btnaddmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmarca.Image = global::mercado.Properties.Resources.oie_transparent__5_;
            this.btnaddmarca.Location = new System.Drawing.Point(246, 123);
            this.btnaddmarca.Name = "btnaddmarca";
            this.btnaddmarca.Size = new System.Drawing.Size(22, 22);
            this.btnaddmarca.TabIndex = 35;
            this.dicas.SetToolTip(this.btnaddmarca, "ADICONAR NOVA MARCA");
            this.btnaddmarca.UseVisualStyleBackColor = false;
            this.btnaddmarca.Click += new System.EventHandler(this.btnaddmarca_Click);
            // 
            // btnatumarcas
            // 
            this.btnatumarcas.BackColor = System.Drawing.Color.Transparent;
            this.btnatumarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatumarcas.Image = global::mercado.Properties.Resources.atualizar;
            this.btnatumarcas.Location = new System.Drawing.Point(270, 123);
            this.btnatumarcas.Name = "btnatumarcas";
            this.btnatumarcas.Size = new System.Drawing.Size(22, 22);
            this.btnatumarcas.TabIndex = 36;
            this.dicas.SetToolTip(this.btnatumarcas, "ATUALIZAR CAMPO DE MARCAS");
            this.btnatumarcas.UseVisualStyleBackColor = false;
            this.btnatumarcas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfornecedor.Image = global::mercado.Properties.Resources.atualizar;
            this.btnfornecedor.Location = new System.Drawing.Point(269, 69);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(22, 22);
            this.btnfornecedor.TabIndex = 38;
            this.dicas.SetToolTip(this.btnfornecedor, "ATUALIZAR CAMPO DE FORNECEDOR");
            this.btnfornecedor.UseVisualStyleBackColor = false;
            this.btnfornecedor.Click += new System.EventHandler(this.btnfornecedor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::mercado.Properties.Resources.oie_transparent__5_;
            this.button3.Location = new System.Drawing.Point(245, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 37;
            this.dicas.SetToolTip(this.button3, "CADASTRAR NOVO FORNECEDOR");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnatucateg
            // 
            this.btnatucateg.BackColor = System.Drawing.Color.Transparent;
            this.btnatucateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatucateg.Image = global::mercado.Properties.Resources.atualizar;
            this.btnatucateg.Location = new System.Drawing.Point(270, 95);
            this.btnatucateg.Name = "btnatucateg";
            this.btnatucateg.Size = new System.Drawing.Size(22, 22);
            this.btnatucateg.TabIndex = 40;
            this.dicas.SetToolTip(this.btnatucateg, "ATUALIZAR CAMPO DE CATEGORIA");
            this.btnatucateg.UseVisualStyleBackColor = false;
            this.btnatucateg.Click += new System.EventHandler(this.btnatucateg_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::mercado.Properties.Resources.oie_transparent__5_;
            this.button5.Location = new System.Drawing.Point(246, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 39;
            this.dicas.SetToolTip(this.button5, "ADICONAR NOVA CATEGORIA");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnsalvar.Image = global::mercado.Properties.Resources.salvar__2_;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalvar.Location = new System.Drawing.Point(229, 232);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(63, 54);
            this.btnsalvar.TabIndex = 41;
            this.dicas.SetToolTip(this.btnsalvar, "SALVAR DADOS");
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::mercado.Properties.Resources.vassoura;
            this.button1.Location = new System.Drawing.Point(318, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 54);
            this.button1.TabIndex = 46;
            this.dicas.SetToolTip(this.button1, "LIMPAR CAMPOS");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::mercado.Properties.Resources.excluir1;
            this.button2.Location = new System.Drawing.Point(409, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 54);
            this.button2.TabIndex = 47;
            this.dicas.SetToolTip(this.button2, "FECHAR");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // marcasTableAdapter1
            // 
            this.marcasTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 42;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtporcen
            // 
            this.txtporcen.Enabled = false;
            this.txtporcen.Location = new System.Drawing.Point(387, 176);
            this.txtporcen.Name = "txtporcen";
            this.txtporcen.Size = new System.Drawing.Size(33, 20);
            this.txtporcen.TabIndex = 43;
            this.txtporcen.TextChanged += new System.EventHandler(this.txtporcen_TextChanged);
            this.txtporcen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtporcen_KeyPress);
            // 
            // txtpdvenda
            // 
            this.txtpdvenda.Location = new System.Drawing.Point(576, 175);
            this.txtpdvenda.Name = "txtpdvenda";
            this.txtpdvenda.Size = new System.Drawing.Size(100, 20);
            this.txtpdvenda.TabIndex = 44;
            this.txtpdvenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpdvenda_KeyPress);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.Info;
            this.lbldata.Location = new System.Drawing.Point(6, 9);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 16);
            this.lbldata.TabIndex = 45;
            // 
            // fornecedorTableAdapter1
            // 
            this.fornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // txt_CodBarras
            // 
            this.txt_CodBarras.Enabled = false;
            this.txt_CodBarras.Location = new System.Drawing.Point(478, 45);
            this.txt_CodBarras.MaxLength = 13;
            this.txt_CodBarras.Name = "txt_CodBarras";
            this.txt_CodBarras.Size = new System.Drawing.Size(89, 20);
            this.txt_CodBarras.TabIndex = 48;
            this.txt_CodBarras.TextChanged += new System.EventHandler(this.txt_CodBarras_TextChanged_1);
            // 
            // cadastro_de_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(696, 306);
            this.Controls.Add(this.txt_CodBarras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.txtpdvenda);
            this.Controls.Add(this.txtporcen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnatucateg);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnfornecedor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnatumarcas);
            this.Controls.Add(this.btnaddmarca);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtunidadesatual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtunidades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbnfornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbncateg);
            this.Controls.Add(this.cbnmarcas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcaddescprod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastro_de_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PRODUTOS";
            this.Load += new System.EventHandler(this.cadastro_de_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcaddescprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnmarcas;
        private System.Windows.Forms.ComboBox cbncateg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbnfornecedor;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private mercado_tgDataSet3TableAdapters.marcasTableAdapter marcasTableAdapter;
        private mercado_tgDataSet5 mercado_tgDataSet5;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private mercado_tgDataSet5TableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private mercado_tgDataSet6 mercado_tgDataSet6;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private mercado_tgDataSet6TableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtunidades;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtunidadesatual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Button btnaddmarca;
        private System.Windows.Forms.Button btnatumarcas;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip dicas;
        private mercado_tgDataSet7 mercado_tgDataSet7;
        private System.Windows.Forms.BindingSource marcasBindingSource1;
        private mercado_tgDataSet7TableAdapters.marcasTableAdapter marcasTableAdapter1;
        private System.Windows.Forms.Button btnatucateg;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtporcen;
        private System.Windows.Forms.TextBox txtpdvenda;
        private System.Windows.Forms.Label lbldata;
        private mercado_tgDataSet8 mercado_tgDataSet8;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private mercado_tgDataSet8TableAdapters.fornecedorTableAdapter fornecedorTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_CodBarras;
    }
}