using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimpleShopper.SoldableItems
{
    public interface SoldableItem
    {
    
        string GetName();
        string GetShortDescription();
    }
}
