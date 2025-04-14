using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Xin chào, {args[0]}!");
        }
        else
        {
            Console.WriteLine("Không có tên nào được truyền trong args.");
        }

        Console.ReadLine(); // Chờ nhấn phím
    }
}
