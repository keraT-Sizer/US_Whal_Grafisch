using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_Whal_Grafisch.model;

namespace US_Whal_Grafisch
{

    enum Geschlecht { WEIBLICH, MAENLICH }
    enum Beeinflussbarkeit { LEICHT, MITTEL, SCHWER }
    enum Alter { ERSTWAEHLER, BIS30, BIS40, BIS50, RESTLICHE }
    enum Schicht { UNTERSCHICH, UNTEREMITTELSCHICH, OBEREMITTELSCHICHT, OBERSCHICHT }
    enum PolitischeHeimat { REPUBLIKANER, DEMOKRATEN }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //List<Wähler> wl = new List<Wähler>();

            //wl = Model.ZeigeWahlvolk(wl);

            

            //var wl_link = from wähler in wl
            //              where wähler.Alter == Alter.ERSTWAEHLER &&
            //                    wähler.Schicht == Schicht.OBERSCHICHT &&
            //                    wähler.Geschlecht == Geschlecht.WEIBLICH &&
            //                    //wähler.PLZ > 47111 &&
            //                    wähler.PLZ < 80000 &&
            //                    wähler.PolitischeHeimat == PolitischeHeimat.DEMOKRATEN &&
            //                    wähler.Beeinflussbarkeit == Beeinflussbarkeit.LEICHT
            //             select wähler;




            //foreach (var item in wl_link)
            //{
            //    Console.WriteLine(item.Vorname + " " + item.Alter + " " + item.PolitischeHeimat);
            //}

            Console.ReadLine();
        }
    }
}
