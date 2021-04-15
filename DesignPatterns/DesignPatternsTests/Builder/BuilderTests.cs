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
    public class BuilderTests
    {
        [TestMethod()]
        public void GetLunchOrderTest()
        {
            // arrange
            LunchOrder.Builder builder = new LunchOrder.Builder();

            // act
            LunchOrder order =
                builder.Bread("Wheat")
                .Dressing("Mayo")
                .Meat("Turkey")
                .GetLunchOrder();

            // assert
            Assert.AreEqual(order.Bread, "Wheat");
            Assert.AreEqual(order.Condiments, null);
            Assert.AreEqual(order.Dressing, "Mayo");
            Assert.AreEqual(order.Meat, "Turkey");

        }
    }
}