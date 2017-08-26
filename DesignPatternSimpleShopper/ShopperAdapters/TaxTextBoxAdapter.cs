using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DesignPatternSimpleShopper.ShopperControls;

namespace DesignPatternSimpleShopper.ShopperAdapters
{
    public class TaxTextBoxAdapter : TaxControl
    {
        public TaxTextBoxAdapter(TextBox textBox)
            : base()
        {
            mTextBox = textBox;
        }

        public override void ResetControl()
        {
            base.ResetControl();
            mTextBox.Clear();
        }

        protected override void SetText(string text)
        {
            mTextBox.Text = text;
        }

        private TextBox mTextBox;
    }
}
