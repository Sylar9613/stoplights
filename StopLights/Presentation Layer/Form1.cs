using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StopLight;
using StopLight.Bussiness_Layer;
using StopLights.Presentation_Layer;

namespace StopLights
{
    public partial class Form1 : Form,ISubject
    {
        List<IObserver> _observers = new List<IObserver>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MakeDo();
            Notify();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Master Semaphore";
        }
        private void MakeDo()
        {
            try
            {
                Singleton single = Singleton.GetInstance;
                label1.Text = single.GetSemaphoreVial.CurrentState.Delay.ToString();
                label1.ForeColor = single.GetSemaphoreVial.CurrentState.Color;
                single.GetSemaphoreVial.Next();
                label2.Text = single.GetSemaphoreWalking.CurrentState.Delay.ToString();
                label2.ForeColor = single.GetSemaphoreWalking.CurrentState.Color;
                single.GetSemaphoreWalking.Next();
                button2.BackgroundImage = single.GetSemaphoreWalking.CurrentState.Image;
                button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                button3.BackgroundImage = single.GetSemaphoreVial.CurrentState.Image;
                button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        public void Attach(IObserver observers)
        {
            _observers.Add(observers);
        }

        public void Dettach(IObserver observers)
        {
            _observers.Add(observers);
        }

        public void Notify()
        {
            foreach (IObserver item in _observers)
                item.Update();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Attach(form2);

            form2.Show();
        }
    }
}
