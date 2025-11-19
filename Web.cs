
using System;

namespace AbstractFactoryUI
{
    public class WebButton : IButton
    {
        public void Render() => Console.WriteLine("<button>Web Button</button>");
    }

    public class WebTextBox : ITextBox
    {
        public void Render() => Console.WriteLine("<input type='text' /> Web TextBox");
    }

    public class WebFactory : IUIFactory
    {
        public IButton CreateButton() => new WebButton();
        public ITextBox CreateTextBox() => new WebTextBox();
    }
}
