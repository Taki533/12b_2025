using System.Text.RegularExpressions;
namespace RegExp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = File.ReadAllText("blabla.txt");
            Console.WriteLine(szoveg);
            Regex reg = new Regex(@"[^\s][A-Z-ÖÜÓŐÚÉÁŰÍ]{2,}\b\s[A-Z-ÖÜÓŐÚÉÁŰÍ]{2,}\b|[A-Z-ÖÜÓŐÚÉÁŰÍ]{2,}\b");
            MatchCollection match = reg.Matches(szoveg);
            foreach (Match m in match)
            {
                Console.WriteLine(m);
            }
        }
    }
}
