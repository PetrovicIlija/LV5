using System;
using System.Collections.Generic;
using System.Text;

namespace peti
{
    class HappyTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public string GetHeader(int width)
        {
            return new string('*', width);
        }
        public string GetFooter(int width)
        {
            return new string('$', width);
        }
    }
}
