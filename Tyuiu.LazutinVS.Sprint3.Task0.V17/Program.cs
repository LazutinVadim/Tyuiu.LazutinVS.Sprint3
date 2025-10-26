using Tyuiu.LazutinVS.Sprint3.Task0.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Write("Введите значение: ");
        double inputValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите начальное значение: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите конечное значение: ");
        int stop = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(ds.GetSumSeries(inputValue, start, stop));
    }
}