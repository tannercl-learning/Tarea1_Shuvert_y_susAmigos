using System;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp.ExistingDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All!");
            Stopwatch medicion = new Stopwatch();
            medicion.Start();
            using (var ctx = new NET_PRUContext())
            {
                var query = ctx.RUT_clientes.ToList();
            }
            medicion.Stop();
            Console.WriteLine("Tiempo transcurrido: {0}", medicion.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));

            Console.WriteLine("FirstOrDefault!");
            medicion = new Stopwatch();
            medicion.Start();
            using (var ctx = new NET_PRUContext())
            {
                var query = ctx.RUT_clientes.Where(t=> t.ID == 1).FirstOrDefault();
            }
            medicion.Stop();
            Console.WriteLine("Tiempo transcurrido: {0}", medicion.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));

            Console.ReadKey();
        }
    }
}
