
namespace Capa_vista_pedido
{
    partial class frm_pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pedidos));
            this.Cbo_buscadorE = new System.Windows.Forms.ComboBox();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Txt_precion = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.Txt_cantidadn = new System.Windows.Forms.Label();
            this.Cbo_producto = new System.Windows.Forms.ComboBox();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_nuevoCE = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Btn_buscarE = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_producton = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_fechaV = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_tipCliente = new System.Windows.Forms.Label();
            this.Txt_cotizacion = new System.Windows.Forms.TextBox();
            this.Txt_ClienteB = new System.Windows.Forms.TextBox();
            this.Txt_idEncezado = new System.Windows.Forms.TextBox();
            this.Dtp_fechaC = new System.Windows.Forms.DateTimePicker();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Txt_FechaVencimiento = new System.Windows.Forms.Label();
            this.Txt_Clienten = new System.Windows.Forms.Label();
            this.Txt_Vendedorn = new System.Windows.Forms.Label();
            this.Txt_idE = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Txt_totaln = new System.Windows.Forms.Label();
            this.Dgv_pedido = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbo_buscadorE
            // 
            this.Cbo_buscadorE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_buscadorE.FormattingEnabled = true;
            this.Cbo_buscadorE.Location = new System.Drawing.Point(89, 38);
            this.Cbo_buscadorE.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_buscadorE.Name = "Cbo_buscadorE";
            this.Cbo_buscadorE.Size = new System.Drawing.Size(160, 27);
            this.Cbo_buscadorE.TabIndex = 315;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 125;
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(787, 36);
            this.Txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(101, 30);
            this.Txt_cantidad.TabIndex = 11;
            // 
            // Txt_precion
            // 
            this.Txt_precion.AutoSize = true;
            this.Txt_precion.Location = new System.Drawing.Point(441, 35);
            this.Txt_precion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_precion.Name = "Txt_precion";
            this.Txt_precion.Size = new System.Drawing.Size(62, 22);
            this.Txt_precion.TabIndex = 31;
            this.Txt_precion.Text = "Precio";
            // 
            // Txt_precio
            // 
            this.Txt_precio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precio.Location = new System.Drawing.Point(517, 33);
            this.Txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(160, 26);
            this.Txt_precio.TabIndex = 30;
            // 
            // Txt_cantidadn
            // 
            this.Txt_cantidadn.AutoSize = true;
            this.Txt_cantidadn.Location = new System.Drawing.Point(698, 38);
            this.Txt_cantidadn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_cantidadn.Name = "Txt_cantidadn";
            this.Txt_cantidadn.Size = new System.Drawing.Size(81, 22);
            this.Txt_cantidadn.TabIndex = 29;
            this.Txt_cantidadn.Text = "Cantidad";
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_producto.FormattingEnabled = true;
            this.Cbo_producto.Location = new System.Drawing.Point(105, 34);
            this.Cbo_producto.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(305, 27);
            this.Cbo_producto.TabIndex = 10;
            this.Cbo_producto.SelectedIndexChanged += new System.EventHandler(this.Cbo_producto_SelectedIndexChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 10;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(233, 111);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(81, 65);
            this.Btn_cancelar.TabIndex = 320;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_nuevoCE
            // 
            this.Btn_nuevoCE.BackColor = System.Drawing.Color.Transparent;
            this.Btn_nuevoCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevoCE.FlatAppearance.BorderSize = 0;
            this.Btn_nuevoCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevoCE.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nuevoCE.Image")));
            this.Btn_nuevoCE.Location = new System.Drawing.Point(100, 111);
            this.Btn_nuevoCE.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_nuevoCE.Name = "Btn_nuevoCE";
            this.Btn_nuevoCE.Size = new System.Drawing.Size(81, 65);
            this.Btn_nuevoCE.TabIndex = 319;
            this.Btn_nuevoCE.UseVisualStyleBackColor = false;
            this.Btn_nuevoCE.Click += new System.EventHandler(this.Btn_nuevoCE_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.Transparent;
            this.Btn_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_reporte.FlatAppearance.BorderSize = 0;
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reporte.Image")));
            this.Btn_reporte.Location = new System.Drawing.Point(923, 119);
            this.Btn_reporte.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(57, 54);
            this.Btn_reporte.TabIndex = 318;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(792, 119);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(56, 48);
            this.Btn_ayuda.TabIndex = 317;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F);
            this.Txt_titulo.Location = new System.Drawing.Point(455, 20);
            this.Txt_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(175, 45);
            this.Txt_titulo.TabIndex = 316;
            this.Txt_titulo.Text = "P E D I D O S";
            // 
            // Btn_buscarE
            // 
            this.Btn_buscarE.BackColor = System.Drawing.Color.Transparent;
            this.Btn_buscarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buscarE.FlatAppearance.BorderSize = 0;
            this.Btn_buscarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscarE.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscarE.Image")));
            this.Btn_buscarE.Location = new System.Drawing.Point(286, 18);
            this.Btn_buscarE.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_buscarE.Name = "Btn_buscarE";
            this.Btn_buscarE.Size = new System.Drawing.Size(81, 65);
            this.Btn_buscarE.TabIndex = 315;
            this.Btn_buscarE.UseVisualStyleBackColor = false;
            this.Btn_buscarE.Click += new System.EventHandler(this.Btn_buscarE_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox3.Controls.Add(this.Cbo_buscadorE);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Btn_buscarE);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(351, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(399, 92);
            this.groupBox3.TabIndex = 314;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Cotización";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "No";
            // 
            // Txt_producton
            // 
            this.Txt_producton.AutoSize = true;
            this.Txt_producton.Location = new System.Drawing.Point(11, 38);
            this.Txt_producton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_producton.Name = "Txt_producton";
            this.Txt_producton.Size = new System.Drawing.Size(81, 22);
            this.Txt_producton.TabIndex = 9;
            this.Txt_producton.Text = "Producto";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dtp_fechaV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_tipCliente);
            this.groupBox1.Controls.Add(this.Txt_cotizacion);
            this.groupBox1.Controls.Add(this.Txt_ClienteB);
            this.groupBox1.Controls.Add(this.Txt_idEncezado);
            this.groupBox1.Controls.Add(this.Dtp_fechaC);
            this.groupBox1.Controls.Add(this.Cbo_cliente);
            this.groupBox1.Controls.Add(this.Cbo_vendedor);
            this.groupBox1.Controls.Add(this.Txt_FechaVencimiento);
            this.groupBox1.Controls.Add(this.Txt_Clienten);
            this.groupBox1.Controls.Add(this.Txt_Vendedorn);
            this.groupBox1.Controls.Add(this.Txt_idE);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(984, 169);
            this.groupBox1.TabIndex = 313;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(876, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 327;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 326;
            this.label1.Text = "Id_cotizacion";
            // 
            // Dtp_fechaV
            // 
            this.Dtp_fechaV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaV.Location = new System.Drawing.Point(547, 113);
            this.Dtp_fechaV.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_fechaV.Name = "Dtp_fechaV";
            this.Dtp_fechaV.Size = new System.Drawing.Size(265, 26);
            this.Dtp_fechaV.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // Txt_tipCliente
            // 
            this.Txt_tipCliente.AutoSize = true;
            this.Txt_tipCliente.Location = new System.Drawing.Point(800, 42);
            this.Txt_tipCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_tipCliente.Name = "Txt_tipCliente";
            this.Txt_tipCliente.Size = new System.Drawing.Size(47, 22);
            this.Txt_tipCliente.TabIndex = 29;
            this.Txt_tipCliente.Text = "Tipo";
            // 
            // Txt_cotizacion
            // 
            this.Txt_cotizacion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cotizacion.Location = new System.Drawing.Point(64, 116);
            this.Txt_cotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_cotizacion.Name = "Txt_cotizacion";
            this.Txt_cotizacion.Size = new System.Drawing.Size(160, 26);
            this.Txt_cotizacion.TabIndex = 325;
            // 
            // Txt_ClienteB
            // 
            this.Txt_ClienteB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ClienteB.Location = new System.Drawing.Point(855, 38);
            this.Txt_ClienteB.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ClienteB.Name = "Txt_ClienteB";
            this.Txt_ClienteB.Size = new System.Drawing.Size(112, 26);
            this.Txt_ClienteB.TabIndex = 29;
            // 
            // Txt_idEncezado
            // 
            this.Txt_idEncezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idEncezado.Location = new System.Drawing.Point(64, 37);
            this.Txt_idEncezado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_idEncezado.Name = "Txt_idEncezado";
            this.Txt_idEncezado.Size = new System.Drawing.Size(160, 26);
            this.Txt_idEncezado.TabIndex = 9;
            // 
            // Dtp_fechaC
            // 
            this.Dtp_fechaC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaC.Location = new System.Drawing.Point(257, 116);
            this.Dtp_fechaC.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_fechaC.Name = "Dtp_fechaC";
            this.Dtp_fechaC.Size = new System.Drawing.Size(265, 26);
            this.Dtp_fechaC.TabIndex = 6;
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(619, 37);
            this.Cbo_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(160, 27);
            this.Cbo_cliente.TabIndex = 5;
            this.Cbo_cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_cliente_SelectedIndexChanged);
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(343, 37);
            this.Cbo_vendedor.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(160, 27);
            this.Cbo_vendedor.TabIndex = 4;
            this.Cbo_vendedor.SelectedIndexChanged += new System.EventHandler(this.Cbo_vendedor_SelectedIndexChanged);
            // 
            // Txt_FechaVencimiento
            // 
            this.Txt_FechaVencimiento.AutoSize = true;
            this.Txt_FechaVencimiento.Location = new System.Drawing.Point(253, 90);
            this.Txt_FechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_FechaVencimiento.Name = "Txt_FechaVencimiento";
            this.Txt_FechaVencimiento.Size = new System.Drawing.Size(130, 22);
            this.Txt_FechaVencimiento.TabIndex = 3;
            this.Txt_FechaVencimiento.Text = "Fecha creacion";
            // 
            // Txt_Clienten
            // 
            this.Txt_Clienten.AutoSize = true;
            this.Txt_Clienten.Location = new System.Drawing.Point(543, 42);
            this.Txt_Clienten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Clienten.Name = "Txt_Clienten";
            this.Txt_Clienten.Size = new System.Drawing.Size(67, 22);
            this.Txt_Clienten.TabIndex = 2;
            this.Txt_Clienten.Text = "Cliente";
            // 
            // Txt_Vendedorn
            // 
            this.Txt_Vendedorn.AutoSize = true;
            this.Txt_Vendedorn.Location = new System.Drawing.Point(253, 42);
            this.Txt_Vendedorn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Vendedorn.Name = "Txt_Vendedorn";
            this.Txt_Vendedorn.Size = new System.Drawing.Size(85, 22);
            this.Txt_Vendedorn.TabIndex = 1;
            this.Txt_Vendedorn.Text = "Vendedor";
            // 
            // Txt_idE
            // 
            this.Txt_idE.AutoSize = true;
            this.Txt_idE.Location = new System.Drawing.Point(11, 38);
            this.Txt_idE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_idE.Name = "Txt_idE";
            this.Txt_idE.Size = new System.Drawing.Size(30, 22);
            this.Txt_idE.TabIndex = 0;
            this.Txt_idE.Text = "ID";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(783, 326);
            this.Txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(142, 26);
            this.Txt_total.TabIndex = 26;
            // 
            // Txt_totaln
            // 
            this.Txt_totaln.AutoSize = true;
            this.Txt_totaln.Location = new System.Drawing.Point(783, 291);
            this.Txt_totaln.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_totaln.Name = "Txt_totaln";
            this.Txt_totaln.Size = new System.Drawing.Size(51, 22);
            this.Txt_totaln.TabIndex = 27;
            this.Txt_totaln.Text = "Total";
            // 
            // Dgv_pedido
            // 
            this.Dgv_pedido.AllowUserToAddRows = false;
            this.Dgv_pedido.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.Dgv_pedido.Location = new System.Drawing.Point(22, 85);
            this.Dgv_pedido.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_pedido.Name = "Dgv_pedido";
            this.Dgv_pedido.RowHeadersWidth = 51;
            this.Dgv_pedido.Size = new System.Drawing.Size(722, 266);
            this.Dgv_pedido.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox2.Controls.Add(this.Btn_agregar);
            this.groupBox2.Controls.Add(this.Btn_borrar);
            this.groupBox2.Controls.Add(this.Dgv_pedido);
            this.groupBox2.Controls.Add(this.Txt_cantidad);
            this.groupBox2.Controls.Add(this.Txt_precion);
            this.groupBox2.Controls.Add(this.Txt_precio);
            this.groupBox2.Controls.Add(this.Txt_cantidadn);
            this.groupBox2.Controls.Add(this.Cbo_producto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_producton);
            this.groupBox2.Controls.Add(this.Txt_totaln);
            this.groupBox2.Controls.Add(this.Txt_total);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 374);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(984, 370);
            this.groupBox2.TabIndex = 315;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregar.Image")));
            this.Btn_agregar.Location = new System.Drawing.Point(787, 109);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(81, 65);
            this.Btn_agregar.TabIndex = 324;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_borrar.FlatAppearance.BorderSize = 0;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.Location = new System.Drawing.Point(787, 196);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(81, 65);
            this.Btn_borrar.TabIndex = 315;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // frm_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 763);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_nuevoCE);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_pedidos";
            this.Text = "frm_pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_buscadorE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.NumericUpDown Txt_cantidad;
        private System.Windows.Forms.Label Txt_precion;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label Txt_cantidadn;
        private System.Windows.Forms.ComboBox Cbo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_nuevoCE;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Button Btn_buscarE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Txt_producton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dtp_fechaV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Txt_tipCliente;
        private System.Windows.Forms.TextBox Txt_ClienteB;
        private System.Windows.Forms.TextBox Txt_idEncezado;
        private System.Windows.Forms.DateTimePicker Dtp_fechaC;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Txt_FechaVencimiento;
        private System.Windows.Forms.Label Txt_Clienten;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label Txt_totaln;
        private System.Windows.Forms.Label Txt_Vendedorn;
        private System.Windows.Forms.Label Txt_idE;
        private System.Windows.Forms.DataGridView Dgv_pedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_cotizacion;
        private System.Windows.Forms.Button button1;
    }
}