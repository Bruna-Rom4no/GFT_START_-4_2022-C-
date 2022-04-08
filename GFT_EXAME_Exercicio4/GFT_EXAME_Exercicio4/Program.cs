using System;

namespace GFT_EXAME_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
            string cliente1 = Console.ReadLine();
            Console.WriteLine("Valor de compra: ");
            int Compra1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string cliente2 = Console.ReadLine();
            Console.WriteLine("Valor de compra: ");
            int Compra2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string cliente3 = Console.ReadLine();
            Console.WriteLine("Valor de compra: ");
            int Compra3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string cliente4 = Console.ReadLine();
            Console.WriteLine("Valor de compra: ");
            int Compra4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string cliente5 = Console.ReadLine();
            Console.WriteLine("Valor de compra: ");
            int Compra5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string cliente6 = Console.ReadLine();
            Console.WriteLine("Valor de compra: ");
            int Compra6 = int.Parse(Console.ReadLine());

            int faturamento = Compra1 + Compra2 + Compra3 + Compra4 + Compra5 + Compra6;

            if (faturamento > 54000)
            {
                int total = faturamento - 54000;
                Console.WriteLine($"O faturamento superou a loja de Ubiratã em {total}");
            }
        }
    }
}
