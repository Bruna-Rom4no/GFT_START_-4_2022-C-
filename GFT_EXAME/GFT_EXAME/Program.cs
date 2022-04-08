using System;
using System.Collections.Generic;
using System.Linq;

namespace GFT_EXAME
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            List<int> _ordem = new List<int>();

            while (i <= 2)
            {
                Console.WriteLine("Digite o " + (i + 1) + " valor");
                _ordem.Add(int.Parse(Console.ReadLine()));

                i++;
            }

            _ordem.Sort();
            _ordem.Reverse();

            Console.WriteLine();

            Console.WriteLine("Os valores que foram digitados são: ");

            foreach (int ordem in _ordem)
            {
                Console.WriteLine(ordem);
            }
            Console.ReadKey();
        }
    
    }
}
