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

        public static double MaxFloatNumber(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            throw new Exception("firstNumber,secondNumber,thirdNumber Same.");
        }

        public static string StringMaximumNumber(string S1, string S2, string S3)
        {
            if (S1.CompareTo(S2) > 0 && S1.CompareTo(S3) > 0)
            {
                return S1;
            }
            if (S2.CompareTo(S1) > 0 && S2.CompareTo(S3) > 0)
            {
                return S2;
            }
            if (S3.CompareTo(S1) > 0 && S3.CompareTo(S2) > 0)
            {
                return S3;
            }
            throw new Exception("S1,S2,S3 are Same ");
        }
    }
}
