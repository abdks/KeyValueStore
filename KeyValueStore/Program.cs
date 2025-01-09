using KeyValueStore;
using Marten;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Host=postgres;Port=5432;Database=keyvaluestore;Username=admin;Password=admin";

builder.Services.AddMarten(options =>
{
    options.Connection(connectionString);
    options.Schema.For<KeyValueRecord>().Identity(x => x.Key);
});

builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();

app.MapControllers();

app.Run();

