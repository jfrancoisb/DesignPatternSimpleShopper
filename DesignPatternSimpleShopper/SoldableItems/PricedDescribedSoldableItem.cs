using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternSimpleShopper.SoldableItems
{
    public class PricedDescribedSoldableItem : SoldableItemDecorator
    {
        public PricedDescribedSoldableItem(DescribedSoldableItem describedSoldableItem, decimal price)
            : base(describedSoldableItem)
        {
            mPrice = price;

        }

        public PricedDescribedSoldableItem(string name, decimal price)
            : this(new DescribedSoldableItem(name), price)
        {
        }

        public decimal GetPrice()
        {
            return mPrice;
        }

        public override string GetShortDescription()
        {
            string description = base.GetShortDescription();

            return string.Concat(description, " ", mPrice.ToString(), "$");
        } 

        protected decimal mPrice;
    }
}
