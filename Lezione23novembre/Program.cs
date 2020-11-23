using System;
namespace Lezione23novembre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una frase: ");
            Console.ReadLine();
            string unicodeString =
                "This Unicode string has 2 characters outside  the" +
                "ASCII range: \n" +
                "PI (\u03A0), and Sigma (\u03A0).";
            Console.WriteLine("Original String:");
            //Questa riga è necessaria perchè altrimenti non viene stampato il PI e il Sigma.
            Console.WriteLine(unicodeString);
            Console.WriteLine();
        }
    }
}
