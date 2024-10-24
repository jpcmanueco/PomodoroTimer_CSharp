namespace PomodoroTImer_CSharp
{
    partial class PomodoroTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Startbutton = new Button();
            Temporizador = new System.Windows.Forms.Timer(components);
            Timerlabel = new Label();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutDeveloperToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            domainUpDown1 = new DomainUpDown();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Startbutton
            // 
            Startbutton.Anchor = AnchorStyles.None;
            Startbutton.Location = new Point(58, 27);
            Startbutton.Name = "Startbutton";
            Startbutton.Size = new Size(75, 23);
            Startbutton.TabIndex = 0;
            Startbutton.Text = "Start";
            Startbutton.UseVisualStyleBackColor = true;
            // 
            // Temporizador
            // 
            Temporizador.Enabled = true;
            // 
            // Timerlabel
            // 
            Timerlabel.Anchor = AnchorStyles.None;
            Timerlabel.AutoSize = true;
            Timerlabel.Font = new Font("Segoe UI", 26F);
            Timerlabel.Location = new Point(44, 51);
            Timerlabel.Name = "Timerlabel";
            Timerlabel.Size = new Size(104, 47);
            Timerlabel.TabIndex = 1;
            Timerlabel.Text = "00:00";
            Timerlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(184, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutDeveloperToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            aboutDeveloperToolStripMenuItem.Size = new Size(162, 22);
            aboutDeveloperToolStripMenuItem.Text = "About developer";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(76, 126);
            button2.Name = "button2";
            button2.Size = new Size(47, 23);
            button2.TabIndex = 3;
            button2.Text = "Pause";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(129, 126);
            button3.Name = "button3";
            button3.Size = new Size(47, 23);
            button3.TabIndex = 4;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(56, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Anchor = AnchorStyles.None;
            domainUpDown1.Items.Add("");
            domainUpDown1.Location = new Point(10, 126);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(60, 23);
            domainUpDown1.TabIndex = 6;
            domainUpDown1.Text = "timerSelect";
            // 
            // PomodoroTimer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(184, 161);
            Controls.Add(domainUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Timerlabel);
            Controls.Add(Startbutton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(200, 200);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(200, 200);
            Name = "PomodoroTimer";
            ShowIcon = false;
            Text = "Pomodoro Timer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Startbutton;
        private System.Windows.Forms.Timer Temporizador;
        private Label Timerlabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private DomainUpDown domainUpDown1;
    }
}
