using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace GIMNASIO.DAO
{
    internal class conexion
    {
        private NpgsqlConnection conection;

        private string cadenaConexion =
            "Host=localhost;Port=5432;Username=postgres;Password=123;Database=BaseDeDatosGymPower";

        public void Conectarse()
        {
            if (conection == null)
                conection = new NpgsqlConnection(cadenaConexion);

            if (conection.State == System.Data.ConnectionState.Closed)
                conection.Open();
        }

        public void Desconectarse()
        {
            if (conection != null &&
                conection.State == System.Data.ConnectionState.Open)
            {
                conection.Close();
            }
        }

        public NpgsqlConnection ObtenerBD()
        {
            return conection;
        }
    }
}
