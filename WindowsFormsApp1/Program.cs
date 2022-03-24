using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Program
    {
        public static Waluta walutaw = new Waluta();
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        public static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string call = "https://openexchangerates.org/api/latest.json?app_id=a88a77c6b5bb401ca088160709305677";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            walutaw = JsonConvert.DeserializeObject<Waluta>(response);
            Console.WriteLine(walutaw.license);
            Console.WriteLine(walutaw.rates["PLN"]);
            Console.Read();
        }
    }
}
