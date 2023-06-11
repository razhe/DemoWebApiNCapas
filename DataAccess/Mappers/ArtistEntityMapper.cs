using DataAccess.Entities;
using Domain.Models;
namespace DataAccess.Mappers
{
    public class ArtistEntityMapper
    {
        public static Artist Map(ArtistModel artist)
        {
            return new Artist
            {
                ArtistId = artist.ArtistId,
                Name = artist.ArtistName,
            };
        }
    }
}
