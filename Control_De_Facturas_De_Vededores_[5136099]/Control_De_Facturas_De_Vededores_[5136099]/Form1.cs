namespace Control_De_Facturas_De_Vededores__5136099_
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los valores del formulario.
            int numFactura = int.Parse(txtNumFact.Text);
            DateTime fechaFact = DateTime.Parse(txtFechaFact.Text);
            double montoFact = double.Parse(txtMontoFact.Text);

            //Objeto de la clase Factura.
            Factura objF = new Factura(numFactura, fechaFact, montoFact);

            //Crear ListViewItem
            ListViewItem fila = new ListViewItem(objF.numFactura.ToString());
            fila.SubItems.Add(objF.fechaFact.ToShortDateString());
            fila.SubItems.Add(objF.montoFact.ToString("C"));
            lvFacturas.Items.Add(fila);

            //Mostrando los montos.
            lblTotalFact.Text = objF.totalFacturas().ToString();
            lblTotalSub.Text = objF.calculaTotalSubTotal().ToString("C");
            lblComisión.Text = objF.calculaComision().ToString("C");
        }
    }
}