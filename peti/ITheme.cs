using System;
using System.Collections.Generic;
using System.Text;

namespace peti
{
    interface ITheme
    {
        void SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);

    }
}
