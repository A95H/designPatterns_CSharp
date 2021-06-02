using FactoryPattern.Childs;
using FactoryPattern.interfaces;

namespace FactoryPattern.classes
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckbox()
        {
           return new WinCheckbox();
        }
    }
}