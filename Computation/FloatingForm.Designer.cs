
namespace Computation
{
    partial class FloatingForm 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fractiontextBox = new System.Windows.Forms.TextBox();
            this.exponedtextBox = new System.Windows.Forms.TextBox();
            this.resultsigntextBox = new System.Windows.Forms.TextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.numtextBox = new System.Windows.Forms.TextBox();
            this.signtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(64, 84);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(385, 31);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Slow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fast";
            // 
            // fractiontextBox
            // 
            this.fractiontextBox.BackColor = System.Drawing.Color.Bisque;
            this.fractiontextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.fractiontextBox.Location = new System.Drawing.Point(206, 140);
            this.fractiontextBox.Name = "fractiontextBox";
            this.fractiontextBox.ReadOnly = true;
            this.fractiontextBox.Size = new System.Drawing.Size(296, 20);
            this.fractiontextBox.TabIndex = 25;
            // 
            // exponedtextBox
            // 
            this.exponedtextBox.BackColor = System.Drawing.Color.Pink;
            this.exponedtextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.exponedtextBox.Location = new System.Drawing.Point(60, 140);
            this.exponedtextBox.Name = "exponedtextBox";
            this.exponedtextBox.ReadOnly = true;
            this.exponedtextBox.Size = new System.Drawing.Size(143, 20);
            this.exponedtextBox.TabIndex = 24;
            // 
            // resultsigntextBox
            // 
            this.resultsigntextBox.BackColor = System.Drawing.Color.Pink;
            this.resultsigntextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.resultsigntextBox.Location = new System.Drawing.Point(32, 140);
            this.resultsigntextBox.Name = "resultsigntextBox";
            this.resultsigntextBox.ReadOnly = true;
            this.resultsigntextBox.Size = new System.Drawing.Size(24, 20);
            this.resultsigntextBox.TabIndex = 23;
            // 
            // enterbutton
            // 
            this.enterbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.enterbutton.Location = new System.Drawing.Point(374, 26);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(75, 35);
            this.enterbutton.TabIndex = 22;
            this.enterbutton.Text = "Enter";
            this.enterbutton.UseVisualStyleBackColor = false;
            this.enterbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numtextBox
            // 
            this.numtextBox.Location = new System.Drawing.Point(124, 34);
            this.numtextBox.Name = "numtextBox";
            this.numtextBox.Size = new System.Drawing.Size(167, 20);
            this.numtextBox.TabIndex = 21;
            // 
            // signtextBox
            // 
            this.signtextBox.Location = new System.Drawing.Point(96, 34);
            this.signtextBox.Name = "signtextBox";
            this.signtextBox.Size = new System.Drawing.Size(24, 20);
            this.signtextBox.TabIndex = 20;
            this.signtextBox.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number";
            // 
            // FloatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(589, 421);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fractiontextBox);
            this.Controls.Add(this.exponedtextBox);
            this.Controls.Add(this.resultsigntextBox);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.numtextBox);
            this.Controls.Add(this.signtextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FloatingForm";
            this.Text = "FlaotingForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fractiontextBox;
        private System.Windows.Forms.TextBox exponedtextBox;
        private System.Windows.Forms.TextBox resultsigntextBox;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.TextBox numtextBox;
        private System.Windows.Forms.TextBox signtextBox;
        private System.Windows.Forms.Label label1;


    }
}