using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class LunchOrderProp
    {
        private string bread;
        private string condiments;
        private string dressing;
        private string meat;

        public LunchOrderProp()
        {
        
        }

        public string Bread { get => bread; set => bread = value; }
        public string Condiments { get => condiments; set => condiments = value; }
        public string Dressing { get => dressing; set => dressing = value; }
        public string Meat { get => meat; set => meat = value; }
    }
}
