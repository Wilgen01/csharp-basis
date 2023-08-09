
using Linq.models;

public class Program
{
    public static void Main(string[] args)
    {

        
        List<String> paises = new() { "Colombia", "Venezuela", "Peru", "Ecuador", "Argentina", "Chile" };
        List<Curso> cursos = new List<Curso> { 
            new Curso(){Id = 1, Titulo = "C# basico", Descripcion="", Duracion=18000, nivel=1},
            new Curso(){Id = 2, Titulo = "C# Avanzado", Descripcion="", Duracion=5000, nivel=2},
            new Curso(){Id = 3, Titulo = "C# Experto", Descripcion="", Duracion=10000, nivel=3},
            new Curso(){Id = 3, Titulo = "C# Dios", Descripcion="", Duracion=20000, nivel=4},
            new Curso(){Id = 4, Titulo = "JS basico", Descripcion="", Duracion=20000, nivel=1},
            new Curso(){Id = 5, Titulo = "JS Avanzado", Descripcion="", Duracion=6000, nivel=2},
            new Curso(){Id = 6, Titulo = "JS Experto", Descripcion="", Duracion=18000, nivel=3},
        };

        // Seleccionar paises con un numero de caracteres expecifico
        var paisesLargos = getPaisesPorNumeroDeCaracteres(paises, 6, false);

        // Ordenar por alfabetico
        paisesLargos = paisesLargos.OrderBy(p => p);
        paisesLargos.ToList().ForEach(p => { Console.WriteLine(p); });

        // Obtener el pais mas largo
        var paisMasLargo = paises.OrderByDescending(p => p.Length).First();
        Console.WriteLine($"El pais con el nombre mas largo {paisMasLargo}");

        // Subconsultas
        Console.WriteLine("");
        Console.WriteLine("SUBCONSULTAS");
        var cursosFiltrados = cursos.Where(c => c.Duracion <= 18000  && c.Titulo.Contains("C#")).OrderBy(c => c.nivel).Select(c => new {c.Titulo, c.Duracion, c.nivel });
        cursosFiltrados.ToList().ForEach(c => { Console.WriteLine(c); });

    }

    public static IEnumerable<String> getPaisesPorNumeroDeCaracteres(List<String> lista, int nCaracteres, bool print)
    {
        //sintaxis basada en metodos
        var result  = lista.Where(i => i.Length > nCaracteres);
        if (print) result.ToList().ForEach(i => Console.WriteLine(i));

        //sintaxis basada en consultas
        //var result2 = from item in result
        //              where item.Length > nCaracteres
        //              select item;
        //if (print) result.ToList().ForEach(i => Console.WriteLine(i));


        return result;
    }

}



        

