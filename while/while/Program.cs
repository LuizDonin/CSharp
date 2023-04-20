using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somar valores enquanto o número inputado nao for = a 0
            int x, soma;
            x = int.Parse(Console.ReadLine());
            soma = 0;
            while(x != 0) {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
