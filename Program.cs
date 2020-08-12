using System;

namespace Historico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] historicos_calculadora = new int[6] { 2, 23, 12, 39, 44, 13 };
            int valor;
            valor = historicos_calculadora[3];
            Console.WriteLine("O elemento é {0}", valor.ToString());
            
        }
    }

