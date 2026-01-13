namespace Feluliras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szoveg s1 = new Szoveg("bulika");
            Szoveg s2 = new Szoveg("sas");
            
            var s5 = s1 - "buzi";
            var s3 = s1 + s2;
            var s4 = s1 + "anyu";
            
            Console.WriteLine(s1<s2);
            Console.WriteLine(s1>s2);
            Console.WriteLine(s1==s2);
            Console.WriteLine(s1!=s2);
            Console.WriteLine(s3.szoveg);
            Console.WriteLine(s4.szoveg);
            Console.WriteLine(s5.szoveg);
        }
    }
}
