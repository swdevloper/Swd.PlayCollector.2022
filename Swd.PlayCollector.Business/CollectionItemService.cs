using Microsoft.IdentityModel.Protocols;
using Swd.PlayCollector.Helper;
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


       public async Task AddMediaItems(IEnumerable<string> sourcefilePaths, CollectionItem item)
       { 
            if(item!=null)
            {
                foreach (var sourcefilePath in sourcefilePaths)
                {
                    string targetFilePath = await CopyFile(sourcefilePath, item.Id);
                    string fileExtension = Path.GetExtension(targetFilePath);
                    TypeOfDocumentService typeOfDocumentService = new TypeOfDocumentService();

                    Media media = new Media
                    {
                        Name = Path.GetFileName(targetFilePath),
                        Uri = string.Format("{0}", item.Id),
                        TypeOfDocument = await typeOfDocumentService.GetTypeOfDocumentByFileExtension(fileExtension),
                        CollectionItem = item
                    };
                    _IRepository.AddMedia(item, media);
                }
            }
       }

        private async Task<string> CopyFile(string sourceFilePath, int id)
        {
            // TODO: String literal durch configurations wert ersetzen
            PlayCollectorConfiguration configuration = new PlayCollectorConfiguration();
            string rootDir = configuration.PathToMediaFiles;
            string targetFilePath = Path.Combine(rootDir, id.ToString(), Path.GetFileName(sourceFilePath));
            await FileHelper.CopyFile(sourceFilePath, targetFilePath);
            return targetFilePath;
        }

 

    }
}