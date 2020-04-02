using System;
using System.Collections.Generic;
namespace AB2

{
    class Program
    {
        static void Main(string[] args)
        {
        /* Menu Items herstellen */
        var order = new MenuOrder();
        var Milchkaffee = new MenuItem() { itemName = "Milchkaffee", itemPrice = 2.20, itemType = "Getränke"};
        var Kakao = new MenuItem() { itemName = "Kakao", itemPrice = 2, itemType = "Getränke" };
        var MineralWasser = new MenuItem() { itemName = "MineralWasser", itemPrice = 1.80, itemType = "Getränke" };
        var Espresso = new MenuItem() { itemName = "Espresso", itemPrice = 2, itemType = "Getränke" };
        var LatteMacchiato = new MenuItem() { itemName = "Espresso Macchiato", itemPrice = 2.5, itemType = "Getränke" };
        var Kaesekuchen = new MenuItem() { itemName = "Käsekuchen", itemPrice = 2.3, itemType = "Speisen" };
        var Blaubeermuffin = new MenuItem() { itemName = "Blaubeermuffin", itemPrice = 1.3, itemType = "Speisen" };
        var Brownie = new MenuItem() { itemName = "Brownie", itemPrice = 1, itemType = "Speisen" };
        var Apfelkuchen = new MenuItem() { itemName = "Apfelkuchen", itemPrice = 2.4 itemType = "Speisen" };
        var Kirschtorte = new MenuItem() { itemName = "Kirschtorte", itemPrice = 3, itemType = "Speisen" };

        order.Add(Milchkaffee);
        }
     }
}
/* 
references 
IDE - https://csharppad.com/
dictionaries - https://www.tutorialsteacher.com/csharp/csharp-dictionary
passing objs as params - https://www.includehelp.com/dot-net/how-to-pass-object-as-argument-into-method-in-c-sharp.aspx
*/
