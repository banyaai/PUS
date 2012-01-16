using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using KlasaRemoting;

namespace KlientRemoting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string adres = textBox1.Text;
            adres = "http://" + adres;
            int port = Convert.ToInt32(textBox2.Text);
            HttpClientChannel kanal = null;
            try
            {
                kanal = new HttpClientChannel();
                ChannelServices.RegisterChannel(kanal, false);
                ZdalnyObiekt obiekt = (ZdalnyObiekt)Activator.GetObject(typeof(ZdalnyObiekt), adres + ":" + port.ToString() +
                    "/NazwaUslugiProjektu");
                listBox1.Items.Add(obiekt.ZwrocTekst(textBox3.Text, textBox4.Text));
                ChannelServices.UnregisterChannel(kanal);
                listBox1.Items.Add("polaczenie zostalo zakonczone");
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message, "blad");
                listBox1.Items.Add("blad polaczenia");
                ChannelServices.UnregisterChannel(kanal);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
