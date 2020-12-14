using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNo;
namespace MaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        MaximumNumber Max = new MaximumNumber();
        //private readonly MaximumNumber max;
        public UnitTest1()
        {
            Max = new MaximumNumber();
        }
        
        /// <summary>
        /// Check MAximum Number and return the first number is maximum
        /// </summary>
        [TestMethod]
        public void CheckFirstMaximumNumber_WhenGreaterNo_FirstPosition()
        {
            int max = 22;
            int Result = MaximumNumber.MaxNumber(22,11,10);
            Assert.AreEqual(max,Result);
        }

        /// <summary>
        /// Check MAximum Number and return the Second number is maximum
        /// </summary>
        [TestMethod]
        public void CheckSecondMaximumNumber_WhenGreaterNo_SecondNumber()
        {
            int max = 24;
            int Result = MaximumNumber.MaxNumber(22, 24, 10);
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum Number and return the Third number is maximum
        /// </summary>
        [TestMethod]
        public void CheckThirMaximumNumber_WhenGreaterNo_ThirdNumber()
        {
            int max = 28;
            int Result = MaximumNumber.MaxNumber(22, 24, 28);
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum Float Number and return the First number is maximum
        /// </summary>
        [TestMethod]
        public void CheckFloat_FirstNumber_WhenGreaterNo_FirstNumber()
        {
            double max = 20.1;
            double Result = MaximumNumber.MaxFloatNumber(20.1,10.1,11.2);
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        ///Check MAximum Float Number and return the Second number is maximum 
        /// </summary>
        [TestMethod]
        public void CheckFloat_SecondNumber_WhenGreaterNo_SecondNumber()
        {
            double max = 28.1;
            double Result= MaximumNumber.MaxFloatNumber(20.2, 28.1, 11.2);
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum Float Number and return the Third number is maximum
        /// </summary>
        [TestMethod]
        public void CheckFloat_ThirdNumber_WhenGreaterNo_ThirdNumber()
        {
            double max = 30.2;
            double Result= MaximumNumber.MaxFloatNumber(20.2, 28.1, 30.2);
            Assert.AreEqual(max, Result);
        }
    }
}
