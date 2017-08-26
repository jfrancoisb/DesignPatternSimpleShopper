using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using DesignPatternSimpleShopper.ShopperAdapters;
using DesignPatternSimpleShopper.ShopperControls;
using DesignPatternSimpleShopper.SoldableItems;

namespace DesignPatternSimpleShopper.ShopperMediators
{
    public class FormShopperMediator : ShopperMediator
    {
        public FormShopperMediator(
            TaxControl taxControl,
            AvailableItemsToPurchaseControl availableItemsToPurchaseControl,
            SelectedSellingItemsControl selectedSellingItemsControl,
            SelectItemControl selectItemControl,
            FormControl formControl
            )
             : base()
        {
            mTaxControl = taxControl;
            mAvailableItemsToPurchaseControl = availableItemsToPurchaseControl;
            mSelectedSellingItemsControl = selectedSellingItemsControl;
            mSelectItemControl  = selectItemControl;
            mFormControl = formControl;

            mTaxControl.SetMediator(this);
            mAvailableItemsToPurchaseControl.SetMediator(this);
            mSelectedSellingItemsControl.SetMediator(this);
            mSelectItemControl.SetMediator(this);
            mFormControl.SetMediator(this);
        }

        public override void Initialise()
        {
            mAvailableItemsToPurchaseControl.ResetControl();

            PricedDescribedSoldableItem item1 = new PricedDescribedSoldableItem("shoes", 35.78m);
            PricedDescribedSoldableItem item2 = new PricedDescribedSoldableItem("hats", 50.99m);
            PricedDescribedSoldableItem item3 = new PricedDescribedSoldableItem("glasses", 12.99m);

            mAvailableItemsToPurchaseControl.AddSellingItem(item1);
            mAvailableItemsToPurchaseControl.AddSellingItem(item2);
            mAvailableItemsToPurchaseControl.AddSellingItem(item3);
        }

        public override void AddSellingItemToSelectedSellingItems()
        {
            PricedDescribedSoldableItem selectedSellingItem = mAvailableItemsToPurchaseControl.GetSelectedSellingItem();
            mSelectedSellingItemsControl.AddSellingItem(selectedSellingItem);

            decimal totalPrice = mSelectedSellingItemsControl.GetTotalSellingItemPrice();

            mTaxControl.ComputeTaxes(totalPrice);
        }

        public override void SelectSellingItem()
        {
            mAvailableItemsToPurchaseControl.SelectSellingItem();
        }

        public override decimal GetSellingItemsTotalPrice()
        {
            throw new NotImplementedException();
        }

        private TaxControl mTaxControl;
        private AvailableItemsToPurchaseControl mAvailableItemsToPurchaseControl;
        private SelectedSellingItemsControl mSelectedSellingItemsControl;
        private SelectItemControl mSelectItemControl;
        private FormControl mFormControl;
    }
}
