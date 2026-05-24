using GIMNASIO.Modelos;
using GIMNASIO.Vistas;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace GIMNASIO.DAO
{
    internal class clienteDAO
    {
        // conexion conec = new conexion();

        conexion conexion = new conexion();

        public void Insertar(Cliente cliente)
        {
            string sql = @"INSERT INTO Cliente
            (
                Nombre,
                ApellidoPaterno,
                ApellidoMaterno,
                sexo,
                FechaNacimiento,
                Telefono,
                Correo
            )
            VALUES
            (
                @Nombre,
                @ApellidoPaterno,
                @ApellidoMaterno,
                @Sexo,
                @FechaNacimiento,
                @Telefono,
                @Correo
            )";

            conexion.Conectarse();

            NpgsqlConnection con = conexion.ObtenerBD();

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);

                cmd.Parameters.AddWithValue("@ApellidoPaterno", cliente.ApellidoPaterno);

                cmd.Parameters.AddWithValue("@ApellidoMaterno", cliente.ApellidoMaterno);

                cmd.Parameters.AddWithValue("@Sexo", cliente.sexo);

                cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.Fechanacimiento);

                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                cmd.Parameters.AddWithValue("@Correo", cliente.CorreoE);

                cmd.ExecuteNonQuery();
            }

            conexion.Desconectarse();
        }




    }
}
