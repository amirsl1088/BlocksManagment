using AllBlocks.Persistence.EF;
using AllBlocks.Persistence.EF.Blocks;
using AllBlocks.Persistence.EF.Units;
using AllBlocks.Services.Blocks;
using AllBlocks.Services.Blocks.contracts;
using AllBlocks.Services.Units;
using AllBlocks.Services.Units.contracts;
using Taav.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EFDataContext>();
builder.Services.AddScoped<BlockService, BlocksAppService>();
builder.Services.AddScoped<BlockRepository, EFBlockRepository>();
builder.Services.AddScoped<UnitService, UnitsAppService>();
builder.Services.AddScoped<UnitRepository, EFUnitRepository>();
builder.Services.AddScoped<IUnitOfWork, EFUnitOfWord>();
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
