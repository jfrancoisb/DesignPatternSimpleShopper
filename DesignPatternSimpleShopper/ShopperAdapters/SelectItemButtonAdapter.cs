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
    public class SelectItemButtonAdapter : SelectItemControl
    {
        public SelectItemButtonAdapter(Button button, Form form)
            : base()
        {
            mButton = button;
            mForm = form;

            button.Click += this.selectItemButton_Click;
        }

        private void selectItemButton_Click(object sender, EventArgs e)
        {
            base.SelectItem();
        }

        private Button mButton;
        private Form mForm;
    }
}
