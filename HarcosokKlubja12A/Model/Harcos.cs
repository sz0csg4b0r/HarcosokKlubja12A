using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosokKlubja12A.Model
{
    internal class Harcos
    {
        public string Nev { get; set; } 
        public int EletEro { get; set; }
        public int HarciEro { get; set; }
        public bool MegadtaMagat { get; set; }

        public Harcos(string nev, int eletEro, int harciEro)
        {
            Nev = nev;
            EletEro = eletEro;
            HarciEro = harciEro;
            MegadtaMagat = false;
        }

        public bool Harcolnak(Harcos ellenfel)
        {
            if (!MegadtaMagat && !ellenfel.MegadtaMagat)
            {
                EletEro -= ellenfel.HarciEro;
                if (EletEro <= 0)
                {
                    MegadtaMagat = true;
                }
                else
                {
                    ellenfel.EletEro -= HarciEro;
                    if (ellenfel.EletEro <= 0)
                    {
                        ellenfel.MegadtaMagat = true;
                    }
                }
            }
            return MegadtaMagat || ellenfel.MegadtaMagat;
        }








        public override string ToString()
        {
            return $"{Nev} nevű harcos, életerő pontja: {EletEro}," +
                $" {(!MegadtaMagat ? "Kitartóan harcol" : "Feladta a küzdelmet.")}";
        }


    }
}
