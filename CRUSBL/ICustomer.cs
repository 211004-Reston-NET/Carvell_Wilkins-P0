using System.Collections.Generic;
using CRUSModels;

namespace CRUSBL
{
    public interface ICustomerBL
    {
        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Customer> GetAllCustomer();

        /// <summary>
        /// Adds a restaurant to the database
        /// </summary>
        /// <param name="p_customer">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// Will find multiple restaurant given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<Customer> GetCustomer(string p_name);
    }
}