using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace Products.Api.IntegrationTests.Endpoints;

public class ProductsEndpointsTests
{
    private readonly WebApplicationFactory<ApiMarker> _applicationFactory = new();

    private readonly HttpClient _httpClient;

    public ProductsEndpointsTests()
    {
        _httpClient = _applicationFactory.CreateClient();
    }

    [Fact]
    public async Task Get_With_Products_Should_ReturnOneProduct()
    {
        //A
        var response = await _httpClient.GetAsync($"/api/products/{new Guid("11111111-2222-3333-4444-555555555555")}");

        //A
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}