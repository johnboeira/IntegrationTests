using eCommerce.MinimalApi.Infra;

namespace eCommerce.MinimalApi.Extensions;

public static class DependencyInjectionExtensions
{
    public static void AddInfra(this IServiceCollection services)
    {
        services.AddScoped<ProductRepository>();
        services.AddScoped<AuthenticationRepository>();
    }
}