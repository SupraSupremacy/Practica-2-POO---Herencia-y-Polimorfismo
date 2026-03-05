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
    public partial class frmContado : Form
    {
        //Inicialización del arreglo de productos
        static string[] productos = { "Lavadora", "Refrigeradora", "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };

        //Creando el objeto de la clase ArrayList
        ArrayList aProductos = new ArrayList(productos);

        //Variable acumuladora de totales
        double tSubtotal = 0;

        public frmContado()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
            cboProducto.DataSource = aProductos;

        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Contado
            Contado objC = new Contado();

            //Datos del cliente
            objC.cliente = txtCliente.Text;
            objC.ruc = txtRuc.Text;
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();

            //Datos del producto
            objC.producto = cboProducto.Text;
            objC.cantidad = int.Parse(txtCantidad.Text);

            //Imprimiendo en la lista
            ListViewItem fila = new ListViewItem(objC.getN().ToString());
            fila.SubItems.Add(objC.producto);
            fila.SubItems.Add(objC.cantidad.ToString());
            fila.SubItems.Add(objC.asignaPrecio().ToString("C"));
            fila.SubItems.Add(objC.calculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);

            listado(objC);

            lblMonto.Text = tSubtotal.ToString("0.00");
        }
        private void frmContado_Load(object sente,EventArgs e)
        {
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
        void listado(Contado objC)
        {
            tSubtotal += objC.calculaSubtotal();
            lstResumen.Items.Clear();
            lstResumen.Items.Add("** RESUMEN DE VENTA **");
            lstResumen.Items.Add("-------------------------------------------");
            lstResumen.Items.Add("CLIENTE: " + objC.cliente);
            lstResumen.Items.Add("RUC: " + objC.ruc);
            lstResumen.Items.Add("FECHA: " + objC.fecha);
            lstResumen.Items.Add("HORA: + " + objC.hora);
            lstResumen.Items.Add("-------------------------------------------");
            lstResumen.Items.Add("SUBTOTAL: " + tSubtotal.ToString("C"));

            double descuento = objC.calculaDescuento(tSubtotal);
            double neto = objC.calculaNeto(tSubtotal, descuento);

            lstResumen.Items.Add("DESCUENTO: " + descuento.ToString("C"));
            lstResumen.Items.Add("NETO: " + neto.ToString("C"));
        }
    }
}
