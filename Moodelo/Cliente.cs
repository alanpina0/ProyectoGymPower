using System;
using System.Collections.Generic;
using System.Text;

namespace Moodelo
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime Fechanacimiento { get; set; }

        public string Telefono { get; set; }
        public string CorreoE { get; set; }
        public int Asistencias { get; set; }

        public DateTime FechaInscripcion { get; set; }



    }
}
