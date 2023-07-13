// See https://aka.ms/new-console-template for more information


using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProy
{

    class Program
    {
        static async Task  Main(string[] args) 
        {

            Console.WriteLine("Esperando.....");

            var tarea1 = new Task(() =>
            {
                Thread.Sleep(10000);
                Console.WriteLine("Tarea1 Terminada");
            });
            tarea1.Start();

            await tarea1;
            var tarea2 = new Task(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Tarea2 Terminada");
            });
            tarea2.Start();
            
            Console.WriteLine("Esperando.....");

            await tarea1;
            await tarea2;

            Console.WriteLine("Fin Programa");
           

        }

        
        

    }
}
