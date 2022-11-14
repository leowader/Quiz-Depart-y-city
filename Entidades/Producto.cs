using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Referencia { get; set; }
        public string Nombre { get; set; }
        public int idCategoria { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Precio { get; set; }
        public override string ToString()
        {
            return $"{Referencia};{Nombre};{idCategoria};{FechaVencimiento};{Precio}";
        }
    }
}
