using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrumMachine
{
    public partial class DrumSequencer : Form
    {
        public DrumSequencer()
        {
            InitializeComponent();
        }

private void DrumSequencer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Sequencer = new Sequencer();
            Sequencer.Closed += (s, args) => this.Close();
            Sequencer.Show();
            Sequencer.Visible = true;
        }
    }
}
