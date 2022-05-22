using PaintMidterm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.View
{
    interface ViewPaint
    {
        void refreshDrawing();

        /// <param name="cursor">Hình dạng</param>
        void setCursor(Cursor cursor);

        /// <param name="color">Màu sắc</param>
        void setColor(Color color);

        /// <param name="btn">Button cần thay đổi nền</param>
        /// <param name="color">Màu sắc</param>
        void setColor(Button btn, Color color);


        /// <param name="shape">Hình cần vẽ</param>
        /// <param name="g">graphics</param>
        void setDrawing(Shape shape, Graphics g);


        /// <param name="shape">Hình cần vẽ điểm điều khiển</param>
        /// <param name="brush"></param>
        /// <param name="g"></param>
        void setDrawingLineSelected(Shape shape, Brush brush, Graphics g);

        /// <param name="points"></param>
        /// <param name="brush"></param>
        /// <param name="g"></param>
        void setDrawingCurveSelected(List<Point> points, Brush brush, Graphics g);

        /// <param name="p"></param>
        /// <param name="rectangle"></param>
        /// <param name="g"></param>
        void setDrawingRegionRectangle(Pen p, Rectangle rectangle, Graphics g);

        /// <param name="shape">Hình cần di chuyển</param>
        /// <param name="distance">Khoảng cách</param>
        void movingShape(Shape shape, Point distance);

        /// <param name="shape">Hình cần resize</param>
        /// <param name="pointCurrent">Vị trí cần thay đổi</param>
        /// <param name="previous">Vị trí trước đó</param>
        /// <param name="indexPoint">Điểm điều khiển</param>
        void movingControlPoint(Shape shape, Point pointCurrent, Point previous, int indexPoint);
    }
}
