namespace operatorOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szam sz1 = new Szam(5);
            Szam sz2 = new Szam(60);

            Szam sz3 = sz1 + sz2;
            //Console.WriteLine("-------------------------------");
            Console.WriteLine(sz3);

            var sz4 = sz1 + 3;
            Console.WriteLine("-------------------------------");

            Console.WriteLine(sz4);

            var sz5 = sz1 + (-2);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(sz5);
            int sz6 = 2+sz2;
            Console.WriteLine("-------------------------------");
            Console.WriteLine(sz6);
            sz1++;
            Console.WriteLine("-------------------------------");
            Console.WriteLine(sz1);
        }
    }
}
