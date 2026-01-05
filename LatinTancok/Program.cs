namespace LatinTancok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rawData = File.ReadAllLines("tancrend.txt").Chunk(3).ToArray();
            //Console.WriteLine(rawData);
            List<Adatok> adatok = new List<Adatok>();
           adatok= rawData.Select(tanc => new Adatok(tanc[0], tanc[1], tanc[2])).ToList();
            Console.WriteLine("2.feladat");
            Console.WriteLine($"Az első tánc:{adatok[0].tancTipus} Az utolsó tánc {adatok[adatok.Count - 1].tancTipus}");

            var samba = adatok.Where(tanc => tanc.tancTipus == "samba").ToList();
            //Console.WriteLine(samba);
            Console.WriteLine("3.feladat");
            Console.WriteLine("a sambát ennyiszer adták elő: " + samba.Count);

            Console.WriteLine("4.feladat");
            var Vilma = adatok.Where(tanc => tanc.lany=="Vilma").ToList();
            var VilmaTancai = Vilma.Select(tanc => tanc.tancTipus).ToList();
            Console.WriteLine($"A táncok amiben Vilma szerepelt : {string.Join(',',VilmaTancai)} ");

            Console.WriteLine("5.feladat");
            Console.WriteLine("Adjon meg egy táncot: ");
            string megadott = Console.ReadLine();
            var vilmaParja = adatok.Where(tanc => tanc.lany == "Vilma" && tanc.tancTipus == megadott).ToList();
            if (vilmaParja.Count == 0)
            {
                Console.WriteLine($"Vilma nem táncolt {megadott}-t.");
            }
            else
            {
                Console.WriteLine($"A samba bemutatóján Vilma párja {vilmaParja[0].fiu}  volt.");
            }

            Console.WriteLine("6.feladat");
            var lanyok = adatok.DistinctBy(tanc => tanc.lany).ToList().Select(tanc => tanc.lany);
            var fiuk = adatok.DistinctBy(tanc => tanc.fiu).ToList().Select(tanc =>tanc.fiu);
            Console.WriteLine(string.Join(",", fiuk));
            StreamWriter ir = new StreamWriter("szereplok.txt");
            ir.WriteLine("Fiúk: " + string.Join(", ", fiuk));
            ir.WriteLine("Lányok: " + string.Join(", ", lanyok));
            ir.Close();

            Console.WriteLine("7. feladat");
            var fiuTancosok = adatok.GroupBy(tanc => tanc.fiu).Select(tancos=> new {nev = tancos.Key,elofordulas=tancos.Count()} ).OrderBy(tancos => tancos.elofordulas);
            var lanyTancosok = adatok.GroupBy(tanc => tanc.lany).Select(tancos=> new {nev = tancos.Key,elofordulas=tancos.Count()} ).OrderBy(tancos => tancos.elofordulas);
            
        }
    }
}
