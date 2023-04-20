using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i=1; i<=N; i++) {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
