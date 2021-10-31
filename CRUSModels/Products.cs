using System;

namespace CRUSModels
{
    public class Products
    {
        public static object p_catagory;
        private string _clothing_type;
        private decimal _price;
        private string _brand;
        public int ItemId {get; set;}

        public string Clothing_Type {
            get
            {
                return _clothing_type;
            }
            set
            {
                _clothing_type = value;
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
            return $"Brand: {Brand} \nName: {Clothing_Type} \nPrice: {Price}";
        }
    }
}