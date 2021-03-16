using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Transaction
    {
        public static void ProcessTransaction(string itemType)
        {
            try
            {
                Dictionary<string, double> coinValDict = Products.GetCoinValue();
                double itemPrice = Products.productDict[itemType];
                Console.WriteLine("Please pay nickels/dimes/quarters to pay {0} dollar amount and proceed: ", itemPrice);

                double inputPrice;
                bool isSuccess = Double.TryParse(Console.ReadLine(), out inputPrice);
                CalculatePayment(itemPrice, inputPrice, isSuccess);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
        }

        public static bool CalculatePayment(double itemPrice, double inputPrice, bool isSuccess)
        {
            bool bRet = false;
            double inputAmount = 0;
            if (isSuccess)
            {
                if (inputPrice == 0.01)
                {
                    Console.WriteLine("Pennies not allowed. Please try again..");
                    inputAmount = 0;
                }
                else
                    inputAmount += inputPrice;
                do
                {
                    if (inputAmount < itemPrice)
                        Console.WriteLine("Please pay additional {0} amount to proceed", itemPrice - inputAmount);
                    else if (inputAmount > itemPrice)
                    {
                        Console.WriteLine("Thanks for the purchase!!");
                        Console.WriteLine("Please collect change {0} dollar(s)..", inputAmount - itemPrice);
                        bRet = true;
                    }
                    inputAmount += Convert.ToDouble(Console.ReadLine());
                }
                while (inputAmount != itemPrice);
            }
            else
            {
                Console.WriteLine("Please enter valid amount!!");
                bRet = false;
            }
            return bRet;
        }
    }
}
