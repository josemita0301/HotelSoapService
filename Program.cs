using HotelSoapService.Data;
using HotelSoapService.SoapContracts;
using Microsoft.EntityFrameworkCore;
using SoapCore;


var builder = WebApplication.CreateBuilder(args);

// Configurar la base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar el servicio SOAP
builder.Services.AddSoapCore();
builder.Services.AddScoped<ISoapAvailabilityService, SoapAvailabilityService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapAvailabilityService>("/AvailabilityService.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();