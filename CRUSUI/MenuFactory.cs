using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CRUSBL;
using CRUSDL;
using CRUSDL.Entities;


namespace CRUSUI
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //Gets the current directory of the RRUI file path
                .AddJsonFile("appsetting.json") //Adds the appsetting.json file in our CRURRUI
                .Build(); //Builds our configuration

            DbContextOptions<ClothesRUSdemoContext> options = new DbContextOptionsBuilder<ClothesRUSdemoContext>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.AddCustomer:
                    return new AddCustomer();
                case MenuType.ShowCustomer:
                    return new ShowCustomers(new CustomerBL(new RespositoryCloud(new ClothesRUSdemoContext(options))));
                case MenuType.AddRestaurant:
                    return new AddRestaurant(new RestaurantBL(new RespositoryCloud(new RRDatabaseContext(options))));
                case MenuType.CurrentRestaurant:
                    return new CurrentRestaurant(new RestaurantBL(new RespositoryCloud(new RRDatabaseContext(options))));
                case MenuType.ReviewMenu:
                    return new ReviewMenu(new RestaurantBL(new RespositoryCloud(new RRDatabaseContext(options))));
                default:
                    return null;
                           MainMenu,
        ClothesMenu,
        ShowClothes,
        
        LineItem,
        CurrentClothing,
        StoreFront,
        OrderPlacement,
        ShowCustomer, 
        CustomerSearch,
        ViewPastOrders,
        CategoryMenu, 
        Inventory,


            }
        }
    }
}