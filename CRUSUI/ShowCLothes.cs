using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class ShowClothes : IMenu
    {
        private IClothingBL _restBL;
        public static string _findRestName;
        public ShowClothes(IClothingBL p_restBL)
        {
            _restBL = p_restBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Clothing stores");
            List<Clothing> listOfClothing = _restBL.GetAllClothing();

            foreach (Clothing rest in listOfClothing)
            {
                Console.WriteLine("====================");
                Console.WriteLine(rest);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for a restaurant");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.ClothesMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Restaurant you want to find");
                    _findRestName = Console.ReadLine();
                    return MenuType.CurrentClothing;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowClothes;
            }
        }
    }
}