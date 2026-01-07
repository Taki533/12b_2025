namespace godrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("melyseg.txt");
            List<Melyseg> adatok = new List<Melyseg>();
            sorok.ToList().ForEach((x) =>
            {
                adatok.Add(new Melyseg(int.Parse(x),adatok.Count + 1));
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

            Console.WriteLine("5. feladat");
            List<Godor> godrok = new List<Godor>();
            godrok.Add(new Godor());
            adatok.ForEach(x =>
            {
                if (x.melyseg > 0)
                {
                    godrok.Last().Add(x);
                }
                else
                {

                    if (godrok.Last().melysegek.Count>0)
                    {
                        godrok.Add(new Godor());
                    }
                        
                }
            });
            godrok.Remove(godrok.Last());

            Console.WriteLine("6.feladat");

            var talaltGodor = godrok.Where(egyGodor => egyGodor.Contains(tavolsagErtek)).ToList();
            if (talaltGodor.Count > 0)
            {
                Console.WriteLine("Van gödör");
            }
            else 
            {
                Console.WriteLine("Ezen a helyen nincs gödör");
            }
            Console.WriteLine($"a) \r\n A gödör kezdete: {talaltGodor.First().GetFirst().Meter} méteren A gödör vége {talaltGodor.Last().GetLast().Meter} méteren");

            
            
            
        }
    }
}
