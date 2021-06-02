using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class Book : LibraryItem
    {
        public override string Display()
        {
           return "base book . ";
        }
    }
}