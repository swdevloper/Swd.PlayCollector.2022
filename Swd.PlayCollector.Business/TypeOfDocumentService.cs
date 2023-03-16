using Swd.PlayCollector.Model;
using Swd.PlayCollector.Repository;

namespace Swd.PlayCollector.Business
{



    public class TypeOfDocumentService
    {
        private ITypeOfDocumentRepository _IRepository;


        public TypeOfDocumentService()
        {
            _IRepository = new TypeOfDocumentRepository();
        }


        public async Task<IQueryable<TypeOfDocument>> GetAllAsync()
        {
            var returnList = await _IRepository.GetAllAsync();
            return returnList;
        }


        public async Task<TypeOfDocument> GetTypeOfDocumentByFileExtension(string fileExtension)
        {
            TypeOfDocument typeOfDocument = new TypeOfDocument { Id = 6, Name = "Unbekannt" };
            switch (fileExtension.ToLower())
            {
                case ".pdf":
                    typeOfDocument = new TypeOfDocument { Id = 2, Name = "Anleitung" };
                    break;
                case ".png":
                case ".jpeg":
                case ".jpg":
                    typeOfDocument = new TypeOfDocument { Id = 1, Name = "Setabbildung" };
                    break;
            }
            return typeOfDocument;
        }

    }
}