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

namespace SerwerRemoting
{
    public partial class Form1 : Form
    {
        string tmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HttpChannel kanal = new HttpChannel(12345);
                ChannelServices.RegisterChannel(kanal, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ZdalnyObiekt), "NazwaUslugiProjektu",
                    WellKnownObjectMode.Singleton);

                textBox1.Text = "Serwer zostal uruchomiony";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Blad");
            }
        }
    }
}
