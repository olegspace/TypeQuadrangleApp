using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeQuadrangleApp
{
    public class Quadrangle
    {
        public Point[] dots = new Point[4];
        public bool AbParallelCd()
        {
            const double eps = 1e-7;

            return eps > Math.Abs(((dots[1].x - dots[0].x) * (dots[2].y - dots[3].y)) - ((dots[2].x - dots[3].x) * (dots[1].y - dots[0].y))); ;
        }

        public bool AdParallelBc()
        {
            const double eps = 1e-7;

            return eps > Math.Abs(((dots[2].x - dots[1].x) * (dots[3].y - dots[0].y)) - ((dots[3].x - dots[0].x) * (dots[2].y - dots[1].y)));
        }

        public bool EqualityAB_BC()
        {
            const double eps = 1e-7;

            return eps > Math.Abs(Math.Sqrt(Math.Pow(dots[1].x - dots[0].x, 2) + Math.Pow(dots[1].y - dots[0].y, 2)) - Math.Sqrt(Math.Pow(dots[2].x - dots[1].x, 2) + Math.Pow(dots[2].y - dots[1].y, 2)));
        }
        public bool EqualityAB_CD()
        {
            const double eps = 1e-7;

            return eps > Math.Abs(Math.Sqrt(Math.Pow(dots[3].x - dots[2].x, 2) + Math.Pow(dots[3].y - dots[2].y, 2)) - Math.Sqrt(Math.Pow(dots[1].x - dots[0].x, 2) + Math.Pow(dots[1].y - dots[0].y, 2)));
        }
        public bool EqualityBC_AD()
        {
            const double eps = 1e-7;

            return eps > Math.Abs(Math.Sqrt(Math.Pow(dots[2].x - dots[1].x, 2) + Math.Pow(dots[2].y - dots[1].y, 2)) - Math.Sqrt(Math.Pow(dots[0].x - dots[3].x, 2) + Math.Pow(dots[0].y - dots[3].y, 2)));
        }


        public string Type()
        {
            const double eps = 1e-7;
            bool a = AbParallelCd(); // AB параллельно CD
            bool b = AdParallelBc();
            bool c = EqualityAB_BC();
            bool d = EqualityAB_CD();
            bool e = EqualityBC_AD();
            if (a || b)
            {
                if (a && b)
                {
                    if (eps > Math.Abs(Math.Sqrt(Math.Pow((dots[2].x - dots[0].x), 2) + Math.Pow((dots[2].y - dots[0].y), 2)) - Math.Sqrt(Math.Pow((dots[3].x - dots[1].x), 2) + Math.Pow((dots[3].y - dots[1].y), 2))))
                    {
                        if (c) return "квадрат";
                        else return "прямоугольник";
                    }
                    else
                    {
                        if (c) return "ромб";
                        else return "параллелограмм";
                    }
                }
                else
                {
                    if (d || e) return "равнобедренная трапеция";
                    else return "трапеция общего вида";
                }
            }
            else return "произвольный";
        }
    }
}
