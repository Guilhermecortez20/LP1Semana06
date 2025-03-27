using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar e instanciar dois cronômetros
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            // Iniciar a contagem do tempo em crono1
            crono1.Start();

            // Pausar o programa durante 0,50 segundos (500 milissegundos)
            Thread.Sleep(500);

            // Iniciar a contagem do tempo em crono2
            crono2.Start();

            // Pausar o programa durante mais 0,25 segundos (250 milissegundos)
            Thread.Sleep(250);

            // Parar a contagem do tempo nos dois cronômetros
            crono1.Stop();
            crono2.Stop();

            // Mostrar no ecrã o tempo decorrido em cada cronômetro, em segundos, com quatro casas decimais
            Console.WriteLine($"Tempo decorrido em crono1: {crono1.Elapsed.TotalSeconds:F4} segundos");
            Console.WriteLine($"Tempo decorrido em crono2: {crono2.Elapsed.TotalSeconds:F4} segundos");
        }
    }
}
