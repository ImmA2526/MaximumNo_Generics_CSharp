using System;

namespace MaximumNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome To Maximum Number Problem**********");
            Console.Write("Max Integer No is : ");
            int Output = MaximumNumber<int>.MaxNumber(22, 11, 10);
            Console.WriteLine(Output);
            Console.Write("Max Float Number is : ");
            double FloatOutput = MaximumNumber<double>.MaxFloatNumber(20.2, 11.2, 10.2);
            Console.WriteLine(FloatOutput);
            Console.Write("Maximum String is : ");
            string StringOutput = MaximumNumber<string>.StringMaximumNumber("Apple","Peach","Banana");
            Console.Write(StringOutput);
        }
    }
}