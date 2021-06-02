using System;
using FactoryPattern.interfaces;

namespace FactoryPattern.Childs
{
    public class MacCheckbox : ICheckBox
    {
        public void Draw()
        {
            Console.WriteLine("Draw Mac Checkbox");
        }

        public void OnClick()
        {
            Console.WriteLine("CheckBox Print");
        }
    }
}