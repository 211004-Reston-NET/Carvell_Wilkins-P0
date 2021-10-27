using System;

namespace CRUSModels
{
    public class LineItems
    {
        private Products _product;
        private int _quantity;
        public Products Product
        {
            get
            { return _product; }
            set
            {
                _product = value;
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
        public override string ToString()
        {
            return $"Brand: {Product.Brand} \nName: {Product.Name} \nPrice: {Product.Price} "; 
        }
    }
}
