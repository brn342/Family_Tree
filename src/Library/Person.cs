﻿namespace Library;

public class Person
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Person(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}