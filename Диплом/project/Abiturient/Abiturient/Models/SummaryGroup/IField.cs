﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abiturient.Models
{
    interface IField
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
