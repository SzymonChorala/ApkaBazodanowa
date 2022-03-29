using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class WalutaBaz :Waluta
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public float ratesPLN { get; set; }
        public float ratesEUR { get; set; }
        public float ratesGBP { get; set; }
        public float ratesCHF { get; set; }
        public float ratesUSD { get; set; }


        public override string ToString()
        {
            string str = Id.ToString();
            str += Environment.NewLine;
            str += Date.ToString();
            str += Environment.NewLine; 
            str += ratesPLN.ToString();

            return str;
        }
    }

    
}
