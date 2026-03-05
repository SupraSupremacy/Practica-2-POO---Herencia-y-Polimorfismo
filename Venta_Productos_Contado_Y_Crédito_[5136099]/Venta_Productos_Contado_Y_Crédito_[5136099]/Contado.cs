using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    public class Contado:Venta
    {
        public static int n;
        public Contado()
        {
            n++;
        }
        public int getN()
        {
            return n; 
        }

        //Métodos de la calse contado.
        public double calculaDescuento(double subtotal)
        {
            if (subtotal < 1000)
                return 2.0 / 100 * subtotal;
            else if (subtotal >= 1000 && subtotal <= 3000)
                return 5.0 / 100 * subtotal;
            else
                return 12.0 / 100 * subtotal;
        }
        public double calculaNeto(double subtotal, double descuento)
        {
            return subtotal - descuento;
        }
    }
}
