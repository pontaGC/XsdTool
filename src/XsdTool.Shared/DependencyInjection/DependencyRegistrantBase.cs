using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace XsdTool.Shared.DependencyInjection;

/// <summary>
/// The abstract implementation of <see cref="IDependenyRegistrant"/>.
/// </summary>
public abstract class DependencyRegistrantBase : IDependenyRegistrant
{
    void IDependenyRegistrant.Register(IServiceCollection container)
    {
        ArgumentNullException.ThrowIfNull(nameof(container));
        this.Register(container);
    }

    /// <summary>
    /// Registers the services to container.
    /// </summary>
    /// <param name="container">The DI container.</param>
    protected abstract void Register([NotNull] IServiceCollection container);
}
