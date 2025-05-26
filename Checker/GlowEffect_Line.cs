using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Timer = System.Windows.Forms.Timer;

namespace Checker
{
    public class GlowEffect_Line
    {
        private Timer timer;
        private Panel targetPanel;
        private int alpha = 0;
        private bool increasing = true;

        public GlowEffect_Line(Panel panel, int interval = 30)
        {
            targetPanel = panel;
            timer = new Timer();
            timer.Interval = interval; // частота обновления
            timer.Tick += Timer_Tick;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
            targetPanel.BackColor = Color.Transparent; // или верни оригинальный цвет
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Пульсация от 0 до 255 и обратно
            if (increasing)
            {
                alpha += 10;
                if (alpha >= 255)
                {
                    alpha = 255;
                    increasing = false;
                }
            }
            else
            {
                alpha -= 10;
                if (alpha <= 50)
                {
                    alpha = 50;
                    increasing = true;
                }
            }

            targetPanel.BackColor = Color.FromArgb(alpha, Color.Red);
        }
    }
}
