namespace mercado
{
    partial class CONSULTAPRODUTOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONSULTAPRODUTOS));
            this.txtpdvenda = new System.Windows.Forms.TextBox();
            this.txtporcen = new System.Windows.Forms.TextBox();
            this.txt_valorUni = new System.Windows.Forms.TextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtunidadesatual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbnfornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet9 = new mercado.mercado_tgDataSet9();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbncateg = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet10 = new mercado.mercado_tgDataSet10();
            this.cbnmarcas = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercado_tgDataSet11 = new mercado.mercado_tgDataSet11();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcaddescprod = new System.Windows.Forms.TextBox();
            this.btnatucateg = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnatumarcas = new System.Windows.Forms.Button();
            this.btnaddmarca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpesqprod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fornecedorTableAdapter = new mercado.mercado_tgDataSet9TableAdapters.fornecedorTableAdapter();
            this.categoriaTableAdapter = new mercado.mercado_tgDataSet10TableAdapters.categoriaTableAdapter();
            this.marcasTableAdapter = new mercado.mercado_tgDataSet11TableAdapters.marcasTableAdapter();
            this.btnalt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpdvenda
            // 
            this.txtpdvenda.Location = new System.Drawing.Point(576, 217);
            this.txtpdvenda.Name = "txtpdvenda";
            this.txtpdvenda.Size = new System.Drawing.Size(100, 20);
            this.txtpdvenda.TabIndex = 72;
            this.txtpdvenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpdvenda_KeyPress);
            this.txtpdvenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpdvenda_KeyUp);
            this.txtpdvenda.Leave += new System.EventHandler(this.txtpdvenda_Leave);
            // 
            // txtporcen
            // 
            this.txtporcen.Location = new System.Drawing.Point(387, 218);
            this.txtporcen.Name = "txtporcen";
            this.txtporcen.Size = new System.Drawing.Size(33, 20);
            this.txtporcen.TabIndex = 71;
            this.txtporcen.TextChanged += new System.EventHandler(this.txtporcen_TextChanged);
            // 
            // txt_valorUni
            // 
            this.txt_valorUni.Location = new System.Drawing.Point(109, 217);
            this.txt_valorUni.Name = "txt_valorUni";
            this.txt_valorUni.Size = new System.Drawing.Size(100, 20);
            this.txt_valorUni.TabIndex = 70;
            this.txt_valorUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorUni_KeyPress);
            this.txt_valorUni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_valorUni_KeyUp);
            this.txt_valorUni.Leave += new System.EventHandler(this.txt_valorUni_Leave);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(364, 194);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBox4.TabIndex = 63;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(218, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 15);
            this.label11.TabIndex = 62;
            this.label11.Text = "VALIDADE DO PRODUTO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(0, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 61;
            this.label10.Text = "ESTOQUE ATUAL";
            // 
            // txtunidadesatual
            // 
            this.txtunidadesatual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtunidadesatual.Location = new System.Drawing.Point(109, 193);
            this.txtunidadesatual.Name = "txtunidadesatual";
            this.txtunidadesatual.Size = new System.Drawing.Size(100, 20);
            this.txtunidadesatual.TabIndex = 60;
            this.txtunidadesatual.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(215, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 15);
            this.label8.TabIndex = 57;
            this.label8.Text = "PORCENTAGEM DE VENDA %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(433, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "PREÇO DE VENDA R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(0, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "PREÇO DE CUSTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(-1, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "FORNECEDOR";
            // 
            // cbnfornecedor
            // 
            this.cbnfornecedor.DataSource = this.fornecedorBindingSource;
            this.cbnfornecedor.DisplayMember = "nome_fornecedor";
            this.cbnfornecedor.FormattingEnabled = true;
            this.cbnfornecedor.Location = new System.Drawing.Point(93, 112);
            this.cbnfornecedor.Name = "cbnfornecedor";
            this.cbnfornecedor.Size = new System.Drawing.Size(148, 21);
            this.cbnfornecedor.TabIndex = 53;
            this.cbnfornecedor.ValueMember = "cod_fornecdor";
            this.cbnfornecedor.SelectedIndexChanged += new System.EventHandler(this.cbnfornecedor_SelectedIndexChanged);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.mercado_tgDataSet9;
            // 
            // mercado_tgDataSet9
            // 
            this.mercado_tgDataSet9.DataSetName = "mercado_tgDataSet9";
            this.mercado_tgDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(-1, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "CATEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(-48, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "MARCA";
            // 
            // cbncateg
            // 
            this.cbncateg.DataSource = this.categoriaBindingSource;
            this.cbncateg.DisplayMember = "categ";
            this.cbncateg.FormattingEnabled = true;
            this.cbncateg.Location = new System.Drawing.Point(93, 137);
            this.cbncateg.Name = "cbncateg";
            this.cbncateg.Size = new System.Drawing.Size(147, 21);
            this.cbncateg.TabIndex = 50;
            this.cbncateg.ValueMember = "cod_categoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.mercado_tgDataSet10;
            // 
            // mercado_tgDataSet10
            // 
            this.mercado_tgDataSet10.DataSetName = "mercado_tgDataSet10";
            this.mercado_tgDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbnmarcas
            // 
            this.cbnmarcas.DataSource = this.marcasBindingSource;
            this.cbnmarcas.DisplayMember = "nome_marcas";
            this.cbnmarcas.FormattingEnabled = true;
            this.cbnmarcas.Location = new System.Drawing.Point(94, 164);
            this.cbnmarcas.Name = "cbnmarcas";
            this.cbnmarcas.Size = new System.Drawing.Size(148, 21);
            this.cbnmarcas.TabIndex = 49;
            this.cbnmarcas.ValueMember = "cod_marca";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "marcas";
            this.marcasBindingSource.DataSource = this.mercado_tgDataSet11;
            // 
            // mercado_tgDataSet11
            // 
            this.mercado_tgDataSet11.DataSetName = "mercado_tgDataSet11";
            this.mercado_tgDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(477, 89);
            this.maskedTextBox1.Mask = "0000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(89, 20);
            this.maskedTextBox1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(351, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "CÓDIGO DE BARRAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(0, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // txtcaddescprod
            // 
            this.txtcaddescprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcaddescprod.Location = new System.Drawing.Point(93, 85);
            this.txtcaddescprod.Name = "txtcaddescprod";
            this.txtcaddescprod.Size = new System.Drawing.Size(252, 20);
            this.txtcaddescprod.TabIndex = 45;
            // 
            // btnatucateg
            // 
            this.btnatucateg.BackColor = System.Drawing.Color.Transparent;
            this.btnatucateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatucateg.Image = global::mercado.Properties.Resources.atualizar;
            this.btnatucateg.Location = new System.Drawing.Point(270, 137);
            this.btnatucateg.Name = "btnatucateg";
            this.btnatucateg.Size = new System.Drawing.Size(22, 22);
            this.btnatucateg.TabIndex = 69;
            this.btnatucateg.UseVisualStyleBackColor = false;
            this.btnatucateg.Click += new System.EventHandler(this.btnatucateg_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::mercado.Properties.Resources.oie_transparent__5_;
            this.button5.Location = new System.Drawing.Point(246, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 68;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfornecedor.Image = global::mercado.Properties.Resources.atualizar;
            this.btnfornecedor.Location = new System.Drawing.Point(269, 111);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(22, 22);
            this.btnfornecedor.TabIndex = 67;
            this.btnfornecedor.UseVisualStyleBackColor = false;
            this.btnfornecedor.Click += new System.EventHandler(this.btnfornecedor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::mercado.Properties.Resources.oie_transparent__5_;
            this.button3.Location = new System.Drawing.Point(245, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 66;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnatumarcas
            // 
            this.btnatumarcas.BackColor = System.Drawing.Color.Transparent;
            this.btnatumarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatumarcas.Image = global::mercado.Properties.Resources.atualizar;
            this.btnatumarcas.Location = new System.Drawing.Point(270, 165);
            this.btnatumarcas.Name = "btnatumarcas";
            this.btnatumarcas.Size = new System.Drawing.Size(22, 22);
            this.btnatumarcas.TabIndex = 65;
            this.btnatumarcas.UseVisualStyleBackColor = false;
            this.btnatumarcas.Click += new System.EventHandler(this.btnatumarcas_Click);
            // 
            // btnaddmarca
            // 
            this.btnaddmarca.BackColor = System.Drawing.Color.Transparent;
            this.btnaddmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmarca.Image = global::mercado.Properties.Resources.oie_transparent__5_;
            this.btnaddmarca.Location = new System.Drawing.Point(246, 165);
            this.btnaddmarca.Name = "btnaddmarca";
            this.btnaddmarca.Size = new System.Drawing.Size(22, 22);
            this.btnaddmarca.TabIndex = 64;
            this.btnaddmarca.UseVisualStyleBackColor = false;
            this.btnaddmarca.Click += new System.EventHandler(this.btnaddmarca_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 73;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpesqprod
            // 
            this.txtpesqprod.Location = new System.Drawing.Point(126, 26);
            this.txtpesqprod.MaxLength = 13;
            this.txtpesqprod.Name = "txtpesqprod";
            this.txtpesqprod.Size = new System.Drawing.Size(83, 20);
            this.txtpesqprod.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(-1, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 15);
            this.label12.TabIndex = 75;
            this.label12.Text = "CÓDIGO DE BARRAS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(0, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 15);
            this.label13.TabIndex = 76;
            this.label13.Text = "DATA DE REGISTRO";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.Info;
            this.lbldata.Location = new System.Drawing.Point(123, 58);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 15);
            this.lbldata.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(0, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 78;
            this.label14.Text = "MARCAS";
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // btnalt
            // 
            this.btnalt.Location = new System.Drawing.Point(13, 297);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(75, 23);
            this.btnalt.TabIndex = 80;
            this.btnalt.Text = "ALTERAR";
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // CONSULTAPRODUTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(696, 348);
            this.Controls.Add(this.btnalt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtpesqprod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpdvenda);
            this.Controls.Add(this.txtporcen);
            this.Controls.Add(this.txt_valorUni);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbnfornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbncateg);
            this.Controls.Add(this.cbnmarcas);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcaddescprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CONSULTAPRODUTOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA PRODUTOS";
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercado_tgDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpdvenda;
        private System.Windows.Forms.TextBox txtporcen;
        private System.Windows.Forms.TextBox txt_valorUni;
        private System.Windows.Forms.Button btnatucateg;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnatumarcas;
        private System.Windows.Forms.Button btnaddmarca;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtunidadesatual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbnfornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbncateg;
        private System.Windows.Forms.ComboBox cbnmarcas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcaddescprod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpesqprod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label14;
        private mercado_tgDataSet9 mercado_tgDataSet9;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private mercado_tgDataSet9TableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private mercado_tgDataSet10 mercado_tgDataSet10;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private mercado_tgDataSet10TableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private mercado_tgDataSet11 mercado_tgDataSet11;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private mercado_tgDataSet11TableAdapters.marcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.Button btnalt;
    }
}