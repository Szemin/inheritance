using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
     class ExcelFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing..");
        }
        public void GenerateReport()
        {
            string prop = ProtectedProp;
            Console.WriteLine($"{FileName} report... ");
        }

    }
}
