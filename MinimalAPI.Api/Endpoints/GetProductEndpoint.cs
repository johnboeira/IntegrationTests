using eCommerce.MinimalApi.Infra;

namespace eCommerce.MinimalApi.Endpoints;

public static class GetProductEndpoint
{
    public const string Name = "GetProduct";

    public static IEndpointRouteBuilder MapGetProduct(this IEndpointRouteBuilder routes)
    {
        routes.MapGet(ApiEndpoints.Movies.Get, async (Guid id, ProductRepository repo, HttpContext httpContext) =>
        {
            var product = await repo.GetByIdAsync(id, httpContext);

            if (product is null)
                return Results.NotFound();

            return TypedResults.Ok(product);
        })
        .WithName(Name)
        .WithTags("Products")
        .Produces(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithRequestTimeout(TimeSpan.FromSeconds(20));

        return routes;
    }
}