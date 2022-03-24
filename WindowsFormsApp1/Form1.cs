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
        Waluta waluta = new Waluta();
        string call = "https://openexchangerates.org/api/latest.json?app_id=a88a77c6b5bb401ca088160709305677";
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
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            waluta = JsonConvert.DeserializeObject<Waluta>(response);


            if (textBoxPLN.Text != "")
            {
                double zloty = Convert.ToDouble(textBoxPLN.Text);
                textBoxEUR.Text = ((zloty * waluta.rates["EUR"])/waluta.rates["PLN"]).ToString("#.##");
                textBoxGBP.Text = ((zloty * waluta.rates["GBP"]) / waluta.rates["PLN"]).ToString("#.##");
                textBoxCHF.Text = ((zloty * waluta.rates["CHF"]) / waluta.rates["PLN"]).ToString("#.##");
                textBoxUSD.Text = (zloty / waluta.rates["PLN"]).ToString("#.##");
            }
            if (textBoxEUR.Text != "")
            {
                double euro = Convert.ToDouble(textBoxEUR.Text);
                textBoxPLN.Text = ((euro * waluta.rates["PLN"]) / waluta.rates["EUR"]).ToString("#.##");
                textBoxGBP.Text = ((euro * waluta.rates["GBP"]) / waluta.rates["EUR"]).ToString("#.##");
                textBoxCHF.Text = ((euro * waluta.rates["CHF"]) / waluta.rates["EUR"]).ToString("#.##");
                textBoxUSD.Text = (euro / waluta.rates["EUR"]).ToString("#.##");
            }
            if (textBoxGBP.Text != "")
            {
                double funt = Convert.ToDouble(textBoxGBP.Text);
                textBoxPLN.Text = ((funt * waluta.rates["PLN"]) / waluta.rates["GBP"]).ToString("#.##");
                textBoxEUR.Text = ((funt * waluta.rates["EUR"]) / waluta.rates["GBP"]).ToString("#.##");
                textBoxCHF.Text = ((funt * waluta.rates["CHF"]) / waluta.rates["GBP"]).ToString("#.##");
                textBoxUSD.Text = (funt / waluta.rates["GBP"]).ToString("#.##");
            }
            if (textBoxCHF.Text != "")
            {
                double frank = Convert.ToDouble(textBoxCHF.Text);
                textBoxPLN.Text = ((frank * waluta.rates["PLN"]) / waluta.rates["CHF"]).ToString("#.##");
                textBoxEUR.Text = ((frank * waluta.rates["EUR"]) / waluta.rates["CHF"]).ToString("#.##");
                textBoxGBP.Text = ((frank * waluta.rates["GBP"]) / waluta.rates["CHF"]).ToString("#.##");
                textBoxUSD.Text = (frank / waluta.rates["CHF"]).ToString("#.##");
            }
            if (textBoxUSD.Text != "")
            {
                double dolar = Convert.ToDouble(textBoxUSD.Text);
                textBoxPLN.Text = ((dolar * waluta.rates["PLN"]) / waluta.rates["USD"]).ToString("#.##");
                textBoxEUR.Text = ((dolar * waluta.rates["EUR"]) / waluta.rates["USD"]).ToString("#.##");
                textBoxGBP.Text = ((dolar * waluta.rates["GBP"]) / waluta.rates["USD"]).ToString("#.##");
                textBoxCHF.Text = (dolar* waluta.rates["CHF"]).ToString("#.##");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Text;
            string[] daty =data.Split('.');
            call = "https://openexchangerates.org/api/historical/" + daty[2] + "-" + daty[1] + "-" + daty[0] + ".json?app_id=a88a77c6b5bb401ca088160709305677";
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
