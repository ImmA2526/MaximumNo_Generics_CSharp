using System;

namespace MaximumNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome To Maximum Number Problem**********");
            int [] Output = { 11,22,50 };
            MaximumNumber<int> generic = new MaximumNumber<int>(Output);
            generic.PrintValue();
        }
    }
}