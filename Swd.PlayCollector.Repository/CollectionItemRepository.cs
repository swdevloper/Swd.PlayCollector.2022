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


        public async Task AddMedia(CollectionItem item, Media media)
        {
            PlayCollectorContext playCollectorContext = new PlayCollectorContext();
            
            CollectionItem existingItem = playCollectorContext.CollectionItem
                                            .Include(c=>c.MediaSet)
                                            .Where(c=>c.Id == item.Id)
                                            .FirstOrDefault();

            existingItem.MediaSet.Add(media);

            var state2 = playCollectorContext.Entry(item).State;
            var state3 = playCollectorContext.Entry(existingItem).State;

            foreach (Media m in existingItem.MediaSet)
            {
                var state = playCollectorContext.Entry(m).State;    


            }
            playCollectorContext.SaveChanges();


        }

    }
}
