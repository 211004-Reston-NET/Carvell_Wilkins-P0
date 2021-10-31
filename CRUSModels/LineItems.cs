using System;

namespace CRUSModels
{
    public class LineItems
    {
        public int _productID;
        private Products _product;

        private String _description;
    
        private int _quantity;

        private int _price;


    
        public Products Product
        {
            get
            { return _product; }
            set
            {
                _product = value;
            }
        }

         public int Price
        {
            get
            { return _price; }
            set
            {
                _price = value;
            }
        }

        public String Description
        {
            get
            { return _description; }
            set
            {
                _description = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        public int ProductId
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
            }
        }
       //public override string ToString()
        //{
            //return $"Brand: {Product.Brand} \nName: {Product.Clothing_Type} \nPrice: {Product.Price} "; 
        }
    }
//}
