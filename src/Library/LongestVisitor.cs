using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestVisitor: Visitor
    {
        string Longest= "";
        public override void Visit(Person person)
        {
            if((person.Name.Length>Longest.Length))
            {
                Longest=person.Name;
                Information=Longest;
            }
            
        }
    }
}