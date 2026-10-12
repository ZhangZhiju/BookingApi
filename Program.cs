var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", () => "Welcome to BookingApi v1.0 - User weny917920");
app.MapGet("/bookings", () =>
{
    return new[] {
    new { Id = 1, CustomerName = "张三", Date = "2026-10-15" },
    new { Id = 2, CustomerName = "李四", Date = "2026-10-16" }
};
});


app.Run();
