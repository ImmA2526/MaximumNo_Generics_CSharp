using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNo
{
    public class MaximumNumber
    {
        public static int MaxNumber(int Firstno, int Secondno, int Thirdno)
        {
            if (Firstno.CompareTo(Secondno) > 0 && Secondno.CompareTo(Thirdno) > 0)
            {
                return Firstno;
            }
            if (Secondno.CompareTo(Firstno) > 0 && Secondno.CompareTo(Thirdno) > 0)
            {
                Console.Write("this is greater");
                return Secondno;
            }
            if (Thirdno.CompareTo(Firstno) > 0 && Thirdno.CompareTo(Secondno) > 0)
            {
                return Thirdno;
            }
            throw new Exception("Firstno,Secondno,Thirdno Same");
        }
    }
}
