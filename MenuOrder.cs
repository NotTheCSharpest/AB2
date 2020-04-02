using System;
using System.Collections.Generic;
namespace AB2
{
    public class MenuOrder
    {
        public IDictionary<MenuItem, decimal> cart = new Dictionary<MenuItem, decimal>();

        public void Add(MenuItem itemchoice)
        {

            bool keyExists = cart.ContainsKey(itemchoice);
            if (keyExists)
            {
                decimal newQuant = cart[itemchoice] + 1;
                Console.WriteLine("You have added {0} {1}", cart[itemchoice], itemchoice.itemName);
            }
            else
            {
                cart.Add(itemchoice, 1);
            }
        }

        public void PrintOrder()
        {
            foreach (KeyValuePair<MenuItem, decimal> entry in cart)

            {
                /* for each item in our order (in the dictionary)
                 * print the quantity, item name, and then cost
                 * where cost is
                 * quantity (dictionary value) x MenuItem.itemPrice (object attrib.)
                 */

                decimal kosten = entry.Value *  entry.Key.itemPrice;
                Console.WriteLine("printing order...");
                Console.WriteLine("{0}x {1} - {2}", entry.Value, entry.Key.itemName, kosten);
                
            }
        }

        public MenuOrder()
        {
        }


    }
}
/* for each - https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary */
