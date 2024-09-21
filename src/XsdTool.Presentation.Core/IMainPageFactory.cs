namespace XsdTool.Presentation.Core;

/// <summary>
/// Responsible for creating a main page view.
/// </summary>
public interface IMainPageFactory
{
    /// <summary>
    /// Creates a main page view.
    /// </summary>
    /// <returns>An instance of the main page.</returns>
    ShellContent Create();
}
