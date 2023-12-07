using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeQuadrangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrangle quadrangle = new Quadrangle();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Введите координату X вершины № {i + 1}");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите координату Y вершины № {i + 1}");
                int y = Convert.ToInt32(Console.ReadLine());
                Point point = new Point(x, y);
                quadrangle.dots[i] = point;
            }
            Console.WriteLine("Результат: четрырёхугольник - " + quadrangle.Type());
        }
    }
}
