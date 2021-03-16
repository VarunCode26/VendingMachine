using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your choice:  1) cola 2) chips 3) candy");
            string input = Console.ReadLine().ToLower();
            ValidateInput verifyInput = new ValidateInput();
            bool isValid = verifyInput.Validate(input);
            if (isValid)
            {
                //Check denominations
                Transaction.ProcessTransaction(input);
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
