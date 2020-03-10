using ParejasCartas_DAL.Connection;
using SimonCompadre_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_DAL.Handlers
{
    public class clsManejadoraPuntuaciones
    {

        public clsManejadoraPuntuaciones()
        {

        }

        public int insertarPuntuacion(clsPuntuaciones puntuaciones)
        {
            int filas = 0;

            SqlConnection connection;
            clsMyConnection myConnection;

            try
            {
                SqlCommand command = new SqlCommand();
                myConnection = new clsMyConnection();
                connection = new SqlConnection();

                connection = myConnection.getConnection();
                command.CommandText = "INSERT INTO dbo.PuntuacionesSimon (nombre,puntos) VALUES(@nombreJugador,@puntos)";
                command.Parameters.Add("@nombreJugador", System.Data.SqlDbType.VarChar).Value = (string)puntuaciones.NombreJugador;
                command.Parameters.Add("@puntos", System.Data.SqlDbType.VarChar).Value = (string)puntuaciones.Puntuacion;

                command.Connection = connection;
                filas = command.ExecuteNonQuery();

                myConnection.closeConnection(ref connection);

            }
            catch (SqlException)
            {
                throw;
            }

            return filas;
        }

    }
}
