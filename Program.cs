namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(Karta kartalar in Enum.GetValues(typeof(Karta)))
            {
                Console.WriteLine(kartalar);
            }
        }
    }
    enum Karta
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }
}