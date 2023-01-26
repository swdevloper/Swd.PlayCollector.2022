using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Swd.PlayCollector.Model
{
    public class Location : ModelBase
    {

        public int Id { get; set; }

        [MaxLength(50)]
        [NotNull]
        public string Name { get; set; }


        public List<CollectionItem> CollectionItems;
       
    }
}