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
            Console.WriteLine("===================================");
            List<LineItems> lineItemList = _lineItemBL.GetAllLineItems(SingletonStoreFront.storeFront.StoreFrontId);

            foreach (LineItems item in lineItemList)
            {
                Console.WriteLine(item);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("[1] - Place an Order");
            Console.WriteLine("[0] - Go back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
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

