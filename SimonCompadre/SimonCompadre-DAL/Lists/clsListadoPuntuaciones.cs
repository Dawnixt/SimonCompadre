using ParejasCartas_DAL.Connection;
using SimonCompadre_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_DAL.Lists
{
    public class clsListadoPuntuaciones
    {

        /// <summary>
        /// Esta funcion obtiene el listado de puntuaciones de la base de datos ordenadas de mejor a peor
        /// </summary>
        /// <returns>Un listado con las puntuaciones de mejor a peor</returns>
        public List<clsPuntuaciones> obtenerPuntuaciones()
        {
            List<clsPuntuaciones> scores = new List<clsPuntuaciones>();
            SqlConnection connection;
            clsMyConnection myConnection;

            try
            {
                myConnection = new clsMyConnection();
                connection = new SqlConnection();
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                clsPuntuaciones puntuacion;

                connection = myConnection.getConnection();
                command.CommandText = "SELECT top 10 * FROM Scores order by tiempo ";
                command.Connection = connection;
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        puntuacion = new clsPuntuaciones();

                        puntuacion.ID = (int)reader["id"];

                        if (!String.IsNullOrEmpty(reader["nombre"].ToString()))
                        {
                            puntuacion.NombreJugador = (String)reader["nombre"];
                        }

                        if (!String.IsNullOrEmpty(reader["puntos"].ToString()))
                        {
                            puntuacion.Puntuacion = (string)reader["puntos"];
                        }

                        scores.Add(puntuacion);
                    }
                }

                reader.Dispose();
                myConnection.closeConnection(ref connection);
            }
            catch (SqlException)
            {
                throw;
            }

            return scores;
        }

    }
}
