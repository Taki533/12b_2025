namespace Jeladó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("jel.txt");
            List<Adat> adatok = new List<Adat>();
            sorok.ToList().ForEach(e=> adatok.Add(new Adat(e)));
        }
    }
}
