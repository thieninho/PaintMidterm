using PaintMidterm.Model;
using PaintMidterm.Presenter.Alter;
using PaintMidterm.Presenter.Draws;
using PaintMidterm.Presenter.Updates;
using PaintMidterm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm
{
    public partial class PaintApp : Form, ViewPaint
    {
        private PresenterDraw presenterDraw;

        private PresenterAlter presenterAlter;

        private PresenterUpdate presenterUpdate;

        private Graphics gr;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public PaintApp()
        {
            InitializeComponent();
            initComponents();
            gr = ptbDrawing.CreateGraphics();
            btnColor.BackColor = Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        private void initComponents()
        {
            presenterDraw = new PresenterDrawImp(this);
            presenterAlter = new PresenterAlterImp(this);
            presenterUpdate = new PresenterUpdateImp(this);
            presenterUpdate.onClickSelectColor(btnColor.BackColor, gr);
            presenterUpdate.onClickSelectSize(btnLineSize.Value + 1);
        }

        public void refreshDrawing()
        {
            ptbDrawing.Invalidate();
        }


        public void setDrawing(Shape shape, Graphics g)
        {
            shape.drawShape(g);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawLine();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            presenterUpdate.onClickSelectMode();
        }
        public void setCursor(Cursor cursor)
        {
            ptbDrawing.Cursor = cursor;
        }
        public void setDrawingLineSelected(Shape shape, Brush brush, Graphics g)
        {
            g.FillRectangle(brush, new System.Drawing.Rectangle(shape.pointHead.X - 4, shape.pointHead.Y - 4, 8, 8));
            g.FillRectangle(brush, new System.Drawing.Rectangle(shape.pointTail.X - 4, shape.pointTail.Y - 4, 8, 8));
        }
        public void movingShape(Shape shape, Point distance)
        {
            shape.moveShape(distance);
            refreshDrawing();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawRectangle();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawEllipse();
        }
        public void setDrawingRegionRectangle(Pen p, Rectangle rectangle, Graphics g)
        {
            g.DrawRectangle(p, rectangle);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickDrawGroup();
        }

        private void btnUnGroup_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickDrawUnGroup();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickDeleteShape();
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawBezier();
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawPolygon();
        }
        public void setDrawingCurveSelected(List<Point> points, Brush brush, Graphics g)
        {
            for (int i = 0; i < points.Count; ++i)
            {
                g.FillRectangle(brush, new System.Drawing.Rectangle(points[i].X - 4, points[i].Y - 4, 8, 8));
            }

        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawPen();

        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawEraser();
        }

        private void btnEditColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                presenterUpdate.onClickSelectColor(colorDialog.Color, gr);
            }
        }

        public void setColor(Color color)
        {
            btnColor.BackColor = color;
        }

        private void btnLineSize_Scroll(object sender, EventArgs e)
        {
            presenterUpdate.onClickSelectSize(btnLineSize.Value + 1);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }

        public void movingControlPoint(Shape shape, Point pointCurrent, Point previous, int indexPoint)
        {
            shape.moveControlPoint(pointCurrent, previous, indexPoint);
            refreshDrawing();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickClearAll(ptbDrawing);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            presenterUpdate.onClickSelectFill(btn, gr);
        }
        public void setColor(Button btn, Color color)
        {
            btn.BackColor = color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickSaveImage(ptbDrawing);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickOpenImage(ptbDrawing);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickNewImage(ptbDrawing);
        }

        private void PaintApp_KeyDown(object sender, KeyEventArgs e)
        {
            presenterAlter.onUseKeyStrokes(ptbDrawing, e.KeyCode);
        }

        private void ptbDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            presenterDraw.onClickStopDrawing(e.Button);
        }

        private void ptbDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            presenterDraw.onClickMouseDown(e.Location);
        }

        private void ptbDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            presenterDraw.onClickMouseMove(e.Location);
        }

        private void ptbDrawing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            presenterDraw.getDrawing(e.Graphics);
        }

        private void ptbDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            presenterDraw.onClickMouseUp();
        }
        static Point set_point(PictureBox pictureBox, Point point)
        {
            float x = 1f * pictureBox.Image.Width / pictureBox.Width;
            float y = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * x), (int)(point.Y * y));
        }


        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            btnColor.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            presenterUpdate.onClickSelectColor(btnColor.BackColor, gr);
        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
