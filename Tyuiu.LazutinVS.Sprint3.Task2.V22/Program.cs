using Tyuiu.LazutinVS.Sprint3.Task2.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        
        int value = 5;
        int startValue = 1;
        int stopValue = 7;

        Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}