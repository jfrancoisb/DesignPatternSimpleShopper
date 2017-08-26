using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using DesignPatternSimpleShopper.ShopperControls;
using DesignPatternSimpleShopper.SoldableItems;

namespace DesignPatternSimpleShopper.ShopperAdapters
{
    public class AvailableItemsToPurchaseComboBoxAdapter : AvailableItemsToPurchaseControl
    {
        public AvailableItemsToPurchaseComboBoxAdapter(ComboBox comboBox, Form form)
            : base()
        {
            mComboBox = comboBox;
            mForm = form;

            mComboBox.SelectedIndexChanged += this.availableItemsToPurchase_SelectedIndexChanged;
        }

        public override void AddSellingItem(PricedDescribedSoldableItem pricedDescribedSoldableItem)
        {
            base.AddSellingItem(pricedDescribedSoldableItem);

            mComboBox.Items.Add(pricedDescribedSoldableItem.GetShortDescription());
        }

        public override void SelectSellingItem()
        {
            if (mComboBox.SelectedIndex >= 0)
                mSelectedSellingItem = mSellingItems[mComboBox.SelectedIndex];
            else
                mSelectedSellingItem = null;
        }

        public override void ResetControl()
        {
            base.ResetControl();
            mComboBox.Items.Clear();
        }

        private void availableItemsToPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.SellectSellingItem();
        }

        private ComboBox mComboBox;
        private Form mForm;
    }
}
