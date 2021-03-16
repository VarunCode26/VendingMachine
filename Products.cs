using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Products
    {
        public static Dictionary<string, double> coinValueDict = new Dictionary<string, double>();
        
        public static Dictionary<string, double> productDict = new Dictionary<string, double>();
        public static Dictionary<string, double> GetProducts()
        {
            productDict.Add(Convert.ToString(item.cola), 1);
            productDict.Add(Convert.ToString(item.chips), 0.5);
            productDict.Add(Convert.ToString(item.candy), 0.65);
            return productDict;
        }
        public static Dictionary<string, double> GetCoinValue()
        {
            coinValueDict.Add(Convert.ToString(coinType.nickels), 0.05);
            coinValueDict.Add(Convert.ToString(coinType.dimes), 0.1);
            coinValueDict.Add(Convert.ToString(coinType.quarters), 0.25);
            coinValueDict.Add(Convert.ToString(coinType.pennies), 0.01);

            return coinValueDict;
        }

        public static bool isProductExist(string ProductName)
        {
            return productDict.ContainsKey(ProductName);
        }
    }
}
