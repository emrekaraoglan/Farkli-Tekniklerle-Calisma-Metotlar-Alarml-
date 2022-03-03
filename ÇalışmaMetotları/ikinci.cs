using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ÇalışmaMetotları
{
    public partial class ikinci : Form
    {
        public ikinci()
        {
            InitializeComponent();
        }

        int saniye = 0, dakika = 0, tur = 0, sure = 0;
        int msaniye = 0, mdakika = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            dakika = 0;
            saniye = 0;
            label5.Text = Convert.ToString(dakika);
            label6.Text = Convert.ToString(saniye);
            msaniye = 0;
            mdakika = 0;
            label17.Text = Convert.ToString(msaniye);
            label12.Text = Convert.ToString(mdakika);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            msaniye++;
            label12.Text = Convert.ToString(mdakika);
            label17.Text = Convert.ToString(msaniye);

            if(msaniye==59)
            {
                msaniye = 0;
                mdakika++;
            }

            if(mdakika==15)
            {
                mdakika = 0;
                timer2.Enabled = false;
                player.SoundLocation= @"C:\Users\emrek\source\repos\ÇalışmaMetotları\Alarm\beep-08b.wav";
                player.PlayLooping();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;

        }

        SoundPlayer player = new SoundPlayer();

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label5.Text = Convert.ToString(dakika);
            label6.Text = Convert.ToString(saniye);
            label8.Text = Convert.ToString(tur);
            label10.Text = Convert.ToString(sure);

            if (saniye ==59)
            {
                dakika++;
                saniye = 0;
            }

            if (dakika == 45)
            {
                dakika = 0;
                saniye = 0;
                tur++;
                timer1.Enabled = false;
                player.SoundLocation = @"C:\Users\emrek\source\repos\ÇalışmaMetotları\Alarm\beep-08b.wav";
                player.PlayLooping();
            }

            sure = tur * 45 + dakika;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
