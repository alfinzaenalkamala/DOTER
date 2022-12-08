using DOTER.Application.Config;
using DOTER.Application.Services.Animals;
using DOTER.Application.Services.Breeders;
using DOTER.Application.Services.Consumers;
using DOTER.Application.Services.PurchaseDetails;
using DOTER.Application.Services.Purchases;
using DOTER.Database.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// DbContext
var connectionString = builder.Configuration.GetConnectionString("Database");
builder.Services.AddDbContext<DoterContext>(options => options.UseSqlServer(connectionString));


// Add AutoMapper
var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new ConfigurationProfile());
});
var mapper = config.CreateMapper();

// Add services to the container.
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<IAnimalAppService, AnimalAppService>();
builder.Services.AddTransient<IConsumerAppService, ConsumerAppService>();
builder.Services.AddTransient<IBreederAppService, BreederAppService>();
builder.Services.AddTransient<IPurchaseAppService, PurchaseAppService>();
builder.Services.AddTransient<IPurchaseDetailAppService, PurchaseDetailAppService>();


builder.Services.AddControllers();
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
