using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaCar
{
    internal class ArabaClass
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public string YakitTuru { get; set; }

        public string VitesTipi { get; set; }

        public int Kilometre { get; set; }
        public string Plaka { get; set; }


        public ArabaClass(string marka, string model, string renk, string yakitTuru, string vitesTipi, int kilometre, string plaka)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            YakitTuru = yakitTuru;
            VitesTipi = vitesTipi;
            Kilometre = kilometre;
            Plaka = plaka;
        }

        public void carFeatures()
        {
            Console.WriteLine("Marka: " + Marka + Environment.NewLine);

            Console.WriteLine("Model: " + Model + Environment.NewLine);

            Console.WriteLine("Renk: " + Renk + Environment.NewLine);

            Console.WriteLine("Yakıt Türü: " + YakitTuru + Environment.NewLine);

            Console.WriteLine("Vites Tipi: " + VitesTipi + Environment.NewLine);

            Console.WriteLine("Kilometre: " + Kilometre + Environment.NewLine);

            Console.WriteLine("Plaka: " + Plaka + Environment.NewLine);




        }
    }
}
