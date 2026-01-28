using KrypteringApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrerar CipherService så den kan användas i endpoints
builder.Services.AddSingleton<CipherService>();

var app = builder.Build();

// Swagger aktiveras oavsett miljö 
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// ENDPOINT: Kryptera
app.MapGet("/encrypt", (string text, int shift, CipherService cipher) =>
{
    var result = cipher.Encrypt(text, shift);
    return Results.Ok(new { mode = "encrypt", original = text, result = result });
});

// ENDPOINT: Avkryptera
app.MapGet("/decrypt", (string text, int shift, CipherService cipher) =>
{
    var result = cipher.Decrypt(text, shift);
    return Results.Ok(new { mode = "decrypt", original = text, result = result });
});

app.Run();