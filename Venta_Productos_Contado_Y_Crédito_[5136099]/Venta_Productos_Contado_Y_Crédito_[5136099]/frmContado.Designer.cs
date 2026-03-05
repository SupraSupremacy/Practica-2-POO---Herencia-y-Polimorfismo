namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    partial class frmContado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCliente = new TextBox();
            label4 = new Label();
            txtRuc = new TextBox();
            label5 = new Label();
            lblFecha = new Label();
            label6 = new Label();
            lblHora = new Label();
            label7 = new Label();
            label8 = new Label();
            cboProducto = new ComboBox();
            label9 = new Label();
            txtCantidad = new TextBox();
            btnAdquirir = new Button();
            lvDetalle = new ListView();
            ITEM = new ColumnHeader();
            DESCRIPCIONDELPRODUCTO = new ColumnHeader();
            CANTIDAD = new ColumnHeader();
            PRECIO = new ColumnHeader();
            SUBTOTAL = new ColumnHeader();
            label10 = new Label();
            lstResumen = new ListBox();
            label11 = new Label();
            lblMonto = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 0;
            label1.Text = "VENTA DE PRODUCTOS AL CONTADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 48);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 0;
            label2.Text = "DATOS DEL CLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 72);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 0;
            label3.Text = "CLIENTE O RAZÓN SOCIAL";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(60, 90);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(321, 23);
            txtCliente.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 72);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 0;
            label4.Text = "RUC";
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(401, 90);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(91, 23);
            txtRuc.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 72);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 0;
            label5.Text = "FECHA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(509, 94);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "FECHA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 72);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 0;
            label6.Text = "HORA";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(634, 94);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(40, 15);
            lblHora.TabIndex = 0;
            lblHora.Text = "HORA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 143);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 0;
            label7.Text = "DATOS DE LA VENTA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 169);
            label8.Name = "label8";
            label8.Size = new Size(159, 15);
            label8.TabIndex = 0;
            label8.Text = "SELECCIONE UN PRODUCTO";
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(60, 196);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(277, 23);
            cboProducto.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 169);
            label9.Name = "label9";
            label9.Size = new Size(134, 15);
            label9.TabIndex = 0;
            label9.Text = "CANTIDAD SOLICITADA";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(376, 196);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(105, 23);
            txtCantidad.TabIndex = 3;
            // 
            // btnAdquirir
            // 
            btnAdquirir.Location = new Point(577, 161);
            btnAdquirir.Name = "btnAdquirir";
            btnAdquirir.Size = new Size(123, 23);
            btnAdquirir.TabIndex = 4;
            btnAdquirir.Text = "ADQUIRIR";
            btnAdquirir.UseVisualStyleBackColor = true;
            btnAdquirir.Click += btnAdquirir_Click;
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { ITEM, DESCRIPCIONDELPRODUCTO, CANTIDAD, PRECIO, SUBTOTAL });
            lvDetalle.Location = new Point(60, 241);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(640, 97);
            lvDetalle.TabIndex = 5;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            // 
            // ITEM
            // 
            ITEM.Text = "ITEM";
            // 
            // DESCRIPCIONDELPRODUCTO
            // 
            DESCRIPCIONDELPRODUCTO.Text = "DESCRIPCIÓN DEL PRODUCTO";
            DESCRIPCIONDELPRODUCTO.Width = 200;
            // 
            // CANTIDAD
            // 
            CANTIDAD.Text = "CANTIDAD";
            CANTIDAD.Width = 170;
            // 
            // PRECIO
            // 
            PRECIO.Text = "PRECIO";
            PRECIO.Width = 120;
            // 
            // SUBTOTAL
            // 
            SUBTOTAL.Text = "SUBTOTAL";
            SUBTOTAL.Width = 85;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 357);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 6;
            label10.Text = "RESUMEN";
            // 
            // lstResumen
            // 
            lstResumen.FormattingEnabled = true;
            lstResumen.Location = new Point(60, 375);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(300, 124);
            lstResumen.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(543, 357);
            label11.Name = "label11";
            label11.Size = new Size(88, 15);
            label11.TabIndex = 6;
            label11.Text = "NETO A PAGAR";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(543, 386);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(88, 15);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "NETO A PAGAR";
            // 
            // frmContado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(lstResumen);
            Controls.Add(lblMonto);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(lvDetalle);
            Controls.Add(btnAdquirir);
            Controls.Add(txtCantidad);
            Controls.Add(cboProducto);
            Controls.Add(txtRuc);
            Controls.Add(txtCliente);
            Controls.Add(lblHora);
            Controls.Add(label6);
            Controls.Add(lblFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmContado";
            Text = "frmContado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCliente;
        private Label label4;
        private TextBox txtRuc;
        private Label label5;
        private Label lblFecha;
        private Label label6;
        private Label lblHora;
        private Label label7;
        private Label label8;
        private ComboBox cboProducto;
        private Label label9;
        private TextBox txtCantidad;
        private Button btnAdquirir;
        private ListView lvDetalle;
        private ColumnHeader ITEM;
        private ColumnHeader DESCRIPCIONDELPRODUCTO;
        private ColumnHeader CANTIDAD;
        private ColumnHeader PRECIO;
        private ColumnHeader SUBTOTAL;
        private Label label10;
        private ListBox lstResumen;
        private Label label11;
        private Label lblMonto;
    }
}