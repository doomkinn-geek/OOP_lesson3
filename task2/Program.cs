using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            Console.WriteLine($"Реверс введнной строки: {ReverseString(str)}");
        }

        static string ReverseString(string input)
        {
            string res = "";
            for(int i = input.Length-1;i>=0;i--)
            {
                res += input[i];
            }
            return res;
        }
    }
}
