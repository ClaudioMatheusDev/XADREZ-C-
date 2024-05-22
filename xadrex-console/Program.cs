using tabuleiro;
using System;
using xadrez;
using System.Net.Http.Headers;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

           
           Console.ReadLine();

        }
    }
}
