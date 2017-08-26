using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimpleShopper.SoldableItems
{
    public class DescribedSoldableItem : SoldableItem
    {
        public DescribedSoldableItem(string name)
        {
            mName = name;
        }

        public string GetName()
        {
            return mName;
        }

        public string GetShortDescription()
        {
            return mName;
        }

        private string mName;
    }
}
