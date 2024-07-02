using ADP.JKR.Example.Core.Interfaces;
using ADP.JKR.Example.Core.Services;

namespace ADP.JKR.Example.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
