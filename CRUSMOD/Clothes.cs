using System;
using System.Text.RegularExpressions;

namespace CRUSMOD
{
    public class Clothes
    {
        private String _city;
        public String City
        {
            get { return _city; }
            set 
           { if (!Regex.IsMatch(value, @"[A-Za-z .]+$")) 
            throw new Exception("City can only hold letters ");
            _city = value;
        }
            
            
        }
        
    }
}
