﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Departamentos
    {
        public string NombreDepartamento { get; set; }
        public override string ToString()
        {
            return $"{NombreDepartamento}";
        }
    }
}
