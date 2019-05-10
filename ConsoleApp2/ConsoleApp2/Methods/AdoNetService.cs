using System;
using System.Threading.Tasks;
using AdoNetExample;
namespace OrquesterApp.Controller
{
    public class AdoNetService
    {
        public static async Task GetProcedureElapsedTimeAsync()
        {
            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                AdoConnection con = new AdoConnection();

                int response = await con.QueryAdoNetProcedure();

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds / 1000;

                Console.WriteLine($"ElapsedTime with Procedure: {elapsedMs} ms - TotalResults: {response}");

            }catch(Exception e)
            {
                Console.WriteLine($"Procedure Error: {e.ToString()}.");
            }
        }

        public static async Task GetQueryElapsedTime()
        {
            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                AdoConnection con = new AdoConnection();

                int response = await con.QueryAdoNetHardCode();

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds / 1000;

                Console.WriteLine($"ElapsedTime with direct query expression: {elapsedMs} ms - TotalResults: {response}");

            }catch(Exception e)
            {
                Console.WriteLine($"Direct query Error: {e.ToString()}.");
            }
}

    }
}
