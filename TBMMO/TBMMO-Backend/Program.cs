using TBMMO_Backend;

var builder = WebApplication.CreateBuilder(args);

// Generic app setup
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();


// swashbuckler stuff
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// more swashbuckler stuff
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
