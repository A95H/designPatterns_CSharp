using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{  
    /// The 'Decorator' abstract class
    public abstract class BookDecorator : LibraryItem
    {
        protected LibraryItem item;
        public BookDecorator(LibraryItem item)
        {
            this.item = item;
        }
        public override string Display()
        {
            return item.Display();
        }

    }
}