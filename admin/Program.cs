using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System;

//if (Email.Contains("@"))
//Console.WriteLine("Enter Username :");

string username = Console.ReadLine();

Console.WriteLine("Enter Password :");
string password = Console.ReadLine();

if (username == "admin" && password == "admin")
{
    Console.WriteLine("Enter Email :");
    string Email = Console.ReadLine();
    if (Email.Contains("@"))
        Console.WriteLine("Enter Username :");
    {
        //Console.WriteLine("missing @");

        Console.WriteLine("Enter Age :");
        string Age = Console.ReadLine();
        int age = Convert.ToInt32(Age);
        if (age <= 18)
            Console.WriteLine("not allowed age");
        Console.WriteLine("Enter Name :");
        string Name = Console.ReadLine();
        if (Name.Length < 3)
            Console.WriteLine("short name");
        Console.WriteLine("Welcome " + Name + " Age is " + Age);
    }
}
else
{
    Console.WriteLine("login not allowed");
}