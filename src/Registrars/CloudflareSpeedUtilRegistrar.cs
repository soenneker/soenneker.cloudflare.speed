using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Cloudflare.Speed.Abstract;
using Soenneker.Cloudflare.Speed;
using Soenneker.Cloudflare.Utils.Client.Registrars;

namespace Soenneker.Cloudflare.Speed.Registrars;

/// <summary>
/// A registrar for registering Cloudflare Speed utilities in the dependency injection container
/// </summary>
public static class CloudflareSpeedUtilRegistrar
{
    /// <summary>
    /// Registers the Cloudflare Speed utilities in the dependency injection container
    /// </summary>
    public static IServiceCollection AddCloudflareSpeedUtilAsSingleton(this IServiceCollection services)
    {
        services.AddCloudflareClientUtilAsSingleton().AddSingleton<ICloudflareSpeedUtil, CloudflareSpeedUtil>();
        return services;
    }

    /// <summary>
    /// Adds <see cref="ICloudflareSpeedUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddCloudflareSpeedUtilAsScoped(this IServiceCollection services)
    {
        services.AddCloudflareClientUtilAsSingleton().TryAddScoped<ICloudflareSpeedUtil, CloudflareSpeedUtil>();

        return services;
    }
}
