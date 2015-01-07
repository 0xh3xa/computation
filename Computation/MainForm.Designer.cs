namespace Computation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flaotingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usignedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intagerToolStripMenuItem,
            this.flaotingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.selectToolStripMenuItem.Text = "&Select";
            // 
            // intagerToolStripMenuItem
            // 
            this.intagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiplayToolStripMenuItem,
            this.divideToolStripMenuItem});
            this.intagerToolStripMenuItem.Image = global::Computation.Properties.Resources.forward;
            this.intagerToolStripMenuItem.Name = "intagerToolStripMenuItem";
            this.intagerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.intagerToolStripMenuItem.Text = "&Intager";
            // 
            // divideToolStripMenuItem
            // 
            this.divideToolStripMenuItem.Name = "divideToolStripMenuItem";
            this.divideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divideToolStripMenuItem.Text = "Divide";
            this.divideToolStripMenuItem.Click += new System.EventHandler(this.divideToolStripMenuItem_Click);
            // 
            // flaotingToolStripMenuItem
            // 
            this.flaotingToolStripMenuItem.Image = global::Computation.Properties.Resources.play;
            this.flaotingToolStripMenuItem.Name = "flaotingToolStripMenuItem";
            this.flaotingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.flaotingToolStripMenuItem.Text = "&Flaoting";
            this.flaotingToolStripMenuItem.Click += new System.EventHandler(this.flaotingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Computation.Properties.Resources.Actions_window_close_ico;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Computation.Properties.Resources.Actions_help_about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // multiplayToolStripMenuItem
            // 
            this.multiplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usignedToolStripMenuItem,
            this.signedToolStripMenuItem1});
            this.multiplayToolStripMenuItem.Name = "multiplayToolStripMenuItem";
            this.multiplayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.multiplayToolStripMenuItem.Text = "Multiplay";
            // 
            // usignedToolStripMenuItem
            // 
            this.usignedToolStripMenuItem.Name = "usignedToolStripMenuItem";
            this.usignedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usignedToolStripMenuItem.Text = "Usigned";
            this.usignedToolStripMenuItem.Click += new System.EventHandler(this.unsignedToolStripMenuItem_Click);
            // 
            // signedToolStripMenuItem1
            // 
            this.signedToolStripMenuItem1.Name = "signedToolStripMenuItem1";
            this.signedToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.signedToolStripMenuItem1.Text = "Signed";
            this.signedToolStripMenuItem1.Click += new System.EventHandler(this.signedToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Computation.Properties.Resources._206210_132088026936436_1211114553_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flaotingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usignedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signedToolStripMenuItem1;

    }
}

