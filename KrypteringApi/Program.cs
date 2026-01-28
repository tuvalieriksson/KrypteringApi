var builder = WebApplication.CreateBuilder(args);

// Lägger till stöd för Swagger (webbgränssnittet)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Visar Swagger när vi kör lokalt
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// En test-endpoint för kontroll 
app.MapGet("/", () => "KrypteringApi är online!");

app.Run();