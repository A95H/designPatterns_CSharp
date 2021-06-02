using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class YellowBadge : BookDecorator
    {
        public YellowBadge(LibraryItem item) : base(item)
        {
        }

        public override string Display()
        {
            // modify the item
            return base.Display() + " YellowBadge Added";
        }

    }
}