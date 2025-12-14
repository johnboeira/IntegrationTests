using eCommerce.MinimalApi.Endpoints;
using eCommerce.MinimalApi.Infra;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRequestTimeouts();
builder.Services.AddScoped<ProductRepository>();

builder.Services.AddHttpsRedirection(options =>
{
    options.HttpsPort = 5031;
});

var app = builder.Build();

app.MapProductsEndpoints();

app.UseHttpsRedirection();
app.UseRequestTimeouts();

app.Run();