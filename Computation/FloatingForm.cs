using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Computation
{
    public partial class FloatingForm : Form
    {
        Timer t;
        private byte[] _fraction;
        byte _baisednum;
        byte _system;
        public FloatingForm()
        {
            InitializeComponent();
            _baisednum = 8;
            _system = 23;
            _fraction=new byte[_system];

           t= new Timer();
            t.Interval = 1000;
        }
        int tick = 0;
        private void Clear()
        {
            //--------Clear Histrory-------------
            this.resultsigntextBox.Text=this.exponedtextBox.Text = this.fractiontextBox.Text = string.Empty;
            for (int i = 0; i < _fraction.Length; i++)
                _fraction[i] = 0;
            
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Clear();
            //-----------Check if interger or not---------
            if (!numtextBox.Text.Contains('.'))
                this.GetBasied(Convert.ToString(int.Parse(numtextBox.Text), 2));
            else
            {
                string s1=numtextBox.Text.Substring(0,numtextBox.Text.IndexOf('.'));
                s1 = Convert.ToString(int.Parse(s1),2);
                string s2 = numtextBox.Text.Substring(numtextBox.Text.IndexOf('.'));
                ArrayList a = new ArrayList();

                float x = float.Parse(s2);
                for (int i = 0; i < i + 1; i++)
                {
                    x *= 2;
                    if (x == 0) break;
                    if (x >= 1)
                    {
                        a.Add(1);
                        x--;
                    }
                    else
                        a.Add(0);
                }
                string ss="";
                for (int i = 0; i < a.ToArray().Length; i++)
                {
                    ss += a[i];
                }

                this.GetBasied(s1+ss);
            }
                t.Enabled = true;
                t.Tick += new EventHandler(t_Tick);
             
        }
        int _count=0;
        void t_Tick(object sender, EventArgs e)
        {
            if (tick >= _fraction.Length - 1)
            {
                t.Enabled = false;
                tick = 0;
            }
                this.fractiontextBox.Text += _fraction[tick].ToString();
            if(_count<sx.Length-1)   
            this.exponedtextBox.Text += sx[_count].ToString();
            tick++;
      _count++;
        }
        string sx;
        private void GetBasied(string s)
        {
            int count = 0;
            int v = 0;
            for (int i = 1; i < s.Length; i++)
            {
                    _fraction[v] = byte.Parse(s[i].ToString());
                    count++;
                    v++;
                
            }
            
            int x =Convert.ToInt32(Math.Pow(2,_baisednum)-1);
            sx = Convert.ToString(x+count,2);
            if (this.signtextBox.Text.Equals("+")) this.resultsigntextBox.Text = "0";
            else if (this.signtextBox.Text.Equals("-")) this.resultsigntextBox.Text = "1";
                
          
        }

        private void signtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar tt = (TrackBar)sender;
            if (tt.Value >= 5&&t.Interval>1) t.Interval /= 10;
               
            else t.Interval += tt.TickFrequency;
        }



    }


}
