using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
            };

            gameEngine.Fight();

            GameEngine gameEngine2 = new GameEngine()
            {
                HeroA = new Warrior("Ivan", 11, 10, new Sword("Me4o")),
                HeroB = new Wizzard("Petar", 12, 30, new Crossbow("Arbalet4o")),
                NotificationsCallBack = ConsoleNotification
            };

            gameEngine2.Fight();

            Console.WriteLine();
            Console.WriteLine($"The first winner is {gameEngine.Winner}");
            Console.WriteLine();
            Console.WriteLine($"And the second winner is {gameEngine2.Winner}");
        }
    }
}