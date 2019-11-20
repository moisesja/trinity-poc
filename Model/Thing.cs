using Semiodesk.Trinity;
using System;
using example;

namespace trinity_poc.Model
{
    [RdfClass(SCHEMA.Thing)]
    public class Thing : Resource
    {        
        public Thing(Uri uri) : base(uri)
        {
        }

        [RdfProperty(SCHEMA.name)]
        public string Name { get; set; }
    }
}