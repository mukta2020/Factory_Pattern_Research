
using System;

namespace AbstractFactoryUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IUIFactory factory;

            Console.WriteLine("Choose platform: windows/mac/web");
            string input = Console.ReadLine()?.ToLower();

            factory = input switch
            {
                "windows" => new WindowsFactory(),
                "mac" => new MacFactory(),
                "web" => new WebFactory(),
                _ => new WebFactory()
            };

            IButton button = factory.CreateButton();
            ITextBox textBox = factory.CreateTextBox();

            button.Render();
            textBox.Render();

            Console.WriteLine("UI Created Successfully.");
        }
    }
}
