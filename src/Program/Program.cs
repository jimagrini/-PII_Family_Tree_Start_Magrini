using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Fuentes = new Person("Jose Fuentes", 67);
            Person Balbi = new Person("Alejandro Balbi", 60);
            Person Repetto = new Person("Pablo Repetto", 48);
            Node n1 = new Node(Fuentes);
            Node n2 = new Node(Balbi);
            Node n3 = new Node(Repetto);
            Node n4 = new Node(new Person("Luis Suarez", 35));
            Node n5 = new Node(new Person("Sergio Rochet", 29));
            Node n6 = new Node(new Person("Camilo Candido", 24));
            Node n7 = new Node(new Person("Christian Almeida", 23));

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            Console.WriteLine(n1.childsAgeCalculator());
            Console.WriteLine(n1.oldestChildCalculator());
            Console.WriteLine(n1.longestChildNameCalculator());
/*
            n3.AddChildren(n4);
            n3.AddChildren(n5);

            n4.AddChildren(n6);
            n5.AddChildren(n7);

*/
            // visitar el árbol aquí
        }
    }
}
