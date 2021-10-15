using System;

namespace CRUSUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good morning! I hope your day is going well");
            
            bool repeat = true; 

            while (repeat)
            {
                 Console.WriteLine("hi, Welcome to the main menu");
                 Console.WriteLine("Pelase choose from the displayed menu");
                 string UserInput;
                 string WG=("women and girls clothing");
                 string MB=("men and boys clothing");
                 Console.WriteLine("[5] Women and girls clothing" );
                 Console.WriteLine("[4] Men and boys clothing");
                 Console.WriteLine("[3] Toddlers");
                 Console.WriteLine("[2] New Appearl");
                 Console.WriteLine("[1] Sales");
                 Console.WriteLine("[0] Exit system");
                 UserInput=Console.ReadLine();

                 switch (UserInput)
                 {
                     case "5":
                        Console.WriteLine($"you have chosen {WG}" );
                        Console.WriteLine("Please press any key to exit the system");
                        Console.ReadLine();
                     break;

                     case "4":
                        Console.WriteLine($"you have chosen {MB}" );
                        Console.WriteLine("Please press any key to exit the system");
                        Console.ReadLine();
                     break;

                    case "3":
                        Console.WriteLine("you have chosen Toddlers" );
                        Console.WriteLine("Please press any key to exit the system");
                        Console.ReadLine();
                     break;
                    case "2":
                        Console.WriteLine("you have chosen New Appeal" );
                        Console.WriteLine("Please press any key to exit the system");
                        Console.ReadLine();

                        break;

                    case "1":
                        Console.WriteLine($"you have chosen sales" );
                        Console.WriteLine("Please press any key to exit the system");
                        Console.ReadLine();
                        break;

                    case "0":
                        Console.WriteLine($"you have chosen to exit system" );
                        Console.WriteLine("Please press any key to exit the system");
                        Console.ReadLine();
                        break;

                     default:
                      repeat=true;
                     Console.WriteLine("please press any key to continue");
                     Console.ReadLine();
                     break;
                     

                 }
                 break;
            }
        }
        // method 
    }
}
