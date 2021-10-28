using System.Collections.Generic;
using CRUSModels;

namespace CRUSDL
{
    public interface IRepository
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Clothing AddClothing(Clothing p_rest);


        //this will return a list of storefronts
        //List<CRUSStoreFront> GetCRUSStoreFronts();

        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Clothing> GetAllClothing();

        List<Review> GetAllReview();

        /// <summary>
        /// This is going to get all the customers from the database
        /// </summary>
        /// <returns> Will return a list of customers</returns>
        List<Customer> GetAllCustomer();

        /// <summary>
        /// this is going to add a customer to our customer database. 
        /// </summary>
        /// <param name="p_customer">The Paramater is the customre that will be added</param>
        /// <returns>Will return the customer that gets added</returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// This is going to get all the line items for a specific store location
        /// </summary>
        /// <param name="p_locations"> This is the store location that will be searched</param>
        /// <returns>we will return a list of line items</returns>
        List<LineItems> GetAllLineItems(string p_locations);
          /// <summary>
        /// This is going to get all Store fronts.
        /// </summary>
        /// <returns>we will return a list of store fronts</returns>
        List<StoreFront> GetAllStoreFront();

        //this is going to get a list of products from the database

        List<Products> GetAllProducts();

        ///This will get us a list of orders that was selected by the customer
        Order PlaceOrder (Customer p_customer, Order p_order);

        Products GetProductsByItemId(int p_ItemId);
    }
}