using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudad
    {
        public string NombreCiudad { get; set; }
        public override string ToString()
        {
            return $"{NombreCiudad}";
        }
    }
}
