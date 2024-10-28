using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person grandParent = new Person("Juan", 80);
            Person parent1 = new Person("Ana", 55);
            Person parent2 = new Person("Carlos", 58);
            Person child1 = new Person("Luis", 30);
            Person child2 = new Person("Marta", 28);
            Person child3 = new Person("Pedro", 25);
            Person child4 = new Person("Lucía", 22);
            
            Node<Person> root = new Node<Person>(grandParent);
            Node<Person> parentNode1 = new Node<Person>(parent1);
            Node<Person> parentNode2 = new Node<Person>(parent2);
            Node<Person> childNode1 = new Node<Person>(child1);
            Node<Person> childNode2 = new Node<Person>(child2);
            Node<Person> childNode3 = new Node<Person>(child3);
            Node<Person> childNode4 = new Node<Person>(child4);

            root.AddChildren(parentNode1);
            root.AddChildren(parentNode2);

            parentNode1.AddChildren(childNode1);
            parentNode1.AddChildren(childNode2);

            parentNode2.AddChildren(childNode3);
            parentNode2.AddChildren(childNode4);
            
            
            // visitar el árbol aquí
            
        }
    }
}
