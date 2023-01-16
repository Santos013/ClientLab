using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWord.Classes
{
    public static class Utils
    {
        public static void ParadaNoConsole(string texto)
        {
            Console.WriteLine(texto);
            Console.ReadLine();//parada no sistema
        }

        public static void Loading(string texto, int milesegundos, int qtdPontinhos, ConsoleColor corFundo, ConsoleColor corFonte)
        {
            Console.BackgroundColor = corFundo;//cor de fundo
            Console.ForegroundColor = corFonte;//cor da fonte
            Console.Write($"{texto} ");
            for (int i = 1; i <= qtdPontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(milesegundos);
            }

            Console.ResetColor();
        }
    }
}