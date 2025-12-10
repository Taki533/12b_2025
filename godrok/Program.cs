namespace godrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("melyseg.txt");
            List<Melyseg> adatok = new List<Melyseg>();
            sorok.ToList().ForEach(x =>
            {
                adatok.Add(new Melyseg(int.Parse(x)));
            });
            Console.WriteLine("1.Feladat");
            Console.WriteLine(adatok.Count);
            Console.WriteLine("2.feladat");
            Console.WriteLine("Adjon meg egy távolságértéket!");
            int tavolsagErtek = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ezen a helyen a felszín {adatok[tavolsagErtek-1].melyseg} méter mélyen van.");
            Console.WriteLine("3.Feladat");
            Console.WriteLine(adatok.Where(x => x.melyseg==0).Count());
            double szazalek = (double)adatok.Where(x => x.melyseg==0).Count()/(double)adatok.Count();
            Console.WriteLine($"Az érintetlen terület aránya {szazalek:0.00%}");
            File.WriteAllLines("godrok.txt",string.Join("", adatok.Select(x=> x.melyseg))
                .Split("0")
                .Where(x=>x.Length>0));

            
            
        }
    }
}
