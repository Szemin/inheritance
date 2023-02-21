using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
     class PowerPointFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing..");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting... ");
        }
    }
}
