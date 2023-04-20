using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileNumerosCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            String[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            while (a != b) {
                if (a < b) {
                    Console.WriteLine("CRESCENTE");
                }
                else {
                    Console.WriteLine("DECRESCENTE");
                }
                vet = Console.ReadLine().Split(' ');
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);
            }
        }
    }
}
