using System.Linq;

namespace LatinTancok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var adatok = File.ReadAllLines("tancrend.txt").Chunk(3).ToList();

            List<tanc> tancok = new List<tanc>();

            for (int i = 0; i < adatok.Count; i++)
            {
                tancok.Add(new tanc(adatok[i][0], adatok[i][2], adatok[i][1]));
            }
            Console.WriteLine("2.feladat");
            Console.WriteLine($"Az első tánc:{tancok[0].Tanc} Az utolsó tánc {tancok[tancok.Count - 1].Tanc}");

            

            Console.WriteLine("3.feladat");

            var Sambak = tancok.Where(x => x.Tanc == "samba").ToList();

            Console.WriteLine("a sambát ennyiszer adták elő: " + Sambak.Count);

            Console.WriteLine("4.feladat");
            var Vilmak = tancok.Where(x => x.Lany == "Vilma").ToList();
            var VilmaTanc = Vilmak.Select(x => x.Tanc).ToList();
            Console.WriteLine($"A táncok amiben Vilma szerepelt : {string.Join(',', VilmaTan)} ");

            Console.WriteLine("5.feladat");
            Console.WriteLine("Adjon meg egy táncot: ");
            string megadott = Console.ReadLine();
            var vilmaParja = tancok.Where(x => x.Lany == "Vilma" && x.Tanc == megadott).ToList();
            if (vilmaParja.Count == 0)
            {
                Console.WriteLine($"Vilma nem táncolt {megadott}-t.");
            }
            else
            {
                Console.WriteLine($"A samba bemutatóján Vilma párja {vilmaParja[0].Fiu}  volt.");
            }
        }
    }
}
