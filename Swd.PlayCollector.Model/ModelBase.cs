using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Model
{
    public class ModelBase
    {

        [MaxLength(25)]
        public string CreatedBy { get; set; }

        [MaxLength(25)]
        public string? UpdatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        
        [AllowNull]
        public DateTime? UpdatedDate { get; set; }

    }
}
