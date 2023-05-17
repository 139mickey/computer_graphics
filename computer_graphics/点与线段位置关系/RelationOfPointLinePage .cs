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

namespace 点与线段位置关系
{
    public partial class RelationOfPointLinePage : TabPage //Form
    {
        Point m_p1;
        Point m_p2;
        Point m_p;

        int index = 0;
        public RelationOfPointLinePage()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (index == 0)
            {
                m_p1 = e.Location;
                index++;
                return;
            }

            if (index == 1)
            {
                m_p2 = e.Location;

                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Red, m_p1, m_p2);

                index++;
                return;
            }

            if (index == 2)
            {
                m_p = e.Location;

                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Blue, 2);
                Brush brush = new SolidBrush(Color.Blue);
                g.DrawEllipse(pen, e.X, e.Y, 2, 2);
                g.FillEllipse(brush, e.X, e.Y, 2, 2);

                index = 0;
                
                Vector2 vAP = new Vector2(m_p1, m_p);                
                Vector2 vAB = new Vector2(m_p1, m_p2);

                float ABccAP = vAB.cross_multi_value(vAP);
                if (ABccAP < 0)
                    MessageBox.Show("点在线段AB的左侧");
                else if (ABccAP > 0)
                    MessageBox.Show("点在线段AB的右侧");
            }
        }
    }
}
