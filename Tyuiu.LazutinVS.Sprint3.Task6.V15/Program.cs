using Tyuiu.LazutinVS.Sprint3.Task6.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        var result = ds.GetSumTheDivisors(a, b);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}