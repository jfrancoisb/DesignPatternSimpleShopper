using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimpleShopper.SoldableItems;
using DesignPatternSimpleShopper.ShopperMediators;

namespace DesignPatternSimpleShopper.ShopperControls
{
    public abstract class SelectedSellingItemsControl : ShopperColleague
    {
        public SelectedSellingItemsControl()
        {
            mSellingItems = new List<QuatifiedPricedDescribedSoldableItem>();
        }

        public void AddSellingItem(PricedDescribedSoldableItem sellingItem)
        {
            if (sellingItem != null)
            {
                QuatifiedPricedDescribedSoldableItem quatifiedPricedDescribedSoldableItem = null;

                int selectedItemPosition = GetSelectedItemPosition(sellingItem);

                if (selectedItemPosition >= 0)
                {
                    quatifiedPricedDescribedSoldableItem = mSellingItems[selectedItemPosition];
                    quatifiedPricedDescribedSoldableItem.IncrementQuantity();
                }
                else
                {
                    quatifiedPricedDescribedSoldableItem = new QuatifiedPricedDescribedSoldableItem(sellingItem, 1);
                    mSellingItems.Add(quatifiedPricedDescribedSoldableItem);
                }

                UpdateSellingItemDescription(quatifiedPricedDescribedSoldableItem);
            }
        }

        public List<QuatifiedPricedDescribedSoldableItem> GetSellingItems()
        {
            return mSellingItems;
        }

        public decimal GetTotalSellingItemPrice()
        {
            decimal lPrice = 0m;
            foreach (QuatifiedPricedDescribedSoldableItem sellingItem in mSellingItems)
                lPrice += sellingItem.GetTotalPrice();

            return lPrice;
        
        }

        public virtual void ResetControl()
        {
            mSellingItems.Clear();
        }

        protected int GetSelectedItemPosition(SoldableItem soldableItem)
        {
            int position = -1;

            foreach (QuatifiedPricedDescribedSoldableItem item in mSellingItems)
            {
                position++;
                if (item.GetName() == soldableItem.GetName())
                {
                    return position;
                }
            }

            return -1;
        }

        public abstract void UpdateSellingItemDescription(QuatifiedPricedDescribedSoldableItem quatifiedPricedDescribedSoldableItem);


        private List<QuatifiedPricedDescribedSoldableItem> mSellingItems;
    }
}
