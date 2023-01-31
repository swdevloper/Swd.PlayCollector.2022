using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Swd.PlayCollector.Model
{
    public class CollectionItem: ModelBase
    {

        public int Id { get; set; }

        [MaxLength(50)]
        [NotNull]
        public string Name { get; set; }

        [MaxLength(25)]
        public string Number { get; set; }
        
        public int? ReleaseYear { get; set; }
        public decimal Price { get; set; }  
        

        public int? LocationId { get; set; }
        public Location Location { get; set; }

        public int? ThemeId { get; set; }
        public Theme Theme { get; set; } 
        
        public List<Media> MediaSet { get; set; }

    }
}