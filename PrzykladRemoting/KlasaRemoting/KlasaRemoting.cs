using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KlasaRemoting
{
    public class ZdalnyObiekt:MarshalByRefObject
    {
        string tmp;
        int connected = 0;
        public ZdalnyObiekt()
        {
        }

        public string ZwrocTekst(string tekst, string zawartosc)
        {

            try
            {
                StreamWriter writer = new StreamWriter(tekst, true);
                connected += 1;
                if (connected == 1)
                {
                    tmp = tmp + tekst;
                }
                writer.Write(zawartosc);
                writer.Close();
                
            }
            catch (IOException)
            {
                return ("blad zapisu do pliku");
            }
            return(tmp);

        }
    }
}
