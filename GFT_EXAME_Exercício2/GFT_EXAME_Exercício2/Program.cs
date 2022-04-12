using System;

namespace GFT_EXAME_Exercício2
{
    class Program : Aluno
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("123", 8, 9, 10, 250);
            Aluno a2 = new Aluno("456", 5, 4, 6, 467);
            Aluno a3 = new Aluno("456", 10, 5, 7, 870);
            Aluno a4 = new Aluno("456", 8, 9, 6, 590);
            Aluno a5 = new Aluno("456", 9, 9, 10, 978);

            Console.WriteLine($"O aluno 1 tem média {a1.Media()} e frequentou {a1.Frequencia()}% das aulas.");

            Console.WriteLine($"O aluno 2 tem média {a2.Media()} e frequentou {a2.Frequencia()}% das aulas.");

            Console.WriteLine($"O aluno 3 tem média {a3.Media()} e frequentou {a3.Frequencia()}% das aulas.");

            Console.WriteLine($"O aluno 4 tem média {a4.Media()} e frequentou {a4.Frequencia()}% das aulas.");

            Console.WriteLine($"O aluno 5 tem média {a5.Media()} e frequentou {a5.Frequencia()}% das aulas.");
        }
    }
}
