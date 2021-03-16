using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ValidateInput
    {
        public  Dictionary<string, double> products = Products.GetProducts();
        public  bool Validate(string input)
             {
            bool bRet = false;
            if (products.ContainsKey(input))
                bRet = true;

            return bRet;
        }
    }
}
