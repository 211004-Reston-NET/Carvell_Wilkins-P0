using System;
using System.IO;
using CRUSMOD;
using System.Collections.Generic;
using System.Text.Json;
     

namespace CRUSDL
{
    public class Repository 
    {
        //folepath need to reference from the startup project (CRUS) and this is why
        //we need to go back a folder and cd into CRUSDL
       private const string _filepath = "./../CRUSDL/Database/CRUS.json";
       private string _jsonstring; 

       //public Clothes AddClothes(Clothes P_rest);
        
            //list<Clothes> listofClothes =

        
        public List<Clothes> GetAllClothes()
            {
             _jsonstring = File.ReadAllText(_filepath);

             return JsonSerializer.Deserialize<List<Clothes>>(_jsonstring);
            }


    

    }
}
