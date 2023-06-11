using DataAccess.Contracts;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly TiendaContext _context;

        public ArtistRepository(TiendaContext tiendaContext)
        {
            _context = tiendaContext;
        }

        public async Task AddArtistAsync(Artist artist)
        {
            await _context.Artists.AddAsync(artist);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteArtistAsync(int id)
        {
            var artist = await _context.Artists.FirstOrDefaultAsync(x => x.ArtistId == id);
            if (artist != null) 
            {
                _context.Artists.Remove(artist);
            }
        }

        public Task<Artist> GetArtistAsync(int id)
        {
            return _context.Artists.FirstOrDefaultAsync(x => x.ArtistId == id);
        }

        public void UpdateArtist(Artist artist)
        {
            _context.Artists.Update(artist);
            _context.SaveChanges();
        }
    }
}
