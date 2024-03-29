using Microsoft.EntityFrameworkCore;
using VinylDatabaseApi;
using VinylDatabaseApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<VinylDatabaseApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VinylDatabaseApiContext") ?? throw new InvalidOperationException("Connection string 'VinylDatabaseApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers()
        .AddNewtonsoftJson(
            options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DbInitializer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseItToSeedSqlServer();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
