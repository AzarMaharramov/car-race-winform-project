using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        bool isstart = false;
        bool isover = false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!isstart)
            {
                isstart = true;
                Thread thread1 = new Thread(Move1);
                Thread.Sleep(500);
                thread1.Start();
                thread1.Priority = ThreadPriority.AboveNormal;
                Thread thread2 = new Thread(Move2);
                thread2.Start();
                thread2.Priority = ThreadPriority.Highest;
            }
            else
            {
                MessageBox.Show("Hazırda yarış gedir!");
            }
        }

        private void Move1()
        {
            long range = rand.Next(0, 10);
            long i = 0;
            int a = 0;
            while (a <= 880)
            {
                a = Convert.ToInt32(i / 1000000);
                
                Point point = new Point(a, Red_car.Location.Y);
                Red_car.Location = point;

                i += range;
            }
            if (!isover)
            {
                isover = true;
                MessageBox.Show("Qırmızı maşın qalib oldu!");
                Close();
            }    
        }

        private void Move2()
        {
            long range = rand.Next(0, 10);
            long i = 0;
            int b = 0;
            while (b <= 880)
            {
                b = Convert.ToInt32(i / 1000000);

                Point point = new Point(b, Blue_car.Location.Y);
                Blue_car.Location = point;

                i += range;
            }
            if (!isover)
            {
                isover = true;
                MessageBox.Show("Göy maşın qalib oldu!");
                Close();
            }
        }
    }
}
