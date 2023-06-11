using DataAccess.Entities;
using Domain.Models;

namespace Aplication.Mappers;

public class ArtistModelMapper
{
    public static ArtistModel Map(Artist artist)
    {
        return new ArtistModel
        {
            ArtistId = artist.ArtistId,
            ArtistName = artist.Name,
        };
    }
}
