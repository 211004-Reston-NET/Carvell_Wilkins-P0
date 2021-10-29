using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class OrderPlacement : IMenu
    {
        private ILineItemBL _lineItems;
        private ICustomerBL _customerBL;
        public OrderPlacement(ICustomerBL p_customerBL, ILineItemBL p_lineItems)
        {
            _customerBL = p_customerBL;
            _lineItems = p_lineItems;
        }
        public void Menu()
        {
        
                List<LineItems> listOfLineItems = _lineItems.GetAllLineItems(SingletonCustomer.order.OrderId);
            
            
            Console.WriteLine($"Current List of Products from {SingletonCustomer.location}");
            
            foreach (LineItems product in listOfLineItems)
            {
                Console.WriteLine("=========================");
                Console.WriteLine("Brand:"+ product.Product.Brand);
                Console.WriteLine("Name:"+ product.Product.Name);
                Console.WriteLine("Price:"+ product.Product.Price);
                Console.WriteLine("Stock Quantity:"+ product.Quantity);
                               ;
            }
            Console.WriteLine("===================");
            Console.WriteLine("Shopping Cart"); 
                            
            
            if (SingletonCustomer.order.LineItems.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
            }
            foreach (LineItems items in SingletonCustomer.order.LineItems)
            {
                Console.WriteLine($" Item:  {items.Product.Name} ");
                Console.WriteLine($" Price:  {items.Product.Price}");
                Console.WriteLine($" Quantity:  {items.Product.Name}");
                Console.WriteLine($" ================");
                               
            }
            Console.WriteLine($"Store Location: {SingletonCustomer.location}");
            Console.WriteLine(" [2] Edit Order");
            Console.WriteLine(" [1] Complete Order");
            Console.WriteLine("[0] Main Menu"); 
                            
        }

        public MenuType YourChoice()
        {
            List<LineItems> listOfLineItems = _lineItems.GetAllLineItems(SingletonCustomer.order.StoreFrontId);
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            {
                case "1":
                    Console.WriteLine("   Please Type in your product.");
                    string _inputName = Console.ReadLine().Trim().ToLower();
                
                    foreach (LineItems product in listOfLineItems)
                    {
                        if (_inputName == product.Product.Name.ToLower())
                        {
                            Console.WriteLine($"   How many {_inputName} would you like?");
                            int _inputQuantity = int.Parse(Console.ReadLine().Trim());
                            LineItems tempProduct = product;
                            

                            product.Quantity =_inputQuantity;
                            SingletonCustomer.order.LineItems.Add(product);
                            SingletonCustomer.order.TotalPrice = SingletonCustomer.order.TotalPrice + (_inputQuantity * product.Product.Price);
                            if (_inputQuantity <= 0)
                            {
                                Console.WriteLine($" Pleae enter a quanity higher than 0");
                                Console.WriteLine(" Please press enter to continue"); 
                               
                                Console.ReadLine();
                                return MenuType.OrderPlacement;
                            }
                            else if (_inputQuantity == 1)
                            {

                                Console.WriteLine($"   {_inputQuantity} {_inputName} has been added to your cart");
                                Console.WriteLine( "Please press Enter to continue"); 
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"   {_inputQuantity} {_inputName} has been added to your cart");
                                Console.WriteLine( "Please press Enter to continue"); 
                                Console.ReadLine(); 
                            }
                        }
                    }

                    return MenuType.OrderPlacement;

                case "2":
                    
                    SingletonCustomer.order.PersonId = SingletonCustomer.customer.ID;
                    _customerBL.OrderPlacement(SingletonCustomer.customer, SingletonCustomer.order);
                    Console.WriteLine("Order Placed");
                    Console.WriteLine("Please Press Enter to continue"); 
                    Console.ReadLine();
                    return MenuType.MainMenu;
                case "0":
                    Console.WriteLine("Back to Main Menu.");
                    Console.WriteLine("Please Press Enter"); 
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("   Please input a valid response!" +
                                    "\n   Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.OrderPlacement;
            }
        }

        
    }
}