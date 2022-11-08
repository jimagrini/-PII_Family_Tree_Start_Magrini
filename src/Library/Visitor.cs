using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public abstract class Visitor
    {
        //Person person;
        protected string Information {get; set;}
        public string Content
        {
            get
            {
                return Information.ToString();
            }
        }

        public abstract void Visit(Person person);
        
        /*{
            ageSumatory+=person.Age;
        }
        */
    }
}