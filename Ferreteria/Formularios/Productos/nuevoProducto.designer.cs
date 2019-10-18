namespace Ferreteria.Formularios.Productos
{
    partial class nuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcb_Imagen = new System.Windows.Forms.PictureBox();
            this.btn_borrarImagen = new System.Windows.Forms.Button();
            this.btn_cargarImagen = new System.Windows.Forms.Button();
            this.txb_precioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_activo = new System.Windows.Forms.CheckBox();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.toolTip1_chkLibre = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btninsertarcategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio_sin_iva = new System.Windows.Forms.TextBox();
            this.txt_precio_con_iva = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = " Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(90, 18);
            this.txt_codigo.MaxLength = 30;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(198, 27);
            this.txt_codigo.TabIndex = 0;
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descripcion.Location = new System.Drawing.Point(12, 123);
            this.txb_descripcion.MaxLength = 100;
            this.txb_descripcion.Multiline = true;
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.Size = new System.Drawing.Size(334, 50);
            this.txb_descripcion.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pcb_Imagen);
            this.groupBox1.Controls.Add(this.btn_borrarImagen);
            this.groupBox1.Controls.Add(this.btn_cargarImagen);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(368, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 329);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // pcb_Imagen
            // 
            this.pcb_Imagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb_Imagen.BackgroundImage")));
            this.pcb_Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_Imagen.Location = new System.Drawing.Point(7, 53);
            this.pcb_Imagen.Name = "pcb_Imagen";
            this.pcb_Imagen.Size = new System.Drawing.Size(296, 244);
            this.pcb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Imagen.TabIndex = 2;
            this.pcb_Imagen.TabStop = false;
            // 
            // btn_borrarImagen
            // 
            this.btn_borrarImagen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarImagen.ForeColor = System.Drawing.Color.Black;
            this.btn_borrarImagen.Location = new System.Drawing.Point(127, 20);
            this.btn_borrarImagen.Name = "btn_borrarImagen";
            this.btn_borrarImagen.Size = new System.Drawing.Size(104, 27);
            this.btn_borrarImagen.TabIndex = 1;
            this.btn_borrarImagen.Text = "Borrar Imagen";
            this.btn_borrarImagen.UseVisualStyleBackColor = true;
            this.btn_borrarImagen.Click += new System.EventHandler(this.btn_borrarImagen_Click);
            // 
            // btn_cargarImagen
            // 
            this.btn_cargarImagen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargarImagen.ForeColor = System.Drawing.Color.Black;
            this.btn_cargarImagen.Location = new System.Drawing.Point(7, 20);
            this.btn_cargarImagen.Name = "btn_cargarImagen";
            this.btn_cargarImagen.Size = new System.Drawing.Size(104, 27);
            this.btn_cargarImagen.TabIndex = 0;
            this.btn_cargarImagen.Text = "Cargar Imagen";
            this.btn_cargarImagen.UseVisualStyleBackColor = true;
            this.btn_cargarImagen.Click += new System.EventHandler(this.btn_cargarImagen_Click);
            // 
            // txb_precioVenta
            // 
            this.txb_precioVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_precioVenta.Location = new System.Drawing.Point(160, 360);
            this.txb_precioVenta.MaxLength = 10;
            this.txb_precioVenta.Name = "txb_precioVenta";
            this.txb_precioVenta.Size = new System.Drawing.Size(96, 27);
            this.txb_precioVenta.TabIndex = 6;
            this.txb_precioVenta.Text = "0,00";
            this.txb_precioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_precioVenta.Click += new System.EventHandler(this.txb_precioVenta_Click);
            this.txb_precioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_precioVenta_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Precio con Iva:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(470, 460);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(98, 40);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(574, 460);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(103, 40);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelarClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Precio de venta:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(115, 198);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(173, 26);
            this.cmb_categoria.TabIndex = 3;
            this.cmb_categoria.Text = "Seleccione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stock:";
            // 
            // txb_Stock
            // 
            this.txb_Stock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Stock.Location = new System.Drawing.Point(83, 415);
            this.txb_Stock.MaxLength = 10;
            this.txb_Stock.Name = "txb_Stock";
            this.txb_Stock.Size = new System.Drawing.Size(60, 27);
            this.txb_Stock.TabIndex = 7;
            this.txb_Stock.Text = "0";
            this.txb_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Stock.Click += new System.EventHandler(this.txb_Stock_Click);
            this.txb_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Stock_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Estado:";
            // 
            // chk_activo
            // 
            this.chk_activo.AutoSize = true;
            this.chk_activo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_activo.Location = new System.Drawing.Point(83, 468);
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Size = new System.Drawing.Size(77, 22);
            this.chk_activo.TabIndex = 9;
            this.chk_activo.Text = "Activo";
            this.chk_activo.UseVisualStyleBackColor = true;
            this.chk_activo.CheckedChanged += new System.EventHandler(this.chk_activo_CheckedChanged);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mensaje.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_mensaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.ForeColor = System.Drawing.Color.White;
            this.lbl_mensaje.Location = new System.Drawing.Point(-3, 510);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(696, 27);
            this.lbl_mensaje.TabIndex = 23;
            this.lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btninsertarcategoria
            // 
            this.btninsertarcategoria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertarcategoria.ForeColor = System.Drawing.Color.Black;
            this.btninsertarcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btninsertarcategoria.Image")));
            this.btninsertarcategoria.Location = new System.Drawing.Point(303, 198);
            this.btninsertarcategoria.Name = "btninsertarcategoria";
            this.btninsertarcategoria.Size = new System.Drawing.Size(27, 26);
            this.btninsertarcategoria.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btninsertarcategoria, "Añadir Categoria");
            this.btninsertarcategoria.UseVisualStyleBackColor = true;
            this.btninsertarcategoria.Click += new System.EventHandler(this.btninsertarcategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(90, 62);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(198, 27);
            this.txt_nombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Precio sin Iva:";
            // 
            // txt_precio_sin_iva
            // 
            this.txt_precio_sin_iva.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_sin_iva.Location = new System.Drawing.Point(160, 254);
            this.txt_precio_sin_iva.MaxLength = 10;
            this.txt_precio_sin_iva.Name = "txt_precio_sin_iva";
            this.txt_precio_sin_iva.Size = new System.Drawing.Size(96, 27);
            this.txt_precio_sin_iva.TabIndex = 4;
            this.txt_precio_sin_iva.Text = "0,00";
            this.txt_precio_sin_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precio_sin_iva.Click += new System.EventHandler(this.txt_precio_sin_iva_Click);
            this.txt_precio_sin_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_sin_iva_KeyPress);
            // 
            // txt_precio_con_iva
            // 
            this.txt_precio_con_iva.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_con_iva.Location = new System.Drawing.Point(160, 311);
            this.txt_precio_con_iva.MaxLength = 10;
            this.txt_precio_con_iva.Name = "txt_precio_con_iva";
            this.txt_precio_con_iva.Size = new System.Drawing.Size(96, 27);
            this.txt_precio_con_iva.TabIndex = 5;
            this.txt_precio_con_iva.Text = "0,00";
            this.txt_precio_con_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precio_con_iva.Click += new System.EventHandler(this.txt_precio_con_iva_Click);
            this.txt_precio_con_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_con_iva_KeyPress);
            // 
            // nuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 538);
            this.Controls.Add(this.txt_precio_con_iva);
            this.Controls.Add(this.txt_precio_sin_iva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btninsertarcategoria);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.chk_activo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_Stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txb_precioVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txb_descripcion);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "nuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nuevoProducto_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txb_descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_borrarImagen;
        private System.Windows.Forms.Button btn_cargarImagen;
        private System.Windows.Forms.PictureBox pcb_Imagen;
        private System.Windows.Forms.TextBox txb_precioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_activo;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.ToolTip toolTip1_chkLibre;
        private System.Windows.Forms.Button btninsertarcategoria;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precio_sin_iva;
        private System.Windows.Forms.TextBox txt_precio_con_iva;
    }
}