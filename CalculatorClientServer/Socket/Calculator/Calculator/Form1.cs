using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using Dll;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calc obj = new Calc();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToInt32(textBox1.Text);
                double num2 = Convert.ToInt32(textBox2.Text);

                ChannelServices.RegisterChannel(new TcpClientChannel());

                obj = (Calc)Activator.GetObject(typeof(Calc), "tcp://localhost:3128/Hello");
                label1.Text = obj.calculate(num1, num2).ToString();
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Server Not Available");
            }
        }
    }
}
