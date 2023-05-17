using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shape;


namespace 道格拉斯算法
{
    public partial class DouglassFormDemo :  TabPage
    {
        private List<Point> Points;
        private Polygon polygon;
        private bool isDragable;
        private int selectedPoint;
        private bool MakeClosePoint;

        public DouglassFormDemo()
        {
            Points = new List<Point>();
            isDragable = false;
            InitializeComponent();
            polygon = null;
            MakeClosePoint = false;
        }

        private void DrawDotAndSetPoint(int x, int y)
        {
            if (MakeClosePoint)
            {
                x = Points[0].X;
                y = Points[0].Y;
                MakeClosePoint = false;
            }
            // 构造静态测试点数据
            // Console.WriteLine("new Point({0}, {1}),", x, y);
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
            if (!isDragable)
            {
                if (polygon == null || !polygon.IsClose)
                {
                    DrawDotAndSetPoint(e.X, e.Y);
                    Draw();
                }
            }
            else
            {
                isDragable = false;
            }
        }

        private void Draw()
        {
            polygon = new Polygon(Points);

            polygon.Draw(ref mainBoard);
            // Console.WriteLine(polygon.CalculateArea());
            label2.Text = $"压缩前的点数为：\n{polygon.GetPointCount()}";
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
                Draw();
            }
            //label1.Text = $"isDragable: {isDragable} \n selectedPoint: {selectedPoint} ";
        }

        private void mainBoard_MouseDown(object sender, MouseEventArgs e)
        {
            const int toRound = 20;
            if ((Points?.Count() ?? 0) > 2)
            {
                var point = new Point
                {
                    X = Helpers.RoundTo(e.X, toRound),
                    Y = Helpers.RoundTo(e.Y, toRound)
                };
                for (var i = 0; i < Points.Count; i++)
                {
                    var x = Helpers.RoundTo(Points[i].X, toRound);
                    var y = Helpers.RoundTo(Points[i].Y, toRound);
                    if (point.X == x && point.Y == y)
                    {
                        isDragable = polygon.IsClose;
                        if (isDragable)
                        {
                            selectedPoint = i;
                        }
                        else
                        {
                            MakeClosePoint = true;
                        }
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

        private void mainBoard_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (polygon == null)
                return;
            var reducePoints = Douglas.DouglasPeuckerReduction(polygon.GetPoints(), Convert.ToDouble(Tolerance.Text));
            Polygon ReducePolygon = new Polygon(reducePoints);
            ReducePolygon.Draw(ref this.pictureBox1);
            label1.Text = $"压缩后点数为：\n{ReducePolygon.GetPointCount()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Point> p = new List<Point> {
                new Point(21, 20),
                new Point(38, 19),
                new Point(55, 20),
                new Point(79, 20),
                new Point(95, 20),
                new Point(116, 19),
                new Point(137, 21),
                new Point(161, 21),
                new Point(179, 21),
                new Point(198, 21),
                new Point(218, 22),
                new Point(242, 22),
                new Point(263, 20),
                new Point(282, 21),
                new Point(264, 44),
                new Point(249, 57),
                new Point(234, 70),
                new Point(218, 76),
                new Point(192, 93),
                new Point(171, 108),
                new Point(153, 121),
                new Point(131, 132),
                new Point(114, 145),
                new Point(93, 162),
                new Point(76, 177),
                new Point(58, 192),
                new Point(41, 213),
                new Point(27, 239),
                new Point(19, 263),
                new Point(16, 285),
                new Point(18, 306),
                new Point(39, 308),
                new Point(65, 305),
                new Point(87, 303),
                new Point(110, 305),
                new Point(135, 304),
                new Point(158, 301),
                new Point(185, 300),
                new Point(210, 300),
                new Point(234, 301),
                new Point(259, 301),
                new Point(282, 301),
                new Point(309, 300),
                new Point(341, 297),
                new Point(366, 297),
                new Point(364, 273),
                new Point(363, 248),
                new Point(362, 225),
                new Point(362, 203),
                new Point(360, 178),
                new Point(358, 156),
                new Point(358, 135),
                new Point(357, 111),
                new Point(356, 89),
                new Point(353, 61),
                new Point(350, 40),
                new Point(350, 21),
                new Point(376, 21),
                new Point(394, 21),
                new Point(418, 23),
                new Point(443, 24),
                new Point(468, 24),
                new Point(495, 27),
                new Point(524, 25),
                new Point(548, 27),
                new Point(570, 27),
                new Point(592, 29),
                new Point(624, 29),
                new Point(648, 29),
                new Point(671, 30),
                new Point(684, 53),
                new Point(692, 75),
                new Point(695, 101),
                new Point(688, 120),
                new Point(674, 139),
                new Point(657, 151),
                new Point(629, 154),
                new Point(592, 154),
                new Point(560, 155),
                new Point(522, 154),
                new Point(492, 151),
                new Point(463, 151),
                new Point(436, 149),
                new Point(407, 149),
                new Point(395, 170),
                new Point(416, 184),
                new Point(456, 183),
                new Point(504, 182),
                new Point(541, 182),
                new Point(576, 184),
                new Point(602, 186),
                new Point(635, 190),
                new Point(661, 190),
                new Point(674, 209),
                new Point(692, 231),
                new Point(692, 253),
                new Point(689, 278),
                new Point(677, 294),
                new Point(651, 306),
                new Point(621, 305),
                new Point(583, 308),
                new Point(557, 306),
                new Point(531, 309),
                new Point(498, 307),
                new Point(473, 308),
                new Point(447, 306),
                new Point(418, 306),
                new Point(398, 301),
                new Point(383, 299),
            };
            Points = p;
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = $"压缩前的点数为：";
            label1.Text = $"压缩后的点数为：";
            Points.Clear();
            polygon = null;
            mainBoard.Refresh();
            pictureBox1.Refresh();
        }


        private void DouglassFormDemo_Load(object sender, EventArgs e)
        {

        }

    }
}
