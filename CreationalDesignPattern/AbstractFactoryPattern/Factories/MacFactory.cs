using FactoryPattern.Childs;
using FactoryPattern.interfaces;

namespace FactoryPattern.classes
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}