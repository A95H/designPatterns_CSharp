using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class HardCover : BookDecorator
    {
        public HardCover(LibraryItem item) : base(item)
        {
        }

        public override string Display()
        {
            return base.Display() + " Hard Cover Added";
        }

    }
}