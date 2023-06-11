using Domain.Models;

namespace Aplication.Contracts
{
    public interface IArtistService
    {
        Task AddArtistAsync(ArtistModel artistModel);
        Task<ArtistModel> GetArtistAsync(int id);
        void UpdateArtistAsync(ArtistModel artistModel);
        Task DeleteArtistAsync(int id);
    }
}
