﻿using PaintMidterm.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintMidterm.Model
{
    public class DataManager
    {
        public static DataManager instance;

        public List<Shape> shapeList { get; set; }

        public Shape shapeToMove { get; set; }

        public System.Drawing.Rectangle rectangleRegion;

        public bool isMouseDown { get; set; }

        public bool isMovingShape { get; set; }

        public bool isMovingMouse { get; set; }

        public bool isDrawingCurve { get; set; }

        public bool isDrawingPolygon { get; set; }

        public bool isDrawingPen { get; set; }

        public bool isDrawingEraser { get; set; }

        public bool isFill { get; set; }

        public bool isSave { get; set; }

        public bool isNotNone { get; set; }

        public bool isSelectAll { get; set; }

        public int pointToResize { get; set; }

        public CurrentShapeStatus currentShape { get; set; }

        public Point cursorCurrent { get; set; }

        public Color colorCurrent { get; set; }
        public int lineSize { get; set; }

        private DataManager()
        {
            shapeList = new List<Shape>();
            pointToResize = -1;
        }

        public static DataManager getInstance()
        {
            if (instance == null) instance = new DataManager();
            return instance;
        }


        /// <param name="p">cập nhật điểm cuối = p</param>
        public void updatePointTail(Point p)
        {
            shapeList[shapeList.Count - 1].pointTail = p;
        }


        /// <param name="line">đối tượng line</param>
        public void addEntity(Shape shape)
        {
            shapeList.Add(shape);
        }

        public void offAllShapeSelected()
        {
            shapeList.ForEach(shape => shape.isSelected = false);
        }


        /// <param name="x">điểm x</param>
        /// <param name="y">điểm y</param>

        public Point distanceXY(Point x, Point y)
        {
            return new Point(y.X - x.X, y.Y - x.Y);
        }


        /// <param name="p"></param>
        public void updateRectangleRegion(Point p)
        {
            rectangleRegion.Width = p.X - rectangleRegion.X;
            rectangleRegion.Height = p.Y - rectangleRegion.Y;
        }
    }
}
