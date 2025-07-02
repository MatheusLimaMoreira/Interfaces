using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return BasicPayment.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) +
                   " + " + Tax.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) +
                   " = " + TotalPayment.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }

    }
}
