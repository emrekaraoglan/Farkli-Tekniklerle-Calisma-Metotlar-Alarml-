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
    public partial class kendinolustur : Form
    {
        public kendinolustur()
        {
            InitializeComponent();
        }

        SoundPlayer player = new SoundPlayer();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void kendinolustur_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            for (int i=1;i<=60;i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int saniye = 0, dakika = 0, tur = 0, sure = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            saniye = 0;
            dakika = 0;
            mdakika = 0;
            msaniye = 0;
            label6.Text = Convert.ToString(saniye);
            label5.Text = Convert.ToString(dakika);
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

        private void button7_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            msaniye++;
            label17.Text = Convert.ToString(msaniye);
            label12.Text = Convert.ToString(mdakika);

            if(msaniye==59)
            {
                msaniye = 0;
                mdakika++;
            }

            if(mdakika==Convert.ToInt32(comboBox2.Text))
            {
                msaniye = 0;
                mdakika = 0;
                timer2.Enabled = false;
                player.SoundLocation= @"C:\Users\emrek\source\repos\ÇalışmaMetotları\Alarm\beep-08b.wav";
                player.PlayLooping();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            player.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
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
                dakika++;
                saniye = 0;
            }

            if(dakika==Convert.ToInt32(comboBox1.Text))
            {
                dakika = 0;
                saniye = 0;
                tur++;
                timer1.Enabled = false;
                player.SoundLocation= @"C:\Users\emrek\source\repos\ÇalışmaMetotları\Alarm\beep-08b.wav";
                player.PlayLooping();
            }

            sure = tur * Convert.ToInt32(comboBox1.Text) + dakika;
        }
    }
}
