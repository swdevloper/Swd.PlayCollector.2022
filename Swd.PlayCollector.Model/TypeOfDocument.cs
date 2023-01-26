﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Model
{
    public class TypeOfDocument
    {

        public int Id { get; set; }

        public string Name { get; set; }
  
        List<Media> MediaSet { get; set; }
    }
}
