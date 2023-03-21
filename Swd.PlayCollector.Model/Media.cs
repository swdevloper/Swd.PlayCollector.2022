using Swd.PlayCollector.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Model
{
    public class Media
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Uri { get; set; }


        public TypeOfDocument TypeOfDocument { get; set; }
        public CollectionItem CollectionItem { get; set; }


        public string ImagePath
        {
            get
            {
                PlayCollectorConfiguration config = new PlayCollectorConfiguration();
                string rootDir =config.PathToMediaFiles;
                return Path.Combine(rootDir,Uri,Name);
            }
        }

    }
}
