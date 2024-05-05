using PlayWorld.Api.Dtos;
using PlayWorld.Api.Entities;

namespace PlayWorld.Api.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {
        return new GenreDto (genre.Id, genre.Name); 
    }

}