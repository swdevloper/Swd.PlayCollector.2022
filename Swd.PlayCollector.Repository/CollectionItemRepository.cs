using Microsoft.EntityFrameworkCore;
using Swd.PlayCollector.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Swd.PlayCollector.Repository
{
    public class CollectionItemRepository: GenericRepository<CollectionItem, PlayCollectorContext>, ICollectionItemRepository
    {

        public async Task<IQueryable<CollectionItem>> GetAllInklusiveAsync()
        {
            PlayCollectorContext context = new PlayCollectorContext();
            return context.CollectionItem.Include(c => c.MediaSet);
        }

    }
}
