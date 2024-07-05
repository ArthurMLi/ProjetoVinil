using ControleDeVinil.Shared.Dados;
using ControleDeVinil.Shared.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//#if DEBUG
//builder.Services.AddSqlite<Contexto>("Data Source=controleDeVinil.db");
//#else
//builder. Services.AddDbContext<Contexto>((options) => {
//options.UseSqlServer(builder.Configuration["ConnectionStrings: ControleDeVinil"]). UseLazyLoadingProxies();
//});
//#endif
//
//builder.Services.AddTransient<DAO<Artista>>;
//builder.Services.AddTransient<DAO<Genero>>;
//builder.Services.AddTransient<DAO<Musica>>;
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
