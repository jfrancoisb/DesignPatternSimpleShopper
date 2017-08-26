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
    public class SelectedSellingItemsListBoxAdapter : SelectedSellingItemsControl
    {
        public SelectedSellingItemsListBoxAdapter(ListBox listBox)
        {
            mListBox = listBox;
        }

        public override void ResetControl()
        {
            base.ResetControl();
            mListBox.Items.Clear();
        }

        public override void UpdateSellingItemDescription(QuatifiedPricedDescribedSoldableItem quatifiedPricedDescribedSoldableItem)
        {
            string shortDescription = quatifiedPricedDescribedSoldableItem.GetShortDescription();
            int selectedItemPosition = GetSelectedItemPosition(quatifiedPricedDescribedSoldableItem);

            if (mListBox.Items.Count >= selectedItemPosition + 1)
            {
                mListBox.Items[selectedItemPosition] = shortDescription;
            }
            else
            {
                mListBox.Items.Add(shortDescription);
            }
        }


        private ListBox mListBox;
    }
}
