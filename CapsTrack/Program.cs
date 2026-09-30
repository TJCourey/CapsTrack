using CapsTrack.api.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var nhlBaseUrl = builder.Configuration["nhlApi:BaseUrl"]
    ?? throw new InvalidOperationException("NHL API base URL is not configured.");

builder.Services.AddHttpClient<INhlClient, NhlClient>(client =>
{
    client.BaseAddress = new Uri(nhlBaseUrl);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
