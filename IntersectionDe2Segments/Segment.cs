using System.Collections.Generic;
using System.Linq;

namespace IntersectionDe2Segments
{
    class Segment
    {
        private Point _A;
        private Point _B;

        internal Point A
        {
            get
            {
                return _A;
            }

            set
            {
                _A = value;
            }
        }

        internal Point B
        {
            get
            {
                return _B;
            }

            set
            {
                _B = value;
            }
        }

        public Segment(Point A, Point B)
        {
            _A = A;
            _B = B;
        }

        public Segment(double[] listePoint)
        {
            if (listePoint == null) return;
            if (listePoint.Length < 2) return;
            _A = new Point(listePoint[0], listePoint[1]);
            if (listePoint.Length < 4) return;
            _B = new Point(listePoint[2], listePoint[3]);
        }

        public double Interpolation(double y)
        {
            return (_B.X - _A.X) / (_B.Y - _A.Y) * (y - _A.Y) + _A.X;
        }

        public double[] Interpolation(double[] y)
        {
            if (y == null || y.Length == 0) return null;
            double[] result = new double[y.Length];
            for (int i = 0; i < y.Length; i++)
                result[i] = Interpolation(y[i]);
            return result;
        }

        public double[] UnionDistinctDesY(Segment S2)
        {
            List<double> result = new List<double>();
            result.Add(_A.Y);
            result.Add(_B.Y);
            result.Add(S2._A.Y);
            result.Add(S2._B.Y);
            return result.OrderBy(c => c).Distinct().ToArray();
        }
    }
}
