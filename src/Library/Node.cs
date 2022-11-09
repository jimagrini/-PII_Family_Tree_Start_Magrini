using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public Node(string name, int age)
        {
            this.Person = new Person(name, age);
        }
        
        private Person person;
        public Person Person
        {
            get
            {
                return this.person;
            }
            set
            {
                this.person=value;
            }
        }

        private List<Node> children = new List<Node>();

        public List<Node> Children
        {
            get
            {
                return this.children;
            }
            set
            {
            }
        }
        public void AddChildren(Node n)
        {
            this.children.Add(n);

        }

        public string longestChildNameCalculator()
        {
            Visitor visitor = new LongestVisitor();
            foreach (Node child in this.Children)
            {
                child.Person.Accept(visitor);
            }
            return visitor.Content;
        }

        public string oldestChildCalculator()
        {
            Visitor visitor = new OldestVisitor();
            foreach (Node child in this.Children)
            {
                child.Person.Accept(visitor);
            }
            return visitor.Content;
        }

        public string childsAgeCalculator()
        {
            Visitor visitor = new AgeSumatorVisitor();
            foreach (Node child in this.Children)
            {
                child.Person.Accept(visitor);
            }
            return visitor.Content;
        }
    }
}
