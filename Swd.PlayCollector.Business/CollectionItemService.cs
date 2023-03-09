using Swd.PlayCollector.Model;
using Swd.PlayCollector.Repository;

namespace Swd.PlayCollector.Business
{



    public class CollectionItemService
    {

        private ICollectionItemRepository _IRepository;


        public CollectionItemService()
        {
            _IRepository = new CollectionItemRepository();
        }


        public async Task AddAsync(CollectionItem item)
        {
            await _IRepository.AddAsync(item);
        }

        public async Task UpdateAsync(CollectionItem item)
        {
            await _IRepository.UpdateAsync(item, item.Id);
        }

        public async Task DeleteAsync(int id)
        {
            await _IRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<CollectionItem>> GetAllAsync()
        {
            var returnList = await _IRepository.GetAllAsync();
            return returnList;
        }



    }
}