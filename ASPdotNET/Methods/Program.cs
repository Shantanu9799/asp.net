using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 20);
            Console.WriteLine("The Point was initially at ( {0}, {1} ).", point.X, point.Y);
            // Output -> The Point was initially at ( 10, 20 ).

            point.Move(new Point(20, 30));
            Console.WriteLine("The Point is now at ( {0}, {1} ) after 1st Operation.", point.X, point.Y);
            // Output -> The Point is now at ( 20, 30 ) after 1st Operation.

            point.Move(30, 40);
            Console.WriteLine("The Point is now at ( {0}, {1} ) after 2nd Operation.", point.X, point.Y);
            // Output -> The Point is now at ( 30, 40 ) after 2nd Operation.

            Console.ReadLine();
        }
    }
}
