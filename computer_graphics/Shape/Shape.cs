using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Shape
    {
        public string name => nameof(Shape);
        public int X { get; set; }
        public int Y { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw(ref System.Windows.Forms.PictureBox board)
        {
            Console.WriteLine("执行基类绘图任务");
        }
        //public int area { set; get; }

        //public int perimeter { get; set; }

        public virtual Graphics CreateGraphics(ref System.Windows.Forms.PictureBox board)
        {
            return board.CreateGraphics();
        }


    }
}
