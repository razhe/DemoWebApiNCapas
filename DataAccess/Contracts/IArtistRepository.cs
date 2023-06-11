using DataAccess.Entities;
namespace DataAccess.Contracts
{
    public interface IArtistRepository
    {
        Task AddArtistAsync(Artist artist);
        Task<Artist> GetArtistAsync(int id);
        void UpdateArtist(Artist artist);
        Task DeleteArtistAsync(int id);
    }
}
