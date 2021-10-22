using System;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class AddCustomer : IMenu
    {
        private static Customer _cust = new Customer();
        private ICustomerBL _custBL;

        public AddCustomer(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }

        public void Menu()
        {

            Console.WriteLine("Name - " + _cust.Name);
            Console.WriteLine("Email - " + _cust.Email);
            Console.WriteLine("Address - " + _cust.Address);
            Console.WriteLine("Adding a new Customer Store");
            Console.WriteLine("[4] - Add Customer Store");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for Email");
            Console.WriteLine("[1] - Input value for Address");
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
                        _custBL.AddCustomer(_cust);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddCustomer;
                    }

                    return MenuType.MainMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _cust.Name = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "2":
                    Console.WriteLine("Type in the value for the Email");
                    _cust.Email = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the value for the Address");
                    _cust.Address = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
            }
        }
    }
}