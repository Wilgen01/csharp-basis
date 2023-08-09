using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basis.models
{
    internal class Algoritmos
    {
        public string ReverseString(string text)
        {
            string result = "";
            int index = 0;
            List<char> charList = new() { };
            char[] charArray = new char[text.Length];

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
                charList.Add(text[i]);
                charArray[index] = text[i];
                index++;
            }

            char[] textReversed = text.ToCharArray();
            Array.Reverse(textReversed);
            //Console.WriteLine(result);
            //Console.WriteLine(string.Join("", charList));
            //Console.WriteLine(new string(charArray));
            //Console.WriteLine(new string(textReversed));

            return new string(textReversed);
        }

        public List<long> FibonacciSequence()
        {
            List<long> list = new() { 1, 1 };

            for (int i = list.Count; i < 1000; i++)
            {
                var number1 = list[^1];
                var number2 = list[^2];

                list.Add(number1 + number2);
            }

            return list;
        }

        public int FibonacciWithRecursion(int num)
        {
            if (num < 2)
            {
                return num;
            }
            return FibonacciWithRecursion(num - 2) + FibonacciWithRecursion(num - 1);
        }

        public void CollectionTypes()
        {
            int[] arr = new int[2]; //arreglos
            List<int> list = new List<int>() { 0, 1, 2 }; // listas
            Stack<int> stack = new Stack<int>(); // pilas
            Queue<int> queue = new Queue<int>(); // colas
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>(); // diccionario
        }
    }
}
