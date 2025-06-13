using twentynine;

internal class Program
{
    private static void Main(string[] args)
    {
        SportsmanList sportsmenList = new SportsmanList(
            new Sportsman("Art", 25, "Swimming", 5),
            new Sportsman("Dan", 12, "Football", 2),
            new Sportsman("Alex", 30, "Tennis", 10),
            new Sportsman("Sam", 12, "Basketball", 3),
            new Sportsman("Deny" , 18, "Football", 1),
            new Sportsman("John", 20, "Swimming", 4)
            );

        foreach (Sportsman sportsman in sportsmenList.GetAllSportsmenOf("Swimming"))
        {
            Console.WriteLine("-- " + sportsman.ToString());
        }
    }
}