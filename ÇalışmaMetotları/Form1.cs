using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇalışmaMetotları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pomodoro pmdr = new Pomodoro();
        ikinci ikinci = new ikinci();
        doksan ucuncu = new doksan();
        kendinolustur kendin = new kendinolustur();


        private void button1_Click(object sender, EventArgs e)
        {
            pmdr.Show();
            //this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ikinci.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ucuncu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kendin.Show();
        }
    }
}
