using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StopLight.Bussiness_Layer
{
    public class WalkingLightRed:StopLight
    {
        public WalkingLightRed()
        {
            _delay = 40;
            _color = Color.Red;
            _image = new Bitmap("C:/Users/Arián/Documents/Visual Studio 2013/Projects/StopLights/StopLights/Resources/CantWalk.gif");
        }
        public override StopLight Next()
        {
            _delay--;
            if (_delay == 0)
                return new WalkingLightGreen();

            return this;
        }
    }
}
