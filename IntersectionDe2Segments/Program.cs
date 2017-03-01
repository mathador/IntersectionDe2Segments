using System.Collections.Generic;
using System.Linq;

namespace IntersectionDe2Segments
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment s1 = new Segment(new double[] { 2, 3, 8, 9 });
            Segment s2 = new Segment(new double[] { 4, 1, 5, 14 });
            //Segment s1 = new Segment(new double[] { 2, 3, 5, 14 });
            //Segment s2 = new Segment(new double[] { 4, 1, 5, 14 });
            //Segment s1 = new Segment(new double[] { 2, 3, 4, 14 });
            //Segment s2 = new Segment(new double[] { 4, 1, 5, 14 });
            //Segment s1 = new Segment(new double[] { 4, 1, 8, 9 });
            //Segment s2 = new Segment(new double[] { 4, 1, 5, 14 });

            double[] union = s1.UnionDistinctDesY(s2);
            double[] x31 = s1.Interpolation(union);
            double[] x32 = s2.Interpolation(union);

            double[] DeltaX3 = new double[x31.Length];
            for (int i = 0; i < x31.Length; i++)
                DeltaX3[i] = x31[i] - x32[i];

            for (int i = 0; i < x31.Length - 1; i++)
                if (DeltaX3[i] * DeltaX3[i + 1] <= 0)
                {
                    Point inter = new Point(0, 0);
                    inter.Y = union[i] - DeltaX3[i] / (DeltaX3[i + 1] - DeltaX3[i]) * (union[i + 1] - union[i]);
                    inter.X = s1.Interpolation(inter.Y);

                    List<Point> list = new List<Point>();
                    list.Add(s1.A);
                    list.Add(s1.B);
                    list.Add(s2.A);
                    list.Add(s2.B);
                    list.Add(inter);
                    list = list.OrderBy(p => p.X).DistinctBy(p => p.X).ToList();

                    break;
                }
                //else if(DeltaX3.Any(x=>x == 0))
                //{

                //}
                //else
                //{

                //}
        }
    }
}
