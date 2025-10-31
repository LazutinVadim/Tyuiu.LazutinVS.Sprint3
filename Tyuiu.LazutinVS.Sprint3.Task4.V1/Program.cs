using Tyuiu.LazutinVS.Sprint3.Task4.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double sum = ds.Calculate(-5, 5);

        Console.WriteLine($"Сумма значений функции : {sum}");

        Console.ReadKey();
    }
}