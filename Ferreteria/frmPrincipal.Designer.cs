namespace Ferreteria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tableDash = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btnprincipal = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tableDash.SuspendLayout();
            this.pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDash
            // 
            this.tableDash.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableDash.ColumnCount = 2;
            this.tableDash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableDash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableDash.Controls.Add(this.pnlMenuVertical, 0, 0);
            this.tableDash.Controls.Add(this.panelContenedor, 1, 0);
            this.tableDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDash.Location = new System.Drawing.Point(0, 0);
            this.tableDash.Name = "tableDash";
            this.tableDash.RowCount = 1;
            this.tableDash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDash.Size = new System.Drawing.Size(1008, 467);
            this.tableDash.TabIndex = 0;
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMenuVertical.Controls.Add(this.btnlogoInicio);
            this.pnlMenuVertical.Controls.Add(this.btn_productos);
            this.pnlMenuVertical.Controls.Add(this.btnprincipal);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuVertical.Location = new System.Drawing.Point(6, 6);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(193, 455);
            this.pnlMenuVertical.TabIndex = 0;
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogoInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoInicio.Image")));
            this.btnlogoInicio.Location = new System.Drawing.Point(3, 32);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(184, 120);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 6;
            this.btnlogoInicio.TabStop = false;
            // 
            // btn_productos
            // 
            this.btn_productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_productos.Image")));
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productos.Location = new System.Drawing.Point(3, 269);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(190, 40);
            this.btn_productos.TabIndex = 5;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btnprincipal
            // 
            this.btnprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprincipal.FlatAppearance.BorderSize = 0;
            this.btnprincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprincipal.ForeColor = System.Drawing.Color.White;
            this.btnprincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnprincipal.Image")));
            this.btnprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprincipal.Location = new System.Drawing.Point(6, 202);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnprincipal.Size = new System.Drawing.Size(190, 40);
            this.btnprincipal.TabIndex = 2;
            this.btnprincipal.Text = "Principal";
            this.btnprincipal.UseVisualStyleBackColor = true;
            this.btnprincipal.Click += new System.EventHandler(this.btnprincipal_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(208, 6);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(794, 455);
            this.panelContenedor.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 467);
            this.Controls.Add(this.tableDash);
            this.Name = "frmPrincipal";
            this.Text = "Ferreteria 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tableDash.ResumeLayout(false);
            this.pnlMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableDash;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnprincipal;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.PictureBox btnlogoInicio;
    }
}

