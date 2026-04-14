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
            /*foreach (Match m in match)
            {
                Console.WriteLine(m);
            }*/
            Regex reg2 = new Regex(@"Romeo",RegexOptions.IgnoreCase);
            MatchCollection match2 = reg2.Matches(szoveg);
            Console.WriteLine(match2.Count);
            /*foreach (Match m in match2)
            {
                Console.WriteLine(m);
            }*/
            Regex reg3 = new Regex(@"\bRomeo[A-ZÖÜÓŐÚÉÁŰÍ]",RegexOptions.IgnoreCase);
            MatchCollection match3 = reg3.Matches(szoveg);
            Console.WriteLine(match3.Count);
            foreach (Match m in match3)
            {
               Console.WriteLine(m);
            }
            Regex reg4 = new Regex(@"\bJúlia[A-ZÖÜÓŐÚÉÁŰÍ]",RegexOptions.IgnoreCase);
            MatchCollection match4 = reg4.Matches(szoveg);
            Console.WriteLine(match4.Count);
            foreach (Match m in match4)
            {
               Console.WriteLine(m);
            }
            Regex reg5 = new Regex(@"\d+", RegexOptions.IgnoreCase);
            MatchCollection match5 = reg5.Matches(szoveg);
            Console.WriteLine(match5.Count);
            foreach (Match m in match5)
            {
                Console.WriteLine(m);
            }
            Regex reg6 = new Regex(@"\d{4}\.\d{2}\.\d{2}", RegexOptions.IgnoreCase);
            MatchCollection match6 = reg6.Matches(szoveg);
            Console.WriteLine(match6.Count);
            foreach (Match m in match6)
            {
                Console.WriteLine(m);
            }
            Regex reg7 = new Regex(@"ELSŐ ŐR\s+([^\s.,!?]+)\s+([^\s.,!?]+)\s", RegexOptions.IgnoreCase);
            MatchCollection match7 = reg7.Matches(szoveg);
            Console.WriteLine(match7.Count);
            foreach (var m in match7)
            {
                Console.WriteLine(m);
            }
            Regex reg8 = new Regex(@"ELSŐ ŐR\s+(?<elso>[^\s.,!?]+)\s+([^\s.,!?]+)\s", RegexOptions.IgnoreCase);
            MatchCollection match8 = reg8.Matches(szoveg);
            Console.WriteLine(match8.Count);
            foreach (var m in match8)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(reg8.Match(szoveg));

        }
    }
}
