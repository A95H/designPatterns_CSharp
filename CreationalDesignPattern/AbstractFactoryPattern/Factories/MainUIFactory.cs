using FactoryPattern.interfaces;

namespace FactoryPattern.Factories
{
    public class MainUIFactory : IGUIFactory
    {
        private IGUIFactory factory;

        public MainUIFactory(IGUIFactory factory)
        {
            this.factory = factory;
        }

        public IButton CreateButton()
        {
            return factory.CreateButton();
        }

        public ICheckBox CreateCheckbox()
        {
            return factory.CreateCheckbox();
        }
    }
}