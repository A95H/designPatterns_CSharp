using System;
using System.Threading.Tasks;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;

/*
https://refactoring.guru/design-patterns/decorator
Decorator is a structural design pattern that lets you attach new behaviors to objects 
by placing these objects inside special wrapper objects that contain the behaviors.

*/

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            HardCover modifiedBook = new HardCover(new YellowBadge(book));
            Console.WriteLine(modifiedBook.Display());

        }
    }
}
