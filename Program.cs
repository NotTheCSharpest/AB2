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
        var Milchkaffee = new MenuItem() { itemName = "Milchkaffee", itemPrice = 2.20M, itemType = "Getränke"};
        var Kakao = new MenuItem() { itemName = "Kakao", itemPrice = 2M, itemType = "Getränke" };
        var MineralWasser = new MenuItem() { itemName = "MineralWasser", itemPrice = 1.80M, itemType = "Getränke" };
        var Espresso = new MenuItem() { itemName = "Espresso", itemPrice = 2M, itemType = "Getränke" };
        var LatteMacchiato = new MenuItem() { itemName = "Espresso Macchiato", itemPrice = 2.5M, itemType = "Getränke" };
        var Kaesekuchen = new MenuItem() { itemName = "Käsekuchen", itemPrice = 2.3M, itemType = "Speisen" };
        var Blaubeermuffin = new MenuItem() { itemName = "Blaubeermuffin", itemPrice = 1.3M, itemType = "Speisen" };
        var Brownie = new MenuItem() { itemName = "Brownie", itemPrice = 1M, itemType = "Speisen" };
        var Apfelkuchen = new MenuItem() { itemName = "Apfelkuchen", itemPrice = 2.4M, itemType = "Speisen" };
        var Kirschtorte = new MenuItem() { itemName = "Kirschtorte", itemPrice = 3M, itemType = "Speisen" };
        var Mittagstisch = new MenuItem() { itemName = "Taglicher Mittagstisch", itemPrice = 4.5M, itemType = "Speisen" };


        order.Add(Milchkaffee);
        order.PrintOrder();
        }
     }
}
/* 
references 
IDE - https://csharppad.com/
dictionaries - https://www.tutorialsteacher.com/csharp/csharp-dictionary
passing objs as params - https://www.includehelp.com/dot-net/how-to-pass-object-as-argument-into-method-in-c-sharp.aspx
*/
