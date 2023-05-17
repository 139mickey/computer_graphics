using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Shape
{
    public class Polygon:Shape
    {
        private List<Point> _points;
        
        public Polygon()
        {
            _points = new List<Point>();
        }
        public Polygon(List<Point> points)
        {
            _points =new List<Point>(points);
        }

        public List<Point> GetPoints() {

            return _points.ToList<Point>();
        }
        public void AddNode(Point point)
        {
            _points.Add(new Point(point.X,point.Y));
        }
        public bool IsClose
        {
            get
            {
                if (_points.Count < 3) return false;

                var FirstPoint = _points[0];
                var LastPoint = _points[_points.Count - 1];

                return FirstPoint == LastPoint;
            }
        }
        public void Close()
        {
            if (IsClose) return;

            var FirstPoint = _points[0];
            AddNode(FirstPoint);
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
                for (int i = 0, j = i + 1; i < _points.Count && j < _points.Count; i++,j++)
                {
                    var line1 = new Line(_points[i], _points[j]);
                    line1.Draw(ref board);
                }
                /*
                Graphics formGraphics;
                formGraphics = board.CreateGraphics();
                formGraphics.DrawPolygon(Pens.Blue, _points.ToArray());
                formGraphics.Dispose();
                */
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
