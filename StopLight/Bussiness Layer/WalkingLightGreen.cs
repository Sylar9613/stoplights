using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace StopLight.Bussiness_Layer
{
    public class WalkingLightGreen:StopLight
    {
        
        public WalkingLightGreen()
        {
            _delay = 20;
            _color = Color.Green;
            _image = new Bitmap("C:/Users/Arián/Documents/Visual Studio 2013/Projects/StopLights/StopLights/Resources/CanWalk.gif");
        }
        public override StopLight Next()
        {
            _delay--;
            if (_delay == 0)
                return new WalkingLightRed();
            return this;
        }
    }
}
