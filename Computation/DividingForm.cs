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
    public partial class DivideForm : Form
    {
        private byte[] _a;
        private byte[] _q;
        private byte _num1;//Q
        private byte _num2;//M
        private byte nbit = 4;
        private byte _n;


        public DivideForm()
        {
            InitializeComponent();
            _a = new byte[nbit];
            _q = new byte[nbit];
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            _n = nbit;
            this.printtextBox.Text = string.Empty;
            this.printtextBox.Text = "\t" + "A" + "\t" + "Q" + "\t" + "N" + Environment.NewLine;
            for (int i = 0; i < nbit; i++)
            {
                _a[i] = 0;
                _q[i] = 0;

            }
            this.resulttextBox.Text = string.Empty;
            _num1 = byte.Parse(this.firsttextBox.Text);
            _num2 = byte.Parse(this.secondtextBox.Text);

            this.ToSystem(_q, Convert.ToString(_num1, 2));

            this.start();
        }



        private void start()
        {
        mm:
            if (_n == 0)
            {
                this.resulttextBox.Text = (_num1 / _num2).ToString();
                return;
            }

            this.Shift();

            this.Substract();

            if (_a[0] != 0)
            {
                _q[3] = 0;
                this.Add(); this.Print();
            }

            else if (_a[0] == 0)
            {
                _q[3] = 1;
                this.Print();
            }


            _n--;
            goto mm;
        }

        private void ToSystem(byte[] arr, String binary)
        {
            int count = binary.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = byte.Parse(binary[count].ToString());
                if (count > 0) count--;
                else break;
            }

        }

        private void Shift()
        {
            for (int i = _a.Length - 4; i <= 3; i++)
            {
                if (i == 3)
                {
                    _a[3] = _q[0];
                    break;
                }
                _a[i] = _a[i + 1];
            }
            for (int i = _q.Length - 4; i <= 3; i++)
            {
                if (i == 3)
                {
                    _q[3] = 0;
                    break;
                }
                _q[i] = _q[i + 1];
            }

            this.Print();
        }

        private void Substract()
        {

            int x = 0;
            int count = 0;
            for (int i = _a.Length - 1; i >= 0; i--)
            {
                if (_a[i] != 0)
                    x += Convert.ToInt32(Math.Pow(2, count));
                count++;
            }
            int y = x - _num2;


            if (y <= 0)
            {
                int f = Math.Abs(y);
                int h = 16 - f;
                string s = Convert.ToString(h, 2);
                if (s.Length <= 4) this.ToSystem(_a, s);
                else this.ToSystem(_a, s.Substring(s.Length - nbit, 4));
            }

            else if (y > 0)
            {
                int h = 16 + y;
                string k = Convert.ToString(h, 2);
                if (k.Length <= 4) this.ToSystem(_a, k);
                else this.ToSystem(_a, k.Substring(k.Length - nbit, 4));
            }
            this.Print();
        }

        private void Add()
        {
            int y;

            int x = 0;
            int count = 0;
            for (int i = _a.Length - 1; i >= 0; i--)
            {
                if (_a[i] != 0)
                    x += Convert.ToInt32(Math.Pow(2, count));
                count++;
            }

            y = x + _num2;
            string u = Convert.ToString(y, 2);
            if (u.Length <= 4) this.ToSystem(_a, u);
            else this.ToSystem(_a, u.Substring(u.Length - nbit, 4));

        }

        private void Print()
        {
            this.printtextBox.Text += "\t";
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
