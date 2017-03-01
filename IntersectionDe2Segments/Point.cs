namespace IntersectionDe2Segments
{
    class Point
    {
        private double _X = 0;
        private double _Y = 0;

        public double X
        {
            get
            {
                return _X;
            }

            set
            {
                _X = value;
            }
        }

        public double Y
        {
            get
            {
                return _Y;
            }

            set
            {
                _Y = value;
            }
        }

        public Point(double X, double Y)
        {
            this.X = X;
            _Y = Y;
        }

        public Point(double[] vecteur)
        {
            if (vecteur == null) return;
            if (vecteur.Length == 0) return;
            X = vecteur[0];
            if (vecteur.Length == 1) return;
            _Y = vecteur[1];
        }

    }
}
