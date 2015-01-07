using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic.Devices;
namespace Computation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

//SoundPlayer p = new SoundPlayer(@"C:\Windows\winsxs\amd64_microsoft-windows-irdafiletransfer_31bf3856ad364e35_6.1.7600.16385_none_bb684a120148a438\ir_inter.wav");
          //  p.PlayLooping();
        }

        private void unsignedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnsignedForm form = new UnsignedForm();
            form.MdiParent = this;
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void intagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignedForm form = new SignedForm();
            form.MdiParent = this;
            form.Show();
        }

        private void flaotingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FloatingForm form = new FloatingForm();
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivideForm form = new DivideForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}