using System;

namespace MaximumNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome To Maximum Number Problem**********");
            Console.Write("Max Integer No is : ");
            int Output = MaximumNumber.MaxNumber(22, 11, 10);
            Console.WriteLine(Output);
        }
    }
}
