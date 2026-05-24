using System;
using System.Collections.Generic;
using System.Text;

namespace GIMNASIO.Modelos
{
    internal class Cliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string sexo { get; set; }



        public DateTime Fechanacimiento { get; set; }

        public string Telefono { get; set; }
        public string CorreoE { get; set; }
        public int Asistencias { get; set; }

        public DateTime FechaInscripcion { get; set; }




    }
}
