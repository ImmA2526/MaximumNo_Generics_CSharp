using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNo
{
    public class MaximumNumber
    {
        public static int MaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                Console.Write("this is greater");
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            throw new Exception("firstNumber,secondNumber,thirdNumber Same");
        }
    }
}
