
public class Program
{
    public static void Main(string[] args)
    {

        // Seleccionar paises con un numero de caracteres expecifico
        List<String> paises = new() { "Colombia", "Venezuela", "Peru", "Ecuador", "Argentina", "Chile" };

        getPaisesPorNumeroDeCaracteres(paises, 6, false);
       

    }

    public static IEnumerable<String> getPaisesPorNumeroDeCaracteres(List<String> lista, int nCaracteres, bool print)
    {
        var result  = lista.Where(i => i.Length > nCaracteres);
        if (print)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        return result;
    }
}



        

