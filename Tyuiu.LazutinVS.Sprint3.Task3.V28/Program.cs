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
        int count1 = 0;


        for (x = 2; x <= 9; x++)
        {
            for (int d = 1; d <= x; d++)
            {
                if (x % d == 0)
                {
                    if (d > 3)
                    {
                        count1++;
                    }
                }
            }
        }
        Console.WriteLine(count1);
    }
}