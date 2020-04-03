using System;
namespace AB2

{
    class Program
    {
        static void Main(string[] args)
        {
            /* Menu Items herstellen */
            MenuItem[] itemsAvailable = new MenuItem[]
        {
            new MenuItem() {itemName = "Milchkaffee", itemPrice = 2.20M, itemType = "Getränke"},
            new MenuItem() {itemName = "Kakao", itemPrice = 2M, itemType = "Getränke"},
            new MenuItem() {itemName = "MineralWasser", itemPrice = 1.80M, itemType = "Getränke"},
            new MenuItem() {itemName = "Espresso", itemPrice = 2M, itemType = "Getränke"},
            new MenuItem() {itemName = "Espresso Macchiato", itemPrice = 2.5M, itemType = "Getränke"},
            new MenuItem() {itemName = "Käsekuchen", itemPrice = 2.3M, itemType = "Speisen"},
            new MenuItem() {itemName = "Blaubeermuffin", itemPrice = 1.3M, itemType = "Speisen"},
            new MenuItem() {itemName = "Brownie", itemPrice = 1M, itemType = "Speisen"},
            new MenuItem() {itemName = "Apfelkuchen", itemPrice = 2.4M, itemType = "Speisen"},
            new MenuItem() {itemName = "Kirschtorte", itemPrice = 3M, itemType = "Speisen"},
            new MenuItem() {itemName = "Taglicher Mittagstisch", itemPrice = 4.5M, itemType = "Speisen"}
        };

        var order = new MenuOrder();

        /* print menu and initial greeting */
        Console.WriteLine("Welcome to Cafe Blau");
        Console.WriteLine("--------------------");
        Console.WriteLine("--------Menu--------");
            /* print available items */
            foreach (var menu in itemsAvailable)
            {
                Console.WriteLine("{0} - {1}", menu.itemName, menu.itemPrice);
            }

            /* take order*/

            void TakeOrder ()
            {
                Console.WriteLine("Enter your selection or type checkout");
                string choice = Console.ReadLine();
                foreach (var menu in itemsAvailable)
                {
                    if (menu.itemName.Equals(choice))
                    {
                        order.Add(menu);
                        TakeOrder();

                    }
                    else if (choice.Equals("checkout"))
                    {
                        order.PrintOrder();
                        order.OrderTotal();
                        return;
                    }
                    /*else
                    {
                        Console.WriteLine("test");
                        TakeOrder();
                    }*/
                }
            }
            TakeOrder();
        }
     }
}
/* 
references 
IDE - https://csharppad.com/
dictionaries - https://www.tutorialsteacher.com/csharp/csharp-dictionary
passing objs as params - https://www.includehelp.com/dot-net/how-to-pass-object-as-argument-into-method-in-c-sharp.aspx
*/
