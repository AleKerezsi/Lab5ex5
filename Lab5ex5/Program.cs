using System;

namespace Lab5ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici. */

            Console.WriteLine("Introduceti sirul de caractere=  ");
            string sir = Console.ReadLine();

            if (string.IsNullOrEmpty(sir) || string.IsNullOrWhiteSpace(sir))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            if (sir.Length == 1) 
            {
                Console.WriteLine("Nu avem ce normaliza, sirul are doar 1 caracter.");
                return;
            }

            string stringNormalizat = NormalizeazaSir(sir);

            Console.WriteLine("Sirul de caractere normalizat este = " + stringNormalizat);

        }
        public static string NormalizeazaSir(string sir)
        {
            string stringNormalizat = string.Empty;

            //curs 5 pag 31
            string[] fragmente = sir.Split(' ');

            foreach (string fragment in fragmente)
            {
                stringNormalizat = stringNormalizat + fragment.Substring(0, 1).ToUpper() + fragment.Substring(1, fragment.Length - 1).ToLower();
                stringNormalizat = stringNormalizat + " ";
            }

            return stringNormalizat;

        }
    }
}
