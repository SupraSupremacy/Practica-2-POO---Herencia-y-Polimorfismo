namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            frmCredito frmCre = new frmCredito();
            frmCre.Show();
        }

        private void btnContado_Click(object sender, EventArgs e)
        {
            frmContado frmC = new frmContado();
            frmC.Show();
        }
    }
}
