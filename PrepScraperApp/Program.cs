using PrepScraper;

class Program
{
    static void Main(string[] args)
    {
        Client client = new();
        Console.WriteLine(client.Test());
    }
}