using Tyuiu.LazutinVS.Sprint3.Task7.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Результат:                                                                   *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine(" +-----------+-----------+");
        Console.WriteLine(" |     X     |    F(x)   |");
        Console.WriteLine(" +-----------+-----------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(" |{0,5:d}       |  {1, 5:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine(" +-----------+-----------+");
        Console.ReadKey();
    }
}