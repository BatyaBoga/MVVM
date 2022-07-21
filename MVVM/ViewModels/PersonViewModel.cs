using MVVM.Models;

namespace MVVM.ViewModels
{
    public class PersonViewModel : ViewModelBase<Person>
    {
        public PersonViewModel(Person person = null) : base(person) { }
        public string FirstName
        {
            get { return This.FirstName; }
            set { SetProperty(This.FirstName, value, () => This.FirstName = value); }
        }
        public string LastName
        {
            get { return This.LastName; }
            set { SetProperty(This.LastName, value, () => This.LastName = value); }
        }

    }
}
