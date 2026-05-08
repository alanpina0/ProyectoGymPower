using System;
using System.Collections.Generic;
using System.Text;

namespace Moodelo
{
    internal class ClienteMembrsia
    {
        public int IdClienteMembresia { get; set; }

        // Relaciones
        public int IdCliente { get; set; }
        public int IdMembresia { get; set; }
        public int IdPago { get; set; }

        // relacion
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }

        // Navegación
        public Cliente Cliente { get; set; }
        public Membresia Membresia { get; set; }
        public Pago Pago { get; set; }
    }
}
