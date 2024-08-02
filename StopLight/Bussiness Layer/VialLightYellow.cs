using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StopLight
{
    public class VialLightYellow:StopLight
    {
        protected StopLight _state;
        public VialLightYellow(StopLight state)
        {
            _color = Color.Yellow;
            _delay = 20;
            _state = state;
            _image = new Bitmap("C:/Users/Arián/Documents/Visual Studio 2013/Projects/StopLights/StopLights/Resources/yellow.gif");
        }
        public override StopLight Next()
        {
            _delay--;
            if (_delay == 0)
            {
                if (_state is VialLightRed)
                    return new VialLightGreen();
                else
                    return new VialLightRed();
            }
            return this;
        }
    }
}
