using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class LineItemMenu : IMenu
    {
        private ILineItemBL _lineItemBL;
        public LineItemMenu(ILineItemBL p_lineItemBL)
        {
            _lineItemBL = p_lineItemBL;
        }
        public void Menu()
        {
            Console.WriteLine($"Now viewing products from {SingletonStoreFront.storeFront.Name}");
            Console.WriteLine(" Please take a look of all items listed.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine( "================================");
            Console.WriteLine( "================================");
            Console.WriteLine("[5] Nike Pants" );
            Console.WriteLine("[4] Nike Shirt");
            Console.WriteLine("[3] Adidas Pants");
            Console.WriteLine("[2] Adidas Shirt");

            List<LineItems> lineItemList = _lineItemBL.GetAllLineItems(SingletonStoreFront.ProductId);

            foreach (LineItems item in lineItemList)
            {
                Console.WriteLine(item);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("[1] Place an Order");
            Console.WriteLine("[0] Go back");

            Console.WriteLine("===================================");
            Console.ReadLine();
        }

        public MenuType YourChoice()
        {
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            {
                case "5":
                    return MenuType.OrderPlacement;
                case "4":
                    return MenuType.OrderPlacement;
                case "3":
                    return MenuType.OrderPlacement;
                case "2":
                    return MenuType.OrderPlacement;

                case "1":
                    return MenuType.OrderPlacement;



                case "0":
                    return MenuType.StoreFront;
                default:
                    Console.WriteLine("Please input a valid response! Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}

