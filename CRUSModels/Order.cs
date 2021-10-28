
using System;
using System.Collections.Generic;

namespace CRUSModels
{
    public class Order
    // The orders contain information about customer orders.
    {
        private List<LineItems> _lineItems = new List<LineItems>();
        private string _email;
        private string _address;
        private decimal _totalPrice;
        public int OrderId { get; set; }
        public int StoreFrontId { get; set; }
        public int PersonId { get; set; }

        public List<LineItems> LineItems
        {
            get
            {
                return _lineItems;
            }
            set
            {
                _lineItems = value;
            }
        }
        public string EmailAddress
        {
            get{
                return _email;
            }
            set
            {
                _email = value;
            }


        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public decimal TotalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
            }
        }
        public override string ToString()
        {
            
            return $"Items: {LineItems} \nAddress: {Address} \nEmailAddress: {EmailAddress} \nPrice: {TotalPrice}";
        }
    }
}