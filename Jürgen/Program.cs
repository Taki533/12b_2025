namespace Jürgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penztarca jurgen = new Penztarca(500);
            Penztarca FrauMaria = new Penztarca(1600);
            Penztarca fizetes = new Penztarca(600);
            Console.WriteLine("Jürgen alapénze: " + jurgen);
            Console.WriteLine(jurgen - 150);
            jurgen.eur = jurgen - 150;
            Console.WriteLine("Jürgen pénze a gyerekének adás után: " + jurgen);
            if (jurgen < FrauMaria)
            {
                Console.WriteLine("EnyjeBenyje");
            }
            else
            {
                Console.WriteLine(jurgen - FrauMaria);
            }
            jurgen = jurgen - FrauMaria;
            Console.WriteLine("Jürgen pénze hitel fizetés után: " + jurgen);
            Console.WriteLine(jurgen + 500);
            Console.WriteLine(jurgen + fizetes);
        }
    }
}
