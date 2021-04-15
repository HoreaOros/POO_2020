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
    public class LunchOrder1Tests
    {
        [TestMethod()]
        public void LunchOrderTest()
        {
            // arrange
            LunchOrderProp order = new LunchOrderProp();

            // act 
            order.Bread = "Wheat";
            order.Condiments = "Salt & pepper";
            order.Dressing = "Mustard";
            order.Meat = "Ham";
            
            // assert

            
        }
    }
}