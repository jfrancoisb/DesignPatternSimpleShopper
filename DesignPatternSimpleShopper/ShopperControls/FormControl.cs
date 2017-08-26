using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimpleShopper.ShopperMediators;

namespace DesignPatternSimpleShopper.ShopperControls
{
    public class FormControl : ShopperColleague
    {
        public void Initialise()
        {
            mMediator.Initialise();
        }
    }
}
