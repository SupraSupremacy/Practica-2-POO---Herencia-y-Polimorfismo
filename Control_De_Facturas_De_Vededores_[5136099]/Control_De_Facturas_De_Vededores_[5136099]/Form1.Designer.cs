namespace Control_De_Facturas_De_Vededores__5136099_
{
    partial class frmFacturas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBox1 = new TextBox();
            txtNumFact = new TextBox();
            txtMontoFact = new TextBox();
            label5 = new Label();
            txtFechaFact = new TextBox();
            label6 = new Label();
            lblFecha = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lvFacturas = new ListView();
            label7 = new Label();
            label8 = new Label();
            lblTotalFact = new Label();
            lblTotalSub = new Label();
            label11 = new Label();
            label12 = new Label();
            lblComisión = new Label();
            NumFactura = new ColumnHeader();
            FechaFact = new ColumnHeader();
            MontoFact = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE FACTURAS DE VENDEDORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "VENDEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 91);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 1;
            label3.Text = "N° FACTURAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 120);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 2;
            label4.Text = "MONTO FACT";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(118, 60);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(381, 23);
            TextBox1.TabIndex = 3;
            // 
            // txtNumFact
            // 
            txtNumFact.Location = new Point(118, 88);
            txtNumFact.Name = "txtNumFact";
            txtNumFact.Size = new Size(173, 23);
            txtNumFact.TabIndex = 4;
            // 
            // txtMontoFact
            // 
            txtMontoFact.Location = new Point(118, 117);
            txtMontoFact.Name = "txtMontoFact";
            txtMontoFact.Size = new Size(173, 23);
            txtMontoFact.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 91);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 1;
            label5.Text = "FECHA FACT.";
            // 
            // txtFechaFact
            // 
            txtFechaFact.Location = new Point(381, 88);
            txtFechaFact.Name = "txtFechaFact";
            txtFechaFact.Size = new Size(118, 23);
            txtFechaFact.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(592, 63);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 1;
            label6.Text = "FECHA";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(652, 63);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(381, 146);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(118, 23);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(518, 146);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lvFacturas
            // 
            lvFacturas.Columns.AddRange(new ColumnHeader[] { NumFactura, FechaFact, MontoFact });
            lvFacturas.FullRowSelect = true;
            lvFacturas.GridLines = true;
            lvFacturas.Location = new Point(31, 175);
            lvFacturas.Name = "lvFacturas";
            lvFacturas.Size = new Size(605, 151);
            lvFacturas.TabIndex = 6;
            lvFacturas.UseCompatibleStateImageBehavior = false;
            lvFacturas.View = View.Details;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 339);
            label7.Name = "label7";
            label7.Size = new Size(373, 15);
            label7.TabIndex = 7;
            label7.Text = "MONTO ASIGNADOS AL VENDEDOR POR EL REGISTRO DE FACTURAS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 371);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 7;
            label8.Text = "TOTAL FACTURAS";
            // 
            // lblTotalFact
            // 
            lblTotalFact.AutoSize = true;
            lblTotalFact.Location = new Point(31, 392);
            lblTotalFact.Name = "lblTotalFact";
            lblTotalFact.Size = new Size(0, 15);
            lblTotalFact.TabIndex = 7;
            // 
            // lblTotalSub
            // 
            lblTotalSub.AutoSize = true;
            lblTotalSub.Location = new Point(247, 392);
            lblTotalSub.Name = "lblTotalSub";
            lblTotalSub.Size = new Size(0, 15);
            lblTotalSub.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(247, 371);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 7;
            label11.Text = "TOTAL SUBTOTAL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(410, 371);
            label12.Name = "label12";
            label12.Size = new Size(126, 15);
            label12.TabIndex = 7;
            label12.Text = "COMISIÓN ASIGNADA";
            // 
            // lblComisión
            // 
            lblComisión.AutoSize = true;
            lblComisión.Location = new Point(410, 392);
            lblComisión.Name = "lblComisión";
            lblComisión.Size = new Size(0, 15);
            lblComisión.TabIndex = 7;
            // 
            // NumFactura
            // 
            NumFactura.Text = "Num. Factura";
            NumFactura.Width = 85;
            // 
            // FechaFact
            // 
            FechaFact.Text = "Fecha Facturación";
            FechaFact.Width = 108;
            // 
            // MontoFact
            // 
            MontoFact.Text = "Monto Facturado";
            MontoFact.Width = 400;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(lblComisión);
            Controls.Add(lblTotalSub);
            Controls.Add(lblTotalFact);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lvFacturas);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtMontoFact);
            Controls.Add(txtFechaFact);
            Controls.Add(txtNumFact);
            Controls.Add(TextBox1);
            Controls.Add(label4);
            Controls.Add(lblFecha);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFacturas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextBox1;
        private TextBox txtNumFact;
        private TextBox txtMontoFact;
        private Label label5;
        private TextBox txtFechaFact;
        private Label label6;
        private Label lblFecha;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ListView lvFacturas;
        private Label label7;
        private Label label8;
        private Label lblTotalFact;
        private Label lblTotalSub;
        private Label label11;
        private Label label12;
        private Label lblComisión;
        private ColumnHeader NumFactura;
        private ColumnHeader FechaFact;
        private ColumnHeader MontoFact;
    }
}
