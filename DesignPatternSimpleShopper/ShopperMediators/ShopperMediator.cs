using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimpleShopper.ShopperAdapters;
using DesignPatternSimpleShopper.ShopperControls;
using DesignPatternSimpleShopper.SoldableItems;

namespace DesignPatternSimpleShopper.ShopperMediators
{
    public abstract class ShopperMediator
    {
        public ShopperMediator()
        {
        }

        public abstract void Initialise();
        public abstract void AddSellingItemToSelectedSellingItems();
        public abstract void SelectSellingItem();
        public abstract decimal GetSellingItemsTotalPrice();
    }
}
