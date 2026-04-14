using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAndPower.Logic
{
    internal class TextSize
    {
        public static double TextSizeLogic(double speedsize)
        {
            var mainWindow = System.Windows.Application.Current.MainWindow;
            var Size = 0.0;
            if (mainWindow != null)
            {
                Size += mainWindow.ActualHeight / speedsize;
            }

            return Size;
        }
    }
}
