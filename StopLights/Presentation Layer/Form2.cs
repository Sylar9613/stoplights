using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StopLight.Bussiness_Layer;
using StopLight;

namespace StopLights.Presentation_Layer
{
    public partial class Form2 : Form,IObserver
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void Update()
        {
            Singleton single = Singleton.GetInstance;
            label1.Text = single.GetSemaphoreVial.CurrentState.Delay.ToString();
            label1.ForeColor = single.GetSemaphoreVial.CurrentState.Color;
            label2.Text = single.GetSemaphoreWalking.CurrentState.Delay.ToString();
            label2.ForeColor = single.GetSemaphoreWalking.CurrentState.Color;
        }
    }
}
