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
    public partial class Pomodoro : Form
    {
        public Pomodoro()
        {
            InitializeComponent();
        }

        //Form1 anasayfa = new Form1();
        int saniye = 0, dakika = 0, tur = 0, sure = 0;
        SoundPlayer player = new SoundPlayer();
 

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            saniye = 0;
            label6.Text = Convert.ToString(saniye);
            dakika = 0;
            label5.Text = Convert.ToString(dakika);
            msaniye = 0;
            mdakika = 0;
            label17.Text = Convert.ToString(msaniye);
            label12.Text = Convert.ToString(mdakika);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        int msaniye = 0, mdakika = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.Stop();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            msaniye++;
            label17.Text = Convert.ToString(msaniye);
            label12.Text = Convert.ToString(mdakika);

            if (msaniye == 59)
            {
                mdakika++;
                msaniye = 0;
            }

            if (mdakika==5)
            {
                mdakika = 0;
                msaniye = 0;
                timer2.Enabled = false;
                player.SoundLocation = @"C:\Users\emrek\source\repos\ÇalışmaMetotları\Alarm\beep-08b.wav";
                player.PlayLooping();
            }
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            
            label6.Text = Convert.ToString(saniye);
            label5.Text = Convert.ToString(dakika);
            label8.Text = Convert.ToString(tur);
            label10.Text = Convert.ToString(sure);

            if (saniye==59)
            {
                saniye = 0;
                dakika++;
            }

            if (dakika==25)
            {
                saniye = 0;
                dakika = 0;
                tur++;
                timer1.Enabled = false;

                //string alarmyolu = Application.StartupPath.ToString() + "\\beep-08b.wav";

                player.SoundLocation = @"C:\Users\emrek\source\repos\ÇalışmaMetotları\Alarm\beep-08b.wav";
                player.PlayLooping();


            }

            sure = dakika + 25 * tur;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
