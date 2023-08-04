using csharp_basis.models;
using System.Collections;

namespace csharp_basis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var algoritmos = new Algoritmos();

            //algoritmos.ReverseString("text to revers");
            //algoritmos.FibonacciSequence().ForEach(Console.WriteLine);
            Console.WriteLine("Ingrese la opción que desea realizar:\n" +
                "[1] Listar personas\n" +
                "[2] Agregar persona\n" +
                "[3] Actualizar persona\n" +
                "[4] Eliminar perona\n" +
                "[5] Salir");
            
            var userOption = Console.ReadLine();
            Console.WriteLine("");
            while (userOption !=null  && userOption != "5") { 

                switch (userOption)
                {
                    case "1":
                        ListarPersonas();
                        break;
                    case "2":
                        AgregarPersona();
                        break;
                }

                
                Console.WriteLine("Ingrese la opción que desea realizar:\n" +
                "[1] Listar personas\n" +
                "[2] Agregar persona\n" +
                "[3] Actualizar persona\n" +
                "[4] Eliminar perona\n" +
                "[5] Salir");
                Console.WriteLine("");
                userOption = Console.ReadLine();

            }


        }

        public static void ListarPersonas()
        {
            Console.Clear();
            var personaDB = new PersonaDB();

            var listaPersonas = personaDB.Get();

            foreach (var persona in listaPersonas)
            {

                
                Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | ", persona.id, persona.nombres, persona.apellidos, persona.edad));
                //Console.WriteLine($"Id: {persona.id} Nombres: {persona.nombres} Apellidos: {persona.apellidos} " +
                //    $"Edad: {persona.edad}");
            }

            Console.WriteLine("");
        }

        public static void AgregarPersona()
        {
            var personaDB = new PersonaDB();
            var persona = new Persona()
            {
                nombres = "Laura Valentina",
                apellidos = "Garcia Rodriguez",
                edad = 12
            };

            personaDB.Add(persona);
        }


    }
}