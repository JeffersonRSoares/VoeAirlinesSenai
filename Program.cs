using VoeAirlinesSenai.Contexts;
using VoeAirlinesSenai.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// *** Criei a duas linhas abaixo *** 
//injeção de dependência da classe VoeiAirlinesContext
builder.Services.AddDbContext<VoeAirlinesContext>();
//injeção de dependência da classe AeronaveService
builder.Services.AddTransient<AeronaveService>();
builder.Services.AddTransient<CancelamentoService>();
builder.Services.AddTransient<ManutencaoService>();
builder.Services.AddTransient<PilotoService>();
builder.Services.AddTransient<VooService>();


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
