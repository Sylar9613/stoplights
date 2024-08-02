using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StopLight
{
    public abstract class StopLight
    {
        protected Color _color;
        protected int _delay;
        protected Image _image;
        
        public abstract StopLight Next();
        
        public Image Image
        {
            get
            {
                return _image;
            }
        }
        public Color Color
        {
            get
            {
                return _color;
            }
        }
        public int Delay
        {
            get
            {
                return _delay;
            }
        }
    }
}
