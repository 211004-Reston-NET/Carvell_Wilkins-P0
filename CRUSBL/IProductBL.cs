using System.Collections.Generic;
using CRUSModels;

namespace CRUSBL
{
    public interface IProductBL
    {
        /// <summary>
        /// This Will grab the list of products from Repository.
        List<Products> SearchByCategory(string p_category);
    }
}