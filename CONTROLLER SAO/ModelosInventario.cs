using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER_SAO
{
    class ModelosInventario
    {
        DataTable tabla = new DataTable();

        public void CrearTabla()
        {
            tabla.Clear();

            tabla.Columns.Add("Concepto", typeof(string));

            tabla.Columns.Add("Valor", typeof(double));
        }

        public DataTable CalcularEOQ(double D, double S, double H)
        {
            CrearTabla();

            double q = Math.Sqrt(2 * D * S / H);

            double nOrdenes = q / D;

            tabla.Rows.Add("EOQ", q);
         
            return tabla;
        }

        public DataTable CalcularEOQ(double D, double S, double H, double p)
        {
            tabla.Clear();

            double q = Math.Sqrt(2 * D * S / H);

            double nOrdenes = q / D;

            double CT = D / q * S - q / 2 * H + p * D;

            return tabla;
        }

        public DataTable CalcularEOQ(double D, double S, double H, double d, double L)
        {
            tabla.Clear();

            double q = Math.Sqrt(2 * D * S / H);

            double nOrdenes = q / D;

            double rop = d * L;

            return tabla;
        }

        public DataTable CalcularEOQ(double D, double S, double H, double d, double L, double p)
        {
            tabla.Clear();

            double q = Math.Sqrt(2 * D * S / H);

            double nOrdenes = q / D;

            double rop = d * L;

            double CT = D / q * S - q / 2 * H + p * D;

            return tabla;
        }
    }
}
