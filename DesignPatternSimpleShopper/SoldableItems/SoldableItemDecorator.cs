using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimpleShopper.SoldableItems
{
    public abstract class SoldableItemDecorator : SoldableItem
    {
        public SoldableItemDecorator()
        {

        }

        public SoldableItemDecorator(SoldableItem soldableItem)
        {
            mComponent = soldableItem;
        }

        public string GetName()
        {
            return mComponent.GetName();
        }

        public virtual string GetShortDescription()
        {
            return mComponent.GetShortDescription();
        }

        protected SoldableItem mComponent;
    }
}
