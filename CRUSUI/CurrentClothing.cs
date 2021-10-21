using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class CurrentClothing : IMenu
    {
        private IClothingBL _restBL;
        public CurrentClothing(IClothingBL p_restBL)
        {
            this._restBL = p_restBL;
        }

        public void Menu()
        {
            List<Clothing> listOfRest = _restBL.GetClothing(ShowClothes._findRestName);

            Console.WriteLine("This is the search result");
            foreach (Clothing rest in listOfRest)
            {
                Console.WriteLine("====================");
                Console.WriteLine(rest);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuType.ShowClothes;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentClothing;
            }
        }
    }
}