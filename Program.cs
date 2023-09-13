namespace BlanketRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = PlayerCreator.Create();
            Console.WriteLine(player);
        }
    }
}