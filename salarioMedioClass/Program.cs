using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace salarioMedioClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            funcionario x, y;

            x = new funcionario();
            y = new funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (x.salario + y.salario) / 2;
            Console.WriteLine("Salário médio: " + media.ToString(CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
