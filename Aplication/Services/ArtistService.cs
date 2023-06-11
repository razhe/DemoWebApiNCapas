using DataAccess.Mappers;
using Aplication.Mappers;
using Aplication.Contracts;
using DataAccess.Contracts;
using Domain.Models;

namespace Aplication.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _repository;

        public ArtistService(IArtistRepository repository)
        {
            _repository = repository;
        }
        public async Task AddArtistAsync(ArtistModel artistModel)
        {
            await _repository.AddArtistAsync(ArtistEntityMapper.Map(artistModel));
        }

        public async Task<ArtistModel> GetArtistAsync(int id)
        {
            var artist = await _repository.GetArtistAsync(id);
            return ArtistModelMapper.Map(artist);
        }

        public void UpdateArtistAsync(ArtistModel artistModel)
        {
            _repository.UpdateArtist(ArtistEntityMapper.Map(artistModel));
        }

        public async Task DeleteArtistAsync(int id)
        {
            await _repository.DeleteArtistAsync(id);
        }
    }
}
