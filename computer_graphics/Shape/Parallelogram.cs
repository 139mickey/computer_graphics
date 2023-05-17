using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape
{
    public class Parallelogram:Shape
    {
        private List<Point> _points;
        public Parallelogram(List<Point> points)
        {
            _points =new List<Point>(points);

            var pointD = new Point
            {
                X = _points[0].X + _points[2].X - _points[1].X,
                Y = _points[0].Y + _points[2].Y - _points[1].Y,
            };

            _points.Add(pointD);
        }

        public override void Draw(ref PictureBox board)
        {
            board.Refresh();

            foreach (var item in _points)
            {
                var dot = new Dot(item);
                dot.Draw(ref board);
            }

            var line1 = new Line(_points[0], _points[1]);
            line1.Draw(ref board);

            var line2 = new Line(_points[1], _points[2]);
            line2.Draw(ref board);

            var line3 = new Line(_points[0], _points[3]);
            line3.Draw(ref board);

            var line4 = new Line(_points[2], _points[3]);
            line4.Draw(ref board);
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
