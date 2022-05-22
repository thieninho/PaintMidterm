using PaintMidterm.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintMidterm.Model
{
    public abstract class Shape:ICloneable
    {
        public string name { get; set; }

        public Point pointHead { get; set; }


        public Point pointTail { get; set; }

        public bool isSelected { get; set; }


        public int contourWidth { get; set; }


        public bool isFill { get; set; }

        public Color color { get; set; }


        public abstract object Clone();

        /// <param name="g">graphics</param>
        public abstract void drawShape(Graphics g);

        /// <param name="distance">khoảng cách</param>
        public virtual void moveShape(Point distance)
        {
            pointHead = new Point(pointHead.X + distance.X, pointHead.Y + distance.Y);
            pointTail = new Point(pointTail.X + distance.X, pointTail.Y + distance.Y);
        }


        /// <param name="p">điểm cần xét</param>

        public abstract bool isHit(Point p);


        protected abstract GraphicsPath graphicsPath { get; }


        /// <param name="rectangle">Hình chữ nhật cần xét</param>

        public virtual bool isInRegion(Rectangle rectangle)
        {
            return pointHead.X >= rectangle.X &&
                pointTail.X <= rectangle.X + rectangle.Width &&
                pointHead.Y >= rectangle.Y &&
                pointTail.Y <= rectangle.Y + rectangle.Height;
        }


        public Rectangle getRectangle()
        {
            return new Rectangle(pointHead.X,
                pointHead.Y,
                pointTail.X - pointHead.X,
                pointTail.Y - pointHead.Y);
        }


        /// <param name="a"></param>
        /// <param name="b"></param>

        public Rectangle getRectangle(Point a, Point b)
        {
            if (a.X > b.X)
            {
                int temp = a.X;
                a.X = b.X;
                b.X = temp;
            }
            if (a.Y > b.Y)
            {
                int temp = a.Y;
                a.Y = b.Y;
                b.Y = temp;
            }
            return new Rectangle(a.X, a.Y, b.X - a.X, b.Y - a.Y);
        }


        /// <param name="p">Điểm cần xét</param>

        public virtual int isHitControlsPoint(Point p)
        {
            List<Point> points = FindRegion.getControlPoints(this);
            for (int i = 0; i < 8; i++)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddRectangle(new Rectangle(points[i].X - 4, points[i].Y - 4, 8, 8));

                if (path.IsVisible(p)) return i;
            }
            return -1;
        }

        /// <param name="index">Điểm điều khiển</param>
        public virtual void changePoint(int index)
        {
            if (index == 0 || index == 1 || index == 3)
            {
                Point point = pointHead;
                pointHead = pointTail;
                pointTail = point;
            }
            if (index == 2)
            {
                int a = pointTail.X;
                int b = pointHead.Y;
                pointHead = new Point(pointHead.X, pointTail.Y);
                pointTail = new Point(a, b);
            }
            if (index == 5)
            {
                int a = pointHead.X;
                int b = pointTail.Y;
                pointHead = new Point(pointTail.X, pointHead.Y);
                pointTail = new Point(a, b);
            }
        }

        /// <param name="pointCurrent">Vị trí cần di chuyển tới</param>
        /// <param name="previous">Vị trí trước đó</param>
        /// <param name="index">Điểm điều khiển</param>
        public virtual void moveControlPoint(Point pointCurrent, Point previous, int index)
        {
            int deltaX = pointCurrent.X - previous.X;
            int deltaY = pointCurrent.Y - previous.Y;
            if (index == 1 || index == 6)
            {
                pointTail = new Point(pointTail.X, pointTail.Y + deltaY);
            }
            else if (index == 3 || index == 4)
            {
                pointTail = new Point(pointTail.X + deltaX, pointTail.Y);
            }
            else
            {
                pointTail = pointCurrent;
            }
        }
    }
}
