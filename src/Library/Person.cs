using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name=value;
            }
        }
        public int Age {get; set;}
        public Person(string name, int age)
        {
            this.Name=name;
            this.Age=age;
        }
    }
}
