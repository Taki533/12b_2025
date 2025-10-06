namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            kampanyFilm film = new kampanyFilm();
            Console.WriteLine(film.tipus);
            film.show();
            Console.WriteLine(film);
        }
    }
}
