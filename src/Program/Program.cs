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

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
        }
    }
}
