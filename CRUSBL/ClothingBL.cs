using System;
using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class ClothingBL :IClothingBL
    {
        private Repository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public ClothingBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public Clothing AddClothing(Clothing p_rest)
        {
            if (p_rest.Name == null || p_rest.City == null || p_rest.State == null)
            {
                throw new Exception("You must have a value in all of the properties of the restaurant class");
            }

            return _repo.AddClothing(p_rest);
        }

        public List<Clothing> GetAllClothing()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Clothing> listOfClothing = _repo.GetAllClothing();
            for (int i = 0; i < listOfClothing.Count; i++)
            {
                listOfClothing[i].Name = listOfClothing[i].Name.ToLower(); 
            }

            return listOfClothing;
        }

        public List<Clothing> GetClothing(string p_name)
        {
            List<Clothing> listOfClothing = _repo.GetAllClothing();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfClothing.Where(rest => rest.Name.ToLower().Contains(p_name.ToLower())).ToList();
        }
    }
}
