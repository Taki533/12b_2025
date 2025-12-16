namespace Jelado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Adat> adatok = new List<Adat>();

            string[] sorok = File.ReadAllLines("jel.txt");

            sorok.ToList().ForEach(sor => adatok.Add(new Adat(sor)));

            adatok = sorok.ToList().Select(x => new Adat(x)).ToList();

            Console.WriteLine();
            Console.WriteLine("2.feladat");

            Console.Write("Adja meg a jel sorszámát! ");
            int bekert = Convert.ToInt32(Console.ReadLine());

            var megfeleloJel = adatok[bekert - 1];

            Console.WriteLine($"x={megfeleloJel.x} y={megfeleloJel.y}");

            /*Másik megoldások
            Console.WriteLine(adatok[bekert-1].koordinatak());

            Console.WriteLine(adatok.Where((e,i) => i == bekert-1).First().koordinatak());
			*/

            Console.WriteLine($"4.feladat\nIdőtartam: {adatok[0].elteltIdo(adatok.Last())}");

            Console.WriteLine("5.feladat");
            int minX = adatok.Min(x => x.x);
            int maxX = adatok.Max(x => x.x);
            int minY = adatok.Min(x => x.y);
            int maxY = adatok.Min(x => x.y);

            Console.WriteLine("Bal also: {0};{1}, JobbFelső: {2}; {3}", minX, minY, maxX,maxY);
            Console.WriteLine("6. feladat");
            var osszeg = adatok.Skip(1).Select((x,i) => x.tavolsag(adatok[i])).Sum();
            Console.WriteLine($"Az elmozdulás {osszeg:0.000} egység");


        }
    }
}