using System;
namespace Lezione23novembre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una frase: ");
            string unicodeString =
                "This Unicode string has 2 characters outside  the" +
                "ASCII range: \n" +
                "PI (\u03A0), and Sigma (\u03A0).";
            Console.WriteLine("Original String:");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodeString);
            Console.WriteLine();
        }
    }
}
