using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Jose Fuentes", 67);
            Node n2 = new Node("Pablo Repetto", 48);
            Node n3 = new Node("Pablo Repetto", 48);
            Node n4 = new Node("Luis Suarez", 35);
            Node n5 = new Node("Antonio Palma", 42);
            Node n6 = new Node("Camilo Candido", 24);
            Node n7 = new Node("Christian Almeida", 23);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n5);

            n3.AddChildren(n4);
            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            Console.WriteLine($"La suma de los hijos de {n1.Person.Name} = "+n1.childsAgeCalculator());
            Console.WriteLine($"El hijo mas grande de {n1.Person.Name} tiene "+n1.oldestChildCalculator());
            Console.WriteLine($"El hijo de {n1.Person.Name} con el nombre mas largo es "+n1.longestChildNameCalculator());

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"La suma de los hijos de {n3.Person.Name} = "+n3.childsAgeCalculator());
            Console.WriteLine($"El hijo mas grande de {n3.Person.Name} tiene "+n3.oldestChildCalculator());
            Console.WriteLine($"El hijo de {n3.Person.Name} con el nombre mas largo es "+n3.longestChildNameCalculator());
            
        }
    }
}
