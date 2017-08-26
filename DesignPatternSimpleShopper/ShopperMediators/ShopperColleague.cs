using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimpleShopper.ShopperMediators
{
    public abstract class ShopperColleague
    {
        public ShopperColleague()
        {
            mMediator = null;
        }

        public void SetMediator(ShopperMediator mediator)
        {
            mMediator = mediator;
        }

        protected ShopperMediator mMediator;
    }
}
