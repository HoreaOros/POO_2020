using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class LunchOrder
    {
        private string bread;
        private string condiments;
        private string dressing;
        private string meat;

        private LunchOrder(Builder builder)
        {
            this.bread = builder.GetBread;
            this.condiments = builder.GetCondiments;
            this.dressing = builder.GetDressing;
            this.meat = builder.GetMeat;
        }

        public class Builder
        {
            private string bread;
            private string condiments;
            private string dressing;
            private string meat;
            
            public Builder()
            {

            }

            public Builder Bread(string bread)
            {
                this.bread = bread;
                return this;
            }
            public Builder Condiments(string condiments)
            {
                this.condiments = condiments;
                return this;
            }
            public Builder Dressing(string dressing)
            {
                this.dressing = dressing;
                return this;
            }
            public Builder Meat(string meat)
            {
                this.meat = meat;
                return this;
            }


            public string GetBread { get => bread; }
            public string GetCondiments { get => condiments; }
            public string GetDressing { get => dressing; }
            public string GetMeat { get => meat; }

            public LunchOrder GetLunchOrder()
            {
                return new LunchOrder(this);
            }

        }


        public string Bread { get => bread; }
        public string Condiments { get => condiments; }
        public string Dressing { get => dressing; }
        public string Meat { get => meat; }


        public override string ToString()
        {
            return new StringBuilder()
                .Append($"Bread: {Bread?? "<none>"}").AppendLine()
                .Append($"Condiments: {Condiments ?? "<none>"}").AppendLine()
                .Append($"Dressing: {Dressing ?? "<none>"}").AppendLine()
                .Append($"Meat: {Meat ?? "<none>"}").AppendLine()
                .ToString();
        }
    }
}
