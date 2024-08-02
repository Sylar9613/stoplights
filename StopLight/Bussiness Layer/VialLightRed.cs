using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StopLight
{
    public class VialLightRed:StopLight
    {
        public VialLightRed()
        {
            _color = Color.Red;
            _delay = 100;
            _image = new Bitmap("C:/Users/Arián/Documents/Visual Studio 2013/Projects/StopLights/StopLights/Resources/red.gif");
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
