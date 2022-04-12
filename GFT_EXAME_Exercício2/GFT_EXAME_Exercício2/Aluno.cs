using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFT_EXAME_Exercício2
{
    class Aluno
    {
        string matricula;

        int nota1;
        int nota2;
        int nota3;

        float faltas;

        public Aluno(string matricula, int nota1, int nota2, int nota3, float faltas)
        {
            this.matricula = matricula;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.faltas = faltas;
        }

        public Aluno()
        {

        }

        public int Media()
        {
            int total;

            return total = (nota1 + nota2 + nota3) / 3;
        }

        public float Frequencia()
        {
            float CargaHoraAulas = 1000;

            return (faltas / CargaHoraAulas) * 100;
        }
    }
}
