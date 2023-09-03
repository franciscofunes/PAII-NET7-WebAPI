using PAII.GuiaEjercicios.WebApi.Services;
using PAII.GuiaEjercicios.WebApi.Services.Enumeraciones;
using PAII.GuiaEjercicios.WebApi.Services.Generalidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
        });

builder.Services.AddSingleton<IGeneralidadesService, GeneralidadesService>();
builder.Services.AddSingleton<IEnumeracionesService, EnumeracionesService>();
builder.Services.AddSingleton<IConversionesService, ConversionesService>();

var app = builder.Build();

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
