using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PUS_Zad_3_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nazwa = textBox1.Text;
                string tresc = textBox2.Text;
                ServiceReference1.ServiceSoapClient serwis = new PUS_Zad_3_Klient.ServiceReference1.ServiceSoapClient(); //utworzenie obiektu reprezentującego
						              // zdalną usługę
                listBox1.Items.Add("Tekst otrzymany od serwisu:");
                listBox1.Items.Add(serwis.PierwszaMetoda(tresc, nazwa)); // Wywołujemy zdalną metodę 
						                // Wywołanie następuje przez lokalny
						                // obiekt serwis 
            }
            catch (Exception ex)				                // obsługa błędów
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
