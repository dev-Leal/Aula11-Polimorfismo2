using System;

namespace Aula_11__Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculo personagem = new Calculo();
            Console.WriteLine(personagem.Calcular());

            Console.WriteLine(personagem.Calcular (3360));

            Console.WriteLine(personagem.Calcular (1600));

            Console.WriteLine(personagem.Calcular (3360, 1600, 2240));

            Console.WriteLine(personagem.Calcular (3360, 1600, 2240, "Rico"));

        }
    }
}
