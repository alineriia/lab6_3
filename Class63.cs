using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_3
{
    class Square: IComparable
    {
        protected float a;
        public Square(int b)
        {
            a = b;
        }
        public double Perimeter()
        {
            return 4 * a;
        }
        public double Area()
        {
            return a * a;
        }
        public void Show()
        {
            Console.WriteLine("a = " + a);
        }
        public int CompareTo(object obj)
        {
            Square b = (Square) obj; //перетворимо до типу DemoPoint
                                           //визначаємо критерії порівняння поточного об'єкта з параметром в залежності від віддаленості точки від початку
// координат
 if (this.Perimeter() < b.Perimeter()) return -1;
 else if (this.Perimeter() > b.Perimeter()) return 1;
 else return 0;

        }
    }
    
}
