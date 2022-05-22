using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.Presenter.Draws
{
    interface PresenterDraw
    {
        /// <param name="g"></param>
        void getDrawing(Graphics g);

        /// <param name="p"></param>
        void onClickMouseDown(Point p);


        /// <param name="p"></param>
        void onClickMouseMove(Point p);


        void onClickMouseUp();


        void onClickDrawLine();


        void onClickDrawRectangle();


        void onClickDrawEllipse();


        void onClickDrawBezier();


        void onClickDrawPolygon();


        void onClickDrawPen();


        void onClickDrawEraser();


        /// <param name="mouse"></param>
        void onClickStopDrawing(MouseButtons mouse);
    }
}
