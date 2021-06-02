using System;
using FactoryPattern.interfaces;

namespace FactoryPattern.Childs
{
    public class WinButton : IButton
    {
        public void Draw()
        {
            Console.WriteLine("Draw Win Button");

        }

        public void OnClick()
        {
            Console.WriteLine("CheckBox Print");

        }
    }
}