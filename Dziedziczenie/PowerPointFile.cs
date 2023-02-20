using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
     class PowerPointFile : File
    {
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting... ");
        }
    }
}
