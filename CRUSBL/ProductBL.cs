using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL
{
    public class ProductBL : IProductBL
    {
        private IRepository _repo;
        public ProductBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public List<Products> SearchByCategory(string p_category)
        {
            List<Products> products = _repo.GetAllProducts();
            return products.Where(prod => prod..ToLower().Contains(p_category.ToLower())).ToList();
        }
    }
}