using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimpleShopper.SoldableItems;
using DesignPatternSimpleShopper.ShopperMediators;

namespace DesignPatternSimpleShopper.ShopperControls
{
    public abstract class AvailableItemsToPurchaseControl : ShopperColleague
    {
        public AvailableItemsToPurchaseControl()
        {
            mSellingItems = new List<PricedDescribedSoldableItem>();
        }

        public virtual void AddSellingItem(PricedDescribedSoldableItem pricedDescribedSoldableItem)
        {
            mSellingItems.Add(pricedDescribedSoldableItem);
        }

        public virtual void ResetControl()
        {
            mSellingItems.Clear();
        }

        public PricedDescribedSoldableItem GetSelectedSellingItem()
        {
            return mSelectedSellingItem;
        }

        public abstract void SelectSellingItem();

        protected List<PricedDescribedSoldableItem> mSellingItems;
        protected PricedDescribedSoldableItem mSelectedSellingItem;

        public void SellectSellingItem()
        {
            mMediator.SelectSellingItem();
        }
    }
}
