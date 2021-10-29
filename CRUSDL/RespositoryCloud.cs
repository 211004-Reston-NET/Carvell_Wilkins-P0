using System.Collections.Generic;
using Model = CRUSModels;
using Entity = CRUSDL.Entities;
using CRUSModels;
using System.Linq;

namespace CRUSDL
{
    public class RepositoryCloud : IRepository
    {
        private Entity.ClothesRUSdemoContext _context;
        public RepositoryCloud(Entity.ClothesRUSdemoContext p_context)
        {
            _context = p_context;
        }


        public Model.Customer AddCustomer(Model.Customer p_customer)
        {
            _context.Customers.Add
            (
               new Entity.Customer()
               {
                   Name = p_customer.Name,
                   EmailAddress = p_customer.Email,
                   Address = p_customer.Address
               }
            );

            //This method will save the changes made to the database
            _context.SaveChanges();
            return p_customer;
        }

        public List<Clothing> GetAllClothing()
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.Select(Customer =>
            new Model.Customer()
            {
                 Name= Customer.Name,
                 Address = Customer.Address,
                 Email = Customer.EmailAddress,
                 ID = Customer.PersonId
            }
             ).ToList();

        }

        public List<LineItems> GetAllLineItems(int p_locations)
        {
            throw new System.NotImplementedException();
        }

        public List<Products> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public List<Review> GetAllReview()
        {
            throw new System.NotImplementedException();
        }

        public List<StoreFront> GetAllStoreFront()
        {
            throw new System.NotImplementedException();
        }

        public Products GetProductsByItemId(int p_ItemId)
        {
            throw new System.NotImplementedException();
        }

        public Order PlaceOrder(Customer p_customer, Order p_order)
        {
            throw new System.NotImplementedException();
        }
    }
}

/*public List<Model.Customer> GetAllCustomer()
 {
     //Method Syntax
     return _context.Customers.Select(Customer => 
         new Model.Customer()
         {
             Name = Customer.Name,
             Email = Customer.EmailAddress,
             Address = Customer.Address,
             ID = Customer.PersonId
         }
     ).ToList();

 public List<Customer> GetAllCustomer()
 {
     throw new System.NotImplementedException();
 }

 public List<LineItems> GetAllLineItems(string p_locations)
 {
     throw new System.NotImplementedException();
 }

 public List<Review> GetAllReview()
 {
     throw new System.NotImplementedException();
 }

 public List<StoreFront> GetAllStoreFront()
 {
     throw new System.NotImplementedException();
 }
}

 public List<Model.Customer> GetAllCustomer()
 {
     //Method Syntax
     return _context.Customers.Select(rest => 
         new Model.Restaurant()
         {
             Name = Customer.customerName,
             Email = Customer.customerEmail,
             Address = Customer.customerAddress,
             Id = Customer.customerId
         }
     ).ToList();


     //Query Syntax
     // var result = (from rest in _context.Restaurants
     //             select rest);

     // List<Model.Restaurant> listOfRest = new List<Model.Restaurant>();
     // foreach (var rest in result)
     // {
     //     listOfRest.Add(new Model.Restaurant(){
     //         Name = rest.RestName,
     //         State = rest.RestState,
     //         City = rest.RestCity,
     //         Id = rest.RestId
     //     });
     // }

     // return listOfRest;
 }

 /*public List<Model.Review> GetAllReview()
 {
     throw new System.NotImplementedException();
 }
}
}
 public Model.Customer AddCustomer(Model.Customer p_customer)
 {
     return _context.Customers.Select(Customer=>)
 }

 public List<Model.Clothing> GetAllClothing()
 {
     throw new System.NotImplementedException();
 }

 public List<Model.Customer> GetAllCustomer()
 {
     throw new System.NotImplementedException();
 }

 public List<Model.LineItems> GetAllLineItems(string p_locations)
 {
     throw new System.NotImplementedException();
 }

 public List<Model.Review> GetAllReview()
 {
     throw new System.NotImplementedException();
 }

 public List<Model.StoreFront> GetAllStoreFront()
 {
     throw new System.NotImplementedException();
 }
}
}*/