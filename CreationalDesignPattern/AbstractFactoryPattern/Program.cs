using System;
using FactoryPattern.Childs;
using FactoryPattern.classes;
using FactoryPattern.Factories;

/*
https://refactoring.guru/design-patterns/abstract-factory

factory method is used to create one product only
but abstract factory is about creating families of related or dependent products .
*/
namespace FactoryPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            MainUIFactory factory;
            var key = Console.ReadLine();
            string gui = key.ToLower();
            if (gui.Equals("win"))
            {
                WinFactory winFactory = new WinFactory();
                factory = new MainUIFactory(winFactory);
            }
            else
            {
                MacFactory macFactory = new MacFactory();
                factory = new MainUIFactory(macFactory);
            }
            factory.CreateCheckbox().Draw();
        }
    }
}
