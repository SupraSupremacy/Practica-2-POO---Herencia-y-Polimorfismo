using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Venta_Productos_Contado_Y_Crédito__5136099_
{
    public class Venta
    {
        //Atributos
        public string cliente { get; set; }
        public string ruc { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }

        //Métodos de la clase Venta
        public double asignaPrecio()
        {
            switch (producto)
            {
                case "Lavadora": return 1500;
                case "Refrigeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "BluRay": return 250;
            }
            return 0;
        }

        //Método que calcula el subtotal
        public double calculaSubtotal()
        {
            return asignaPrecio() * cantidad;
        }
    }
}
