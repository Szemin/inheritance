using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
     class WordDocumentFile : File 
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing..");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printing... ");
        }
    }
}
