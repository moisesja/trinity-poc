using Semiodesk.Trinity;
using System;
using System.Reflection;
using trinity_poc.Model;

namespace trinity_poc
{
    /// <summary>
    /// Example taken from https://trinity-rdf.net/doc/tutorials/firstSteps.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            OntologyDiscovery.AddAssembly(Assembly.GetExecutingAssembly());
            MappingDiscovery.RegisterCallingAssembly();

            var store = StoreFactory.CreateStore("provider=dotnetrdf");

            var model = store.GetModel(new Uri("http://inrupt.net/model"));

            var moy = model.CreateResource<Person>(new Uri("http://moisesj.inrupt.net"));
            moy.FirstName = "Moises";
            moy.LastName = "Jaramillo";
            moy.Birtday = DateTime.Parse("1/1/1900");
            moy.Commit();

            var liz = model.CreateResource<Person>(new Uri("http://lizadj.inrupt.net"));
            liz.FirstName = "Elizabeth";
            liz.LastName = "Daly";
            liz.Birtday = DateTime.Parse("2/2/1900");
            liz.Commit();

            QueryFromTheStore(model);

        }

        private static void QueryFromTheStore(IModel model)
        {
            var moy = (Person)model.GetResource(new Uri("http://moisesj.inrupt.net"));
        }
    }
}
