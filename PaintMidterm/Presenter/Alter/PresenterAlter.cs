using PaintMidterm.Model;
using PaintMidterm.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.Presenter.Alter
{
    interface PresenterAlter
    {
        void onClickDrawGroup();


        void onClickDrawUnGroup();


        void onClickDeleteShape();


        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickClearAll(PictureBox picturebox);

 
        /// <param name="picturebox"><Picturebox cần lưu/param>
        void onClickSaveImage(PictureBox picturebox);


        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickOpenImage(PictureBox picturebox);


        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickNewImage(PictureBox picturebox);

        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickShutdown(PictureBox picturebox);


        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onUseKeyStrokes(PictureBox picturebox, Keys key);

    }
}
