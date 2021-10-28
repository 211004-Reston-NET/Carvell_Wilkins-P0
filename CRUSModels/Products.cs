using System;

namespace CRUSModels
{
    public class Products
    {
        private string _name;
        private decimal _price;
        private string _brand;
        public int ItemId {get; set;}

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public decimal Price {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Brand {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        public override string ToString(){
            return $"Brand: {Brand} \nName: {Name} \nPrice: {Price}";
        }
    }
}