using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimpleShopper.ShopperMediators;

namespace DesignPatternSimpleShopper.ShopperControls
{
    public abstract class TaxControl : ShopperColleague
    {
        public TaxControl()
        {
        }

        public virtual void ResetControl()
        {
            SetText(string.Empty);
        }

        public void ComputeTaxes(decimal price)
        {
            ResetControl();

            decimal tps = Math.Round(price * 0.05m,  2, MidpointRounding.AwayFromZero);
            decimal tvq = Math.Round(price * 0.09975m, 2, MidpointRounding.AwayFromZero);
            decimal total = price + tps + tvq;

            StringBuilder taxesCalculation = new StringBuilder();

            taxesCalculation.Append("Sous Total");
            taxesCalculation.Append(" = ");
            taxesCalculation.Append(price.ToString());
            taxesCalculation.Append("$");
            taxesCalculation.AppendLine();

            taxesCalculation.Append("TPS");
            taxesCalculation.Append("(");
            taxesCalculation.Append("5%");
            taxesCalculation.Append(") = ");
            taxesCalculation.Append(tps);
            taxesCalculation.Append("$");
            taxesCalculation.AppendLine();

            taxesCalculation.Append("TVQ");
            taxesCalculation.Append("(");
            taxesCalculation.Append("9.975%");
            taxesCalculation.Append(") = ");
            taxesCalculation.Append(tvq);
            taxesCalculation.Append("$");
            taxesCalculation.AppendLine();

            taxesCalculation.Append("Total");
            taxesCalculation.Append(" = ");
            taxesCalculation.Append(total);
            taxesCalculation.Append("$");

            SetText(taxesCalculation.ToString());
        }

        protected abstract void SetText(string text);
    }
}
