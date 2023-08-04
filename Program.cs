using csharp_basis.models;
using System.Collections;

namespace csharp_basis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var algoritmos = new Algoritmos();

            algoritmos.ReverseString("text to revers");
            algoritmos.FibonacciSequence().ForEach(Console.WriteLine);
        }

       
    }
}