using Microsoft.EntityFrameworkCore;
using PlayWorld.Api.Data;
using PlayWorld.Api.Mapping;

namespace PlayWorld.Api.Endpoints;

public static class GenresEndpoints
{
    public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("genres");

        group.MapGet("/", async (GameStoreContext dbContext) => 
        await dbContext.Genres
                    .Select(genre => genre.ToDto())
                    .AsNoTracking()
                    .ToListAsync()); 

            return group; 
    }
}
