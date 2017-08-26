using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimpleShopper.SoldableItems
{
    public class QuatifiedPricedDescribedSoldableItem : SoldableItemDecorator
    {

        public QuatifiedPricedDescribedSoldableItem(PricedDescribedSoldableItem pricedDescribedSoldableItem, int quantity)
            : base(pricedDescribedSoldableItem)
        {
            mQuantity = quantity;
        }

        public QuatifiedPricedDescribedSoldableItem(string name, decimal price, int quantity)
            : this(new PricedDescribedSoldableItem(name, price), quantity)
        {
        }

        public override string GetShortDescription()
        {
            string pricedDescription = base.GetShortDescription();

            return string.Concat(pricedDescription, " X ", mQuantity.ToString(), " = ", GetTotalPrice().ToString(), "$");
        } 

        public decimal GetPrice()
        {
            PricedDescribedSoldableItem pricedDescribedSoldableItem = (PricedDescribedSoldableItem)mComponent;

            return pricedDescribedSoldableItem.GetPrice();
        }

        public int GetQuantity()
        {
            return mQuantity;
        }

        public decimal GetTotalPrice()
        {
            return mQuantity * GetPrice();
        }

        public void IncrementQuantity()
        {
            mQuantity++;
        }

        private int mQuantity;
    }
}
