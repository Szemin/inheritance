﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    abstract class File
    {
        public string FileName { get; set; }
        public double Size { get; set; }
        public DateTime CreatedOn { get; set; }
        protected string ProtectedProp { get; set; }
        private string PrivateProp { get; set; }

        public abstract void Compress();
    }
}
