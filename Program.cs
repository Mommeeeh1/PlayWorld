using PlayWorld.Api.Data;
using PlayWorld.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);


var connString = builder.Configuration.GetConnectionString("Playworld"); 
builder.Services.AddSqlite<GameStoreContext>(connString); 

var app = builder.Build();

app.MapGamesEndpoints(); 
app.MapGenresEndpoints(); 

await app.MigrateDbAsync(); 
  
app.Run();
