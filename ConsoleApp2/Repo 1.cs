using System;
internal class programm
{
    static void Main(string[] args)
    {
        int a = 0;
        string str;
        Console.WriteLine("Напишите год");

        str = Console.ReadLine();
        a = Convert.ToInt32(str);

        if (a % 4 == 0)
        {

            Console.WriteLine("Високосный год");
        }
        else
        {
            Console.WriteLine("Не високосный год");
        }
    }
}
