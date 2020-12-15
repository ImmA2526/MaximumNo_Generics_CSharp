using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNo
{
    public class MaximumNumber<T> where T:IComparable
    {
        public T firstNumber,secondNumber,thirdNumber;
        
        public MaximumNumber(T firstNumber, T secondNumber, T thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }
        public static T MaxNumber(T firstNumber, T secondNumber, T thirdNumber) 
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

        public static T MaxFloatNumber(T firstNumber, T secondNumber, T thirdNumber)
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

        public static T StringMaximumNumber(T S1, T S2, T S3) 
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