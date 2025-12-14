namespace eCommerce.MinimalApi.Endpoints;

public static class ProductEndpointsExtensions
{
    public static IEndpointRouteBuilder MapProductsEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGetProduct();

        return app;
    }
}