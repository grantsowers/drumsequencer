using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DrumMachine
{
    public partial class Sequencer : Form
    {
        private System.Media.SoundPlayer rockkick;
        private System.Media.SoundPlayer rocksnare;
        private System.Media.SoundPlayer rockhh;
        private System.Media.SoundPlayer rockride;
        private System.Media.SoundPlayer rockcrash;
        private System.Media.SoundPlayer hiphopkick;
        private System.Media.SoundPlayer hiphopsnare;
        private System.Media.SoundPlayer hiphophh;
        private System.Media.SoundPlayer hiphopride;
        private System.Media.SoundPlayer hiphopcrash;
        private System.Media.SoundPlayer edmkick;
        private System.Media.SoundPlayer edmsnare;
        private System.Media.SoundPlayer edmhh;
        private System.Media.SoundPlayer edmride;
        private System.Media.SoundPlayer edmcrash;

        public Sequencer()
        {
            InitializeComponent();
            rockkick = new System.Media.SoundPlayer(@"e:\DrumMachine\Jl_K2.wav");
            rocksnare = new System.Media.SoundPlayer(@"e:\DrumMachine\Chc_Sn.wav");
            rockhh = new System.Media.SoundPlayer(@"e:\DrumMachine\Clb_H.wav");
            rockride = new System.Media.SoundPlayer(@"e:\DrumMachine\Ride_01.wav");
            rockcrash = new System.Media.SoundPlayer(@"e:\DrumMachine\Str_Crsh2.wav");
            hiphopkick = new System.Media.SoundPlayer(@"e:\DrumMachine\KICK 9.wav");
            hiphopsnare = new System.Media.SoundPlayer(@"e:\DrumMachine\LEX Clap&Snare.wav");
            hiphophh = new System.Media.SoundPlayer(@"e:\DrumMachine\Perc 11.wav");
            hiphopride = new System.Media.SoundPlayer(@"e:\DrumMachine\VOX 1.wav");
            hiphopcrash = new System.Media.SoundPlayer(@"e:\DrumMachine\Synth 25.wav");
            edmkick = new System.Media.SoundPlayer(@"e:\DrumMachine\KICK 6.wav");
            edmsnare = new System.Media.SoundPlayer(@"e:\DrumMachine\SNARE 4.wav");
            edmhh = new System.Media.SoundPlayer(@"e:\DrumMachine\Perc 11.wav");
            edmride = new System.Media.SoundPlayer(@"e:\DrumMachine\SYNTH 28.wav");
            edmcrash = new System.Media.SoundPlayer(@"e:\DrumMachine\Synth 24.wav");
        }

        private static Random random = new Random();

        //Buttons
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startbuttonClick(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void stopbuttonClick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        //Progressbar and Playback
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            //Beat display
            if (progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
               beatdisplay.Text = "Beat = 1";
            if (progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                beatdisplay.Text = "Beat = 2";
            if (progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                beatdisplay.Text = "Beat = 3";
            if (progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                beatdisplay.Text = "Beat = 4";
            if (progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                beatdisplay.Text = "Beat = 5";
            if (progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                beatdisplay.Text = "Beat = 6";
            if (progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                beatdisplay.Text = "Beat = 7";
            if (progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                beatdisplay.Text = "Beat = 8";
            if (progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                beatdisplay.Text = "Beat = 9";
            if (progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                beatdisplay.Text = "Beat = 10";
            if (progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                beatdisplay.Text = "Beat = 11";
            if (progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                beatdisplay.Text = "Beat = 12";
            if (progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                beatdisplay.Text = "Beat = 13";
            if (progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                beatdisplay.Text = "Beat = 14";
            if (progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                beatdisplay.Text = "Beat = 15";
            if (progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                beatdisplay.Text = "Beat = 16";


            //Kits and playback
            if (radioButton1.Checked)
            {

                //Bass
                if (checkBox1.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    hiphopkick.Play();
                if (checkBox2.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    hiphopkick.Play();
                if (checkBox3.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    hiphopkick.Play();
                if (checkBox4.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    hiphopkick.Play();
                if (checkBox5.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    hiphopkick.Play();
                if (checkBox6.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    hiphopkick.Play();
                if (checkBox7.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    hiphopkick.Play();
                if (checkBox8.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    hiphopkick.Play();
                if (checkBox9.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    hiphopkick.Play();
                if (checkBox10.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    hiphopkick.Play();
                if (checkBox11.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    hiphopkick.Play();
                if (checkBox12.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    hiphopkick.Play();
                if (checkBox13.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    hiphopkick.Play();
                if (checkBox14.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    hiphopkick.Play();
                if (checkBox15.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    hiphopkick.Play();
                if (checkBox16.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    hiphopkick.Play();

                //Snare
                if (checkBox17.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox18.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox19.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox20.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox21.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox22.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox23.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox24.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox25.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox26.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox27.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox28.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox29.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox30.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox31.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    hiphopsnare.Play();
                if (checkBox32.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    hiphopsnare.Play();

                //Highhat
                if (checkBox33.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    hiphophh.Play();
                if (checkBox34.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    hiphophh.Play();
                if (checkBox35.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    hiphophh.Play();
                if (checkBox36.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    hiphophh.Play();
                if (checkBox37.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    hiphophh.Play();
                if (checkBox38.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    hiphophh.Play();
                if (checkBox39.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    hiphophh.Play();
                if (checkBox40.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    hiphophh.Play();
                if (checkBox41.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    hiphophh.Play();
                if (checkBox42.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    hiphophh.Play();
                if (checkBox43.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    hiphophh.Play();
                if (checkBox44.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    hiphophh.Play();
                if (checkBox45.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    hiphophh.Play();
                if (checkBox46.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    hiphophh.Play();
                if (checkBox47.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    hiphophh.Play();
                if (checkBox48.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    hiphophh.Play();

                //Ride
                if (checkBox49.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    hiphopride.Play();
                if (checkBox50.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    hiphopride.Play();
                if (checkBox51.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    hiphopride.Play();
                if (checkBox52.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    hiphopride.Play();
                if (checkBox53.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    hiphopride.Play();
                if (checkBox54.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    hiphopride.Play();
                if (checkBox55.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    hiphopride.Play();
                if (checkBox56.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    hiphopride.Play();
                if (checkBox57.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    hiphopride.Play();
                if (checkBox58.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    hiphopride.Play();
                if (checkBox59.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    hiphopride.Play();
                if (checkBox60.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    hiphopride.Play();
                if (checkBox61.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    hiphopride.Play();
                if (checkBox62.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    hiphopride.Play();
                if (checkBox63.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    hiphopride.Play();
                if (checkBox64.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    hiphopride.Play();

                //Crash
                if (checkBox65.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox66.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox67.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox68.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox69.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox70.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox71.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox72.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox73.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox74.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox75.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox76.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox77.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox78.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox79.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    hiphopcrash.Play();
                if (checkBox80.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    hiphopcrash.Play();
            }

            else if (radioButton2.Checked)
            {
                //Bass
                if (checkBox1.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    rockkick.Play();
                if (checkBox2.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    rockkick.Play();
                if (checkBox3.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    rockkick.Play();
                if (checkBox4.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    rockkick.Play();
                if (checkBox5.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    rockkick.Play();
                if (checkBox6.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    rockkick.Play();
                if (checkBox7.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    rockkick.Play();
                if (checkBox8.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    rockkick.Play();
                if (checkBox9.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    rockkick.Play();
                if (checkBox10.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    rockkick.Play();
                if (checkBox11.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    rockkick.Play();
                if (checkBox12.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    rockkick.Play();
                if (checkBox13.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    rockkick.Play();
                if (checkBox14.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    rockkick.Play();
                if (checkBox15.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    rockkick.Play();
                if (checkBox16.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    rockkick.Play();

                //Snare
                if (checkBox17.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    rocksnare.Play();
                if (checkBox18.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    rocksnare.Play();
                if (checkBox19.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    rocksnare.Play();
                if (checkBox20.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    rocksnare.Play();
                if (checkBox21.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    rocksnare.Play();
                if (checkBox22.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    rocksnare.Play();
                if (checkBox23.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    rocksnare.Play();
                if (checkBox24.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    rocksnare.Play();
                if (checkBox25.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    rocksnare.Play();
                if (checkBox26.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    rocksnare.Play();
                if (checkBox27.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    rocksnare.Play();
                if (checkBox28.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    rocksnare.Play();
                if (checkBox29.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    rocksnare.Play();
                if (checkBox30.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    rocksnare.Play();
                if (checkBox31.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    rocksnare.Play();
                if (checkBox32.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    rocksnare.Play();

                //Highhat
                if (checkBox33.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    rockhh.Play();
                if (checkBox34.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    rockhh.Play();
                if (checkBox35.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    rockhh.Play();
                if (checkBox36.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    rockhh.Play();
                if (checkBox37.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    rockhh.Play();
                if (checkBox38.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    rockhh.Play();
                if (checkBox39.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    rockhh.Play();
                if (checkBox40.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    rockhh.Play();
                if (checkBox41.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    rockhh.Play();
                if (checkBox42.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    rockhh.Play();
                if (checkBox43.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    rockhh.Play();
                if (checkBox44.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    rockhh.Play();
                if (checkBox45.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    rockhh.Play();
                if (checkBox46.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    rockhh.Play();
                if (checkBox47.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    rockhh.Play();
                if (checkBox48.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    rockhh.Play();

                //Ride
                if (checkBox49.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    rockride.Play();
                if (checkBox50.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    rockride.Play();
                if (checkBox51.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    rockride.Play();
                if (checkBox52.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    rockride.Play();
                if (checkBox53.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    rockride.Play();
                if (checkBox54.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    rockride.Play();
                if (checkBox55.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    rockride.Play();
                if (checkBox56.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    rockride.Play();
                if (checkBox57.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    rockride.Play();
                if (checkBox58.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    rockride.Play();
                if (checkBox59.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    rockride.Play();
                if (checkBox60.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    rockride.Play();
                if (checkBox61.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    rockride.Play();
                if (checkBox62.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    rockride.Play();
                if (checkBox63.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    rockride.Play();
                if (checkBox64.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    rockride.Play();

                //Crash
                if (checkBox65.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    rockcrash.Play();
                if (checkBox66.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    rockcrash.Play();
                if (checkBox67.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    rockcrash.Play();
                if (checkBox68.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    rockcrash.Play();
                if (checkBox69.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    rockcrash.Play();
                if (checkBox70.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    rockcrash.Play();
                if (checkBox71.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    rockcrash.Play();
                if (checkBox72.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    rockcrash.Play();
                if (checkBox73.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    rockcrash.Play();
                if (checkBox74.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    rockcrash.Play();
                if (checkBox75.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    rockcrash.Play();
                if (checkBox76.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    rockcrash.Play();
                if (checkBox77.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    rockcrash.Play();
                if (checkBox78.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    rockcrash.Play();
                if (checkBox79.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    rockcrash.Play();
                if (checkBox80.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    rockcrash.Play();
            }

            else if (radioButton3.Checked)
            {

                //Bass
                if (checkBox1.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                   edmkick.Play();
                if (checkBox2.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    edmkick.Play();
                if (checkBox3.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    edmkick.Play();
                if (checkBox4.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    edmkick.Play();
                if (checkBox5.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    edmkick.Play();
                if (checkBox6.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    edmkick.Play();
                if (checkBox7.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    edmkick.Play();
                if (checkBox8.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    edmkick.Play();
                if (checkBox9.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    edmkick.Play();
                if (checkBox10.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    edmkick.Play();
                if (checkBox11.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    edmkick.Play();
                if (checkBox12.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    edmkick.Play();
                if (checkBox13.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    edmkick.Play();
                if (checkBox14.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    edmkick.Play();
                if (checkBox15.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    edmkick.Play();
                if (checkBox16.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    edmkick.Play();

                //Snare
                if (checkBox17.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    edmsnare.Play();
                if (checkBox18.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    edmsnare.Play();
                if (checkBox19.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    edmsnare.Play();
                if (checkBox20.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    edmsnare.Play();
                if (checkBox21.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    edmsnare.Play();
                if (checkBox22.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    edmsnare.Play();
                if (checkBox23.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    edmsnare.Play();
                if (checkBox24.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    edmsnare.Play();
                if (checkBox25.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    edmsnare.Play();
                if (checkBox26.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    edmsnare.Play();
                if (checkBox27.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    edmsnare.Play();
                if (checkBox28.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    edmsnare.Play();
                if (checkBox29.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    edmsnare.Play();
                if (checkBox30.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    edmsnare.Play();
                if (checkBox31.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    edmsnare.Play();
                if (checkBox32.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    edmsnare.Play();

                //Highhat
                if (checkBox33.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    edmhh.Play();
                if (checkBox34.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    edmhh.Play();
                if (checkBox35.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    edmhh.Play();
                if (checkBox36.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    edmhh.Play();
                if (checkBox37.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    edmhh.Play();
                if (checkBox38.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    edmhh.Play();
                if (checkBox39.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    edmhh.Play();
                if (checkBox40.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    edmhh.Play();
                if (checkBox41.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    edmhh.Play();
                if (checkBox42.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    edmhh.Play();
                if (checkBox43.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    edmhh.Play();
                if (checkBox44.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    edmhh.Play();
                if (checkBox45.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    edmhh.Play();
                if (checkBox46.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    edmhh.Play();
                if (checkBox47.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    edmhh.Play();
                if (checkBox48.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    edmhh.Play();

                //Ride
                if (checkBox49.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    edmride.Play();
                if (checkBox50.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    edmride.Play();
                if (checkBox51.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    edmride.Play();
                if (checkBox52.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    edmride.Play();
                if (checkBox53.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    edmride.Play();
                if (checkBox54.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    edmride.Play();
                if (checkBox55.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    edmride.Play();
                if (checkBox56.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    edmride.Play();
                if (checkBox57.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    edmride.Play();
                if (checkBox58.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    edmride.Play();
                if (checkBox59.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    edmride.Play();
                if (checkBox60.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    edmride.Play();
                if (checkBox61.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    edmride.Play();
                if (checkBox62.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    edmride.Play();
                if (checkBox63.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    edmride.Play();
                if (checkBox64.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    edmride.Play();

                //Crash
                if (checkBox65.Checked && progressBar1.Value == (progressBar1.Maximum * (1.0 / 16)))
                    edmcrash.Play();
                if (checkBox66.Checked && progressBar1.Value == (progressBar1.Maximum * (2.0 / 16)))
                    edmcrash.Play();
                if (checkBox67.Checked && progressBar1.Value == (progressBar1.Maximum * (3.0 / 16)))
                    edmcrash.Play();
                if (checkBox68.Checked && progressBar1.Value == (progressBar1.Maximum * (4.0 / 16)))
                    edmcrash.Play();
                if (checkBox69.Checked && progressBar1.Value == (progressBar1.Maximum * (5.0 / 16)))
                    edmcrash.Play();
                if (checkBox70.Checked && progressBar1.Value == (progressBar1.Maximum * (6.0 / 16)))
                    edmcrash.Play();
                if (checkBox71.Checked && progressBar1.Value == (progressBar1.Maximum * (7.0 / 16)))
                    edmcrash.Play();
                if (checkBox72.Checked && progressBar1.Value == (progressBar1.Maximum * (8.0 / 16)))
                    edmcrash.Play();
                if (checkBox73.Checked && progressBar1.Value == (progressBar1.Maximum * (9.0 / 16)))
                    edmcrash.Play();
                if (checkBox74.Checked && progressBar1.Value == (progressBar1.Maximum * (10.0 / 16)))
                    edmcrash.Play();
                if (checkBox75.Checked && progressBar1.Value == (progressBar1.Maximum * (11.0 / 16)))
                    edmcrash.Play();
                if (checkBox76.Checked && progressBar1.Value == (progressBar1.Maximum * (12.0 / 16)))
                    edmcrash.Play();
                if (checkBox77.Checked && progressBar1.Value == (progressBar1.Maximum * (13.0 / 16)))
                    edmcrash.Play();
                if (checkBox78.Checked && progressBar1.Value == (progressBar1.Maximum * (14.0 / 16)))
                    edmcrash.Play();
                if (checkBox79.Checked && progressBar1.Value == (progressBar1.Maximum * (15.0 / 16)))
                    edmcrash.Play();
                if (checkBox80.Checked && progressBar1.Value == (progressBar1.Maximum * (16.0 / 16)))
                    edmcrash.Play();
            }

            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void clearbuttonClick(object sender, EventArgs e)
        {
            foreach (CheckBox control in this.Controls.OfType<CheckBox>())
            {
                control.Checked = false;
            }
        }

        private void randombuttonClick(object sender, EventArgs e)
        {
            List<CheckBox> Checkboxlist = new List<CheckBox>();
            foreach (CheckBox control in this.Controls.OfType<CheckBox>())
            {
                Checkboxlist.Add(control);
                control.Checked = false;
            }

            for (int i = 0; i <= 50; i++)
            {
                var r = random.Next(0, Checkboxlist.Count);
                var checkbox = Checkboxlist[r];
                Checkboxlist[r].Checked = true;
            }
        }

        //Tempo Controls
        //Syncs trackbar and numericupdown
        void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tempotrackbar.Value = Convert.ToInt32(numericUpDown1.Value);
            if (tempotrackbar.Value > 120)
            {
                timer1.Interval = (100 - (tempotrackbar.Value - 90));
            }
            else if (tempotrackbar.Value <= 120)
            {
                timer1.Interval = (100 + (150 - tempotrackbar.Value));
            }
        }

        private void tempotrackbar_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = tempotrackbar.Value;
            if (tempotrackbar.Value > 120)
            {
                timer1.Interval = (100 - (tempotrackbar.Value - 90));
            }
            else if (tempotrackbar.Value <= 120)
            {
                timer1.Interval = (100 + (150 - tempotrackbar.Value));
            }
        }

        //Labels
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    label1.Text = "Kick";
                    label2.Text = "Snare";
                    label3.Text = "HighHat";
                    label4.Text = "Vocals";
                    label5.Text = "Hit";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    label1.Text = "Kick";
                    label2.Text = "Snare";
                    label3.Text = "HighHat";
                    label4.Text = "Ride";
                    label5.Text = "Crash";
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    label1.Text = "Sub";
                    label2.Text = "Snare";
                    label3.Text = "HighHat";
                    label4.Text = "Vocals";
                    label5.Text = "Hit";
                }
            }
        }

        //Monophony insurance
        //Row 1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox17.Checked = false;
                checkBox33.Checked = false;
                checkBox49.Checked = false;
                checkBox65.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox18.Checked = false;
                checkBox34.Checked = false;
                checkBox50.Checked = false;
                checkBox66.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox19.Checked = false;
                checkBox35.Checked = false;
                checkBox51.Checked = false;
                checkBox67.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox20.Checked = false;
                checkBox36.Checked = false;
                checkBox52.Checked = false;
                checkBox68.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox21.Checked = false;
                checkBox37.Checked = false;
                checkBox53.Checked = false;
                checkBox69.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox22.Checked = false;
                checkBox38.Checked = false;
                checkBox54.Checked = false;
                checkBox70.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox23.Checked = false;
                checkBox39.Checked = false;
                checkBox55.Checked = false;
                checkBox71.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox24.Checked = false;
                checkBox40.Checked = false;
                checkBox56.Checked = false;
                checkBox72.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox25.Checked = false;
                checkBox41.Checked = false;
                checkBox57.Checked = false;
                checkBox73.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox26.Checked = false;
                checkBox42.Checked = false;
                checkBox58.Checked = false;
                checkBox74.Checked = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox27.Checked = false;
                checkBox43.Checked = false;
                checkBox59.Checked = false;
                checkBox75.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox28.Checked = false;
                checkBox44.Checked = false;
                checkBox60.Checked = false;
                checkBox76.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox29.Checked = false;
                checkBox45.Checked = false;
                checkBox61.Checked = false;
                checkBox77.Checked = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox30.Checked = false;
                checkBox46.Checked = false;
                checkBox62.Checked = false;
                checkBox78.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox31.Checked = false;
                checkBox47.Checked = false;
                checkBox63.Checked = false;
                checkBox79.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox32.Checked = false;
                checkBox48.Checked = false;
                checkBox64.Checked = false;
                checkBox80.Checked = false;
            }
        }

        //Row 2
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                checkBox1.Checked = false;
                checkBox33.Checked = false;
                checkBox49.Checked = false;
                checkBox65.Checked = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                checkBox2.Checked = false;
                checkBox34.Checked = false;
                checkBox50.Checked = false;
                checkBox66.Checked = false;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                checkBox3.Checked = false;
                checkBox35.Checked = false;
                checkBox51.Checked = false;
                checkBox67.Checked = false;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                checkBox4.Checked = false;
                checkBox36.Checked = false;
                checkBox52.Checked = false;
                checkBox68.Checked = false;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                checkBox5.Checked = false;
                checkBox37.Checked = false;
                checkBox53.Checked = false;
                checkBox69.Checked = false;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox6.Checked = false;
                checkBox38.Checked = false;
                checkBox54.Checked = false;
                checkBox70.Checked = false;
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                checkBox7.Checked = false;
                checkBox39.Checked = false;
                checkBox55.Checked = false;
                checkBox71.Checked = false;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                checkBox8.Checked = false;
                checkBox40.Checked = false;
                checkBox56.Checked = false;
                checkBox72.Checked = false;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                checkBox9.Checked = false;
                checkBox41.Checked = false;
                checkBox57.Checked = false;
                checkBox73.Checked = false;
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                checkBox10.Checked = false;
                checkBox42.Checked = false;
                checkBox58.Checked = false;
                checkBox74.Checked = false;
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                checkBox11.Checked = false;
                checkBox43.Checked = false;
                checkBox59.Checked = false;
                checkBox75.Checked = false;
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                checkBox11.Checked = false;
                checkBox44.Checked = false;
                checkBox60.Checked = false;
                checkBox76.Checked = false;
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                checkBox13.Checked = false;
                checkBox45.Checked = false;
                checkBox61.Checked = false;
                checkBox77.Checked = false;
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                checkBox14.Checked = false;
                checkBox46.Checked = false;
                checkBox62.Checked = false;
                checkBox78.Checked = false;
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked)
            {
                checkBox15.Checked = false;
                checkBox47.Checked = false;
                checkBox63.Checked = false;
                checkBox79.Checked = false;
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                checkBox16.Checked = false;
                checkBox48.Checked = false;
                checkBox64.Checked = false;
                checkBox80.Checked = false;
            }
        }

        //Row 3
        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked)
            {
                checkBox17.Checked = false;
                checkBox1.Checked = false;
                checkBox49.Checked = false;
                checkBox65.Checked = false;
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
            {
                checkBox18.Checked = false;
                checkBox2.Checked = false;
                checkBox50.Checked = false;
                checkBox66.Checked = false;
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
            {
                checkBox19.Checked = false;
                checkBox3.Checked = false;
                checkBox51.Checked = false;
                checkBox67.Checked = false;
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked)
            {
                checkBox20.Checked = false;
                checkBox4.Checked = false;
                checkBox52.Checked = false;
                checkBox68.Checked = false;
            }
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked)
            {
                checkBox21.Checked = false;
                checkBox5.Checked = false;
                checkBox53.Checked = false;
                checkBox69.Checked = false;
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked)
            {
                checkBox22.Checked = false;
                checkBox6.Checked = false;
                checkBox54.Checked = false;
                checkBox70.Checked = false;
            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked)
            {
                checkBox23.Checked = false;
                checkBox7.Checked = false;
                checkBox55.Checked = false;
                checkBox71.Checked = false;
            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked)
            {
                checkBox24.Checked = false;
                checkBox8.Checked = false;
                checkBox56.Checked = false;
                checkBox72.Checked = false;
            }
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked)
            {
                checkBox25.Checked = false;
                checkBox9.Checked = false;
                checkBox57.Checked = false;
                checkBox73.Checked = false;
            }
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked)
            {
                checkBox26.Checked = false;
                checkBox10.Checked = false;
                checkBox58.Checked = false;
                checkBox74.Checked = false;
            }
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked)
            {
                checkBox27.Checked = false;
                checkBox11.Checked = false;
                checkBox59.Checked = false;
                checkBox75.Checked = false;
            }
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked)
            {
                checkBox28.Checked = false;
                checkBox12.Checked = false;
                checkBox60.Checked = false;
                checkBox76.Checked = false;
            }
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked)
            {
                checkBox29.Checked = false;
                checkBox13.Checked = false;
                checkBox61.Checked = false;
                checkBox77.Checked = false;
            }
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked)
            {
                checkBox30.Checked = false;
                checkBox14.Checked = false;
                checkBox62.Checked = false;
                checkBox78.Checked = false;
            }
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked)
            {
                checkBox31.Checked = false;
                checkBox15.Checked = false;
                checkBox63.Checked = false;
                checkBox79.Checked = false;
            }
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox48.Checked)
            {
                checkBox32.Checked = false;
                checkBox16.Checked = false;
                checkBox64.Checked = false;
                checkBox80.Checked = false;
            }
        }

        //Row 4
        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox49.Checked)
            {
                checkBox17.Checked = false;
                checkBox33.Checked = false;
                checkBox1.Checked = false;
                checkBox65.Checked = false;
            }
        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox50.Checked)
            {
                checkBox18.Checked = false;
                checkBox34.Checked = false;
                checkBox2.Checked = false;
                checkBox66.Checked = false;
            }
        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox51.Checked)
            {
                checkBox19.Checked = false;
                checkBox35.Checked = false;
                checkBox3.Checked = false;
                checkBox67.Checked = false;
            }
        }

        private void checkBox52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox52.Checked)
            {
                checkBox20.Checked = false;
                checkBox36.Checked = false;
                checkBox4.Checked = false;
                checkBox68.Checked = false;
            }
        }

        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox53.Checked)
            {
                checkBox21.Checked = false;
                checkBox37.Checked = false;
                checkBox5.Checked = false;
                checkBox69.Checked = false;
            }
        }

        private void checkBox54_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox54.Checked)
            {
                checkBox22.Checked = false;
                checkBox38.Checked = false;
                checkBox6.Checked = false;
                checkBox70.Checked = false;
            }
        }

        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox55.Checked)
            {
                checkBox23.Checked = false;
                checkBox39.Checked = false;
                checkBox7.Checked = false;
                checkBox71.Checked = false;
            }
        }

        private void checkBox56_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox56.Checked)
            {
                checkBox24.Checked = false;
                checkBox40.Checked = false;
                checkBox8.Checked = false;
                checkBox72.Checked = false;
            }
        }

        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox57.Checked)
            {
                checkBox25.Checked = false;
                checkBox41.Checked = false;
                checkBox9.Checked = false;
                checkBox73.Checked = false;
            }
        }

        private void checkBox58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox58.Checked)
            {
                checkBox26.Checked = false;
                checkBox42.Checked = false;
                checkBox10.Checked = false;
                checkBox74.Checked = false;
            }
        }

        private void checkBox59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox59.Checked)
            {
                checkBox27.Checked = false;
                checkBox43.Checked = false;
                checkBox11.Checked = false;
                checkBox75.Checked = false;
            }
        }

        private void checkBox60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox60.Checked)
            {
                checkBox28.Checked = false;
                checkBox44.Checked = false;
                checkBox12.Checked = false;
                checkBox76.Checked = false;
            }
        }

        private void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox61.Checked)
            {
                checkBox29.Checked = false;
                checkBox45.Checked = false;
                checkBox13.Checked = false;
                checkBox77.Checked = false;
            }
        }

        private void checkBox62_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox62.Checked)
            {
                checkBox30.Checked = false;
                checkBox46.Checked = false;
                checkBox14.Checked = false;
                checkBox78.Checked = false;
            }
        }

        private void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox63.Checked)
            {
                checkBox31.Checked = false;
                checkBox47.Checked = false;
                checkBox15.Checked = false;
                checkBox79.Checked = false;
            }
        }

        private void checkBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox32.Checked = false;
                checkBox48.Checked = false;
                checkBox16.Checked = false;
                checkBox80.Checked = false;
            }
        }

        //Row 5
        private void checkBox65_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox65.Checked)
            {
                checkBox17.Checked = false;
                checkBox33.Checked = false;
                checkBox49.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void checkBox66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox66.Checked)
            {
                checkBox18.Checked = false;
                checkBox34.Checked = false;
                checkBox50.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox19.Checked = false;
                checkBox35.Checked = false;
                checkBox51.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox68.Checked)
            {
                checkBox20.Checked = false;
                checkBox36.Checked = false;
                checkBox52.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox69_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox69.Checked)
            {
                checkBox21.Checked = false;
                checkBox37.Checked = false;
                checkBox53.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox70_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox70.Checked)
            {
                checkBox22.Checked = false;
                checkBox38.Checked = false;
                checkBox54.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox71_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox71.Checked)
            {
                checkBox23.Checked = false;
                checkBox39.Checked = false;
                checkBox55.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox72_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox72.Checked)
            {
                checkBox24.Checked = false;
                checkBox40.Checked = false;
                checkBox56.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox73_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox73.Checked)
            {
                checkBox25.Checked = false;
                checkBox41.Checked = false;
                checkBox57.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox74_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox74.Checked)
            {
                checkBox26.Checked = false;
                checkBox42.Checked = false;
                checkBox58.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void checkBox75_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox75.Checked)
            {
                checkBox27.Checked = false;
                checkBox43.Checked = false;
                checkBox59.Checked = false;
                checkBox11.Checked = false;
            }
        }

        private void checkBox76_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox76.Checked)
            {
                checkBox28.Checked = false;
                checkBox44.Checked = false;
                checkBox60.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox77_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox77.Checked)
            {
                checkBox29.Checked = false;
                checkBox45.Checked = false;
                checkBox61.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox78_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox78.Checked)
            {
                checkBox30.Checked = false;
                checkBox46.Checked = false;
                checkBox62.Checked = false;
                checkBox14.Checked = false;
            }
        }

        private void checkBox79_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox79.Checked)
            {
                checkBox31.Checked = false;
                checkBox47.Checked = false;
                checkBox63.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox80_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox80.Checked)
            {
                checkBox32.Checked = false;
                checkBox48.Checked = false;
                checkBox64.Checked = false;
                checkBox16.Checked = false;
            }
        }
    }
}
