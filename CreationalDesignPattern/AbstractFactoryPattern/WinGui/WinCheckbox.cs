using System;
using FactoryPattern.interfaces;

namespace FactoryPattern.Childs
{
    public class WinCheckbox : ICheckBox
    {
        public void Draw()
        {
            Console.WriteLine("Draw Win CheckBox");
        }

        public void OnClick()
        {
            Console.WriteLine("CheckBox Print");
        }
    }
}