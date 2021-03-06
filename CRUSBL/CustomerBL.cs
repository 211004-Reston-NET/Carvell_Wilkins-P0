using System;
using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class CustomerBL :ICustomerBL
    {
        private IRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customer AddCustomer(Customer p_customer)
        {
            if (p_customer.Name == null || p_customer.Email == null || p_customer.Address == null)
            {
                throw new Exception("You must have a value in all of the properties of the customeraurant class");
            }

            return _repo.AddCustomer(p_customer);
        }

        public List<Customer> GetAllCustomer()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].Name = listOfCustomer[i].Name.ToLower(); 
            }

            return listOfCustomer;
        }

        public List<Customer> GetCustomer(string p_name)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomer.Where(rest => rest.Name.ToLower().Contains(p_name.ToLower())).ToList();
        }

        public Customer GetSingleCustomer(string p_name, string p_email)
        {
            List<Customer> listOfCustomers = _repo.GetAllCustomer();
            return listOfCustomers.FirstOrDefault(cust => cust.Name == p_name && cust.Email == p_email);
        }

        public Order OrderPlacement(Customer p_customer, Order p_order)
        {
            throw new NotImplementedException();
        }
    }
}
