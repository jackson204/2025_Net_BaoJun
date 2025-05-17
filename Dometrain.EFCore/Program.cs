using Dometrain.EFCore.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext with SQL Server
builder.Services.AddDbContext<MoviesContext>();
var app = builder.Build();

var serviceScope = app.Services.CreateScope();
var dbContext = serviceScope.ServiceProvider.GetRequiredService<MoviesContext>();

dbContext.Database.EnsureDeleted();
dbContext.Database.EnsureCreated();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
