using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maisVelhoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoa x, y;

            x = new pessoa();
            y = new pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("nome: ");
            x.nome = Console.ReadLine();
            Console.Write("idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("nome: ");
            y.nome = Console.ReadLine();
            Console.Write("idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade) Console.WriteLine($"pessoa mais velha: {x.nome}");
            else Console.WriteLine("pessoa mais velha: "+y.nome);

            Console.ReadKey();
        }
    }
}
