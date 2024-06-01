namespace WFExamFinalProgramming1
{
    partial class CRUD
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
            this.skuLbl = new System.Windows.Forms.Label();
            this.skuTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.precioCompraTxt = new System.Windows.Forms.NumericUpDown();
            this.precioCompraLbl = new System.Windows.Forms.Label();
            this.precioVentaLbl = new System.Windows.Forms.Label();
            this.precioVentaTxt = new System.Windows.Forms.NumericUpDown();
            this.precioMayoreoLbl = new System.Windows.Forms.Label();
            this.precioMayoreoTxt = new System.Windows.Forms.NumericUpDown();
            this.stockLbl = new System.Windows.Forms.Label();
            this.stockTxt = new System.Windows.Forms.NumericUpDown();
            this.disponibleLbl = new System.Windows.Forms.Label();
            this.disponibleCheck = new System.Windows.Forms.CheckBox();
            this.crearBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.leerBtn = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.Label();
            this.fechaCreacionLbl = new System.Windows.Forms.Label();
            this.fechaActualizacionLbl = new System.Windows.Forms.Label();
            this.fechaCreacionTxt = new System.Windows.Forms.Label();
            this.fechaActualizacionTxt = new System.Windows.Forms.Label();
            this.productosGridView = new System.Windows.Forms.DataGridView();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.reiniciarBtn = new System.Windows.Forms.Button();
            this.totalProductosLbl = new System.Windows.Forms.Label();
            this.totalProductosTxt = new System.Windows.Forms.Label();
            this.buscarTxt = new System.Windows.Forms.TextBox();
            this.filtroLbl = new System.Windows.Forms.Label();
            this.buscarFiltroBtn = new System.Windows.Forms.Button();
            this.activosBtn = new System.Windows.Forms.Button();
            this.inactivosBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.precioCompraTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioVentaTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioMayoreoTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // skuLbl
            // 
            this.skuLbl.AutoSize = true;
            this.skuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skuLbl.Location = new System.Drawing.Point(62, 133);
            this.skuLbl.Name = "skuLbl";
            this.skuLbl.Size = new System.Drawing.Size(66, 25);
            this.skuLbl.TabIndex = 0;
            this.skuLbl.Text = "SKU*";
            // 
            // skuTxt
            // 
            this.skuTxt.BackColor = System.Drawing.SystemColors.Window;
            this.skuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuTxt.Location = new System.Drawing.Point(189, 134);
            this.skuTxt.Name = "skuTxt";
            this.skuTxt.Size = new System.Drawing.Size(134, 26);
            this.skuTxt.TabIndex = 1;
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.SystemColors.Window;
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(189, 92);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(134, 26);
            this.idTxt.TabIndex = 0;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idLbl.Location = new System.Drawing.Point(62, 91);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(33, 25);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "ID";
            // 
            // nombreTxt
            // 
            this.nombreTxt.BackColor = System.Drawing.SystemColors.Window;
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(189, 178);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(304, 26);
            this.nombreTxt.TabIndex = 5;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombreLbl.Location = new System.Drawing.Point(62, 177);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(96, 25);
            this.nombreLbl.TabIndex = 4;
            this.nombreLbl.Text = "Nombre*";
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.BackColor = System.Drawing.SystemColors.Window;
            this.descripcionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTxt.Location = new System.Drawing.Point(189, 222);
            this.descripcionTxt.Multiline = true;
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcionTxt.Size = new System.Drawing.Size(304, 60);
            this.descripcionTxt.TabIndex = 7;
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcionLbl.Location = new System.Drawing.Point(62, 242);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(125, 25);
            this.descripcionLbl.TabIndex = 6;
            this.descripcionLbl.Text = "Descripción";
            // 
            // precioCompraTxt
            // 
            this.precioCompraTxt.DecimalPlaces = 2;
            this.precioCompraTxt.Location = new System.Drawing.Point(724, 91);
            this.precioCompraTxt.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.precioCompraTxt.Name = "precioCompraTxt";
            this.precioCompraTxt.Size = new System.Drawing.Size(130, 20);
            this.precioCompraTxt.TabIndex = 9;
            // 
            // precioCompraLbl
            // 
            this.precioCompraLbl.AutoSize = true;
            this.precioCompraLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioCompraLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precioCompraLbl.Location = new System.Drawing.Point(547, 91);
            this.precioCompraLbl.Name = "precioCompraLbl";
            this.precioCompraLbl.Size = new System.Drawing.Size(193, 25);
            this.precioCompraLbl.TabIndex = 10;
            this.precioCompraLbl.Text = "Precio Compra* Q.";
            // 
            // precioVentaLbl
            // 
            this.precioVentaLbl.AutoSize = true;
            this.precioVentaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioVentaLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precioVentaLbl.Location = new System.Drawing.Point(547, 133);
            this.precioVentaLbl.Name = "precioVentaLbl";
            this.precioVentaLbl.Size = new System.Drawing.Size(174, 25);
            this.precioVentaLbl.TabIndex = 12;
            this.precioVentaLbl.Text = "Precio Venta* Q.";
            // 
            // precioVentaTxt
            // 
            this.precioVentaTxt.DecimalPlaces = 2;
            this.precioVentaTxt.Location = new System.Drawing.Point(724, 133);
            this.precioVentaTxt.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.precioVentaTxt.Name = "precioVentaTxt";
            this.precioVentaTxt.Size = new System.Drawing.Size(130, 20);
            this.precioVentaTxt.TabIndex = 11;
            // 
            // precioMayoreoLbl
            // 
            this.precioMayoreoLbl.AutoSize = true;
            this.precioMayoreoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioMayoreoLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precioMayoreoLbl.Location = new System.Drawing.Point(547, 177);
            this.precioMayoreoLbl.Name = "precioMayoreoLbl";
            this.precioMayoreoLbl.Size = new System.Drawing.Size(192, 25);
            this.precioMayoreoLbl.TabIndex = 14;
            this.precioMayoreoLbl.Text = "Precio Mayoreo Q.";
            // 
            // precioMayoreoTxt
            // 
            this.precioMayoreoTxt.DecimalPlaces = 2;
            this.precioMayoreoTxt.Location = new System.Drawing.Point(724, 177);
            this.precioMayoreoTxt.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.precioMayoreoTxt.Name = "precioMayoreoTxt";
            this.precioMayoreoTxt.Size = new System.Drawing.Size(130, 20);
            this.precioMayoreoTxt.TabIndex = 13;
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockLbl.Location = new System.Drawing.Point(547, 222);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(67, 25);
            this.stockLbl.TabIndex = 16;
            this.stockLbl.Text = "Stock";
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(724, 222);
            this.stockTxt.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(130, 20);
            this.stockTxt.TabIndex = 15;
            // 
            // disponibleLbl
            // 
            this.disponibleLbl.AutoSize = true;
            this.disponibleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponibleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.disponibleLbl.Location = new System.Drawing.Point(547, 262);
            this.disponibleLbl.Name = "disponibleLbl";
            this.disponibleLbl.Size = new System.Drawing.Size(113, 25);
            this.disponibleLbl.TabIndex = 17;
            this.disponibleLbl.Text = "Disponible";
            // 
            // disponibleCheck
            // 
            this.disponibleCheck.AutoSize = true;
            this.disponibleCheck.Location = new System.Drawing.Point(724, 268);
            this.disponibleCheck.Name = "disponibleCheck";
            this.disponibleCheck.Size = new System.Drawing.Size(18, 17);
            this.disponibleCheck.TabIndex = 18;
            this.disponibleCheck.UseVisualStyleBackColor = true;
            // 
            // crearBtn
            // 
            this.crearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.crearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.crearBtn.Location = new System.Drawing.Point(906, 193);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(98, 40);
            this.crearBtn.TabIndex = 19;
            this.crearBtn.Text = "Crear";
            this.crearBtn.UseVisualStyleBackColor = false;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.actualizarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.actualizarBtn.Location = new System.Drawing.Point(1030, 192);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(98, 40);
            this.actualizarBtn.TabIndex = 20;
            this.actualizarBtn.Text = "Actualizar";
            this.actualizarBtn.UseVisualStyleBackColor = false;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.eliminarBtn.Location = new System.Drawing.Point(906, 240);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(98, 40);
            this.eliminarBtn.TabIndex = 21;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // leerBtn
            // 
            this.leerBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.leerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leerBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.leerBtn.Location = new System.Drawing.Point(1030, 240);
            this.leerBtn.Name = "leerBtn";
            this.leerBtn.Size = new System.Drawing.Size(98, 40);
            this.leerBtn.TabIndex = 22;
            this.leerBtn.Text = "Leer";
            this.leerBtn.UseVisualStyleBackColor = false;
            this.leerBtn.Click += new System.EventHandler(this.leerBtn_Click);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tittle.Location = new System.Drawing.Point(57, 23);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(536, 67);
            this.tittle.TabIndex = 23;
            this.tittle.Text = "Productos - CRUD";
            // 
            // fechaCreacionLbl
            // 
            this.fechaCreacionLbl.AutoSize = true;
            this.fechaCreacionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCreacionLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechaCreacionLbl.Location = new System.Drawing.Point(902, 88);
            this.fechaCreacionLbl.Name = "fechaCreacionLbl";
            this.fechaCreacionLbl.Size = new System.Drawing.Size(195, 25);
            this.fechaCreacionLbl.TabIndex = 24;
            this.fechaCreacionLbl.Text = "Fecha de Creación";
            // 
            // fechaActualizacionLbl
            // 
            this.fechaActualizacionLbl.AutoSize = true;
            this.fechaActualizacionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaActualizacionLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechaActualizacionLbl.Location = new System.Drawing.Point(902, 137);
            this.fechaActualizacionLbl.Name = "fechaActualizacionLbl";
            this.fechaActualizacionLbl.Size = new System.Drawing.Size(237, 25);
            this.fechaActualizacionLbl.TabIndex = 25;
            this.fechaActualizacionLbl.Text = "Fecha de Actualización";
            // 
            // fechaCreacionTxt
            // 
            this.fechaCreacionTxt.AutoSize = true;
            this.fechaCreacionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCreacionTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fechaCreacionTxt.Location = new System.Drawing.Point(903, 115);
            this.fechaCreacionTxt.Name = "fechaCreacionTxt";
            this.fechaCreacionTxt.Size = new System.Drawing.Size(40, 20);
            this.fechaCreacionTxt.TabIndex = 26;
            this.fechaCreacionTxt.Text = "N/A";
            // 
            // fechaActualizacionTxt
            // 
            this.fechaActualizacionTxt.AutoSize = true;
            this.fechaActualizacionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaActualizacionTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fechaActualizacionTxt.Location = new System.Drawing.Point(903, 163);
            this.fechaActualizacionTxt.Name = "fechaActualizacionTxt";
            this.fechaActualizacionTxt.Size = new System.Drawing.Size(40, 20);
            this.fechaActualizacionTxt.TabIndex = 27;
            this.fechaActualizacionTxt.Text = "N/A";
            // 
            // productosGridView
            // 
            this.productosGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.productosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosGridView.GridColor = System.Drawing.SystemColors.Window;
            this.productosGridView.Location = new System.Drawing.Point(64, 363);
            this.productosGridView.Name = "productosGridView";
            this.productosGridView.RowHeadersWidth = 51;
            this.productosGridView.Size = new System.Drawing.Size(1064, 316);
            this.productosGridView.TabIndex = 28;
            this.productosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productosGridView_CellContentClick);
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.buscarBtn.Location = new System.Drawing.Point(395, 89);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(98, 40);
            this.buscarBtn.TabIndex = 29;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = false;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // reiniciarBtn
            // 
            this.reiniciarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reiniciarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reiniciarBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.reiniciarBtn.Location = new System.Drawing.Point(1030, 311);
            this.reiniciarBtn.Name = "reiniciarBtn";
            this.reiniciarBtn.Size = new System.Drawing.Size(98, 40);
            this.reiniciarBtn.TabIndex = 30;
            this.reiniciarBtn.Text = "Reiniciar";
            this.reiniciarBtn.UseVisualStyleBackColor = false;
            this.reiniciarBtn.Click += new System.EventHandler(this.reiniciarBtn_Click);
            // 
            // totalProductosLbl
            // 
            this.totalProductosLbl.AutoSize = true;
            this.totalProductosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductosLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.totalProductosLbl.Location = new System.Drawing.Point(961, 44);
            this.totalProductosLbl.Name = "totalProductosLbl";
            this.totalProductosLbl.Size = new System.Drawing.Size(166, 20);
            this.totalProductosLbl.TabIndex = 31;
            this.totalProductosLbl.Text = "Total de productos";
            // 
            // totalProductosTxt
            // 
            this.totalProductosTxt.AutoSize = true;
            this.totalProductosTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductosTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.totalProductosTxt.Location = new System.Drawing.Point(1111, 44);
            this.totalProductosTxt.Name = "totalProductosTxt";
            this.totalProductosTxt.Size = new System.Drawing.Size(19, 20);
            this.totalProductosTxt.TabIndex = 31;
            this.totalProductosTxt.Text = "0";
            // 
            // buscarTxt
            // 
            this.buscarTxt.BackColor = System.Drawing.SystemColors.Window;
            this.buscarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTxt.Location = new System.Drawing.Point(147, 320);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(346, 26);
            this.buscarTxt.TabIndex = 33;
            // 
            // filtroLbl
            // 
            this.filtroLbl.AutoSize = true;
            this.filtroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filtroLbl.Location = new System.Drawing.Point(62, 320);
            this.filtroLbl.Name = "filtroLbl";
            this.filtroLbl.Size = new System.Drawing.Size(60, 25);
            this.filtroLbl.TabIndex = 32;
            this.filtroLbl.Text = "Filtro";
            // 
            // buscarFiltroBtn
            // 
            this.buscarFiltroBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarFiltroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarFiltroBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.buscarFiltroBtn.Location = new System.Drawing.Point(551, 311);
            this.buscarFiltroBtn.Name = "buscarFiltroBtn";
            this.buscarFiltroBtn.Size = new System.Drawing.Size(98, 40);
            this.buscarFiltroBtn.TabIndex = 34;
            this.buscarFiltroBtn.Text = "Buscar";
            this.buscarFiltroBtn.UseVisualStyleBackColor = false;
            this.buscarFiltroBtn.Click += new System.EventHandler(this.buscarFiltroBtn_Click);
            // 
            // activosBtn
            // 
            this.activosBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.activosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activosBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.activosBtn.Location = new System.Drawing.Point(709, 311);
            this.activosBtn.Name = "activosBtn";
            this.activosBtn.Size = new System.Drawing.Size(98, 40);
            this.activosBtn.TabIndex = 35;
            this.activosBtn.Text = "Activos";
            this.activosBtn.UseVisualStyleBackColor = false;
            this.activosBtn.Click += new System.EventHandler(this.activosBtn_Click);
            // 
            // inactivosBtn
            // 
            this.inactivosBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inactivosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivosBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.inactivosBtn.Location = new System.Drawing.Point(873, 311);
            this.inactivosBtn.Name = "inactivosBtn";
            this.inactivosBtn.Size = new System.Drawing.Size(98, 40);
            this.inactivosBtn.TabIndex = 36;
            this.inactivosBtn.Text = "Inactivos";
            this.inactivosBtn.UseVisualStyleBackColor = false;
            this.inactivosBtn.Click += new System.EventHandler(this.inactivosBtn_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.inactivosBtn);
            this.Controls.Add(this.activosBtn);
            this.Controls.Add(this.buscarFiltroBtn);
            this.Controls.Add(this.buscarTxt);
            this.Controls.Add(this.filtroLbl);
            this.Controls.Add(this.totalProductosTxt);
            this.Controls.Add(this.totalProductosLbl);
            this.Controls.Add(this.reiniciarBtn);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.productosGridView);
            this.Controls.Add(this.fechaActualizacionTxt);
            this.Controls.Add(this.fechaCreacionTxt);
            this.Controls.Add(this.fechaActualizacionLbl);
            this.Controls.Add(this.fechaCreacionLbl);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.leerBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.actualizarBtn);
            this.Controls.Add(this.crearBtn);
            this.Controls.Add(this.disponibleCheck);
            this.Controls.Add(this.disponibleLbl);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.stockTxt);
            this.Controls.Add(this.precioMayoreoLbl);
            this.Controls.Add(this.precioMayoreoTxt);
            this.Controls.Add(this.precioVentaLbl);
            this.Controls.Add(this.precioVentaTxt);
            this.Controls.Add(this.precioCompraLbl);
            this.Controls.Add(this.precioCompraTxt);
            this.Controls.Add(this.descripcionTxt);
            this.Controls.Add(this.descripcionLbl);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.skuTxt);
            this.Controls.Add(this.skuLbl);
            this.Name = "CRUD";
            this.Text = "Productos - CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.precioCompraTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioVentaTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioMayoreoTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label skuLbl;
        private System.Windows.Forms.TextBox skuTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.NumericUpDown precioCompraTxt;
        private System.Windows.Forms.Label precioCompraLbl;
        private System.Windows.Forms.Label precioVentaLbl;
        private System.Windows.Forms.NumericUpDown precioVentaTxt;
        private System.Windows.Forms.Label precioMayoreoLbl;
        private System.Windows.Forms.NumericUpDown precioMayoreoTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.NumericUpDown stockTxt;
        private System.Windows.Forms.Label disponibleLbl;
        private System.Windows.Forms.CheckBox disponibleCheck;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button leerBtn;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label fechaCreacionLbl;
        private System.Windows.Forms.Label fechaActualizacionLbl;
        private System.Windows.Forms.Label fechaCreacionTxt;
        private System.Windows.Forms.Label fechaActualizacionTxt;
        private System.Windows.Forms.DataGridView productosGridView;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button reiniciarBtn;
        private System.Windows.Forms.Label totalProductosLbl;
        private System.Windows.Forms.Label totalProductosTxt;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.Label filtroLbl;
        private System.Windows.Forms.Button buscarFiltroBtn;
        private System.Windows.Forms.Button activosBtn;
        private System.Windows.Forms.Button inactivosBtn;
    }
}

