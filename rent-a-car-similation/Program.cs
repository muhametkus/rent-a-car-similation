using rent_a_car_similation.Data;
using rent_a_car_similation.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
builder.Services.AddScoped<CarService>();
builder.Services.AddScoped<ColorService>();
builder.Services.AddScoped<FuelService>();
builder.Services.AddScoped<TransmissionService>();

builder.Services.AddScoped<CarData>();
builder.Services.AddScoped<ColorData>();
builder.Services.AddScoped<FuelData>();
builder.Services.AddScoped<TransmissionData>();

builder.Services.AddControllers();

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
