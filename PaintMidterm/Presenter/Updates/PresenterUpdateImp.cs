using PaintMidterm.Model;
using PaintMidterm.Utils;
using PaintMidterm.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.Presenter.Updates
{
    internal class PresenterUpdateImp : PresenterUpdate
    {
        ViewPaint viewPaint;

        DataManager dataManager;

        public PresenterUpdateImp(ViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.getInstance();
        }

        public void onClickSelectMode()
        {
            dataManager.offAllShapeSelected();
            viewPaint.refreshDrawing();
            dataManager.currentShape = CurrentShapeStatus.Void;
            viewPaint.setCursor(Cursors.Default);
        }

        public void onClickSelectColor(System.Drawing.Color color, Graphics g)
        {
            dataManager.colorCurrent = color;
            viewPaint.setColor(color);
            foreach (Shape item in dataManager.shapeList)
            {
                if (item.isSelected)
                {
                    item.color = color;
                    viewPaint.setDrawing(item, g);
                }
            }
        }

        public void onClickSelectSize(int size)
        {
            dataManager.lineSize = size;
        }

        public void onClickSelectTpye(int type)
        {
            
        }

        public void onClickSelectFill(Button btn, Graphics g)
        {
            dataManager.isFill = !dataManager.isFill;
            if (btn.BackColor.Equals(Color.LightCyan))
                viewPaint.setColor(btn, SystemColors.Control);
            else
                viewPaint.setColor(btn, Color.LightCyan);
        }
    }
}
