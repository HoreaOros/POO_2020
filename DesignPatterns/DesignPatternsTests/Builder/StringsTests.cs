using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Tests
{
    [TestClass()]
    public class StringsTests
    {
        [TestMethod()]
        public void BuildStringTest()
        {
            // arrange
            List<object> items = new List<object> { "Hello", 42, 'G'};

            // act 
            string result = Strings.BuildString(items);
            string expected = "Hello" 
                + Environment.NewLine 
                + "42" 
                + Environment.NewLine 
                + "G" + Environment.NewLine;


            // assert

            Assert.AreEqual(result, expected);
        }
    }
}