namespace clockapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            maxwindow = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            exitbotton = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            trackBar2 = new TrackBar();
            panel5 = new Panel();
            BGButton1 = new FontAwesome.Sharp.IconButton();
            saveButton = new FontAwesome.Sharp.IconButton();
            timebutton = new FontAwesome.Sharp.IconButton();
            colorbutton = new FontAwesome.Sharp.IconButton();
            sizebutton = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            optionbutton = new FontAwesome.Sharp.IconButton();
            trackbutton = new FontAwesome.Sharp.IconButton();
            pauserun = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnmenu = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            toolTip1 = new ToolTip(components);
            colorDialog1 = new ColorDialog();
            timer2 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(maxwindow);
            panel2.Controls.Add(iconButton9);
            panel2.Controls.Add(exitbotton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(98, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 36);
            panel2.TabIndex = 1;
            panel2.MouseClick += panel2_MouseClick;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // maxwindow
            // 
            maxwindow.Dock = DockStyle.Right;
            maxwindow.FlatAppearance.BorderSize = 0;
            maxwindow.FlatStyle = FlatStyle.Flat;
            maxwindow.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            maxwindow.IconColor = Color.Black;
            maxwindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maxwindow.IconSize = 25;
            maxwindow.Location = new Point(319, 0);
            maxwindow.Name = "maxwindow";
            maxwindow.Size = new Size(46, 36);
            maxwindow.TabIndex = 4;
            maxwindow.UseVisualStyleBackColor = true;
            maxwindow.MouseClick += maxwindow_MouseClick;
            // 
            // iconButton9
            // 
            iconButton9.BackColor = SystemColors.AppWorkspace;
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.Font = new Font("Lucida Sans Typewriter", 9F);
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton9.IconColor = Color.Black;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.Location = new Point(6, 7);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(95, 23);
            iconButton9.TabIndex = 3;
            iconButton9.Text = "DASHBOARD";
            iconButton9.UseVisualStyleBackColor = false;
            iconButton9.Click += iconButton9_Click;
            // 
            // exitbotton
            // 
            exitbotton.Dock = DockStyle.Right;
            exitbotton.FlatAppearance.BorderSize = 0;
            exitbotton.FlatStyle = FlatStyle.Flat;
            exitbotton.IconChar = FontAwesome.Sharp.IconChar.CircleLeft;
            exitbotton.IconColor = Color.Black;
            exitbotton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitbotton.IconSize = 25;
            exitbotton.Location = new Point(365, 0);
            exitbotton.Name = "exitbotton";
            exitbotton.Size = new Size(46, 36);
            exitbotton.TabIndex = 2;
            exitbotton.UseVisualStyleBackColor = true;
            exitbotton.MouseClick += exitbotton_MouseClick;
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.BackColor = Color.Snow;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(trackBar2);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(98, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(411, 200);
            panel4.TabIndex = 2;
            panel4.DragDrop += panel4_DragDrop;
            panel4.DragEnter += panel4_DragEnter;
            // 
            // trackBar2
            // 
            trackBar2.BackColor = Color.LightGray;
            trackBar2.Location = new Point(236, 130);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 30;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(120, 45);
            trackBar2.TabIndex = 5;
            trackBar2.Value = 30;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(BGButton1);
            panel5.Controls.Add(saveButton);
            panel5.Controls.Add(timebutton);
            panel5.Controls.Add(colorbutton);
            panel5.Controls.Add(sizebutton);
            panel5.Location = new Point(-1, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(99, 154);
            panel5.TabIndex = 6;
            // 
            // BGButton1
            // 
            BGButton1.FlatAppearance.BorderSize = 0;
            BGButton1.FlatStyle = FlatStyle.Flat;
            BGButton1.Font = new Font("Lucida Sans", 7F);
            BGButton1.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            BGButton1.IconColor = Color.Black;
            BGButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BGButton1.IconSize = 25;
            BGButton1.ImageAlign = ContentAlignment.MiddleLeft;
            BGButton1.Location = new Point(0, 65);
            BGButton1.Name = "BGButton1";
            BGButton1.Size = new Size(112, 29);
            BGButton1.TabIndex = 12;
            BGButton1.Tag = "Background";
            BGButton1.Text = "startTime";
            BGButton1.TextAlign = ContentAlignment.MiddleLeft;
            BGButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGButton1.UseVisualStyleBackColor = true;
            BGButton1.Click += iconButton1_Click_1;
            // 
            // saveButton
            // 
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Lucida Sans", 7F);
            saveButton.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            saveButton.IconColor = Color.Black;
            saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveButton.IconSize = 25;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(0, 122);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 29);
            saveButton.TabIndex = 11;
            saveButton.Tag = "Save";
            saveButton.Text = "startTime";
            saveButton.TextAlign = ContentAlignment.MiddleLeft;
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += iconButton1_Click;
            // 
            // timebutton
            // 
            timebutton.FlatAppearance.BorderSize = 0;
            timebutton.FlatStyle = FlatStyle.Flat;
            timebutton.Font = new Font("Lucida Sans", 7F);
            timebutton.IconChar = FontAwesome.Sharp.IconChar.Clock;
            timebutton.IconColor = Color.Black;
            timebutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            timebutton.IconSize = 25;
            timebutton.ImageAlign = ContentAlignment.MiddleLeft;
            timebutton.Location = new Point(0, 94);
            timebutton.Name = "timebutton";
            timebutton.Size = new Size(112, 29);
            timebutton.TabIndex = 10;
            timebutton.Tag = "Time";
            timebutton.Text = "startTime";
            timebutton.TextAlign = ContentAlignment.MiddleLeft;
            timebutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            timebutton.UseVisualStyleBackColor = true;
            timebutton.Click += timebutton_Click;
            // 
            // colorbutton
            // 
            colorbutton.FlatAppearance.BorderSize = 0;
            colorbutton.FlatStyle = FlatStyle.Flat;
            colorbutton.Font = new Font("Lucida Sans", 7F);
            colorbutton.IconChar = FontAwesome.Sharp.IconChar.Paintbrush;
            colorbutton.IconColor = Color.Black;
            colorbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            colorbutton.IconSize = 25;
            colorbutton.ImageAlign = ContentAlignment.MiddleLeft;
            colorbutton.Location = new Point(0, 32);
            colorbutton.Name = "colorbutton";
            colorbutton.Size = new Size(112, 29);
            colorbutton.TabIndex = 8;
            colorbutton.Tag = "Color";
            colorbutton.Text = "startTime";
            colorbutton.TextAlign = ContentAlignment.MiddleLeft;
            colorbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            colorbutton.UseVisualStyleBackColor = true;
            colorbutton.Click += colorbutton_Click;
            // 
            // sizebutton
            // 
            sizebutton.FlatAppearance.BorderSize = 0;
            sizebutton.FlatStyle = FlatStyle.Flat;
            sizebutton.Font = new Font("Lucida Sans", 7F);
            sizebutton.IconChar = FontAwesome.Sharp.IconChar.UpRightAndDownLeftFromCenter;
            sizebutton.IconColor = Color.Black;
            sizebutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sizebutton.IconSize = 25;
            sizebutton.ImageAlign = ContentAlignment.MiddleLeft;
            sizebutton.Location = new Point(0, 3);
            sizebutton.Name = "sizebutton";
            sizebutton.Size = new Size(112, 29);
            sizebutton.TabIndex = 7;
            sizebutton.Tag = "Size";
            sizebutton.Text = "startTime";
            sizebutton.TextAlign = ContentAlignment.MiddleLeft;
            sizebutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            sizebutton.UseVisualStyleBackColor = true;
            sizebutton.Click += sizebutton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("GyeonggiTitleV Bold", 60F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(394, 80);
            label1.TabIndex = 0;
            label1.Text = "Loading..";
            label1.MouseClick += label1_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("GyeonggiTitle Medium", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(32, 145);
            label3.Name = "label3";
            label3.Size = new Size(188, 33);
            label3.TabIndex = 8;
            label3.Text = "Stopwatch";
            label3.DoubleClick += label3_DoubleClick_1;
            label3.MouseClick += label3_MouseClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.GhostWhite;
            textBox1.Location = new Point(104, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(optionbutton);
            panel3.Controls.Add(trackbutton);
            panel3.Controls.Add(pauserun);
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(btnmenu);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 236);
            panel3.TabIndex = 0;
            panel3.MouseClick += panel3_MouseClick;
            // 
            // optionbutton
            // 
            optionbutton.FlatAppearance.BorderSize = 0;
            optionbutton.FlatStyle = FlatStyle.Flat;
            optionbutton.Font = new Font("Lucida Sans", 7F);
            optionbutton.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            optionbutton.IconColor = Color.Black;
            optionbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            optionbutton.IconSize = 25;
            optionbutton.Location = new Point(0, 191);
            optionbutton.Name = "optionbutton";
            optionbutton.Size = new Size(110, 34);
            optionbutton.TabIndex = 8;
            optionbutton.Tag = "Option";
            optionbutton.Text = "startTime";
            optionbutton.TextAlign = ContentAlignment.MiddleLeft;
            optionbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            optionbutton.UseVisualStyleBackColor = true;
            optionbutton.Click += optionbutton_Click;
            // 
            // trackbutton
            // 
            trackbutton.FlatAppearance.BorderSize = 0;
            trackbutton.FlatStyle = FlatStyle.Flat;
            trackbutton.Font = new Font("Lucida Sans", 7F);
            trackbutton.IconChar = FontAwesome.Sharp.IconChar.Egg;
            trackbutton.IconColor = Color.Black;
            trackbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            trackbutton.IconSize = 25;
            trackbutton.Location = new Point(0, 160);
            trackbutton.Name = "trackbutton";
            trackbutton.Size = new Size(110, 34);
            trackbutton.TabIndex = 7;
            trackbutton.Tag = "Opacity";
            trackbutton.Text = "startTime";
            trackbutton.TextAlign = ContentAlignment.MiddleLeft;
            trackbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            trackbutton.UseVisualStyleBackColor = true;
            trackbutton.Click += trackbutton_Click;
            // 
            // pauserun
            // 
            pauserun.FlatAppearance.BorderSize = 0;
            pauserun.FlatStyle = FlatStyle.Flat;
            pauserun.Font = new Font("Lucida Sans", 7F);
            pauserun.IconChar = FontAwesome.Sharp.IconChar.Pause;
            pauserun.IconColor = Color.Black;
            pauserun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pauserun.IconSize = 25;
            pauserun.Location = new Point(0, 80);
            pauserun.Name = "pauserun";
            pauserun.Size = new Size(110, 34);
            pauserun.TabIndex = 6;
            pauserun.Tag = "Start";
            pauserun.Text = "startTime";
            pauserun.TextAlign = ContentAlignment.MiddleLeft;
            pauserun.TextImageRelation = TextImageRelation.ImageBeforeText;
            pauserun.UseVisualStyleBackColor = true;
            pauserun.Click += pauserun_Click;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Lucida Sans", 7F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.Location = new Point(0, 120);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(110, 34);
            iconButton3.TabIndex = 4;
            iconButton3.Tag = "Reset";
            iconButton3.Text = "startTime";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // btnmenu
            // 
            btnmenu.FlatAppearance.BorderSize = 0;
            btnmenu.FlatStyle = FlatStyle.Flat;
            btnmenu.Font = new Font("GyeonggiTitle Light", 9.75F);
            btnmenu.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnmenu.IconColor = Color.Black;
            btnmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnmenu.IconSize = 25;
            btnmenu.Location = new Point(0, 40);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(110, 22);
            btnmenu.TabIndex = 1;
            btnmenu.Tag = "Home";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.MouseClick += btnmenu_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.sigaeclock;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(98, 236);
            panel1.TabIndex = 0;
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = Color.FromArgb(192, 0, 0);
            toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Gray;
            ClientSize = new Size(509, 236);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            TopMost = true;
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton exitbotton;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton maxwindow;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TrackBar trackBar2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton trackbutton;
        private FontAwesome.Sharp.IconButton pauserun;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnmenu;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton optionbutton;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton colorbutton;
        private FontAwesome.Sharp.IconButton sizebutton;
        private FontAwesome.Sharp.IconButton timebutton;
       
        private Label label3;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton saveButton;
        private ToolTip toolTip1;
        private ColorDialog colorDialog1;
        private FontAwesome.Sharp.IconButton BGButton1;
        private System.Windows.Forms.Timer timer2;
    }
}
