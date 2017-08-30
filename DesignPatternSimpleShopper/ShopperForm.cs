using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DesignPatternSimpleShopper.ShopperAdapters;
using DesignPatternSimpleShopper.ShopperControls;
using DesignPatternSimpleShopper.ShopperMediators;

namespace DesignPatternSimpleShopper
{
    public partial class ShopperForm : Form
    {
        public ShopperForm()
        {
            InitializeComponent();

            TaxControl lTaxControl = new TaxTextBoxAdapter(taxesCalculationTextBox);
            AvailableItemsToPurchaseControl lAvailableItemsToPurchaseControl = new AvailableItemsToPurchaseComboBoxAdapter(availableItemsToPurchase, this);
            SelectedSellingItemsControl lSelectedSellingItemsControl = new SelectedSellingItemsListBoxAdapter(sellingItemsListBox);
            SelectItemControl lSelectItemControl = new SelectItemButtonAdapter(selectItemButton);
            FormControl lFormControl = new FormAdapter(this);

            ShopperMediator lShopperMediator = new FormShopperMediator(
                lTaxControl, 
                lAvailableItemsToPurchaseControl, 
                lSelectedSellingItemsControl,
                lSelectItemControl, 
                lFormControl);
        }
    }
}
