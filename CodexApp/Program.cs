using CodexApp.Controllers;
using CodexApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Porque agregamos el servicio de InitialData y QuerySaldo?
//Porque necesitamos que estos servicios esten disponibles para los controladores que los necesiten.

builder.Services.AddSingleton<A_DatosIniciales>(); // Se agrega la clase InitialData al contenedor de servicios.

builder.Services.AddSingleton<QuerySaldo>(); // Se agrega la clase QuerySaldo al contenedor de servicios.

builder.Services.AddSingleton<PagoQueue>(); // Se agrega la clase PagoQueue al contenedor de servicios.

builder.Services.AddSingleton<AumentoLimiteStack>(); // Se agrega la clase AumentoLimiteStack al contenedor de servicios.

builder.Services.AddSingleton<PinUpdate>(); // Se agrega la clase PinUpdate al contenedor de servicios.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
