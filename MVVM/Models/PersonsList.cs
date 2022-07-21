using System;
using System.Collections.Generic;
using MVVM.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class PersonsList
    {
        public List<Person> Persons { get; set; }

        public PersonsList()
        {
            Persons = DataBaseImitation.GetPeople();
        }

        public void Add(Person person)
        {
            if (!Persons.Contains(person))
            {
                Persons.Add(person);
                //FakeService.Write(person);
            }
        }

        public void Delete(Person person)
        {
            if (Persons.Contains(person))
            {
                Persons.Remove(person);
                //FakeService.Delete(person);
            }
        }

        public void Update(Person person)
        {
            //FakeService.Write(person);
        }
    }
}
