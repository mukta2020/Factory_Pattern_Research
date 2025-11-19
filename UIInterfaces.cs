
namespace AbstractFactoryUI
{
    public interface IButton
    {
        void Render();
    }

    public interface ITextBox
    {
        void Render();
    }

    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
