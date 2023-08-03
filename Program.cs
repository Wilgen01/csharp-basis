namespace csharp_basis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // reverse string
            string text = "text to Invert";
            string result = "";
            int index = 0;
            List<char> charList = new() { };
            char[] charArray = new char[text.Length];

            for (int i = text.Length - 1; i >= 0 ; i--)
            {
                result += text[i];
                charList.Add(text[i]);
                charArray[index] = text[i];
                index++;
            }

            char[] textReversed = text.ToCharArray();
            Array.Reverse(textReversed);
            Console.WriteLine(result);
            Console.WriteLine(string.Join("", charList));
            Console.WriteLine(new string(charArray));
            Console.WriteLine(new string(textReversed));




        }
    }
}