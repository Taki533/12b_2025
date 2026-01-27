using System.Text.RegularExpressions;
namespace RegExp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = File.ReadAllText("blabla.txt");
            Console.WriteLine(szoveg);
            Regex reg = new Regex("^[A-Z]+\b");
            MatchCollection match = reg.Matches(szoveg);
            Console.WriteLine(match.Count);
        }
    }
}
