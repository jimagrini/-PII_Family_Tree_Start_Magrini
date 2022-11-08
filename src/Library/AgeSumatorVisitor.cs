using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AgeSumatorVisitor: Visitor
    {
        private int ageSumatory;
        public override void Visit(Person person)
        {
            ageSumatory+=person.Age;
            Information=ageSumatory.ToString();
        }
    }
}