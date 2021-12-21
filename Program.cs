var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World");

app.MapGet("/user", () => new{Name = "Fernando", Age = 19});
app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("Teste", "Fernando");
    return new {Name = "Fernando", Age = 19};
    });

app.MapPost("/saveproduct", (Product product) => {
    return product.Code + " - " + product.Name;
});

app.Run();

public class Product {
    public string Code { get; set; }
    public string Name { get; set; }
}
