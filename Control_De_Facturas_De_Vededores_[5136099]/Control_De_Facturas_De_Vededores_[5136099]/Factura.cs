using System;
using System.Collections.Generic;
using System.Text;

namespace Control_De_Facturas_De_Vededores__5136099_
{
    internal class Factura
    {
        //Declaración de atributos privados.
        private int _numFactura;
        private DateTime _fechaFact;
        private double _montoFact;

        static private double acumulado;
        static private int n;

        //Método constructor con parámetros.
        public Factura(int numFactura, DateTime fechaFact, double montoFact)
        {
            this._numFactura = numFactura;
            this._fechaFact = fechaFact;
            this._montoFact = montoFact;
            acumulado += montoFact;
            n++;
        }

        //Métodos GET"s
        public int numFactura
        {
            get { return _numFactura; }
        }
        public DateTime fechaFact
        {
            get { return _fechaFact; }
        }
        public double montoFact
        {
            get { return _montoFact; }
        }
        public int totalFacturas()
        {
            return n;
        }
        public double calculaTotalSubTotal()
        {
            return acumulado;
        }
        public double calculaComision()
        {
            return 0.12 * calculaTotalSubTotal();
        }
    }
}
