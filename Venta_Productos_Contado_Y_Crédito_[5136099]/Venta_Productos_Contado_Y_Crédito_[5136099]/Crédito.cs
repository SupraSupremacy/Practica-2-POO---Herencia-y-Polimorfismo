using System;
using System.Collections.Generic;
using System.Text;

namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    public class Crédito:Venta
    {
        public static int x;
        public Crédito()
        {
            x++;
        }
        public int getX()
        {
            return x;
        }

        //Atributos de la clase Crédito
        public int letras { get; set; }

        //Métodos de la clase Crédito
        public double calculaMontoInteres()
        {
            switch (letras)
            {
                case 3: return 5.0 / 100 * calculaSubtotal();
                case 6: return 10.0 / 100 * calculaSubtotal();
                case 9: return 15.0 / 100 * calculaSubtotal();
                case 12: return 25.0 / 100 * calculaSubtotal();
            }
            return 0;
        }
        public double calculaMontoMensual()
        {
            return (calculaSubtotal() + calculaMontoInteres()) / letras;
        }
    }
}
