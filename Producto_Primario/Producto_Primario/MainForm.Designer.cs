/*
 * Created by SharpDevelop.
 * User: Rahampery
 * Date: 22/04/2016
 * Time: 07:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Producto_Primario
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnElimina;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripAministrador;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtBoxNombre;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtBoxCorreo;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.TextBox txtBoxApellidos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBoxTelefono;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.TextBox txtBoxDireccion;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtRFC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelProductos;
		private System.Windows.Forms.GroupBox grpBoxDescripcion;
		private System.Windows.Forms.Label lbltTotal;
		private System.Windows.Forms.TextBox txtBoxTotal;
		private System.Windows.Forms.Panel panelTotal;
		private System.Windows.Forms.Panel panelPrecio;
		private System.Windows.Forms.Panel panelCantidad;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBoxCantidad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comBoxProducto;
		private System.Windows.Forms.Button btnCobrar;
		private System.Windows.Forms.GroupBox grpBoxDatosProveedor;
		private System.Windows.Forms.TextBox txtBoxRFCProveedorCompras;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtBoxTelefonoProveedorCompras;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtBoxCorreoProveedorCompras;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBoxNombreProveedorCompras;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtBoxDireccionProveedorCompras;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnLimpiarProveedorCompras;
		private System.Windows.Forms.Button btnBuscarProveedorCompras;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdioBtnGramos;
		private System.Windows.Forms.RadioButton rdioBtnKg;
		private System.Windows.Forms.RadioButton rdioBtnTonelada;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripAlmacen;
		private System.Windows.Forms.ToolStripMenuItem toolStripClientes;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton rdioBtnTCompras;
		private System.Windows.Forms.RadioButton rdioBtnGrCompras;
		private System.Windows.Forms.RadioButton rdioBtnKgCompras;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtBoxCantidadCompra;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnAgregarCompras;
		private System.Windows.Forms.ComboBox comBoxProductoCompra;
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button btnEliminarCompras;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtBoxTotalCompras;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelPrecioCompras;
		private System.Windows.Forms.Panel panelCantidadCompras;
		private System.Windows.Forms.Panel panelProductosCompras;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.grpBoxDescripcion = new System.Windows.Forms.GroupBox();
			this.rdioBtnTonelada = new System.Windows.Forms.RadioButton();
			this.rdioBtnGramos = new System.Windows.Forms.RadioButton();
			this.rdioBtnKg = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBoxCantidad = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comBoxProducto = new System.Windows.Forms.ComboBox();
			this.btnCobrar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnElimina = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbltTotal = new System.Windows.Forms.Label();
			this.txtBoxTotal = new System.Windows.Forms.TextBox();
			this.panelTotal = new System.Windows.Forms.Panel();
			this.panelPrecio = new System.Windows.Forms.Panel();
			this.panelCantidad = new System.Windows.Forms.Panel();
			this.panelProductos = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtRFC = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBoxCorreo = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtBoxApellidos = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBoxTelefono = new System.Windows.Forms.TextBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.txtBoxDireccion = new System.Windows.Forms.TextBox();
			this.txtBoxNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.grpBoxDatosProveedor = new System.Windows.Forms.GroupBox();
			this.btnLimpiarProveedorCompras = new System.Windows.Forms.Button();
			this.btnBuscarProveedorCompras = new System.Windows.Forms.Button();
			this.txtBoxDireccionProveedorCompras = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtBoxRFCProveedorCompras = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtBoxTelefonoProveedorCompras = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtBoxCorreoProveedorCompras = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBoxNombreProveedorCompras = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripAministrador = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripAlmacen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripClientes = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdioBtnTCompras = new System.Windows.Forms.RadioButton();
			this.rdioBtnGrCompras = new System.Windows.Forms.RadioButton();
			this.rdioBtnKgCompras = new System.Windows.Forms.RadioButton();
			this.label14 = new System.Windows.Forms.Label();
			this.txtBoxCantidadCompra = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.btnAgregarCompras = new System.Windows.Forms.Button();
			this.comBoxProductoCompra = new System.Windows.Forms.ComboBox();
			this.btnComprar = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.btnEliminarCompras = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txtBoxTotalCompras = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelPrecioCompras = new System.Windows.Forms.Panel();
			this.panelCantidadCompras = new System.Windows.Forms.Panel();
			this.panelProductosCompras = new System.Windows.Forms.Panel();
			this.label21 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.grpBoxDescripcion.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.grpBoxDatosProveedor.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1305, 692);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.grpBoxDescripcion);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1176, 661);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Vender";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// grpBoxDescripcion
			// 
			this.grpBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.grpBoxDescripcion.Controls.Add(this.rdioBtnTonelada);
			this.grpBoxDescripcion.Controls.Add(this.rdioBtnGramos);
			this.grpBoxDescripcion.Controls.Add(this.rdioBtnKg);
			this.grpBoxDescripcion.Controls.Add(this.label8);
			this.grpBoxDescripcion.Controls.Add(this.txtBoxCantidad);
			this.grpBoxDescripcion.Controls.Add(this.label7);
			this.grpBoxDescripcion.Controls.Add(this.button1);
			this.grpBoxDescripcion.Controls.Add(this.comBoxProducto);
			this.grpBoxDescripcion.Controls.Add(this.btnCobrar);
			this.grpBoxDescripcion.Controls.Add(this.label6);
			this.grpBoxDescripcion.Controls.Add(this.label5);
			this.grpBoxDescripcion.Controls.Add(this.btnElimina);
			this.grpBoxDescripcion.Controls.Add(this.label4);
			this.grpBoxDescripcion.Controls.Add(this.label3);
			this.grpBoxDescripcion.Controls.Add(this.lbltTotal);
			this.grpBoxDescripcion.Controls.Add(this.txtBoxTotal);
			this.grpBoxDescripcion.Controls.Add(this.panelTotal);
			this.grpBoxDescripcion.Controls.Add(this.panelPrecio);
			this.grpBoxDescripcion.Controls.Add(this.panelCantidad);
			this.grpBoxDescripcion.Controls.Add(this.panelProductos);
			this.grpBoxDescripcion.Location = new System.Drawing.Point(6, 153);
			this.grpBoxDescripcion.Name = "grpBoxDescripcion";
			this.grpBoxDescripcion.Size = new System.Drawing.Size(1164, 487);
			this.grpBoxDescripcion.TabIndex = 9;
			this.grpBoxDescripcion.TabStop = false;
			this.grpBoxDescripcion.Text = "Descripción";
			// 
			// rdioBtnTonelada
			// 
			this.rdioBtnTonelada.Location = new System.Drawing.Point(725, 23);
			this.rdioBtnTonelada.Name = "rdioBtnTonelada";
			this.rdioBtnTonelada.Size = new System.Drawing.Size(36, 24);
			this.rdioBtnTonelada.TabIndex = 11;
			this.rdioBtnTonelada.TabStop = true;
			this.rdioBtnTonelada.Text = "T";
			this.rdioBtnTonelada.UseVisualStyleBackColor = true;
			// 
			// rdioBtnGramos
			// 
			this.rdioBtnGramos.Location = new System.Drawing.Point(816, 23);
			this.rdioBtnGramos.Name = "rdioBtnGramos";
			this.rdioBtnGramos.Size = new System.Drawing.Size(44, 24);
			this.rdioBtnGramos.TabIndex = 13;
			this.rdioBtnGramos.TabStop = true;
			this.rdioBtnGramos.Text = "gr";
			this.rdioBtnGramos.UseVisualStyleBackColor = true;
			// 
			// rdioBtnKg
			// 
			this.rdioBtnKg.Location = new System.Drawing.Point(767, 23);
			this.rdioBtnKg.Name = "rdioBtnKg";
			this.rdioBtnKg.Size = new System.Drawing.Size(44, 24);
			this.rdioBtnKg.TabIndex = 12;
			this.rdioBtnKg.TabStop = true;
			this.rdioBtnKg.Text = "Kg";
			this.rdioBtnKg.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(502, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Cantidad:";
			// 
			// txtBoxCantidad
			// 
			this.txtBoxCantidad.Location = new System.Drawing.Point(587, 23);
			this.txtBoxCantidad.Name = "txtBoxCantidad";
			this.txtBoxCantidad.Size = new System.Drawing.Size(123, 24);
			this.txtBoxCantidad.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(120, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Producto:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(912, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 14;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// comBoxProducto
			// 
			this.comBoxProducto.FormattingEnabled = true;
			this.comBoxProducto.Location = new System.Drawing.Point(207, 23);
			this.comBoxProducto.Name = "comBoxProducto";
			this.comBoxProducto.Size = new System.Drawing.Size(284, 26);
			this.comBoxProducto.TabIndex = 9;
			// 
			// btnCobrar
			// 
			this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnCobrar.Location = new System.Drawing.Point(1079, 265);
			this.btnCobrar.MaximumSize = new System.Drawing.Size(150, 117);
			this.btnCobrar.Name = "btnCobrar";
			this.btnCobrar.Size = new System.Drawing.Size(117, 80);
			this.btnCobrar.TabIndex = 15;
			this.btnCobrar.Text = "Cobrar";
			this.btnCobrar.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(936, 63);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(244, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Importe";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(821, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(244, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Precio";
			// 
			// btnElimina
			// 
			this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnElimina.Location = new System.Drawing.Point(1079, 152);
			this.btnElimina.MaximumSize = new System.Drawing.Size(150, 117);
			this.btnElimina.Name = "btnElimina";
			this.btnElimina.Size = new System.Drawing.Size(117, 80);
			this.btnElimina.TabIndex = 14;
			this.btnElimina.Text = "Eliminar";
			this.btnElimina.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(716, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(244, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Cantidad";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Productos";
			// 
			// lbltTotal
			// 
			this.lbltTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbltTotal.Location = new System.Drawing.Point(875, 462);
			this.lbltTotal.Name = "lbltTotal";
			this.lbltTotal.Size = new System.Drawing.Size(50, 23);
			this.lbltTotal.TabIndex = 5;
			this.lbltTotal.Text = "Total: ";
			// 
			// txtBoxTotal
			// 
			this.txtBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxTotal.Enabled = false;
			this.txtBoxTotal.Location = new System.Drawing.Point(931, 459);
			this.txtBoxTotal.Name = "txtBoxTotal";
			this.txtBoxTotal.Size = new System.Drawing.Size(100, 24);
			this.txtBoxTotal.TabIndex = 14;
			// 
			// panelTotal
			// 
			this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panelTotal.AutoScroll = true;
			this.panelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelTotal.Location = new System.Drawing.Point(936, 89);
			this.panelTotal.Name = "panelTotal";
			this.panelTotal.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.panelTotal.Size = new System.Drawing.Size(97, 357);
			this.panelTotal.TabIndex = 3;
			// 
			// panelPrecio
			// 
			this.panelPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panelPrecio.AutoScroll = true;
			this.panelPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelPrecio.Location = new System.Drawing.Point(821, 89);
			this.panelPrecio.Name = "panelPrecio";
			this.panelPrecio.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.panelPrecio.Size = new System.Drawing.Size(109, 357);
			this.panelPrecio.TabIndex = 2;
			// 
			// panelCantidad
			// 
			this.panelCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panelCantidad.AutoScroll = true;
			this.panelCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelCantidad.Location = new System.Drawing.Point(716, 89);
			this.panelCantidad.Name = "panelCantidad";
			this.panelCantidad.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.panelCantidad.Size = new System.Drawing.Size(95, 357);
			this.panelCantidad.TabIndex = 1;
			// 
			// panelProductos
			// 
			this.panelProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panelProductos.AutoScroll = true;
			this.panelProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelProductos.Location = new System.Drawing.Point(36, 89);
			this.panelProductos.Name = "panelProductos";
			this.panelProductos.Padding = new System.Windows.Forms.Padding(5);
			this.panelProductos.Size = new System.Drawing.Size(674, 357);
			this.panelProductos.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnLimpiar);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.txtRFC);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtBoxCorreo);
			this.groupBox1.Controls.Add(this.lblCorreo);
			this.groupBox1.Controls.Add(this.txtBoxApellidos);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtBoxTelefono);
			this.groupBox1.Controls.Add(this.lblTelefono);
			this.groupBox1.Controls.Add(this.lblDireccion);
			this.groupBox1.Controls.Add(this.txtBoxDireccion);
			this.groupBox1.Controls.Add(this.txtBoxNombre);
			this.groupBox1.Controls.Add(this.lblNombre);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1164, 141);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del cliente";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLimpiar.Location = new System.Drawing.Point(926, 89);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(86, 38);
			this.btnLimpiar.TabIndex = 7;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscar.Location = new System.Drawing.Point(1027, 89);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(86, 38);
			this.btnBuscar.TabIndex = 8;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// txtRFC
			// 
			this.txtRFC.Location = new System.Drawing.Point(87, 96);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(186, 24);
			this.txtRFC.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(20, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(311, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "RFC:";
			// 
			// txtBoxCorreo
			// 
			this.txtBoxCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxCorreo.Location = new System.Drawing.Point(875, 57);
			this.txtBoxCorreo.Name = "txtBoxCorreo";
			this.txtBoxCorreo.Size = new System.Drawing.Size(238, 24);
			this.txtBoxCorreo.TabIndex = 5;
			// 
			// lblCorreo
			// 
			this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCorreo.Location = new System.Drawing.Point(793, 57);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(167, 23);
			this.lblCorreo.TabIndex = 11;
			this.lblCorreo.Text = "Correo:";
			// 
			// txtBoxApellidos
			// 
			this.txtBoxApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtBoxApellidos.Location = new System.Drawing.Point(515, 23);
			this.txtBoxApellidos.Name = "txtBoxApellidos";
			this.txtBoxApellidos.Size = new System.Drawing.Size(425, 24);
			this.txtBoxApellidos.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Location = new System.Drawing.Point(445, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Apellidos:";
			// 
			// txtBoxTelefono
			// 
			this.txtBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxTelefono.Location = new System.Drawing.Point(966, 23);
			this.txtBoxTelefono.Name = "txtBoxTelefono";
			this.txtBoxTelefono.Size = new System.Drawing.Size(147, 24);
			this.txtBoxTelefono.TabIndex = 3;
			// 
			// lblTelefono
			// 
			this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTelefono.Location = new System.Drawing.Point(884, 23);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(76, 23);
			this.lblTelefono.TabIndex = 6;
			this.lblTelefono.Text = "Telefono:";
			// 
			// lblDireccion
			// 
			this.lblDireccion.Location = new System.Drawing.Point(5, 60);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(76, 23);
			this.lblDireccion.TabIndex = 4;
			this.lblDireccion.Text = "Dirección:";
			// 
			// txtBoxDireccion
			// 
			this.txtBoxDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxDireccion.Location = new System.Drawing.Point(87, 57);
			this.txtBoxDireccion.Name = "txtBoxDireccion";
			this.txtBoxDireccion.Size = new System.Drawing.Size(686, 24);
			this.txtBoxDireccion.TabIndex = 4;
			// 
			// txtBoxNombre
			// 
			this.txtBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxNombre.Location = new System.Drawing.Point(87, 23);
			this.txtBoxNombre.MaximumSize = new System.Drawing.Size(425, 24);
			this.txtBoxNombre.Name = "txtBoxNombre";
			this.txtBoxNombre.Size = new System.Drawing.Size(424, 24);
			this.txtBoxNombre.TabIndex = 1;
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(5, 23);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(76, 23);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Nombre: ";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.grpBoxDatosProveedor);
			this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1297, 661);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Comprar";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// grpBoxDatosProveedor
			// 
			this.grpBoxDatosProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.grpBoxDatosProveedor.Controls.Add(this.btnLimpiarProveedorCompras);
			this.grpBoxDatosProveedor.Controls.Add(this.btnBuscarProveedorCompras);
			this.grpBoxDatosProveedor.Controls.Add(this.txtBoxDireccionProveedorCompras);
			this.grpBoxDatosProveedor.Controls.Add(this.label13);
			this.grpBoxDatosProveedor.Controls.Add(this.txtBoxRFCProveedorCompras);
			this.grpBoxDatosProveedor.Controls.Add(this.label12);
			this.grpBoxDatosProveedor.Controls.Add(this.txtBoxTelefonoProveedorCompras);
			this.grpBoxDatosProveedor.Controls.Add(this.label11);
			this.grpBoxDatosProveedor.Controls.Add(this.txtBoxCorreoProveedorCompras);
			this.grpBoxDatosProveedor.Controls.Add(this.label10);
			this.grpBoxDatosProveedor.Controls.Add(this.txtBoxNombreProveedorCompras);
			this.grpBoxDatosProveedor.Controls.Add(this.label9);
			this.grpBoxDatosProveedor.Location = new System.Drawing.Point(3, 6);
			this.grpBoxDatosProveedor.Name = "grpBoxDatosProveedor";
			this.grpBoxDatosProveedor.Size = new System.Drawing.Size(1285, 124);
			this.grpBoxDatosProveedor.TabIndex = 0;
			this.grpBoxDatosProveedor.TabStop = false;
			this.grpBoxDatosProveedor.Text = "Datos de proveedor";
			// 
			// btnLimpiarProveedorCompras
			// 
			this.btnLimpiarProveedorCompras.Location = new System.Drawing.Point(869, 66);
			this.btnLimpiarProveedorCompras.Name = "btnLimpiarProveedorCompras";
			this.btnLimpiarProveedorCompras.Size = new System.Drawing.Size(86, 38);
			this.btnLimpiarProveedorCompras.TabIndex = 5;
			this.btnLimpiarProveedorCompras.Text = "Limpiar";
			this.btnLimpiarProveedorCompras.UseVisualStyleBackColor = true;
			// 
			// btnBuscarProveedorCompras
			// 
			this.btnBuscarProveedorCompras.Location = new System.Drawing.Point(987, 66);
			this.btnBuscarProveedorCompras.Name = "btnBuscarProveedorCompras";
			this.btnBuscarProveedorCompras.Size = new System.Drawing.Size(86, 38);
			this.btnBuscarProveedorCompras.TabIndex = 6;
			this.btnBuscarProveedorCompras.Text = "Buscar";
			this.btnBuscarProveedorCompras.UseVisualStyleBackColor = true;
			// 
			// txtBoxDireccionProveedorCompras
			// 
			this.txtBoxDireccionProveedorCompras.Location = new System.Drawing.Point(87, 66);
			this.txtBoxDireccionProveedorCompras.Name = "txtBoxDireccionProveedorCompras";
			this.txtBoxDireccionProveedorCompras.Size = new System.Drawing.Size(686, 24);
			this.txtBoxDireccionProveedorCompras.TabIndex = 4;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(5, 66);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(76, 23);
			this.label13.TabIndex = 8;
			this.label13.Text = "Dirección:";
			// 
			// txtBoxRFCProveedorCompras
			// 
			this.txtBoxRFCProveedorCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxRFCProveedorCompras.Location = new System.Drawing.Point(1127, 23);
			this.txtBoxRFCProveedorCompras.MaximumSize = new System.Drawing.Size(150, 24);
			this.txtBoxRFCProveedorCompras.Name = "txtBoxRFCProveedorCompras";
			this.txtBoxRFCProveedorCompras.Size = new System.Drawing.Size(150, 24);
			this.txtBoxRFCProveedorCompras.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(1081, 23);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(69, 23);
			this.label12.TabIndex = 6;
			this.label12.Text = "RFC:";
			// 
			// txtBoxTelefonoProveedorCompras
			// 
			this.txtBoxTelefonoProveedorCompras.Location = new System.Drawing.Point(926, 22);
			this.txtBoxTelefonoProveedorCompras.MaximumSize = new System.Drawing.Size(147, 24);
			this.txtBoxTelefonoProveedorCompras.Name = "txtBoxTelefonoProveedorCompras";
			this.txtBoxTelefonoProveedorCompras.Size = new System.Drawing.Size(147, 24);
			this.txtBoxTelefonoProveedorCompras.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(856, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(76, 23);
			this.label11.TabIndex = 4;
			this.label11.Text = "Teléfono:";
			// 
			// txtBoxCorreoProveedorCompras
			// 
			this.txtBoxCorreoProveedorCompras.Location = new System.Drawing.Point(586, 23);
			this.txtBoxCorreoProveedorCompras.MaximumSize = new System.Drawing.Size(425, 24);
			this.txtBoxCorreoProveedorCompras.Name = "txtBoxCorreoProveedorCompras";
			this.txtBoxCorreoProveedorCompras.Size = new System.Drawing.Size(261, 24);
			this.txtBoxCorreoProveedorCompras.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(516, 23);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 23);
			this.label10.TabIndex = 2;
			this.label10.Text = "Correo:";
			// 
			// txtBoxNombreProveedorCompras
			// 
			this.txtBoxNombreProveedorCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxNombreProveedorCompras.Location = new System.Drawing.Point(87, 23);
			this.txtBoxNombreProveedorCompras.MaximumSize = new System.Drawing.Size(425, 24);
			this.txtBoxNombreProveedorCompras.Name = "txtBoxNombreProveedorCompras";
			this.txtBoxNombreProveedorCompras.Size = new System.Drawing.Size(425, 24);
			this.txtBoxNombreProveedorCompras.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(5, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 23);
			this.label9.TabIndex = 0;
			this.label9.Text = "Nombre:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripAministrador,
			this.consultarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1329, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripAministrador
			// 
			this.toolStripAministrador.BackColor = System.Drawing.Color.LightGray;
			this.toolStripAministrador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.toolStripAministrador.Name = "toolStripAministrador";
			this.toolStripAministrador.Size = new System.Drawing.Size(103, 21);
			this.toolStripAministrador.Text = "Administrador";
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripAlmacen,
			this.toolStripClientes});
			this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			this.consultarToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
			this.consultarToolStripMenuItem.Text = "Consultar";
			// 
			// toolStripAlmacen
			// 
			this.toolStripAlmacen.Name = "toolStripAlmacen";
			this.toolStripAlmacen.Size = new System.Drawing.Size(200, 22);
			this.toolStripAlmacen.Text = "Almacen";
			// 
			// toolStripClientes
			// 
			this.toolStripClientes.Name = "toolStripClientes";
			this.toolStripClientes.Size = new System.Drawing.Size(200, 22);
			this.toolStripClientes.Text = "Clientes/Proveedores";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.rdioBtnTCompras);
			this.groupBox2.Controls.Add(this.rdioBtnGrCompras);
			this.groupBox2.Controls.Add(this.rdioBtnKgCompras);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtBoxCantidadCompra);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.btnAgregarCompras);
			this.groupBox2.Controls.Add(this.comBoxProductoCompra);
			this.groupBox2.Controls.Add(this.btnComprar);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.btnEliminarCompras);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.txtBoxTotalCompras);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.panelPrecioCompras);
			this.groupBox2.Controls.Add(this.panelCantidadCompras);
			this.groupBox2.Controls.Add(this.panelProductosCompras);
			this.groupBox2.Location = new System.Drawing.Point(6, 134);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1285, 487);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Descripción";
			// 
			// rdioBtnTCompras
			// 
			this.rdioBtnTCompras.Location = new System.Drawing.Point(725, 23);
			this.rdioBtnTCompras.Name = "rdioBtnTCompras";
			this.rdioBtnTCompras.Size = new System.Drawing.Size(36, 24);
			this.rdioBtnTCompras.TabIndex = 9;
			this.rdioBtnTCompras.TabStop = true;
			this.rdioBtnTCompras.Text = "T";
			this.rdioBtnTCompras.UseVisualStyleBackColor = true;
			// 
			// rdioBtnGrCompras
			// 
			this.rdioBtnGrCompras.Location = new System.Drawing.Point(816, 23);
			this.rdioBtnGrCompras.Name = "rdioBtnGrCompras";
			this.rdioBtnGrCompras.Size = new System.Drawing.Size(44, 24);
			this.rdioBtnGrCompras.TabIndex = 11;
			this.rdioBtnGrCompras.TabStop = true;
			this.rdioBtnGrCompras.Text = "gr";
			this.rdioBtnGrCompras.UseVisualStyleBackColor = true;
			// 
			// rdioBtnKgCompras
			// 
			this.rdioBtnKgCompras.Location = new System.Drawing.Point(767, 23);
			this.rdioBtnKgCompras.Name = "rdioBtnKgCompras";
			this.rdioBtnKgCompras.Size = new System.Drawing.Size(44, 24);
			this.rdioBtnKgCompras.TabIndex = 10;
			this.rdioBtnKgCompras.TabStop = true;
			this.rdioBtnKgCompras.Text = "Kg";
			this.rdioBtnKgCompras.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(502, 26);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(79, 23);
			this.label14.TabIndex = 16;
			this.label14.Text = "Cantidad:";
			// 
			// txtBoxCantidadCompra
			// 
			this.txtBoxCantidadCompra.Location = new System.Drawing.Point(587, 23);
			this.txtBoxCantidadCompra.Name = "txtBoxCantidadCompra";
			this.txtBoxCantidadCompra.Size = new System.Drawing.Size(123, 24);
			this.txtBoxCantidadCompra.TabIndex = 8;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(120, 26);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(81, 23);
			this.label15.TabIndex = 15;
			this.label15.Text = "Producto:";
			// 
			// btnAgregarCompras
			// 
			this.btnAgregarCompras.Location = new System.Drawing.Point(1125, 20);
			this.btnAgregarCompras.Name = "btnAgregarCompras";
			this.btnAgregarCompras.Size = new System.Drawing.Size(75, 30);
			this.btnAgregarCompras.TabIndex = 13;
			this.btnAgregarCompras.Text = "Agregar";
			this.btnAgregarCompras.UseVisualStyleBackColor = true;
			// 
			// comBoxProductoCompra
			// 
			this.comBoxProductoCompra.FormattingEnabled = true;
			this.comBoxProductoCompra.Location = new System.Drawing.Point(207, 23);
			this.comBoxProductoCompra.Name = "comBoxProductoCompra";
			this.comBoxProductoCompra.Size = new System.Drawing.Size(284, 26);
			this.comBoxProductoCompra.TabIndex = 7;
			// 
			// btnComprar
			// 
			this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnComprar.Location = new System.Drawing.Point(1079, 265);
			this.btnComprar.MaximumSize = new System.Drawing.Size(150, 117);
			this.btnComprar.Name = "btnComprar";
			this.btnComprar.Size = new System.Drawing.Size(150, 80);
			this.btnComprar.TabIndex = 15;
			this.btnComprar.Text = "Comprar";
			this.btnComprar.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label16.Location = new System.Drawing.Point(936, 63);
			this.label16.Name = "label16";
			this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label16.Size = new System.Drawing.Size(365, 23);
			this.label16.TabIndex = 13;
			this.label16.Text = "Importe";
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label17.Location = new System.Drawing.Point(821, 63);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(365, 23);
			this.label17.TabIndex = 12;
			this.label17.Text = "Precio";
			// 
			// btnEliminarCompras
			// 
			this.btnEliminarCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminarCompras.Location = new System.Drawing.Point(1079, 152);
			this.btnEliminarCompras.MaximumSize = new System.Drawing.Size(150, 117);
			this.btnEliminarCompras.Name = "btnEliminarCompras";
			this.btnEliminarCompras.Size = new System.Drawing.Size(150, 80);
			this.btnEliminarCompras.TabIndex = 14;
			this.btnEliminarCompras.Text = "Eliminar";
			this.btnEliminarCompras.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label18.Location = new System.Drawing.Point(716, 63);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(365, 23);
			this.label18.TabIndex = 11;
			this.label18.Text = "Cantidad";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(36, 63);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 23);
			this.label19.TabIndex = 10;
			this.label19.Text = "Productos";
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label20.Location = new System.Drawing.Point(875, 462);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(50, 23);
			this.label20.TabIndex = 5;
			this.label20.Text = "Total: ";
			// 
			// txtBoxTotalCompras
			// 
			this.txtBoxTotalCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBoxTotalCompras.Enabled = false;
			this.txtBoxTotalCompras.Location = new System.Drawing.Point(931, 459);
			this.txtBoxTotalCompras.Name = "txtBoxTotalCompras";
			this.txtBoxTotalCompras.Size = new System.Drawing.Size(100, 24);
			this.txtBoxTotalCompras.TabIndex = 14;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new System.Drawing.Point(936, 89);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.panel1.Size = new System.Drawing.Size(97, 357);
			this.panel1.TabIndex = 3;
			// 
			// panelPrecioCompras
			// 
			this.panelPrecioCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panelPrecioCompras.AutoScroll = true;
			this.panelPrecioCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelPrecioCompras.Location = new System.Drawing.Point(821, 89);
			this.panelPrecioCompras.Name = "panelPrecioCompras";
			this.panelPrecioCompras.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.panelPrecioCompras.Size = new System.Drawing.Size(109, 357);
			this.panelPrecioCompras.TabIndex = 2;
			// 
			// panelCantidadCompras
			// 
			this.panelCantidadCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panelCantidadCompras.AutoScroll = true;
			this.panelCantidadCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelCantidadCompras.Location = new System.Drawing.Point(716, 89);
			this.panelCantidadCompras.Name = "panelCantidadCompras";
			this.panelCantidadCompras.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.panelCantidadCompras.Size = new System.Drawing.Size(95, 357);
			this.panelCantidadCompras.TabIndex = 1;
			// 
			// panelProductosCompras
			// 
			this.panelProductosCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panelProductosCompras.AutoScroll = true;
			this.panelProductosCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelProductosCompras.Location = new System.Drawing.Point(36, 89);
			this.panelProductosCompras.Name = "panelProductosCompras";
			this.panelProductosCompras.Padding = new System.Windows.Forms.Padding(5);
			this.panelProductosCompras.Size = new System.Drawing.Size(674, 357);
			this.panelProductosCompras.TabIndex = 0;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(876, 26);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(59, 23);
			this.label21.TabIndex = 21;
			this.label21.Text = "Precio:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(942, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 24);
			this.textBox1.TabIndex = 12;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(1071, 26);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(29, 23);
			this.label22.TabIndex = 22;
			this.label22.Text = "Kg";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1329, 731);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CONTROL ESPECIAL DE OPERACIONES DEL CICLO COMERCIAL AZTECA CONFITERIA: CHILES Y C" +
	"ONDIMENTOS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.grpBoxDescripcion.ResumeLayout(false);
			this.grpBoxDescripcion.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.grpBoxDatosProveedor.ResumeLayout(false);
			this.grpBoxDatosProveedor.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
