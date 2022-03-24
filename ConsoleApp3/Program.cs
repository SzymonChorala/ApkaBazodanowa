using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    public static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            string call = "https://openexchangerates.org/api/latest.json?app_id=a88a77c6b5bb401ca088160709305677";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            Waluta waluta = JsonConvert.DeserializeObject<Waluta>(response);
            Console.WriteLine(waluta.license);
            Console.WriteLine(waluta.rates["PLN"]);
            Console.Read();

        }
    }
}
