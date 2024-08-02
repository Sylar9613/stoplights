using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StopLight
{
    public class VialLightGreen:StopLight
    {
        public VialLightGreen()
        {
            _color = Color.Green;
            _delay = 40;
            _image = new Bitmap("C:/Users/Arián/Documents/Visual Studio 2013/Projects/StopLights/StopLights/Resources/green.gif");
        }
        public override StopLight Next()
        {
            _delay--;
            if (_delay == 0)
                return new VialLightYellow(this);
            return this;
        }
    }
}
