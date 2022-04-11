using Microsoft.EntityFrameworkCore;
using ApiRest.Models;

var builder = WebApplication.CreateBuilder(args);

//Configuração
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer(
    "Data Source=localhost; Initial Catalog=ProjetoEscola; Integrated Security=False; User ID=root; Passawor=; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False"));
var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
