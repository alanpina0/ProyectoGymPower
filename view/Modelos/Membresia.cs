using System;
using System.Collections.Generic;
using System.Text;

namespace GIMNASIO.Modelos
{
    internal class Membresia
    {
        public int IdMembresia { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }

        public int Duracion { get; set; }  // duración en días

    }
}
