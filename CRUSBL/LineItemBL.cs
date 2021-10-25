using System.Collections.Generic;
using CRUSDL;
using CRUSModels;

namespace CRUSBL


{
    public class LineItemBL : ILineItemBL
    {
        private Repository _repo;
        public LineItemBL(Repository p_repo)
        {
            _repo = p_repo;
        }
        public List<LineItems> GetAllLineItems(string p_locations)
        {
            return _repo.GetAllLineItems(p_locations);
        }
    }
}