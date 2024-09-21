using System.Diagnostics.CodeAnalysis;
using XsdTool.Presentation.Core;
using XsdTool.Shared.DependencyInjection;

namespace XsdTool.Presentation;

/// <summary>
/// Register depedencies in presentation layer.
/// </summary>
public sealed class DependencyRegistrant : DependencyRegistrantBase
{
    /// <inheritdoc />
    protected override void Register([NotNull] IServiceCollection container)
    {
        RegisterAppShellContentFactroy(container);
    }

    private static void RegisterAppShellContentFactroy(IServiceCollection container)
    {
        container.AddSingleton<IMainPageFactory, MainPageFactory>();
    }
}
