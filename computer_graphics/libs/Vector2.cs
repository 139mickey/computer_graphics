using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace libs
{
    class Vector2
    {
        float m_fx;
        float m_fy;

        public Vector2()
        { }

        public Vector2(float x, float y)
        {
            m_fx = x;
            m_fy = y;
        }

        public Vector2(PointF p1, PointF p2)
        {
            m_fx = p2.X - p1.X;
            m_fy = p2.Y - p1.Y;
        }

        public Vector2 add_vector(Vector2 v1)
        {
            float x = m_fx + v1.m_fx;
            float y = m_fy + v1.m_fy;

            Vector2 curV = new Vector2(x, y);
            return curV;

        }

        public Vector2 sub_vector(Vector2 v1)
        {
            float x = m_fx - v1.m_fx;
            float y = m_fy - v1.m_fy;

            Vector2 curV = new Vector2(x, y);
            return curV;

        }

        public float dot_multi(Vector2 v1)
        {
            float curValue = m_fx * v1.m_fx + m_fy * v1.m_fy;

            return curValue;

        }

        public Vector2 scale_vector(float k)
        {
            float x = m_fx * k;
            float y = m_fy * k;

            Vector2 curV = new Vector2(x, y);
            return curV;

        }

        public float cross_multi_value(Vector2 v1)
        {
            float curValue = m_fx * v1.m_fy - v1.m_fx * m_fy;

            return curValue;

        }
        public float mo()
        {
            float x2 = m_fx * m_fx;
            float y2 = m_fy * m_fy;
            float mo = (float)System.Math.Sqrt(x2 + y2);
            return mo;
        }
    }
}
