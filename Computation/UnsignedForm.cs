using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Computation
{
    public partial class UnsignedForm : Form
    {
        private byte[] _a;
        private byte[] _q;
        private byte _c;
        private byte _num1;//Q
        private byte _num2;//M
        private byte nbit = 4;
        private byte _n;

        public UnsignedForm()
        {
            InitializeComponent();
            _a = new byte[nbit];
            _q = new byte[nbit];
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            _n = nbit;
            this.printtextBox.Text = string.Empty;
            this.printtextBox.Text = "\t" + "C" + "\t" + "A" + "\t" + "Q" + "\t" + "N" + Environment.NewLine;
            for (int i = 0; i < nbit; i++)
            {
                _a[i] = 0;
                _q[i] = 0;
            }
            this.resulttextBox.Text = string.Empty;
            _num1 = byte.Parse(this.firsttextBox.Text);
            _num2 = byte.Parse(this.secondtextBox.Text);
            
            this.ToSystem(_q, Convert.ToString(_num1, 2));

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
            if (_q[_q.Length - 1] != 0)
            {
                this.Add();
                this.Shift();
            }
            else if (_q[_q.Length - 1] == 0) this.Shift();

            goto aa;
        }

        //--------Convert to System-----------
        private void ToSystem(byte[] arr, string strnum)
        {
            int count = strnum.Length - 1;
            for (int i =/*3*/ arr.Length - 1; i >= 0; i--)
            {
                arr[i] = byte.Parse(strnum[count].ToString());
                if (count > 0) count--;
                else break;
            }

        }

        //-----------For A+M----------
        private void Add()
        {
            int x = 0;
            int count = 0;
            for (int i = _a.Length - 1; i >= 0; i--)
            {
                if (_a[i] != 0)
                    x += Convert.ToInt32(Math.Pow(2, count));
                count++;
            }
            int y = x + _num2;

            string s = Convert.ToString(y, 2);
            if (s.Length <= 4) this.ToSystem(_a, s);
            else
            {
                _c = 1;
                this.ToSystem(_a, s.Substring(s.Length - nbit, 4));
            }
            this.Print();
        }
        //------------for Shift------------
        private void Shift()
        {
            for (int i = _q.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    _q[0] = _a[3];
                    break;
                }
                _q[i] = _q[i - 1];

            }
            for (int i = _a.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    _a[0] = _c;
                    _c = 0;
                    break;
                }
                _a[i] = _a[i - 1];

            }

            this.Print();
            _n--;
        }
        //-----------for print Values-------------
        private void Print()
        {
            this.printtextBox.Text += "\t" + _c.ToString() + "\t";
            for (int i = 0; i < nbit; i++)
                this.printtextBox.Text += _a[i].ToString();
            this.printtextBox.Text += "\t";
            for (int i = 0; i < nbit; i++)
                this.printtextBox.Text += _q[i].ToString();
            this.printtextBox.Text += "\t" + _n.ToString();
            this.printtextBox.Text += Environment.NewLine;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            this.printtextBox.Text = this.resulttextBox.Text = this.firsttextBox.Text = this.secondtextBox.Text = string.Empty;
        }








    }
}