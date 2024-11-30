var builder = WebApplication.CreateBuilder(args);

// Add services for controllers
builder.Services.AddControllers();  // Ensures that controllers like ChatController are recognized

// Add services for Swagger (optional)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the application pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Map controllers (this enables endpoints like /api/chat to work)
app.MapControllers();

app.Run();