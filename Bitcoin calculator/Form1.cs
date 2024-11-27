using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bitcoin_calculator
{
    public partial class Form1 : Form
    {
        private object siseta;

  

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            {
                sisesta.Visible = true;
                sisesta.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float arvutus = float.Parse(sisesta.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                tulemus.Text = $"{arvutus} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
            if (valivaluuta.SelectedItem.ToString() == "EUR")
            {
                sisesta.Visible = true;
                sisesta.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float arvutus = float.Parse(sisesta.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                tulemus.Text = $"{arvutus} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
            if (valivaluuta.SelectedItem.ToString() == "GBP")
            {
                sisesta.Visible = true;
                sisesta.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float arvutus = float.Parse(sisesta.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;
                tulemus.Text = $"{arvutus} Bitcoini {newbitcoinrate.Bpi.GBP.code}";
            }
            if (valivaluuta.SelectedItem.ToString() == "USD")
            {
                sisesta.Visible = true;
                sisesta.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float arvutus = float.Parse(sisesta.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                tulemus.Text = $"{arvutus} Bitcoini {newbitcoinrate.Bpi.USD.code}";
            }


        }

        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }

            {
                {
                    return bitcoin;
                }
            }
        }

        private void valivaluuta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

        

        
    
