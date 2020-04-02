using System;
using System.Collections.Generic;
namespace AB2
{
    public class MenuOrder
    {
        public IDictionary<string, decimal> cart = new Dictionary<string, decimal>();

        public void Add(MenuItem itemchoice)
        {

            bool keyExists = cart.ContainsKey(itemchoice.itemName);
            if (keyExists)
            {
                double newQuant = cart[itemchoice.itemName] + 1;
                Console.WriteLine("You have added {0} {1}", cart[itemchoice.itemName], itemchoice.itemName);
            }
            else
            {
                cart.Add(itemchoice.itemName, 1);
            }
        }

        public void PrintOrder()
        {
            foreach (KeyValuePair<string, decimal> entry in cart)

            {
                /* for each item in our order (in the dictionary)
                 * print the quantity, item name, and then cost
                 * where cost is
                 * quantity (dictionary value) x MenuItem.itemPrice (object attrib.)
                 */

                decimal kosten = entry.Value *  MenuItem {entry}.itemPrice;
                Console.WriteLine("{0}x {1} - {2}", entry.Value, entry.Key);
                
            }
        }

        public MenuOrder()
        {
        }


    }
}
/* for each - https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary */
