using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.Presenter.Updates
{
    interface PresenterUpdate
    {


        void onClickSelectMode();


        /// <param name="color">Màu cần đổi</param>
        /// <param name="g">Áp dụng lên graphic g</param>
        void onClickSelectColor(Color color, Graphics g);

        /// <param name="size"></param>
        void onClickSelectSize(int size);

        /// <param name="btn"></param>
        /// <param name="g"></param>
        void onClickSelectFill(Button btn, Graphics g);


    }
}
