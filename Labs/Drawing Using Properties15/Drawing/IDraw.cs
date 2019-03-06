using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        //void SetLocation(int xCoord, int yCoord);
        int X { get; set; }  //use properites to set location instead of using a method 
        int Y { get; set; }
        void Draw(Canvas canvas);
    }
}
