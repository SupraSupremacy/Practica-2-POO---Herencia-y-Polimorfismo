namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    partial class frmCredito
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
            lvDetalle = new ListView();
            ITEM = new ColumnHeader();
            DESCRIPCIONDELPRODUCTO = new ColumnHeader();
            CANTIDAD = new ColumnHeader();
            PRECIO = new ColumnHeader();
            SUBTOTAL = new ColumnHeader();
            btnAdquirir = new Button();
            txtCantidad = new TextBox();
            cboProducto = new ComboBox();
            txtRuc = new TextBox();
            txtCliente = new TextBox();
            lblHora = new Label();
            label6 = new Label();
            lblFecha = new Label();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            cboLetras = new ComboBox();
            btnMostrar = new Button();
            lvResumen = new ListView();
            NLetra = new ColumnHeader();
            Monto = new ColumnHeader();
            lblMonto = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "DATOS DEL CLIENTE";
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { ITEM, DESCRIPCIONDELPRODUCTO, CANTIDAD, PRECIO, SUBTOTAL });
            lvDetalle.Location = new Point(60, 205);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(640, 97);
            lvDetalle.TabIndex = 21;
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
            // btnAdquirir
            // 
            btnAdquirir.Location = new Point(577, 125);
            btnAdquirir.Name = "btnAdquirir";
            btnAdquirir.Size = new Size(123, 23);
            btnAdquirir.TabIndex = 20;
            btnAdquirir.Text = "ADQUIRIR";
            btnAdquirir.UseVisualStyleBackColor = true;
            btnAdquirir.Click += btnAdquirir_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(376, 160);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(105, 23);
            txtCantidad.TabIndex = 19;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(60, 160);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(277, 23);
            cboProducto.TabIndex = 18;
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(401, 54);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(91, 23);
            txtRuc.TabIndex = 16;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(60, 54);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(321, 23);
            txtCliente.TabIndex = 17;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(634, 58);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(40, 15);
            lblHora.TabIndex = 6;
            lblHora.Text = "HORA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 36);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 7;
            label6.Text = "HORA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(509, 58);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "FECHA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 36);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 36);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 10;
            label4.Text = "RUC";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 133);
            label9.Name = "label9";
            label9.Size = new Size(134, 15);
            label9.TabIndex = 11;
            label9.Text = "CANTIDAD SOLICITADA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 133);
            label8.Name = "label8";
            label8.Size = new Size(159, 15);
            label8.TabIndex = 12;
            label8.Text = "SELECCIONE UN PRODUCTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 107);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 13;
            label7.Text = "DATOS DE LA VENTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 36);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 14;
            label3.Text = "CLIENTE O RAZÓN SOCIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 324);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 13;
            label2.Text = "OPCIONES DEL CRÉDITO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 350);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 13;
            label10.Text = "Seleccionar letras";
            // 
            // cboLetras
            // 
            cboLetras.FormattingEnabled = true;
            cboLetras.Location = new Point(60, 368);
            cboLetras.Name = "cboLetras";
            cboLetras.Size = new Size(121, 23);
            cboLetras.TabIndex = 22;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(60, 397);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(150, 23);
            btnMostrar.TabIndex = 23;
            btnMostrar.Text = "MOSTRAR RESUMEN";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lvResumen
            // 
            lvResumen.Columns.AddRange(new ColumnHeader[] { NLetra, Monto });
            lvResumen.Location = new Point(260, 324);
            lvResumen.Name = "lvResumen";
            lvResumen.Size = new Size(293, 96);
            lvResumen.TabIndex = 24;
            lvResumen.UseCompatibleStateImageBehavior = false;
            lvResumen.View = View.Details;
            // 
            // NLetra
            // 
            NLetra.Text = "N° Letra";
            NLetra.Width = 165;
            // 
            // Monto
            // 
            Monto.Text = "Monto";
            Monto.Width = 124;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(598, 350);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(88, 15);
            lblMonto.TabIndex = 25;
            lblMonto.Text = "NETO A PAGAR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(598, 324);
            label11.Name = "label11";
            label11.Size = new Size(102, 15);
            label11.TabIndex = 26;
            label11.Text = "MONTO A PAGAR";
            // 
            // frmCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 433);
            Controls.Add(lblMonto);
            Controls.Add(label11);
            Controls.Add(lvResumen);
            Controls.Add(btnMostrar);
            Controls.Add(cboLetras);
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
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmCredito";
            Text = "frmCredito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvDetalle;
        private ColumnHeader ITEM;
        private ColumnHeader DESCRIPCIONDELPRODUCTO;
        private ColumnHeader CANTIDAD;
        private ColumnHeader PRECIO;
        private ColumnHeader SUBTOTAL;
        private Button btnAdquirir;
        private TextBox txtCantidad;
        private ComboBox cboProducto;
        private TextBox txtRuc;
        private TextBox txtCliente;
        private Label lblHora;
        private Label label6;
        private Label lblFecha;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label10;
        private ComboBox cboLetras;
        private Button btnMostrar;
        private ListView lvResumen;
        private ColumnHeader NLetra;
        private ColumnHeader Monto;
        private Label lblMonto;
        private Label label11;
    }
}