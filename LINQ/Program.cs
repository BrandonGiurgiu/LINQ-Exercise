namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "Call of Duty", "ATV", "Spiderman", "Grand Turismo" };

            var order = videoGames.OrderBy(game => game.Length);

            foreach (var game in order)
            {
                Console.WriteLine($" {game} ");
                Console.WriteLine("------------");
            }

            Console.ReadLine();

        }
    }
}
