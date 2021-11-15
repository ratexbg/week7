using Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2test
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine(r);
            Console.WriteLine($"Perimeter {(r.Perimeter())}" );
            Rectangle translated = r.Translate(10).Translate(-50);
            Console.WriteLine(translated);
        }
    }
}
