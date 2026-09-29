using HarcosokKlubja12A.Model;

namespace HarcosokKlubja12A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Harcos harcos1 = new Harcos("PeeThor", 99, 16);
            Harcos harcos2 = new Harcos("VickThor", 99, 11);

            Console.WriteLine("1. Kezdeti állapot:");
            Console.WriteLine(harcos1.ToString());
            Console.WriteLine(harcos2.ToString());

            Csata(harcos1, harcos2);
        }

        private static void Csata(Harcos harcos1, Harcos harcos2)
        {
            bool csataVege = false;
            int korokSzama = 0;

            while (!csataVege)
            {
                korokSzama++;
                Console.WriteLine($"{korokSzama}. számú támadások:");

                csataVege = harcos1.Harcolnak(harcos2);
                Console.WriteLine(harcos1.ToString());
                Console.WriteLine(harcos2.ToString());

                if (harcos1.EletEro <= 0)
                {
                    Console.WriteLine($"{harcos1.Nev} elbukottt, {harcos2.Nev} megnyerte a küzdelmet.");
                }
                else if (harcos2.EletEro <= 0)
                {
                    Console.WriteLine($"{harcos2.Nev} elbukottt, {harcos1.Nev} megnyerte a küzdelmet.");
                }
            }
        }
    }
}
