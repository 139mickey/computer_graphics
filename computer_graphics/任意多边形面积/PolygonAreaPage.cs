using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 任意多边形面积
{
    public partial class PolygonAreaPage : TabPage //Form
    {
        public PolygonAreaPage()
        {
            InitializeComponent();
        }

        int clickCount = 0;
        Point[] d = new Point[100];
        List<PointF> PointList = new List<PointF>();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 2);
            Brush brush = new SolidBrush(Color.Blue);
            g.DrawEllipse(pen, e.X, e.Y, 7, 7);
            g.FillEllipse(brush, e.X, e.Y, 7, 7);

            d[clickCount] = e.Location;
            if (clickCount >= 1)
            {
                g.DrawLine(pen, d[clickCount], d[clickCount - 1]);
                
            }
            clickCount++;
            PointF pPoint = new PointF(d[clickCount - 1].X, d[clickCount - 1].Y);
            PointList.Add(pPoint);
        }
        public static float CalculateArea(List<PointF> vectorPoints)
        {
            int iCycle, iCount;
            iCycle = 0;
            iCount = vectorPoints.Count;
            float iArea = 0;
            for (iCycle = 0; iCycle < iCount; iCycle++)
            {
                iArea = iArea + (vectorPoints[iCycle].X * vectorPoints[(iCycle + 1) % iCount].Y - vectorPoints[(iCycle + 1) % iCount].X * vectorPoints[iCycle].Y);
            }
            float area = (float)Math.Abs(0.5 * iArea);
            return area;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 2);

            if (PointList.Count > 0) {
                g.DrawLine(pen, PointList[PointList.Count - 1], PointList[0]);
                float S = CalculateArea(PointList);
                MessageBox.Show("多边形面积为：" + S);
            }
            else
                MessageBox.Show("多边形面积为：" + 0);
        }
    }
}
