using System.Data.SqlClient;

namespace csharp_basis.models
{
    class PersonaDB
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
                    persona.id = reader.GetInt32(0);
                    list.Add(persona);
                }

                reader.Close();
                connection.Close();
            }

            return list;
        }

        public void Add(Persona persona)
        {
            var query = "INSERT INTO persona(nombres, apellidos, edad) " +
                        "values(@nombres, @apellidos, @edad)";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombres", persona.nombres);
                command.Parameters.AddWithValue("@apellidos", persona.apellidos);
                command.Parameters.AddWithValue("@edad", persona.edad);


                connection.Open();
                command.ExecuteNonQuery();

                

                connection.Close();
            }
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM persona WHERE id=@id";

            using(var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                var result = command.ExecuteNonQuery();
                if (result == 0)
                {
                    Console.WriteLine("El Id ingresado no corresponde a ningún registro");
                }

                connection.Close();
            }
        }

        public void Update(Persona persona)
        {
            var query = "UPDATE persona SET nombres=@nombres, apellidos=@apellidos, edad=@edad WHERE id=@id";

            using(var connection = new SqlConnection(connectionString)) 
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombres", persona.nombres);
                command.Parameters.AddWithValue("@apellidos", persona.apellidos);
                command.Parameters.AddWithValue("@edad", persona.edad);
                command.Parameters.AddWithValue("@id", persona.id);


                connection.Open();
                var result = command.ExecuteNonQuery();

                if (result == 0)
                {
                    Console.WriteLine("El Id ingresado no corresponde a ningún registro");
                }

                connection.Close();
            }
        }
          
    }
}
