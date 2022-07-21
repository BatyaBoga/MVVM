using System;
using MVVM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Data
{
    public class DataBaseImitation
    {
        public static List<Person> GetPeople() 
        { 
            
            return new List<Person>()
            {
               new Person() { FirstName = "Bill", LastName = "Gates" },
               new Person() { FirstName = "Paul", LastName = "Alen" },
               new Person() { FirstName = "Leslie", LastName = "Lamport" }

            };
            
        }
    }
}
