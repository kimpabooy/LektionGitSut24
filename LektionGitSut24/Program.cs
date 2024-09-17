namespace LektionGitSut24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this game!");
            Console.WriteLine("Choose a nickname: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"welcome {userName}");
            Console.ReadKey();
        }
    }
}
