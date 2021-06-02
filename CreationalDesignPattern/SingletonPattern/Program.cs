using System;
using SingletonPattern.Singleton;
/*
https://refactoring.guru/design-patterns/singleton

Singleton is a creational design pattern 
that lets you ensure that a class has only one instance,
while providing a global access point to this instance.
*/
namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = Database.getInstance();
            db.query("Select * from users");
        }
    }
}
