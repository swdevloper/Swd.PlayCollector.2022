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
                // TODO: String literal durch configurations wert ersetzen
                string rootDir = @"C:\\SwDeveloper2022\\SWDData\\PlayCollector";
                return Path.Combine(rootDir,Uri,Name);

            }

        }

    }
}
