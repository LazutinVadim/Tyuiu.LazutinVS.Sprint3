using Tyuiu.LazutinVS.Sprint3.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 1 начальное значение: ");
        int startValue1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 1 конечное значение: ");
        int stopValue1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 2 начальное значение: ");
        int startValue2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("введите 2 конечное значение: ");
        int stopValue2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        var result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}