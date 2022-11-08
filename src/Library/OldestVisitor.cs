using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class OldestVisitor: Visitor
    {
        int Oldest;
        public override void Visit(Person person)
        {
            if(person.Age>Oldest)
            {
                Oldest=person.Age;
            }
            Information=Oldest.ToString();
        }
    }
}