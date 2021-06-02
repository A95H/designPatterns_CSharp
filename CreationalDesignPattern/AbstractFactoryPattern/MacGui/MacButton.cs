using System;
using FactoryPattern.interfaces;

namespace FactoryPattern.Childs
{
    public class MacButton : IButton
    {
        public void Draw()
        {
            Console.WriteLine("Draw Mac Button");
            
        }

        public void OnClick()
        {
            Console.WriteLine("CheckBox Mac Print");

        }
    }
}