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
    }
}