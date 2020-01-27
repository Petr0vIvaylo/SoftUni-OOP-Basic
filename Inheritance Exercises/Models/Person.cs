﻿using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private int age;
    private string name;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            name = value;
        }
    }

    public virtual int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append($"Name: {this.Name}, Age: {this.Age}");
        return builder.ToString();
    }
}

