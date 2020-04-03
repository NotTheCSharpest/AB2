using System;
using System.Collections.Generic;
namespace AB2
{
    public class MenuOrder
    {
        public IDictionary<MenuItem, int> cart = new Dictionary<MenuItem, int>();

        public void Add(MenuItem itemchoice)
        {

            bool keyExists = cart.ContainsKey(itemchoice);
            if (keyExists)
            {
                int newQuant = cart[itemchoice] + 1;
                cart[itemchoice] = newQuant;
                Console.WriteLine("{0} added", itemchoice.itemName);
            }
            else
            {
                cart.Add(itemchoice, 1);
                Console.WriteLine("{0} added", itemchoice.itemName);
            }
        }

        public void PrintOrder()
        {
            Console.WriteLine("\r\nprinting order...");
            foreach (KeyValuePair<MenuItem, int> entry in cart)

            {
                decimal kosten = entry.Value *  entry.Key.itemPrice;                
                Console.WriteLine("{0}x {1} - {2}", entry.Value, entry.Key.itemName, kosten);
                
            }
        }

        public void OrderTotal()
        {
            decimal total = 0;
            foreach (KeyValuePair<MenuItem, int> entry in cart)
            {
                decimal kosten = entry.Value * entry.Key.itemPrice;
                
                total += kosten;
                /*string printtotal = total.ToString();*/

        }
        Console.WriteLine("your total is: {0}", total);
        }


        public MenuOrder()
        {
        }


    }
}
/* for each - https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary */
