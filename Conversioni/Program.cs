using System;

namespace Conversioni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversione decimale binaria
            Console.WriteLine("Inserire numero decimale da convertire");
            int num = int.Parse(Console.ReadLine());

            string sequenzaBit = "";
            int resto;
            while(num>0)
            {
                resto = num % 2;
                num = num / 2;
                sequenzaBit = resto + sequenzaBit;
            }

            Console.WriteLine(sequenzaBit);

            //Conversione binario decimale
            
            Console.WriteLine("Inserire stringa di bit");
            string sequenza = Console.ReadLine();
            int cont = 0;
            double decimale = 0;
            while(cont<sequenza.Length)
            {
                int bit = Convert.ToInt32(sequenza[cont])-48;
                int pot = Convert.ToInt32(sequenza.Length - 1 - cont);
                double val =  bit * Math.Pow(2, pot);
                decimale += val;
                cont++;
            }

            Console.WriteLine(decimale);
        }
    }
}
