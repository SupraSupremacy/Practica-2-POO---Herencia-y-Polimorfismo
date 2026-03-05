namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    partial class Form1
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
            btnCredito = new Button();
            btnContado = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 22);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "VENTA DE PRODUCTOS";
            // 
            // btnCredito
            // 
            btnCredito.Location = new Point(28, 65);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(175, 23);
            btnCredito.TabIndex = 1;
            btnCredito.Text = "VENTA AL CRÉDITO";
            btnCredito.UseVisualStyleBackColor = true;
            btnCredito.Click += btnCredito_Click;
            // 
            // btnContado
            // 
            btnContado.Location = new Point(225, 65);
            btnContado.Name = "btnContado";
            btnContado.Size = new Size(175, 23);
            btnContado.TabIndex = 1;
            btnContado.Text = "VENTA AL CONTADO";
            btnContado.UseVisualStyleBackColor = true;
            btnContado.Click += btnContado_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(71, 100);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Venta al crédito";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(265, 100);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(95, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Venta al contado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 159);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(btnContado);
            Controls.Add(btnCredito);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulario Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCredito;
        private Button btnContado;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
