using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basis.models
{
    internal class PersonaDB
    {
        private string connectionString
            = "Data Source=DESKTOP-L21CB3D;Initial Catalog=TestDb1;" +
            "Integrated Security=True;";

        public List<Persona> Get()
        {
            var list = new List<Persona>();

            string query = "SELECT * FROM persona";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var persona = new Persona();
                    persona.nombres = reader.GetString(1);
                    persona.apellidos= reader.GetString(2);
                    persona.edad = reader.GetInt32(3);
                    list.Add(persona);
                }

                reader.Close();
                connection.Close();
            }

            return list;
        }
          
    }
}
