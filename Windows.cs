
using System;

namespace AbstractFactoryUI
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Windows Button");
    }

    public class WindowsTextBox : ITextBox
    {
        public void Render() => Console.WriteLine("Rendering Windows TextBox");
    }

    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ITextBox CreateTextBox() => new WindowsTextBox();
    }
}
