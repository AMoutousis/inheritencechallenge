using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BillInheritenceChallenge
{
    class Bill
    {

        public double Subtotal { get; set; }
        public double TaxRate { get; set; }
        //default constructor
        public Bill() { }

        public Bill(double subtotal, double taxrate)
        {
            this.Subtotal = subtotal;
            this.TaxRate = taxrate;
        }

        public virtual double CalcTotal()
        {
            double totalBill;

            totalBill = Subtotal * (1 + TaxRate);

            return totalBill;
        }
    }
}
