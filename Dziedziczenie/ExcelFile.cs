﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
     class ExcelFile : File
    {
        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report... ");
        }

    }
}
