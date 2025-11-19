
using System;

namespace AbstractFactoryUI
{
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Mac Button");
    }

    public class MacTextBox : ITextBox
    {
        public void Render() => Console.WriteLine("Rendering Mac TextBox");
    }

    public class MacFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ITextBox CreateTextBox() => new MacTextBox();
    }
}
