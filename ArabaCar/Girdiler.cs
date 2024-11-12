using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArabaCar
{
    class Girdiler
    {
        public void Islemler()
        {
            Console.Write("Arabanın markasını girin: ");
            string marka = Console.ReadLine();

            Console.Write("Arabanın modelini girin: ");
            string model = Console.ReadLine();

            Console.Write("Arabanın rengini girin: ");
            string renk = Console.ReadLine();

            Console.Write("Arabanın yakıt türünü girin: ");
            string yakitTuru = Console.ReadLine();

            Console.Write("Arabanın vites tipini girin: ");
            string vitesTipi = Console.ReadLine();

            Console.Write("Arabanın kilometresini girin: ");
            if (int.TryParse(Console.ReadLine(), out int kilometre))
            {

            }
            else
            {
                Console.Write("Geçersiz bir kilometre girdiniz." + Environment.NewLine);
            }

            Console.Write("Arabanın plakasını girin: ");
            string plaka = Console.ReadLine();

            ArabaClass arabaaa = new ArabaClass(marka, model, renk, yakitTuru, vitesTipi, kilometre, plaka);

            arabaaa.carFeatures();

        }
    }
}
