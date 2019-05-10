using OrquesterApp.Controller;
using System;

namespace Tarea1_dotnet
{
    public class Program
    {

        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        public static async System.Threading.Tasks.Task MainAsync(string[] args)
        {
            Console.WriteLine("Begining tasks!");
            /*Elapsed time in query*/
            await AdoNetService.GetQueryElapsedTime();
            /*Elapsed time in procedure*/
            await AdoNetService.GetProcedureElapsedTimeAsync();
            /*Elapsed time using ORM*/


            Console.WriteLine("\nFinishied Task.");
            Console.ReadLine();
            
        }
    }
}
