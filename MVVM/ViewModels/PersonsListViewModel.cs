using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class PersonsListViewModel : ViewModel
    {
        private PersonsManager personeManager;

        private int selectedIndex;

        private ObservableCollection<PersonViewModel> persones = new ObservableCollection<PersonViewModel>();

        public PersonsListViewModel()
        {
            this.personeManager = new PersonsManager();
            selectedIndex = -1;

            foreach (var person in personeManager.persons.PersonsList)
            {
                var np = new PersonViewModel(person);
                np.PropertyChanged += Person_OnNotifyPropertyChanged;
                persones.Add(np);
            }
        }

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { if (SetProperty(ref selectedIndex, value)) { RaisePropertyChanged(nameof(SelectedPerson)); } }
        }

        public ObservableCollection<PersonViewModel> Persones
        {
            get { return persones; }
            set { SetProperty(ref persones, value); }
        }

        public PersonViewModel SelectedPerson
        {
            get { return (selectedIndex >= 0) ? persones[selectedIndex] : null; }
        }

        public void Add()
        {
            var person = new PersonViewModel();
            person.PropertyChanged += Person_OnNotifyPropertyChanged;
            Persones.Add(person);
            personeManager.Add(person);
            SelectedIndex = Persones.IndexOf(person);
        }

        public void Delete()
        {
            if (SelectedIndex != -1)
            {
                var person = Persones[SelectedIndex];
                Persones.RemoveAt(SelectedIndex);
                personeManager.Delete(person);
            }
        }

        void Person_OnNotifyPropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            personeManager.Update();
        }

    }
}
