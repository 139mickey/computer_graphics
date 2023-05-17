using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Shape;
using static Shape.Helpers;

namespace 平行四边形的图形绘制与面积
{
    public partial class ParallelogramPage : TabPage //Form
    {
        private List<Point> Points;
        private bool isDragable;
        private int selectedPoint;

        public ParallelogramPage()
        {
            Points = new List<Point>();
            isDragable = false;
            InitializeComponent();
            Text = "平行四边形绘制与面积计算";
        }

        private void DrawDotAndSetPoint(int x,int y)
        {
            var point = new Point
            {
                X = x,
                Y = y
            };
            Points.Add(point);
            var dot = new Dot(point);
            dot.Draw(ref mainBoard);
        }

        private void mainBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if ((Points?.Count() ?? 0) < 2)
            {
                DrawDotAndSetPoint(e.X, e.Y);
            }
            else if((Points?.Count() ?? 0) == 2)
            {
                DrawDotAndSetPoint(e.X, e.Y);

                DrawParallelogram();
            }
            else
            {
                isDragable = false;
            }
        }

        private void DrawParallelogram()
        {
            Parallelogram parallelogram = new Parallelogram(Points);
            parallelogram.Draw(ref mainBoard);
            Console.WriteLine(parallelogram.CalculateArea());
            label2.Text = $"面积为：\n{parallelogram.CalculateArea()}";
        }

        private void mainBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragable)
            {
                Points[selectedPoint] = new Point
                {
                    X = e.X,
                    Y = e.Y
                };
                DrawParallelogram();
            }
            //label1.Text = $"isDragable: {isDragable} \n selectedPoint: {selectedPoint} ";
        }

        private void mainBoard_MouseDown(object sender, MouseEventArgs e)
        {
            const int toRound= 20;
            if ((Points?.Count()?? 0) >2)
            {
                var point = new Point
                {
                    X = RoundTo(e.X, toRound),
                    Y = RoundTo(e.Y, toRound)
                };
                for (var i = 0; i < 3; i++)
                {
                    var x = RoundTo(Points[i].X, toRound);
                    var y = RoundTo(Points[i].Y, toRound);
                    if (point.X == x && point.Y == y)
                    {
                        isDragable = true;
                        selectedPoint = i;
                        break;
                    }
                    else
                    {
                        isDragable = false;
                        selectedPoint = 0;
                    }
                }
            }
        }
    }
}
