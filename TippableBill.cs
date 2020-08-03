using System;
using System.Collections.Generic;
using System.Text;

namespace BillInheritenceChallenge
{
    class TippableBill : Bill
    {

        public double Tip { get; set; }


        public TippableBill() { }

        public TippableBill(double tip, double subtotal, double taxrate) : base()
        {
            this.Tip = tip;
            TaxRate = taxrate;
            Subtotal = subtotal;

        }

        public override double CalcTotal()
        {
            double totalBill;

            totalBill = (Subtotal * (1 + TaxRate)) + Tip;

            return totalBill;
        }

    }
}
