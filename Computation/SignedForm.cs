using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computation
{
    public partial class SignedForm : Form
    {
        private byte[] _a;
        private byte[] _q;
        private byte _q_1;
        private int _num1;
        private int _num2;
        private byte _n;
        private byte _numbit = 4;
        int _system;
       
        public SignedForm()
        {
            InitializeComponent();
            _a = new byte[_numbit];
            _q = new byte[_numbit];
           
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            string str1 = this.sign1textBox.Text;
            string str2 = this.sign2textBox.Text;
            if (sign1textBox.Text == sign2textBox.Text)
            {
                signresulttextBox.Text = "+";

                _num1 = byte.Parse(this.firsttextBox.Text);
                _num2 = byte.Parse(this.secondtextBox.Text);

            }
            else
            {
                signresulttextBox.Text = "-";
                _num1 = byte.Parse(this.firsttextBox.Text) * -1;
                _num2 = byte.Parse(this.secondtextBox.Text) * -1;
            
            }
                _n = _numbit;
            this.printtextBox.Text = string.Empty;
            this.printtextBox.Text =  "A" + "\t"+"Q"+"\t" + "Q-1" + "\t" + "N" + Environment.NewLine;
          
            _system = 2;
            for (int i = 0; i < _numbit; i++)
            {
                _a[i] = 0;
                _q[i] = 0;
            }
            this.resulttextBox.Text = string.Empty;
                this.ToSystem(_q, Convert.ToString(_num2, _system));
            this.Start();
        }

        //-----------start-----------
        private void Start()
        {
        aa:
            if (_n == 0)
            {
                this.resulttextBox.Text = (_num1 * _num2).ToString();
                return;
            }
            //--------Q0=1?-----------
        if (_q[_q.Length - 1] == 0 && _q_1 == 1)
        {
         
            this.Operation("+");
            this.Shift();
        }
        else if (_q[_q.Length - 1] == 1 && _q_1 == 0)
        {
            this.Operation("-");
            this.Shift();
        }
        else
            this.Shift();
            goto aa;
        }

        //--------Convert to System-----------
        private void ToSystem(byte[] arr, string strnum)
        {
            int count = strnum.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = byte.Parse(strnum[count].ToString());
                if (count > 0) count--;
                else break;
            }
            this.Print();
        }

        //-----------For A+M----------
        private void Operation(string  sign)
        {
            int x = 0;
            int count = 0;
           int y=0;
            for (int i = _a.Length - 1; i >= 0; i--)
            {
                if (_a[i] != 0)
                    x += Convert.ToInt32(Math.Pow(_system, count));
                count++;
            }

            if(sign=="+")
            y = x + _num1;
            else if(sign=="-") y=x-_num1;
            
            string s = Convert.ToString(y, _system);
            if (s.Length <= _numbit) this.ToSystem(_a, s);

            else {
                
                this.ToSystem(_a, s.Substring((s.Length - _numbit), _numbit));
                }
        }
        //------------for Shift------------
        private void Shift()
        {
          //  for (int i = _q.Length - 1; i >= 0; i--)
            {
                //if (i == _q.Length-1)
                //{
                //}
                 _q_1 = _q[3];
                
                _q[3] = _q[2];

                _q[2] = _q[1];

                _q[1] = _q[0];
              
                _q[0] = _a[3];
            }

            for (int i = _a.Length - 1; i >= 0; i--)
            {
                if (i ==0)
                {
                    _a[0] = _a[1];
                    break;
                }
                _a[i] = _a[i - 1];
             //   _a[0] = _a[1];
            }
            _n--;
            this.Print();
        }
        //-----------for print Values-------------
        private void Print()
        {
            for (int i = 0; i < _numbit; i++)
                this.printtextBox.Text += _a[i].ToString();
            this.printtextBox.Text += "\t";
            for (int i = 0; i < _numbit; i++)
                this.printtextBox.Text += _q[i].ToString();
            this.printtextBox.Text += "\t" + _q_1.ToString();
          
            this.printtextBox.Text += "\t" + _n.ToString();
            this.printtextBox.Text += Environment.NewLine;
        }

        
    }
}
