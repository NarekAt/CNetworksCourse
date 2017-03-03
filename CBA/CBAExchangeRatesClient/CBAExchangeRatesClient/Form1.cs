using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBAExchangeRatesClient
{
    public partial class Form1 : Form
    {
        private CBARef.GateSoapClient client;

        public Form1()
        {
            InitializeComponent();
            client = new CBARef.GateSoapClient();
        }

        private  void clearLastQuery()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void lastExchangeRate(string ISO)
        {
            DateTime date = DateTime.Now.Date;
            textBox3.Text = client.ExchangeRatesByDateByISO(date, ISO).Rates[0].Rate;
        }

        private void minMaxRatesByDateRange(string ISO)
        {
            var from = dateTimePicker1.Value.Date;
            var to = dateTimePicker2.Value.Date;

            var rates = client.ExchangeRatesByDateRangeByISO(ISO, from, to);
            decimal max = 0;
            decimal min = decimal.MaxValue;
            decimal current;

            DateTime minDay = DateTime.Now.Date;
            DateTime maxDay = DateTime.Now.Date;

            foreach (var i in rates)
            {
                current = i.Rate;
                if (current < min)
                {
                    min = i.Rate;
                    minDay = i.RateDate;
                }

                if (current > max)
                {
                    max = current;
                    maxDay = i.RateDate;
                }
            }
            var minStr = string.Format("{0:G29}", decimal.Parse(min.ToString()));
            var maxStr = string.Format("{0:G29}", decimal.Parse(max.ToString()));

            textBox1.Text = minStr;
            textBox2.Text = maxStr;
            textBox4.Text = minDay.ToString();
            textBox5.Text = maxDay.ToString();
        }

        private void query(object sender, EventArgs ea, string ISO)
        {
            clearLastQuery();

            if (radioButton2.Checked)
            {
                lastExchangeRate(ISO);
            }
            else
            {
                minMaxRatesByDateRange(ISO);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            query(sender, e, "USD");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            query(sender, e, "EUR");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query(sender, e, "GBP");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            query(sender, e, "RUS");
        }
    }
}
