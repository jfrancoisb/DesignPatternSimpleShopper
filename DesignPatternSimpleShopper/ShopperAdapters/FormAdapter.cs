using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using DesignPatternSimpleShopper.ShopperControls;

namespace DesignPatternSimpleShopper.ShopperAdapters
{
    public class FormAdapter : FormControl
    {
        public FormAdapter(Form form)
            : base()
        {
            mForm = form;

            mForm.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Initialise();
        }

        private Form mForm;
    }
}
