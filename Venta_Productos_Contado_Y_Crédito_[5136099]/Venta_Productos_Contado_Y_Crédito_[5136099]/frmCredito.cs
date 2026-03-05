using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    public partial class frmCredito : Form
    {
        static int[] letras = { 3, 6, 9, 12 };
        static string[] productos = { "Lavadora", "Refrigeradora", "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };

        //Declaración de los ArrayList
        ArrayList aProductos = new ArrayList(productos);
        ArrayList aLetras = new ArrayList(letras);

        double tSubtotal = 0;
        public frmCredito()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
            cboLetras.DataSource = aLetras;
            cboProducto.DataSource = aProductos;
        }
        private void frmCredito_Load(object sender, EventArgs e)
        {
            cboLetras.DataSource = aLetras;
            cboProducto.DataSource = aProductos;
            mostrarFecha();
            mostrarHora();
        }
        void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        void mostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Crédito.
            Crédito objCr = new Crédito();

            //Datos del cliente.
            objCr.cliente = txtCliente.Text;
            objCr.ruc = txtRuc.Text;
            objCr.fecha = DateTime.Parse(lblFecha.Text);
            objCr.hora = DateTime.Parse(lblHora.Text);

            //Datos del producto.
            objCr.producto = cboProducto.Text;
            objCr.cantidad = int.Parse(txtCantidad.Text);

            //Imprimiendo en la lista.
            ListViewItem fila = new ListViewItem(objCr.getX().ToString());
            fila.SubItems.Add(objCr.producto);
            fila.SubItems.Add(objCr.cantidad.ToString());
            fila.SubItems.Add(objCr.asignaPrecio().ToString("C"));
            fila.SubItems.Add(objCr.calculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            tSubtotal += objCr.calculaSubtotal();
            lblMonto.Text = tSubtotal.ToString("0.00");
        }
        void montoLetras(int le)
        {
            double montoMensual = double.Parse(lblMonto.Text) / le;

            lvResumen.Items.Clear();
            for (int i = 1; i <= le; i++)
            {
                ListViewItem fila = new ListViewItem(i.ToString());
                fila.SubItems.Add(montoMensual.ToString("C"));
                lvResumen.Items.Add(fila);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int letras = int.Parse(cboLetras.Text);
            switch (letras)
            {
                case 3:montoLetras(3);break;
                case 6: montoLetras(6); break;
                case 9: montoLetras(9); break;
                case 12: montoLetras(12); break;
            }
        }
    }
}
