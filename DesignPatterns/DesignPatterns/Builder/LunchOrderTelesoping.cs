using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class LunchOrderTelescoping
    {
        private string bread;
        private string condiments;
        private string dressing;
        private string meat;

        public LunchOrderTelescoping(string bread)
        {
            this.bread = bread;
        }

        public LunchOrderTelescoping(string bread, string condiments) :this(bread)
        {
            this.condiments = condiments;
        }

        public LunchOrderTelescoping(string bread, string condiments, string dressing) : this(bread, condiments)
        {
            this.dressing = dressing;
        }

        public LunchOrderTelescoping(string bread, string condiments, string dressing, string meat) : this(bread, condiments, dressing)
        {
            this.meat = meat;
        }



        public string Bread { get => bread; }
        public string Condiments { get => condiments; }
        public string Dressing { get => dressing; }
        public string Meat { get => meat; }
    }
}
