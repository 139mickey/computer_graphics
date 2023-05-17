using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Shape
{
    public class Triangle:Shape
    {
        private List<Point> _points;
        
        public Triangle()
        {
            _points = new List<Point>();
        }

        public Triangle(List<Point> points)
        {
            AddPoints(points);
        }

        public AddPoints(List<Point> points)
        {
            if (points.Count >= 3)
            {
                _points = points.GetRange(0, 3);
            }
        }

        public List<Point> GetPoints() {

            return _points.ToList<Point>();
        }

        public override void Draw(ref PictureBox board)
        {
            board.Refresh();

            foreach (var item in _points)
            {
                var dot = new Dot(item);
                dot.Draw(ref board);
            }


            if (_points.Count > 1) {
                Graphics formGraphics;
                formGraphics = board.CreateGraphics();
                formGraphics.DrawTriangle(Pens.Blue, _points.ToArray());
                formGraphics.Dispose();
            }
        }

        public int GetPointCount() {
            return _points.Count;
        }
        public double CalculateArea()
        {
            double area = 0.0;
            for (int i = 0, j = _points.Count - 1; i < _points.Count; j = i, i += 1)
            {
                var point1 = _points[i];
                var point2 = _points[j];
                area += point1.X * point2.Y;
                area -= point1.Y * point2.X;
            }
            return Math.Round(Math.Abs(area / 2), 2);
        }

    }
}
