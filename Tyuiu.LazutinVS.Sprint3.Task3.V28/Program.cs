using Tyuiu.LazutinVS.Sprint3.Task3.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        //DataService ds = new DataService();
        //Console.WriteLine("Введите строку: ");
        //string a = Console.ReadLine();
        //Console.WriteLine("Введите символ: ");
        //char start = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine("***************************************************************************");
        //Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        //Console.WriteLine("***************************************************************************");
        //Console.WriteLine(ds.ReplaceNumOnChar(a, start));
        //Console.ReadKey();
        int x;
        double sp = 0;
        int i = 0;
        for (x = -3; x <= 2; x++)
        {
            if (x == 0)
            {
                continue;
            }
            sp = sp + (2*x + 2);
            i++;
        }
        Console.WriteLine(sp);
    }
}