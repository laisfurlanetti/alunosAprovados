using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace alunosAprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            decimal media;

            Console.Write("Qual a primeira nota? ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual a segunda nota? ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual a terceira nota? ");
            nota3 = Convert.ToInt32(Console.ReadLine());

            media = Obtermedia(nota1, nota2, nota3);
            Aprovacao(nota1, nota2, nota3, media);
            Console.Read();
        }
        public static decimal Obtermedia(int nota1, int nota2, int nota3)
        {
            decimal media = (nota1 + nota2 + nota3) / 3;
            return media;
        }
        public static void Aprovacao(int nota1, int nota2, int nota3, decimal media)
        {
            if (media >= 7 && media < 10)
                Console.Write("APROVADO");
            if (media < 7)
                Console.Write("REPROVADO");
            if (media == 10)
                Console.Write("APROVADO COM DISTINCAO");
        }
    }
    
}
