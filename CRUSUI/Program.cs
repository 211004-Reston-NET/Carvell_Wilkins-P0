﻿using System;
using CRUSBL;
using CRUSDL;

namespace CRUSUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a boolean that has either a false or true value
            //I will use this to stop the while loop
            bool repeat = true;


            //This is example of polymorphism, abstraction, and inheritance all at the same time
            IMenu page = new MainMenu();
            

            //This is a while loop that will keep repeating until I changed the
            //repeat variable to false
            while (repeat)
            {
                //Clean the screen on the terminal
                Console.Clear();

                //IMenu interface can hold a bunch of objects as long as they inherited from
                //IMenu, this lets us dynamically change the page by having the page variable
                //Point to a different object each time
                page.Menu();
                MenuType currentPage = page.YourChoice();

                //switch case will change the page variable to point to another object to change
                //its MainMenu 
                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        //If user choosed to go back to the MainMenu
                        //page will start pointing to a MainMenu object instead
                        page = new MainMenu();
                        break;
                    case MenuType.ClothesMenu:
                        //This will point the page reference variable to a new Restaurant Object
                        //Since Restaurant Object has different implementation/function of the Menu Method
                        //It will have different implementations/functions when the while loop goes back and
                        //repeat itself
                        page = new ClothesMenu();
                        break; 
                    case MenuType.ShowClothes:
                        page = new ShowClothes(new ClothingBL(new Repository()));
                        break;
                    case MenuType.AddClothing:
                        page = new AddClothing(new ClothingBL(new Repository()));
                        break;
                    case MenuType.CurrentClothing:
                        page = new CurrentClothing(new ClothingBL(new Repository()));
                        break;
                    case MenuType.Exit:
                        Console.WriteLine("You are now exiting the program!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("You forgot to add a menu in your enum/code");
                        repeat = false;
                        break;
                }

                
            }

        }
    }
}