using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qRGenerate
{
    class Program
    {
        static void Main(string[] args)
        {
            QRgenerate qRgenerate = new QRgenerate();
            qRgenerate.writeBarcode2("","123456");
            Console.WriteLine( qRgenerate.Decoder());

            Console.ReadLine();
        }
    }
}
