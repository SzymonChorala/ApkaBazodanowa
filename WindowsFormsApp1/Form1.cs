using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button_Click(object sender, EventArgs e)
        {
            Waluta waluta = new Waluta();
            string date = dateTimePicker1.Text;
            string[] daty = date.Split('/');
            string call = "https://openexchangerates.org/api/historical/" + daty[2] + "-" + daty[0] + "-" + daty[1] + ".json?app_id=a88a77c6b5bb401ca088160709305677";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            waluta = JsonConvert.DeserializeObject<Waluta>(response);
            var context = new Przelicznik();

            var val = new WalutaBaz();
            if (context.Waluty.Any(x => x.Date == date))
                val = context.Waluty.First(x => x.Date == date);
            else
            {
                val=context.Waluty.Add(new WalutaBaz
                {
                    disclaimer = waluta.disclaimer,
                    license = waluta.license,
                    timestamp = waluta.timestamp,
                    Base = waluta.Base,
                    ratesPLN = waluta.rates["PLN"],
                    ratesCHF = waluta.rates["CHF"],
                    ratesEUR = waluta.rates["EUR"],
                    ratesGBP = waluta.rates["GBP"],
                    ratesUSD = waluta.rates["USD"],
                    Date = date
                }
                );
                context.SaveChanges();
            }
            
            if (textBoxPLN.Text != "")
            {
                double zloty = Convert.ToDouble(textBoxPLN.Text);

                textBoxEUR.Text = ((zloty * val.ratesEUR)/val.ratesPLN).ToString("#.##");
                textBoxGBP.Text = ((zloty * val.ratesGBP) / val.ratesPLN).ToString("#.##");
                textBoxCHF.Text = ((zloty * val.ratesCHF) / val.ratesPLN).ToString("#.##");
                textBoxUSD.Text = (zloty / val.ratesPLN).ToString("#.##");
            }
            if (textBoxEUR.Text != "")
            {
                double euro = Convert.ToDouble(textBoxEUR.Text);
                textBoxPLN.Text = ((euro * val.ratesPLN) / val.ratesEUR).ToString("#.##");
                textBoxGBP.Text = ((euro * val.ratesGBP) / val.ratesEUR).ToString("#.##");
                textBoxCHF.Text = ((euro * val.ratesCHF) / val.ratesEUR).ToString("#.##");
                textBoxUSD.Text = (euro / val.ratesEUR).ToString("#.##");
            }
            if (textBoxGBP.Text != "")
            {
                double funt = Convert.ToDouble(textBoxGBP.Text);
                textBoxPLN.Text = ((funt * val.ratesPLN) / val.ratesGBP).ToString("#.##");
                textBoxEUR.Text = ((funt * val.ratesEUR) / val.ratesGBP).ToString("#.##");
                textBoxCHF.Text = ((funt * val.ratesCHF) / val.ratesGBP).ToString("#.##");
                textBoxUSD.Text = (funt / val.ratesGBP).ToString("#.##");
            }
            if (textBoxCHF.Text != "")
            {
                double frank = Convert.ToDouble(textBoxCHF.Text);
                textBoxPLN.Text = ((frank * val.ratesPLN) / val.ratesCHF).ToString("#.##");
                textBoxEUR.Text = ((frank * val.ratesEUR) / val.ratesCHF).ToString("#.##");
                textBoxGBP.Text = ((frank * val.ratesGBP) / val.ratesCHF).ToString("#.##");
                textBoxUSD.Text = (frank / val.ratesCHF).ToString("#.##");
            }
            if (textBoxUSD.Text != "")
            {
                double dolar = Convert.ToDouble(textBoxUSD.Text);
                textBoxPLN.Text = ((dolar * val.ratesPLN) / val.ratesUSD).ToString("#.##");
                textBoxEUR.Text = ((dolar * val.ratesEUR) / val.ratesUSD).ToString("#.##");
                textBoxGBP.Text = ((dolar * val.ratesGBP) / val.ratesUSD).ToString("#.##");
                textBoxCHF.Text = (dolar* val.ratesCHF).ToString("#.##");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
                    
        }

        private void textBoxPLN_Click(object sender, EventArgs e)
        {
            textBoxUSD.Text = null;
            textBoxEUR.Text = null;
            textBoxCHF.Text = null;
            textBoxGBP.Text = null;
        }

        private void textBoxEUR_Click(object sender, EventArgs e)
        {
            textBoxUSD.Text = null;
            textBoxPLN.Text = null;
            textBoxCHF.Text = null;
            textBoxGBP.Text = null;
        }

        private void textBoxUSD_Click(object sender, EventArgs e)
        {
            textBoxPLN.Text = null;
            textBoxEUR.Text = null;
            textBoxCHF.Text = null;
            textBoxGBP.Text = null;
        }

        private void textBoxGBP_Click(object sender, EventArgs e)
        {
            textBoxUSD.Text = null;
            textBoxEUR.Text = null;
            textBoxCHF.Text = null;
            textBoxPLN.Text = null;
        }

        private void textBoxCHF_Click(object sender, EventArgs e)
        {
            textBoxUSD.Text = null;
            textBoxEUR.Text = null;
            textBoxPLN.Text = null;
            textBoxGBP.Text = null;
        }

    }
}
