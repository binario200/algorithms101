/*
Problem: Find out what product prices were modified from the OriginaItems and OriginalPrices arrays.

origItems array contains original products: { "cheese", "milk", "juice", "eggs", "bacon" }
origPrices array contains original product prices:  { 115.23, 34.67, 5.90, 7.8, 34.78, 50.32 }

modifItems array contains products that were modified by someone:  { "milk", "eggs" }
modifPrices array contains product prices that were modified by someone: { 54.4, 50.1 }

Find the best Algorithm in Terms of Performance: 

Example of O(N*N) solution: 

            string[] origItems = {"cheese", "milk", "juice", "eggs", "bacon"};
            double[] origPrices = { 115.23, 34.67, 5.90, 7.8, 34.78, 50.32 };
            string[] modifItems = { "milk", "eggs" };
            double[] modifPrices = { 54.4, 50.1 };
 
            int altered_price=0;
 
            for (int i = 0; i < modifItems.Length; i++) {
                for (int j = 0; j < origItems.Length; j++) {
                    if (modifItems[i] == origItems[j]) {
                        if (origPrices[j] != modifPrices[i]){
                            altered_price++;
                            break;
                        }
                    }
                }
            }


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] origItems = { "cheese", "milk", "juice", "eggs", "bacon" };
            double[] origPrices = { 115.23, 34.67, 5.90, 7.8, 34.78, 50.32 };
            string[] modifItems = { "milk", "eggs" };
            double[] modifPrices = { 54.4, 50.1 };
            int altered_price = 0;

            Dictionary<string, double> origDictionary = new Dictionary<string, double>();

            for (int index = 0; index < origItems.Length; index++)
            {
                origDictionary.Add(origItems[index], origPrices[index]);
            }

            Dictionary<string, double> modifDictionary = new Dictionary<string, double>();

            for (int index = 0; index < modifItems.Length; index++)
            {
                modifDictionary.Add(modifItems[index], modifPrices[index]);
            }

            for (int index = 0; index < modifDictionary.Count; index++)
            {
                var item = modifDictionary.ElementAt(index);                
                var found = origDictionary.FirstOrDefault(t => t.Key == item.Key);

                if (found.Key != null) {
                    if (found.Value != item.Value)
                        altered_price++;
                }                
            }

            System.Console.WriteLine(altered_price);
        }
    }
}
