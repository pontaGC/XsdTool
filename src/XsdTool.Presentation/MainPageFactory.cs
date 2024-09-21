using XsdTool.Presentation.Core;

namespace XsdTool.Presentation;

/// <summary>
/// Responsible for creating a main page view.
/// </summary>
internal sealed class MainPageFactory : IMainPageFactory
{
    /// <inheritdoc />
    public ShellContent Create()
    {
        var contentView = CreateMainPage();
        return new ShellContent()
        {
            Title = contentView.Title,
            Content = contentView,
            Route = "MainPage",
        };
    }

    private MainPage.MainPage CreateMainPage()
    {
        return new MainPage.MainPage()
        {
            Title = "Home",
            //BindingContext = new MainPageViewModel(),
        };
    }
}
