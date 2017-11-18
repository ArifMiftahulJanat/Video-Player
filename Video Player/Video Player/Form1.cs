using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files, paths;

        private void timer1_Tick(object sender, EventArgs e)
        {
            text_posisi.Text = Player.Ctlcontrols.currentPositionString;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void listmusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[FileName.SelectedIndex];
            timer1.Start();
        }

        private void tb_volume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = tb_volume.Value;
            timer1.Start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Player.URL = paths[FileName.SelectedIndex];
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    FileName.Items.Add(files[i]);
                }
            }
        }
    }
}
