using System;
namespace AB2
{
    public class MenuOrder
    {
        public IDictionary<string, double> cart = new Dictionary<string, double>();
        void Add(MenuItem itemchoice)
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
                Console.WriteLine("You have added {0} {1}", cart[itemchoice.itemName], itemchoice.itemName);

            }
        }
        public MenuOrder()
        {
        }
        public MenuOrder TestObj = new MenuOrder();

    }
}
