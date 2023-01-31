using Swd.PlayCollector.Model;
using Swd.PlayCollector.Repository;

namespace Swd.PlayCollector.Test
{
    [TestClass]
    public class TestRepository
    {
        [TestMethod]
        public void Add_CollectionItem()
        {
            CollectionItem item = new CollectionItem();
            item.Name = "Testitem";
            item.CreatedDate = DateTime.Now;
            item.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            CollectionItemRepository repo  = new CollectionItemRepository();
            repo.Add(item);
            Assert.AreNotEqual(0, item.Id);
        }

        [TestMethod]
        public async Task Add_CollectionItemAsync()
        {
            CollectionItem item = new CollectionItem();
            item.Name = "Testitem";
            item.CreatedDate = DateTime.Now;
            item.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            CollectionItemRepository repo = new CollectionItemRepository();
            await repo.AddAsync(item);
            Assert.AreNotEqual(0, item.Id);
        }


        [TestMethod]
        [DataRow(0.0)]
        [DataRow(-10.0)]
        [DataRow(10.0)]
        public void Add_CollectionItemWithPrice(double price)
        {
            CollectionItem item = new CollectionItem();
            item.Name = "Testitem";
            item.Price = Convert.ToDecimal(price);
            item.CreatedDate = DateTime.Now;
            item.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            CollectionItemRepository repo = new CollectionItemRepository();
            repo.Add(item);
            Assert.AreNotEqual(0, item.Id);
        }



        [TestMethod]
        public void Update_CollectionItem()
        {
            CollectionItemRepository repo = new CollectionItemRepository();

            CollectionItem item = new CollectionItem();
            string itemName = "Testitem";
            item.Name = itemName;
            item.CreatedDate = DateTime.Now;
            item.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                        
            repo.Add(item);

            CollectionItem addedItem = repo.GetById(item.Id);
            addedItem.Name = String.Format("Testitem{0}", DateTime.Now);
            repo.Update(addedItem, addedItem.Id);
            
            CollectionItem updatedItem = repo.GetById(item.Id);

            Assert.AreNotEqual(itemName, updatedItem.Name);
        }


        [TestMethod]
        public void Delete_CollectionItem()
        {
            CollectionItemRepository repo = new CollectionItemRepository();

            CollectionItem item = new CollectionItem();
            string itemName = "Testitem";
            item.Name = itemName;
            item.CreatedDate = DateTime.Now;
            item.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            repo.Add(item);
            int id = item.Id;
            repo.Delete(id);

            CollectionItem deletedItem = repo.GetById(id);
            Assert.IsNull(deletedItem);
        }

        [TestMethod]
        public void GetAll_CollectionItem()
        {
            CollectionItemRepository repo = new CollectionItemRepository();



            int itemCount = repo.GetAll().Count();
            Assert.AreNotEqual(0,itemCount);
        }


        [TestMethod]
        public void Add_Location()
        {
            Location item = new Location();
            item.Name = "Testlocation";
            item.CreatedDate = DateTime.Now;
            item.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            LocationRepository repo = new LocationRepository();
            repo.Add(item);
            Assert.AreNotEqual(0, item.Id);
        }

        [TestMethod]
        public async Task Add_LocationAsync()
        {
            Location item = new Location();
            item.Name = "Testlocation";
            item.CreatedDate = DateTime.Now;
            item.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            LocationRepository repo = new LocationRepository();
            await repo.AddAsync(item);
            Assert.AreNotEqual(0, item.Id);
        }

    }
}