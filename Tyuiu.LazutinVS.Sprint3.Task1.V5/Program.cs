internal class Program
{
    private static void Main(string[] args)
    {
        double a = 0.25;
        int start = 1;
        int end = 9;

        DataService ds = new DataService();
        double MultiplySeries = ds.GetMultiplySeries(a, start, end);


        Console.WriteLine(MultiplySeries);
        Console.ReadKey();
    }
}