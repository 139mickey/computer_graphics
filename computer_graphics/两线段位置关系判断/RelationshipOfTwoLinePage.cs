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

namespace 两线段位置关系判断
{
    public partial class RelationshipOfTwoLinePage : TabPage //Form
    {
        Point m_p0;
        Point m_p1;

        Point m_p2;
        Point m_p3;
        int index = 0;
        public RelationshipOfTwoLinePage()
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
                index++;
                return;
            }

            if (index == 3)
            {
                m_p3 = e.Location;
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Red, m_p2, m_p3);
                index = 0;

                bool ok1 = false;
                bool ok2 = false;

                Vector2 vAB = new Vector2(m_p0, m_p1);
                Vector2 vAC = new Vector2(m_p0, m_p2);
                Vector2 vAD = new Vector2(m_p0, m_p3);
                float value1 = vAB.cross_multi_value(vAC);
                float value2 = vAB.cross_multi_value(vAD);
                if (value1 * value2 < 0) ok1 = true;

                Vector2 vCD = new Vector2(m_p2, m_p3);
                Vector2 vCA = new Vector2(m_p2, m_p0);
                Vector2 vCB = new Vector2(m_p2, m_p1);
                float value3 = vCD.cross_multi_value(vCA);
                float value4 = vCD.cross_multi_value(vCB);
                if (value3 * value4 < 0) ok2 = true;

                if (ok1 && ok2) MessageBox.Show("跨立");
                else
                    MessageBox.Show("不跨立");
            }
        }
    }
}
