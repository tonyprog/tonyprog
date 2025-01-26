using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入您的名字：");
        string name = Console.ReadLine();

        Console.WriteLine("請輸入您的年齡：");
        string ageInput = Console.ReadLine();

        if (int.TryParse(ageInput, out int age))
        {
            Console.WriteLine($"嗨，{name}！您今年 {age} 歲。");
        }
        else
        {
            Console.WriteLine("您輸入的年齡無效！");
        }

        Console.WriteLine("按下任意鍵結束程式...");
        Console.ReadKey();
    }
}
