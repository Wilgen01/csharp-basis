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
                "[4] Eliminar persona\n" +
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
                    case "3":
                        EditarPersona();
                        break;
                    case "4":
                        EliminarPersona();
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


                //Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | ", persona.id, persona.nombres, persona.apellidos, persona.edad));
                Console.WriteLine($"Id: {persona.id} Nombres: {persona.nombres} Apellidos: {persona.apellidos} " +
                    $"Edad: {persona.edad}");
            }

            Console.WriteLine("");
        }

        public static void AgregarPersona()
        {
            var personaDB = new PersonaDB();

            var persona = IngresarPersona();
            if (persona is not null )
            {
                personaDB.Add(persona);
            }

        }
        public static void EditarPersona()
        {
            var personaDB = new PersonaDB();

            int id = 0;
            while (id == 0)
            {
                Console.WriteLine("Digite el ID de la persona a editar");
                var input = Console.ReadLine();
                if (int.TryParse(input, out id))
                {
                    var persona = IngresarPersona();
                    if (persona is not null)
                    {
                        persona.id = id;
                        personaDB.Update(persona);
                    }
                }
                else
                {
                    Console.WriteLine("Opción no valida");
                }
            }

        }


        public static void EliminarPersona()
        {
            var personaDB = new PersonaDB();

            int id = 0;
            while (id == 0) { 
                Console.WriteLine("Digite el ID de la persona a eliminar");
                var input = Console.ReadLine();
                if (int.TryParse(input, out id))
                {
                    personaDB.Delete(id);
                }
                else
                {
                    Console.WriteLine("Opción no valida");
                }
            }
        }

        public static Persona? IngresarPersona()
        {
            Console.WriteLine("Ingrese los nombres:");
            var nombres = Console.ReadLine();
            if (string.IsNullOrEmpty(nombres))
            {
                Console.WriteLine("Nombre no valido");
                return null;
            }

            Console.WriteLine("Ingrese los apellidos:");
            var apellidos = Console.ReadLine();
            if (string.IsNullOrEmpty(apellidos))
            {
                Console.WriteLine("Apellido no valido");
                return null;
            }

            Console.WriteLine("Ingrese la edad:");
            var inputEdad = Console.ReadLine();
            if (!int.TryParse(inputEdad, out int edad))
            {
                Console.WriteLine("La edad debe ser un numero");
                return null;
            }
            
            var persona = new Persona()
            {
                nombres = nombres,
                apellidos = apellidos,
                edad = edad
            };

            return persona;
        }


    }
}