using System.Collections.Generic;
using CRUSDL;
using CRUSModels;

namespace CRUSBL


{
    public class LineItemBL : ILineItemBL
    {
        private IRepository _repo;
        public LineItemBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public List<LineItems> GetAllLineItems(int p_locations)
        {
            return _repo.GetAllLineItems(p_locations);
        }
    }
}