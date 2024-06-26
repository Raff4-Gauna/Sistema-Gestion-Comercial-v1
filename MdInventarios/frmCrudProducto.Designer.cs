﻿
namespace CapaPresentación.MdInventarios
{
    partial class frmCrudProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrudProducto));
            this.txtcodigobarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonSinRedondeo = new System.Windows.Forms.RadioButton();
            this.btnAgregarMarGanancia = new FontAwesome.Sharp.IconButton();
            this.radioButtonRedondeo = new System.Windows.Forms.RadioButton();
            this.btnAgregarImpuestos = new FontAwesome.Sharp.IconButton();
            this.txtpreciofinal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAgregarProveedor = new FontAwesome.Sharp.IconButton();
            this.cboproveedor = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbomargenganancias = new System.Windows.Forms.ComboBox();
            this.cboimpuestos = new System.Windows.Forms.ComboBox();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtstockexistente = new System.Windows.Forms.TextBox();
            this.btnAbrirUnidadMedidas = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cbotipounidad = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEleccion1CboUniMed = new System.Windows.Forms.Label();
            this.txtstockminimo = new System.Windows.Forms.TextBox();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEleccion2CboUniMed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripciongeneral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarImg = new FontAwesome.Sharp.IconButton();
            this.picImgProducto = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalProductosNoActivas = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMargenGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbicacionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockExistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chechgenerarcod = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbosubcategoria = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.label23 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarSubCat = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCat = new FontAwesome.Sharp.IconButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCodigoBarra = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigobarra
            // 
            this.txtcodigobarra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcodigobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarra.Location = new System.Drawing.Point(7, 21);
            this.txtcodigobarra.Name = "txtcodigobarra";
            this.txtcodigobarra.Size = new System.Drawing.Size(237, 24);
            this.txtcodigobarra.TabIndex = 110;
            this.txtcodigobarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigobarra_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 15);
            this.label10.TabIndex = 109;
            this.label10.Text = "Código de Barra: *";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtdescripciongeneral);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonSinRedondeo);
            this.groupBox4.Controls.Add(this.btnAgregarMarGanancia);
            this.groupBox4.Controls.Add(this.radioButtonRedondeo);
            this.groupBox4.Controls.Add(this.btnAgregarImpuestos);
            this.groupBox4.Controls.Add(this.txtpreciofinal);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.btnAgregarProveedor);
            this.groupBox4.Controls.Add(this.cboproveedor);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cbomargenganancias);
            this.groupBox4.Controls.Add(this.cboimpuestos);
            this.groupBox4.Controls.Add(this.txtpreciocompra);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(397, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 190);
            this.groupBox4.TabIndex = 160;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cotización";
            // 
            // radioButtonSinRedondeo
            // 
            this.radioButtonSinRedondeo.AutoSize = true;
            this.radioButtonSinRedondeo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonSinRedondeo.Location = new System.Drawing.Point(404, 133);
            this.radioButtonSinRedondeo.Name = "radioButtonSinRedondeo";
            this.radioButtonSinRedondeo.Size = new System.Drawing.Size(121, 17);
            this.radioButtonSinRedondeo.TabIndex = 237;
            this.radioButtonSinRedondeo.TabStop = true;
            this.radioButtonSinRedondeo.Text = "Quitar Redondeo";
            this.radioButtonSinRedondeo.UseVisualStyleBackColor = true;
            this.radioButtonSinRedondeo.CheckedChanged += new System.EventHandler(this.radioButtonSinRedondeo_CheckedChanged);
            // 
            // btnAgregarMarGanancia
            // 
            this.btnAgregarMarGanancia.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMarGanancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMarGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarGanancia.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarMarGanancia.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarMarGanancia.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarMarGanancia.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarMarGanancia.IconSize = 20;
            this.btnAgregarMarGanancia.Location = new System.Drawing.Point(219, 148);
            this.btnAgregarMarGanancia.Name = "btnAgregarMarGanancia";
            this.btnAgregarMarGanancia.Size = new System.Drawing.Size(21, 28);
            this.btnAgregarMarGanancia.TabIndex = 246;
            this.btnAgregarMarGanancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarMarGanancia.UseVisualStyleBackColor = false;
            this.btnAgregarMarGanancia.Click += new System.EventHandler(this.btnAgregarMarGanancia_Click);
            // 
            // radioButtonRedondeo
            // 
            this.radioButtonRedondeo.AutoSize = true;
            this.radioButtonRedondeo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonRedondeo.Location = new System.Drawing.Point(275, 133);
            this.radioButtonRedondeo.Name = "radioButtonRedondeo";
            this.radioButtonRedondeo.Size = new System.Drawing.Size(126, 17);
            this.radioButtonRedondeo.TabIndex = 236;
            this.radioButtonRedondeo.TabStop = true;
            this.radioButtonRedondeo.Text = "Aplicar Redondeo";
            this.radioButtonRedondeo.UseVisualStyleBackColor = true;
            this.radioButtonRedondeo.CheckedChanged += new System.EventHandler(this.radioButtonRedondeo_CheckedChanged);
            // 
            // btnAgregarImpuestos
            // 
            this.btnAgregarImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarImpuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImpuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImpuestos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarImpuestos.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarImpuestos.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarImpuestos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarImpuestos.IconSize = 20;
            this.btnAgregarImpuestos.Location = new System.Drawing.Point(102, 148);
            this.btnAgregarImpuestos.Name = "btnAgregarImpuestos";
            this.btnAgregarImpuestos.Size = new System.Drawing.Size(21, 28);
            this.btnAgregarImpuestos.TabIndex = 245;
            this.btnAgregarImpuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarImpuestos.UseVisualStyleBackColor = false;
            this.btnAgregarImpuestos.Click += new System.EventHandler(this.btnAgregarImpuestos_Click);
            // 
            // txtpreciofinal
            // 
            this.txtpreciofinal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtpreciofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtpreciofinal.Location = new System.Drawing.Point(275, 83);
            this.txtpreciofinal.Multiline = true;
            this.txtpreciofinal.Name = "txtpreciofinal";
            this.txtpreciofinal.Size = new System.Drawing.Size(207, 44);
            this.txtpreciofinal.TabIndex = 235;
            this.txtpreciofinal.TextChanged += new System.EventHandler(this.txtpreciofinal_TextChanged);
            this.txtpreciofinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciofinal_KeyPress);
            this.txtpreciofinal.Leave += new System.EventHandler(this.txtpreciofinal_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkGreen;
            this.label20.Location = new System.Drawing.Point(272, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 16);
            this.label20.TabIndex = 234;
            this.label20.Text = "Precio Final Consumidor";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarProveedor.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarProveedor.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarProveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarProveedor.IconSize = 20;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(182, 37);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(20, 21);
            this.btnAgregarProveedor.TabIndex = 244;
            this.btnAgregarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // cboproveedor
            // 
            this.cboproveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboproveedor.FormattingEnabled = true;
            this.cboproveedor.Location = new System.Drawing.Point(10, 37);
            this.cboproveedor.Name = "cboproveedor";
            this.cboproveedor.Size = new System.Drawing.Size(166, 21);
            this.cboproveedor.TabIndex = 243;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(7, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 242;
            this.label17.Text = "Proveedor *";
            // 
            // cbomargenganancias
            // 
            this.cbomargenganancias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbomargenganancias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomargenganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomargenganancias.FormattingEnabled = true;
            this.cbomargenganancias.Location = new System.Drawing.Point(129, 148);
            this.cbomargenganancias.Name = "cbomargenganancias";
            this.cbomargenganancias.Size = new System.Drawing.Size(88, 28);
            this.cbomargenganancias.TabIndex = 241;
            this.cbomargenganancias.SelectedIndexChanged += new System.EventHandler(this.cbomargenganancias_SelectedIndexChanged);
            // 
            // cboimpuestos
            // 
            this.cboimpuestos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboimpuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboimpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboimpuestos.FormattingEnabled = true;
            this.cboimpuestos.Location = new System.Drawing.Point(10, 148);
            this.cboimpuestos.Name = "cboimpuestos";
            this.cboimpuestos.Size = new System.Drawing.Size(88, 28);
            this.cboimpuestos.TabIndex = 240;
            this.cboimpuestos.SelectedIndexChanged += new System.EventHandler(this.cboimpuestos_SelectedIndexChanged);
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtpreciocompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciocompra.Location = new System.Drawing.Point(10, 83);
            this.txtpreciocompra.Multiline = true;
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(207, 44);
            this.txtpreciocompra.TabIndex = 239;
            this.txtpreciocompra.TextChanged += new System.EventHandler(this.txtpreciocompra_TextChanged);
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            this.txtpreciocompra.Leave += new System.EventHandler(this.txtpreciocompra_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(7, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 13);
            this.label22.TabIndex = 238;
            this.label22.Text = "Precio de Compra *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(8, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 237;
            this.label18.Text = "Impuestos *";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(126, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 236;
            this.label21.Text = "% Ganancia: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtstockexistente);
            this.groupBox3.Controls.Add(this.btnAbrirUnidadMedidas);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cbotipounidad);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblEleccion1CboUniMed);
            this.groupBox3.Controls.Add(this.txtstockminimo);
            this.groupBox3.Controls.Add(this.txtubicacion);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblEleccion2CboUniMed);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(6, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 190);
            this.groupBox3.TabIndex = 159;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventario";
            // 
            // txtstockexistente
            // 
            this.txtstockexistente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstockexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockexistente.Location = new System.Drawing.Point(6, 38);
            this.txtstockexistente.Name = "txtstockexistente";
            this.txtstockexistente.Size = new System.Drawing.Size(182, 29);
            this.txtstockexistente.TabIndex = 149;
            this.txtstockexistente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstockexistente_KeyPress);
            // 
            // btnAbrirUnidadMedidas
            // 
            this.btnAbrirUnidadMedidas.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirUnidadMedidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirUnidadMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirUnidadMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirUnidadMedidas.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbrirUnidadMedidas.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAbrirUnidadMedidas.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnAbrirUnidadMedidas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAbrirUnidadMedidas.IconSize = 20;
            this.btnAbrirUnidadMedidas.Location = new System.Drawing.Point(348, 38);
            this.btnAbrirUnidadMedidas.Name = "btnAbrirUnidadMedidas";
            this.btnAbrirUnidadMedidas.Size = new System.Drawing.Size(26, 28);
            this.btnAbrirUnidadMedidas.TabIndex = 158;
            this.btnAbrirUnidadMedidas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirUnidadMedidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirUnidadMedidas.UseVisualStyleBackColor = false;
            this.btnAbrirUnidadMedidas.Click += new System.EventHandler(this.btnAbrirUnidadMedidas_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(5, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 148;
            this.label15.Text = "Stock Existente: *";
            // 
            // cbotipounidad
            // 
            this.cbotipounidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbotipounidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipounidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipounidad.FormattingEnabled = true;
            this.cbotipounidad.Location = new System.Drawing.Point(238, 37);
            this.cbotipounidad.Name = "cbotipounidad";
            this.cbotipounidad.Size = new System.Drawing.Size(104, 28);
            this.cbotipounidad.TabIndex = 157;
            this.cbotipounidad.SelectedIndexChanged += new System.EventHandler(this.cbotipounidad_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(242, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 156;
            this.label14.Text = "Unidad de Medida: *";
            // 
            // lblEleccion1CboUniMed
            // 
            this.lblEleccion1CboUniMed.AutoSize = true;
            this.lblEleccion1CboUniMed.BackColor = System.Drawing.Color.Black;
            this.lblEleccion1CboUniMed.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleccion1CboUniMed.ForeColor = System.Drawing.Color.Lime;
            this.lblEleccion1CboUniMed.Location = new System.Drawing.Point(191, 42);
            this.lblEleccion1CboUniMed.Name = "lblEleccion1CboUniMed";
            this.lblEleccion1CboUniMed.Size = new System.Drawing.Size(16, 24);
            this.lblEleccion1CboUniMed.TabIndex = 154;
            this.lblEleccion1CboUniMed.Text = ".";
            // 
            // txtstockminimo
            // 
            this.txtstockminimo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstockminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockminimo.Location = new System.Drawing.Point(6, 86);
            this.txtstockminimo.Name = "txtstockminimo";
            this.txtstockminimo.Size = new System.Drawing.Size(181, 29);
            this.txtstockminimo.TabIndex = 151;
            this.txtstockminimo.Text = "1";
            this.txtstockminimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstockminimo_KeyPress);
            // 
            // txtubicacion
            // 
            this.txtubicacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtubicacion.Location = new System.Drawing.Point(7, 134);
            this.txtubicacion.Multiline = true;
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(335, 40);
            this.txtubicacion.TabIndex = 153;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 13);
            this.label16.TabIndex = 152;
            this.label16.Text = "Ubicación en el Almacén: ";
            // 
            // lblEleccion2CboUniMed
            // 
            this.lblEleccion2CboUniMed.AutoSize = true;
            this.lblEleccion2CboUniMed.BackColor = System.Drawing.Color.Black;
            this.lblEleccion2CboUniMed.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleccion2CboUniMed.ForeColor = System.Drawing.Color.Lime;
            this.lblEleccion2CboUniMed.Location = new System.Drawing.Point(189, 91);
            this.lblEleccion2CboUniMed.Name = "lblEleccion2CboUniMed";
            this.lblEleccion2CboUniMed.Size = new System.Drawing.Size(16, 24);
            this.lblEleccion2CboUniMed.TabIndex = 155;
            this.lblEleccion2CboUniMed.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 150;
            this.label5.Text = "Stock Mínimo: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(861, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Cat/Sub";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(731, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Categoria/SubCategoria:";
            this.label9.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(432, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "TIPO + MARCA + DESCRIPCIÓN + CAPACIDAD/TAMAÑO";
            this.label2.Visible = false;
            // 
            // txtdescripciongeneral
            // 
            this.txtdescripciongeneral.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdescripciongeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripciongeneral.Location = new System.Drawing.Point(6, 23);
            this.txtdescripciongeneral.Name = "txtdescripciongeneral";
            this.txtdescripciongeneral.Size = new System.Drawing.Size(386, 22);
            this.txtdescripciongeneral.TabIndex = 90;
            this.txtdescripciongeneral.TextChanged += new System.EventHandler(this.txtdescripciongeneral_TextChanged);
            this.txtdescripciongeneral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripciongeneral_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Descripción General: *";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnAgregarImg);
            this.tabPage2.Controls.Add(this.picImgProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Imagen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImg.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.btnAgregarImg.IconColor = System.Drawing.Color.Black;
            this.btnAgregarImg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarImg.IconSize = 25;
            this.btnAgregarImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarImg.Location = new System.Drawing.Point(6, 184);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(182, 34);
            this.btnAgregarImg.TabIndex = 148;
            this.btnAgregarImg.Text = "Agregar";
            this.btnAgregarImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarImg.UseVisualStyleBackColor = false;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // picImgProducto
            // 
            this.picImgProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImgProducto.Location = new System.Drawing.Point(6, 6);
            this.picImgProducto.Name = "picImgProducto";
            this.picImgProducto.Size = new System.Drawing.Size(182, 172);
            this.picImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgProducto.TabIndex = 147;
            this.picImgProducto.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.dgvdata);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(934, 262);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Detalles";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTotalProductosNoActivas);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblTotalProductos);
            this.groupBox2.Controls.Add(this.cbobusqueda);
            this.groupBox2.Controls.Add(this.txtbusqueda);
            this.groupBox2.Controls.Add(this.btnlimpiarbuscador);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 50);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 138;
            this.label4.Text = "Prod. No Activos:";
            // 
            // lblTotalProductosNoActivas
            // 
            this.lblTotalProductosNoActivas.AutoSize = true;
            this.lblTotalProductosNoActivas.BackColor = System.Drawing.Color.Red;
            this.lblTotalProductosNoActivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductosNoActivas.Location = new System.Drawing.Point(832, 27);
            this.lblTotalProductosNoActivas.Name = "lblTotalProductosNoActivas";
            this.lblTotalProductosNoActivas.Size = new System.Drawing.Size(44, 16);
            this.lblTotalProductosNoActivas.TabIndex = 137;
            this.lblTotalProductosNoActivas.Text = "Total";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(588, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 15);
            this.label19.TabIndex = 136;
            this.label19.Text = "Total  Prod:";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductos.Location = new System.Drawing.Point(663, 27);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(44, 16);
            this.lblTotalProductos.TabIndex = 135;
            this.lblTotalProductos.Text = "Total";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(6, 18);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(149, 24);
            this.cbobusqueda.TabIndex = 102;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(158, 16);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(265, 26);
            this.txtbusqueda.TabIndex = 105;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.LightSalmon;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 20;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(429, 16);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(53, 26);
            this.btnlimpiarbuscador.TabIndex = 104;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.IdCategoria,
            this.DescripcionCategoria,
            this.IdSubcategoria,
            this.DescripcionSubcategoria,
            this.IdTasaImpuesto,
            this.NumeroPorcentaje,
            this.IdTipoUnidad,
            this.TipoUnidad,
            this.IdProveedor,
            this.NombreProveedor,
            this.Imagen,
            this.CodigoBarras,
            this.Codigo,
            this.DescripcionGeneral,
            this.PrecioCompra,
            this.IdMargenGanancia,
            this.DescripcionPorcentaje,
            this.PrecioFinal,
            this.UbicacionProducto,
            this.StockExistente,
            this.StockMinimo,
            this.EstadoValor,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(-2, 62);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(936, 199);
            this.dgvdata.TabIndex = 99;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            this.IdCategoria.Width = 20;
            // 
            // DescripcionCategoria
            // 
            this.DescripcionCategoria.HeaderText = "Categoria";
            this.DescripcionCategoria.Name = "DescripcionCategoria";
            this.DescripcionCategoria.ReadOnly = true;
            this.DescripcionCategoria.Visible = false;
            // 
            // IdSubcategoria
            // 
            this.IdSubcategoria.HeaderText = "IdSubcategoria";
            this.IdSubcategoria.Name = "IdSubcategoria";
            this.IdSubcategoria.ReadOnly = true;
            this.IdSubcategoria.Visible = false;
            this.IdSubcategoria.Width = 180;
            // 
            // DescripcionSubcategoria
            // 
            this.DescripcionSubcategoria.HeaderText = "Subcategoria";
            this.DescripcionSubcategoria.Name = "DescripcionSubcategoria";
            this.DescripcionSubcategoria.ReadOnly = true;
            this.DescripcionSubcategoria.Visible = false;
            // 
            // IdTasaImpuesto
            // 
            this.IdTasaImpuesto.HeaderText = "IdTasaImpuesto";
            this.IdTasaImpuesto.Name = "IdTasaImpuesto";
            this.IdTasaImpuesto.ReadOnly = true;
            this.IdTasaImpuesto.Visible = false;
            this.IdTasaImpuesto.Width = 160;
            // 
            // NumeroPorcentaje
            // 
            this.NumeroPorcentaje.HeaderText = "IVA";
            this.NumeroPorcentaje.Name = "NumeroPorcentaje";
            this.NumeroPorcentaje.ReadOnly = true;
            this.NumeroPorcentaje.Visible = false;
            this.NumeroPorcentaje.Width = 30;
            // 
            // IdTipoUnidad
            // 
            this.IdTipoUnidad.HeaderText = "IdTipoUnidad";
            this.IdTipoUnidad.Name = "IdTipoUnidad";
            this.IdTipoUnidad.ReadOnly = true;
            this.IdTipoUnidad.Visible = false;
            // 
            // TipoUnidad
            // 
            this.TipoUnidad.HeaderText = "T. Unidad";
            this.TipoUnidad.Name = "TipoUnidad";
            this.TipoUnidad.ReadOnly = true;
            this.TipoUnidad.Visible = false;
            this.TipoUnidad.Width = 85;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            this.IdProveedor.Width = 140;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.HeaderText = "Proveedor";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Visible = false;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.HeaderText = "CodigoBarras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            this.CodigoBarras.Width = 120;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // DescripcionGeneral
            // 
            this.DescripcionGeneral.HeaderText = "DescripcionGeneral";
            this.DescripcionGeneral.Name = "DescripcionGeneral";
            this.DescripcionGeneral.ReadOnly = true;
            this.DescripcionGeneral.Width = 150;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // IdMargenGanancia
            // 
            this.IdMargenGanancia.HeaderText = "IdMargenGanancia";
            this.IdMargenGanancia.Name = "IdMargenGanancia";
            this.IdMargenGanancia.ReadOnly = true;
            this.IdMargenGanancia.Visible = false;
            // 
            // DescripcionPorcentaje
            // 
            this.DescripcionPorcentaje.HeaderText = "Por. Ganancia";
            this.DescripcionPorcentaje.Name = "DescripcionPorcentaje";
            this.DescripcionPorcentaje.ReadOnly = true;
            this.DescripcionPorcentaje.Visible = false;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.HeaderText = "PrecioFinal";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            // 
            // UbicacionProducto
            // 
            this.UbicacionProducto.HeaderText = "UbicacionProducto";
            this.UbicacionProducto.Name = "UbicacionProducto";
            this.UbicacionProducto.ReadOnly = true;
            this.UbicacionProducto.Visible = false;
            // 
            // StockExistente
            // 
            this.StockExistente.HeaderText = "StockExistente";
            this.StockExistente.Name = "StockExistente";
            this.StockExistente.ReadOnly = true;
            // 
            // StockMinimo
            // 
            this.StockMinimo.HeaderText = "StockMinimo";
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // chechgenerarcod
            // 
            this.chechgenerarcod.AutoSize = true;
            this.chechgenerarcod.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chechgenerarcod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chechgenerarcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chechgenerarcod.ForeColor = System.Drawing.Color.Black;
            this.chechgenerarcod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chechgenerarcod.Location = new System.Drawing.Point(250, 28);
            this.chechgenerarcod.Name = "chechgenerarcod";
            this.chechgenerarcod.Size = new System.Drawing.Size(122, 17);
            this.chechgenerarcod.TabIndex = 113;
            this.chechgenerarcod.Text = "Generar Cod Interno";
            this.chechgenerarcod.UseVisualStyleBackColor = false;
            this.chechgenerarcod.CheckedChanged += new System.EventHandler(this.chechgenerarcod_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(368, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 120;
            this.label11.Text = "Categorias: *";
            // 
            // cbocategoria
            // 
            this.cbocategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(371, 20);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(234, 23);
            this.cbocategoria.TabIndex = 121;
            this.cbocategoria.SelectedIndexChanged += new System.EventHandler(this.cbocategoria_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(650, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 15);
            this.label12.TabIndex = 122;
            this.label12.Text = "Sub Categorias / Marca: *";
            // 
            // cbosubcategoria
            // 
            this.cbosubcategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbosubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosubcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosubcategoria.FormattingEnabled = true;
            this.cbosubcategoria.Location = new System.Drawing.Point(653, 22);
            this.cbosubcategoria.Name = "cbosubcategoria";
            this.cbosubcategoria.Size = new System.Drawing.Size(234, 23);
            this.cbosubcategoria.TabIndex = 123;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(8, 64);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(136, 24);
            this.txtcodigo.TabIndex = 125;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 124;
            this.label13.Text = "Código: *";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 17;
            this.btneliminar.Location = new System.Drawing.Point(565, 387);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(165, 26);
            this.btneliminar.TabIndex = 165;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 17;
            this.btnguardar.Location = new System.Drawing.Point(223, 387);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(165, 26);
            this.btnguardar.TabIndex = 163;
            this.btnguardar.Text = "Grabar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Wheat;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 17;
            this.btnlimpiar.Location = new System.Drawing.Point(394, 387);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(165, 26);
            this.btnlimpiar.TabIndex = 164;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(655, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 15);
            this.label23.TabIndex = 167;
            this.label23.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(658, 66);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(165, 24);
            this.cboestado.TabIndex = 166;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(768, 393);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 168;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(736, 393);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 169;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(150, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 145;
            this.label3.Text = "ULT 4 DIGITOS DEL COD.  BARRAS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnAgregarSubCat);
            this.groupBox1.Controls.Add(this.btnAgregarCat);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Controls.Add(this.rbCodigoBarra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboestado);
            this.groupBox1.Controls.Add(this.cbosubcategoria);
            this.groupBox1.Controls.Add(this.txtcodigobarra);
            this.groupBox1.Controls.Add(this.cbocategoria);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chechgenerarcod);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 95);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregarSubCat
            // 
            this.btnAgregarSubCat.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSubCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSubCat.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregarSubCat.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarSubCat.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarSubCat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarSubCat.IconSize = 20;
            this.btnAgregarSubCat.Location = new System.Drawing.Point(888, 22);
            this.btnAgregarSubCat.Name = "btnAgregarSubCat";
            this.btnAgregarSubCat.Size = new System.Drawing.Size(18, 22);
            this.btnAgregarSubCat.TabIndex = 237;
            this.btnAgregarSubCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarSubCat.UseVisualStyleBackColor = false;
            this.btnAgregarSubCat.Click += new System.EventHandler(this.btnAgregarSubCat_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregarCat.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarCat.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarCat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarCat.IconSize = 20;
            this.btnAgregarCat.Location = new System.Drawing.Point(606, 21);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(18, 22);
            this.btnAgregarCat.TabIndex = 236;
            this.btnAgregarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(471, 70);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 16);
            this.rbCodigo.TabIndex = 172;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // rbCodigoBarra
            // 
            this.rbCodigoBarra.AutoSize = true;
            this.rbCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoBarra.Location = new System.Drawing.Point(371, 70);
            this.rbCodigoBarra.Name = "rbCodigoBarra";
            this.rbCodigoBarra.Size = new System.Drawing.Size(94, 16);
            this.rbCodigoBarra.TabIndex = 171;
            this.rbCodigoBarra.TabStop = true;
            this.rbCodigoBarra.Text = "Código Barras";
            this.rbCodigoBarra.UseVisualStyleBackColor = true;
            this.rbCodigoBarra.CheckedChanged += new System.EventHandler(this.rbCodigoBarra_CheckedChanged);
            // 
            // frmCrudProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(966, 417);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCrudProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Productos";
            this.Load += new System.EventHandler(this.frmCrudProducto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigobarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripciongeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalProductosNoActivas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.CheckBox chechgenerarcod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbosubcategoria;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtindice;
        public System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbCodigoBarra;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMargenGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UbicacionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockExistente;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnAgregarSubCat;
        private FontAwesome.Sharp.IconButton btnAgregarCat;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btnAgregarMarGanancia;
        private FontAwesome.Sharp.IconButton btnAgregarImpuestos;
        private FontAwesome.Sharp.IconButton btnAgregarProveedor;
        private System.Windows.Forms.ComboBox cboproveedor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbomargenganancias;
        private System.Windows.Forms.ComboBox cboimpuestos;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtstockexistente;
        private FontAwesome.Sharp.IconButton btnAbrirUnidadMedidas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbotipounidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEleccion1CboUniMed;
        private System.Windows.Forms.TextBox txtstockminimo;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEleccion2CboUniMed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonSinRedondeo;
        private System.Windows.Forms.RadioButton radioButtonRedondeo;
        private System.Windows.Forms.TextBox txtpreciofinal;
        private System.Windows.Forms.Label label20;
        private FontAwesome.Sharp.IconButton btnAgregarImg;
        private System.Windows.Forms.PictureBox picImgProducto;
    }
}