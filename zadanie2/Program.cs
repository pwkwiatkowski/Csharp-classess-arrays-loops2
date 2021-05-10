using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utwórz postrzępioną tablicę liczb typu int.Wypełnij kolejne komórki wartościami malejącymi od 10 do 1.
            //Do utworzenia tablicy i wypełnienia jej danymi wykorzystaj pętlę typu for.

            int licznik = 10;

            int[][] postrzepiona = new int[4][];

            for(int i=0; i<postrzepiona.Length; i++)
            {
                postrzepiona[i] = new int[i + 1];

                for(int j=0; j<postrzepiona[i].Length; j++)
                {
                    postrzepiona[i][j] = licznik--;
                    Console.Write("{0} ", postrzepiona[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}
