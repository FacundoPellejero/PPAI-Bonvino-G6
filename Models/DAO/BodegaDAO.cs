using BomVino_PPAI.Models.DTO;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BomVino_PPAI.Models.DAO
{
    public class BodegaDAO 
    {
 

        private string connectionString;

        // Creamos un campo de clase SqlConnection
        private SqlConnection connection;

        // Constructor que inicializa la cadena de conexión
        public BodegaDAO(string connectionString)
        {
            this.connectionString = connectionString;
            // Inicializamos el objeto SqlConnection
            connection = new SqlConnection(connectionString);
        }


        // Método para verificar si alguna bodega tiene actualización disponible
        public bool estaParaActualizarNovedadesVino(DateTime fechaActual)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Bodega";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime ultimaActualizacion = Convert.ToDateTime(reader["ultimaActualizacion"]);
                        int periodoActualizacion = Convert.ToInt32(reader["periodoActualizacion"]);

                        // Comprobar si necesita actualización
                        if ((fechaActual - ultimaActualizacion).TotalDays >= periodoActualizacion * 30) // Convertir meses a días
                        {
                            return true;
                        }
                    }
                    return false;   
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tu lógica de aplicación
                Console.WriteLine("Error: " + ex.Message);
                return false;   
            }

        }

        // Obtener Datos
        public List<Bodega> getDatos(DateTime fechaActual)
        {
            List<Bodega> objetosBodegaDatos = new List<Bodega>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Bodega";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime ultimaActualizacion = Convert.ToDateTime(reader["ultimaActualizacion"]);
                        int periodoActualizacion = Convert.ToInt32(reader["periodoActualizacion"]);

                        // Comprobar si necesita actualización
                        if ((fechaActual - ultimaActualizacion).TotalDays >= periodoActualizacion * 30) // Convertir meses a días
                        {
                            // Crear objeto Bodega y mapear los datos
                            Bodega bodega = new Bodega();
                            bodega.id = Convert.ToInt32(reader["id"]);
                            bodega.Nombre = reader["nombre"].ToString();
                            bodega.CoordenadasUbicacion = reader["coordenadas"].ToString();
                            bodega.UltimaActualizacion = ultimaActualizacion;
                            bodega.PeriodoActualizacion = periodoActualizacion;

                            // Agregar la bodega a la lista
                            objetosBodegaDatos.Add(bodega);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tu lógica de aplicación
                Console.WriteLine("Error: " + ex.Message);
                // Puedes lanzar la excepción nuevamente o manejarla de otra manera según tu caso
            }

            return objetosBodegaDatos;
        }


    }
}
