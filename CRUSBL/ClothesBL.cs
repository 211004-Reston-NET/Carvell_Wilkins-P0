using System;
using System.Collections.Generic;
using CRUSMOD;
using CRUSDL;


namespace CRUSBL
{
    public class ClothesBL
    {
        private Repository _repo;
      
        public ClothesBL(Repository p_repo);
        {
            _repo = p_repo;
        }
        public List<Clothes> GetAllClothes()
        {
            return _repo.GetAllClothes();
        }
    }
}
