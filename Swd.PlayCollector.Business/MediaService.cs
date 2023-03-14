using Microsoft.IdentityModel.Protocols;
using Swd.PlayCollector.Model;
using Swd.PlayCollector.Repository;
using System.Globalization;

namespace Swd.PlayCollector.Business
{



    public class MediaService
    {

        private IMediaRepository _IRepository;


        public MediaService()
        {
            _IRepository = new MediaRepository();
        }


        public async Task AddAsync(Media item)
        {
            await _IRepository.AddAsync(item);
        }

        public async Task UpdateAsync(Media item)
        {
            await _IRepository.UpdateAsync(item, item.Id);
        }

        public async Task DeleteAsync(int id)
        {
            await _IRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<Media>> GetAllAsync()
        {
            var returnList = await _IRepository.GetAllAsync();
            return returnList;
        }





    }
}