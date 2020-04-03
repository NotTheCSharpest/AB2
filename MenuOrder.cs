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
                decimal newQuant = cart[itemchoice] + 1M;
                cart[itemchoice] = newQuant;
                Console.WriteLine("{0} added", itemchoice.itemName);
            }
            else
            {
                cart.Add(itemchoice, 1M);
                Console.WriteLine("{0} added", itemchoice.itemName);
            }
        }

        public void PrintMenu()
        {
            /* example from discord.
             * foreach(var item in menuItems)
                {
                  Console.WriteLine(item.PropOne);
                  Console.WriteLine(item.PropTwo);
                  Console.WriteLine(item.PropThree);
                  Console.WriteLine(item.PropFour);
                  Console.WriteLine(item.PropFive);
                  //and so on
                }
                */
        }
        public void PrintOrder()
        {
            Console.WriteLine("\r\nprinting order...");
            foreach (KeyValuePair<MenuItem, decimal> entry in cart)

            {
                decimal kosten = entry.Value *  entry.Key.itemPrice;                
                Console.WriteLine("{0}x {1} - {2}", entry.Value, entry.Key.itemName, kosten);
                
            }
        }

        public void OrderTotal()
        {
            decimal total = 0;
            foreach (KeyValuePair<MenuItem, decimal> entry in cart)
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
