namespace csharp_basis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReverseString("text to revers");
            FibonacciSequence().ForEach(Console.WriteLine);
            //FibonacciWithRecursion(1000);
        }

        public static string ReverseString(string text)
        {
            //reverse string
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

        public static List<int> FibonacciSequence()
        {
            List<int> list = new() { 1,1};
            
            for(int i = list.Count; i<1000; i++)
            {
                var number1 = list[^1];
                var number2 = list[^2];

                list.Add(number1 + number2);
            }

            return list;
        }

        public static int FibonacciWithRecursion(int num)
        {
            if (num < 2)
            {
                return num;
            }
            return FibonacciWithRecursion(num-2) + FibonacciWithRecursion(num - 1);
        }
    }
}