using System.Collections.ObjectModel;
using Avalonia.NETCoreMVVMApp1.Models;
using ReactiveUI;

namespace Avalonia.NETCoreMVVMApp1.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public ObservableCollection<Person> Persons { get; set; }

        private Person _person;
        public Person SelectedPerson
        {
            get => _person;
            set => this.RaiseAndSetIfChanged(ref _person, value);
        }
        
        public ViewModelBase()
        {
            Persons = new ObservableCollection<Person>
            {
                new()
                {
                    Id = 0, 
                    FirstName = "First name", 
                    LastName = "Last name"
                },
                new()
                {
                    Id = 0, 
                    FirstName = "First name", 
                    LastName = "Last name"
                },
                new()
                {
                    Id = 0, 
                    FirstName = "First name", 
                    LastName = "Last name"
                },
            };
        }
    }
}