﻿using PaintMidterm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintMidterm.Utils
{
    public class FindRegion
    {
        /// <param name="group"></param>
        public static void setPointHeadTail(GroupShape group)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;

            for (int i = 0; i < group.Count; i++)
            {
                Shape shape = group[i];

                if (shape.pointHead.X < minX)
                {
                    minX = shape.pointHead.X;
                }
                if (shape.pointTail.X < minX)
                {
                    minX = shape.pointTail.X;
                }

                if (shape.pointHead.Y < minY)
                {
                    minY = shape.pointHead.Y;
                }
                if (shape.pointTail.Y < minY)
                {
                    minY = shape.pointTail.Y;
                }

                if (shape.pointHead.X > maxX)
                {
                    maxX = shape.pointHead.X;
                }
                if (shape.pointTail.X > maxX)
                {
                    maxX = shape.pointTail.X;
                }

                if (shape.pointHead.Y > maxY)
                {
                    maxY = shape.pointHead.Y;
                }
                if (shape.pointTail.Y > maxY)
                {
                    maxY = shape.pointTail.Y;
                }
            }
            group.pointHead = new Point(minX, minY);
            group.pointTail = new Point(maxX, maxY);
        }
        /// <param name="curve"></param>
        public static void setPointHeadTail(MCurve curve)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;
            curve.points.ForEach(p =>
            {
                if (minX > p.X)
                {
                    minX = p.X;
                }
                if (minY > p.Y)
                {
                    minY = p.Y;
                }
                if (maxX < p.X)
                {
                    maxX = p.X;
                }
                if (maxY < p.Y)
                {
                    maxY = p.Y;
                }
            });
            curve.pointHead = new Point(minX, minY);
            curve.pointTail = new Point(maxX, maxY);
        }

        /// <param name="polygon"></param>
        public static void setPointHeadTail(MPolygon polygon)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;
            polygon.points.ForEach(p =>
            {
                if (minX > p.X)
                {
                    minX = p.X;
                }
                if (minY > p.Y)
                {
                    minY = p.Y;
                }
                if (maxX < p.X)
                {
                    maxX = p.X;
                }
                if (maxY < p.Y)
                {
                    maxY = p.Y;
                }
            });
            polygon.pointHead = new Point(minX, minY);
            polygon.pointTail = new Point(maxX, maxY);
        }

        /// <param name="pen"></param>
        public static void setPointHeadTail(MPen pen)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;
            pen.points.ForEach(p =>
            {
                if (minX > p.X)
                {
                    minX = p.X;
                }
                if (minY > p.Y)
                {
                    minY = p.Y;
                }
                if (maxX < p.X)
                {
                    maxX = p.X;
                }
                if (maxY < p.Y)
                {
                    maxY = p.Y;
                }
            });
            pen.pointHead = new Point(minX, minY);
            pen.pointTail = new Point(maxX, maxY);
        }

        /// <param name="shape">Hình cần nhận điểm điều khiển</param>

        public static List<Point> getControlPoints(Shape shape)
        {
            List<Point> points = new List<Point>();
            int xCenter = (shape.pointHead.X + shape.pointTail.X) / 2;
            int yCenter = (shape.pointHead.Y + shape.pointTail.Y) / 2;
            points.Add(new Point(shape.pointHead.X, shape.pointHead.Y));
            points.Add(new Point(xCenter, shape.pointHead.Y));
            points.Add(new Point(shape.pointTail.X, shape.pointHead.Y));
            points.Add(new Point(shape.pointHead.X, yCenter));
            points.Add(new Point(shape.pointTail.X, yCenter));
            points.Add(new Point(shape.pointHead.X, shape.pointTail.Y));
            points.Add(new Point(xCenter, shape.pointTail.Y));
            points.Add(new Point(shape.pointTail.X, shape.pointTail.Y));
            return points;
        }
    }
}
