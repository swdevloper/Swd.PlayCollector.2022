using Microsoft.IdentityModel.Protocols;
using Swd.PlayCollector.Model;
using Swd.PlayCollector.Repository;
using System.Globalization;

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


        public async Task<CollectionItem> GetById(object key)
        {
            CollectionItem item = await _IRepository.GetByIdAsync(key);
            return item;
        }

        public async Task<IQueryable<CollectionItem>> GetAllInklusiveAsync()
        {
            //CollectionItemRepository repository = new CollectionItemRepository();
            var returnList = await _IRepository.GetAllInklusiveAsync();
            return returnList;
        }


        public async Task AddMediaItems(IEnumerable<string> files, int id)
        {
            foreach (var file in files)
            {
                string mediaFile = await CopyFile(file, id);
                if(mediaFile != null)
                {
                    Media media = new Media();
                    media.Name = file;
                    media.TypeOfDocument = new TypeOfDocument { Id = 1 };
                    media.Uri = file;

                    CollectionItem item = await GetById(id);

                    media.CollectionItem = item;
                    await AddMediaItemAsync(media);
                }
            }
        }


        private async Task<string> CopyFile(string sourceFile, int id)
        {
            string rootDir = @"C:\\SwDeveloper2022\\SWDData\\PlayCollector";
            string targetDir = Path.Combine(rootDir, id.ToString());
            if(!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }
            string fileName = Path.GetFileName(sourceFile);
            string targetFile = Path.Combine(rootDir, id.ToString(), fileName); ;
            File.Copy(sourceFile, targetFile, true);
            return targetFile;
        }

        private async Task AddMediaItemAsync(Media media)
        {
            MediaService mediaService = new MediaService();
            await mediaService.AddAsync(media);
        }

    }
}