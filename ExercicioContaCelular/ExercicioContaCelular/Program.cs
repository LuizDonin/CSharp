using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ExercicioContaCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());
            conta = 50.0;
// o sinal de " a += b " corresponde a " a = a + b " e também serve para "-=" "*=" "/=" e "%="
            if (minutos > 100) {
                conta += (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor a pagar = R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
