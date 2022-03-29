using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    internal class Przelicznik : DbContext
    {
        public virtual DbSet<WalutaBaz> Waluty{get; set;}

        public override string ToString()
        {
            string str= Waluty.ToString();

            return str;
        }
    }
}
