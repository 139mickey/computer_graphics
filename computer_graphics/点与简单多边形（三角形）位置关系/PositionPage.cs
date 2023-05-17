using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libs;

namespace 点与简单多边形_三角形_位置关系
{
    public partial class PositionPage : TabPage // Form
    {
        Point m_p0;
        Point m_p1;

        Point m_p2;
        Point m_p3;

        int index = 0;
        public PositionPage()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (index == 0)
            {
                m_p0 = e.Location;
                index++;
                return;
            }
            if (index == 1)
            {
                m_p1 = e.Location;
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Red, m_p0, m_p1);
                index++;
                return;
            }

            if (index == 2)
            {
                m_p2 = e.Location;
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Red, m_p1, m_p2);
                g.DrawLine(Pens.Red, m_p2, m_p0);
                index++;
                return;
            }
            if (index == 3)
            {
                m_p3 = e.Location;
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Blue, 2);
                Brush brush = new SolidBrush(Color.Blue);
                g.DrawEllipse(pen, e.X, e.Y, 2, 2);
                g.FillEllipse(brush, e.X, e.Y, 2, 2);
                index = 0;

                bool ok1 = false;
                //bool ok2 = false;

                Vector2 v03 = new Vector2(m_p0, m_p3);
                Vector2 v01 = new Vector2(m_p0, m_p1);
                Vector2 v13 = new Vector2(m_p1, m_p3);
                Vector2 v12 = new Vector2(m_p1, m_p2);
                Vector2 v23 = new Vector2(m_p2, m_p3);
                Vector2 v20 = new Vector2(m_p2, m_p0);

                float value1 = v03.cross_multi_value(v01);
                float value2 = v13.cross_multi_value(v12);
                float value3 = v23.cross_multi_value(v20);

                if (value1 * value2 * value3 < 0)
                    ok1 = false;
                else
                    ok1 = true;

                if (ok1)
                    MessageBox.Show("点在三角形内");
                else
                    MessageBox.Show("点在三角形外");
            }
        }
    }
}
