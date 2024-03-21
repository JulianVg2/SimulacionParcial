using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionParcial
{
    internal class Reporte
    {
        string nombre;
        decimal grados;

        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Grados { get => grados; set => grados = value; }
    }
}
