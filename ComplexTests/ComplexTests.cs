using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers.Tests
{
    [TestClass()]
    public class ComplexTests
    {
        [TestMethod()]
        public void AddTest()
        {
            /// AAA
            
            // arrange
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(2, 3);

            Complex expected = new Complex(2, 5);
            // act
            Complex actual = c1.Add(c2);

            // assert

            Assert.AreEqual(expected.Real, actual.Real, "partile reale nu sunt egale");
            //Assert.AreEqual(expected.Imag, actual.Imag, "partile reale nu sunt egale");

        }
    }
}