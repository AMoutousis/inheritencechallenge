using System;

namespace BillInheritenceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill testBill = new Bill();

            Console.WriteLine("Hello World! I'm in main!");

            Bill jackie = new Bill(15.8, 0.06);
            Pay(jackie);

            TippableBill robbie = new TippableBill(2, 8.5, 0.06);
            Pay(robbie);

        }
        public static void Pay(Bill testBill)
        {
            Console.WriteLine($"${testBill.CalcTotal()}");
        }
    }
}
