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


        public async Task<IQueryable<CollectionItem>> GetAllAsync()
        {



            var returnList = await _IRepository.GetAllAsync();
            return returnList;

        }



    }
}