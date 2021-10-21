using System;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class AddClothing : IMenu
    {
        private static Clothing _rest = new Clothing();
        private IClothingBL _restBL;
         
        public AddClothing(IClothingBL p_restBL)
        {
            _restBL = p_restBL;
        }

        public void Menu()
        {
            
            Console.WriteLine("Name - " + _rest.Name);
            Console.WriteLine("State - "+ _rest.State);
            Console.WriteLine("City - "+ _rest.City);
            Console.WriteLine("Adding a new Clothing Store");
            Console.WriteLine("[4] - Add Clothing Store");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for State");
            Console.WriteLine("[1] - Input value for City");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "4":
                    //Anything inside the try block will be catched if an exception has risen
                    //Laymen's term if a problem has happened while doing this code, it will instead do the catch block
                    try
                    {
                         _restBL.AddClothing(_rest);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddClothing;
                    }
                    
                    return MenuType.ClothesMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _rest.Name = Console.ReadLine();
                    return MenuType.AddClothing;
                case "2":
                    Console.WriteLine("Type in the value for the State");
                    _rest.State = Console.ReadLine();
                    return MenuType.AddClothing;
                case "1":
                    Console.WriteLine("Type in the value for the City");
                    _rest.City = Console.ReadLine();
                    return MenuType.AddClothing;
                case "0":
                    return MenuType.ClothesMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowClothes;
            }
        }
    }
}