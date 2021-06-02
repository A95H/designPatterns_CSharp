using FactoryPattern.interfaces;

namespace FactoryPattern.interfaces
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckbox();
    }
}