using MVVM.Data;


namespace MVVM.Models
{
    public class PersonsManager
    {
        public Persons persons;

        public PersonsManager()
        {
            persons = DataBaseImitation.GetPeople();
        }

        public void Add(Person person)
        {
            if (!this.persons.PersonsList.Contains(person))
            {
                this.persons.PersonsList.Add(person);

            }
        }

        public void Delete(Person person)
        {
            if (this.persons.PersonsList.Contains(person))
            {
                this.persons.PersonsList.Remove(person);
            }
        }

        public void Update()
        {
            DataBaseImitation.Update(persons);
        }
    }
}
