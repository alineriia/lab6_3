using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_3
{
    
    class Main63
    {
        static void Main(string[] args)
        {
            Square[] a = new Square[3];
            a[0] = new Square(2);
            a[1] = new Square(5);
            a[2] = new Square(4);
            Console.WriteLine("\n====== SORTING BY PERIMETER ====== \n");//сортування за середнім балом
            Array.Sort(a);
            foreach (Square s in a)
            {
                Console.WriteLine("{0}", s.Perimeter());
            }
            Console.ReadKey();



        }
    }
}
