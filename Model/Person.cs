using System;
using System.Collections.ObjectModel;
using example;
using Semiodesk.Trinity;

namespace trinity_poc.Model
{
    [RdfClass(SCHEMA.Person)]
    public class Person : Thing
    {
        public Person(Uri uri) : base(uri)
        {
        }

        [RdfProperty(SCHEMA.givenName)]
        [NotifyPropertyChanged]
        public string FirstName { get; set; }

        [RdfProperty(SCHEMA.familyName)]
        [NotifyPropertyChanged]
        public string LastName { get; set; }

        [RdfProperty(SCHEMA.birthDate)]        
        public DateTime Birtday { get; set; }

        [RdfProperty(SCHEMA.knows)]        
        public ObservableCollection<Person> KnownPersons { get; set; }
    }
}