namespace calendar
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel2 = new Panel();
            maxwindow = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            exitbotton = new FontAwesome.Sharp.IconButton();
            trackBar2 = new TrackBar();
            panel4 = new Panel();
            panel5 = new Panel();
            stopwatchbtton = new FontAwesome.Sharp.IconButton();
            backgroundbutton = new FontAwesome.Sharp.IconButton();
            colorbutton = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            panel6 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            sizebutton = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            optionbutton = new FontAwesome.Sharp.IconButton();
            trackbutton = new FontAwesome.Sharp.IconButton();
            btnmenu = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
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
            panel2.Size = new Size(373, 40);
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
            maxwindow.Location = new Point(281, 0);
            maxwindow.Name = "maxwindow";
            maxwindow.Size = new Size(46, 40);
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
            iconButton9.Location = new Point(6, 9);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(95, 23);
            iconButton9.TabIndex = 3;
            iconButton9.Text = "DASHBOARD";
            iconButton9.UseVisualStyleBackColor = false;
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
            exitbotton.Location = new Point(327, 0);
            exitbotton.Name = "exitbotton";
            exitbotton.Size = new Size(46, 40);
            exitbotton.TabIndex = 2;
            exitbotton.UseVisualStyleBackColor = true;
         
            exitbotton.MouseClick += exitbotton_MouseClick;
            // 
            // trackBar2
            // 
            trackBar2.BackColor = Color.LightGray;
            trackBar2.Location = new Point(240, 143);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 30;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(113, 45);
            trackBar2.TabIndex = 5;
            trackBar2.Value = 30;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.BackColor = Color.Snow;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(monthCalendar1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(trackBar2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(98, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(373, 441);
            panel4.TabIndex = 2;
            panel4.DragDrop += panel4_DragDrop;
            panel4.DragEnter += panel4_DragEnter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(stopwatchbtton);
            panel5.Controls.Add(backgroundbutton);
            panel5.Controls.Add(colorbutton);
            panel5.Location = new Point(-1, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(101, 104);
            panel5.TabIndex = 6;
            // 
            // stopwatchbtton
            // 
            stopwatchbtton.FlatAppearance.BorderSize = 0;
            stopwatchbtton.FlatStyle = FlatStyle.Flat;
            stopwatchbtton.Font = new Font("Lucida Sans", 7F);
            stopwatchbtton.IconChar = FontAwesome.Sharp.IconChar.Hourglass1;
            stopwatchbtton.IconColor = Color.Black;
            stopwatchbtton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            stopwatchbtton.IconSize = 25;
            stopwatchbtton.ImageAlign = ContentAlignment.MiddleLeft;
            stopwatchbtton.Location = new Point(0, 70);
            stopwatchbtton.Name = "stopwatchbtton";
            stopwatchbtton.Size = new Size(112, 34);
            stopwatchbtton.TabIndex = 12;
            stopwatchbtton.Tag = "Stopwatch";
            stopwatchbtton.Text = "startTime";
            stopwatchbtton.TextAlign = ContentAlignment.MiddleLeft;
            stopwatchbtton.TextImageRelation = TextImageRelation.ImageBeforeText;
            stopwatchbtton.UseVisualStyleBackColor = true;
            stopwatchbtton.Click += iconButton1_Click;
            // 
            // backgroundbutton
            // 
            backgroundbutton.FlatAppearance.BorderSize = 0;
            backgroundbutton.FlatStyle = FlatStyle.Flat;
            backgroundbutton.Font = new Font("Lucida Sans", 7F);
            backgroundbutton.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            backgroundbutton.IconColor = Color.Black;
            backgroundbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            backgroundbutton.IconSize = 25;
            backgroundbutton.ImageAlign = ContentAlignment.MiddleLeft;
            backgroundbutton.Location = new Point(0, 35);
            backgroundbutton.Name = "backgroundbutton";
            backgroundbutton.Size = new Size(112, 29);
            backgroundbutton.TabIndex = 9;
            backgroundbutton.Tag = "Background";
            backgroundbutton.Text = "startTime";
            backgroundbutton.TextAlign = ContentAlignment.MiddleLeft;
            backgroundbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            backgroundbutton.UseVisualStyleBackColor = true;
            backgroundbutton.Click += backgroundbutton_Click;
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
            colorbutton.Location = new Point(0, 0);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("GyeonggiTitle Medium", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(32, 145);
            label3.Name = "label3";
            label3.Size = new Size(0, 33);
            label3.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(19, 26);
            monthCalendar1.Margin = new Padding(15);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.AutoScrollMargin = new Size(100, 100);
            panel6.AutoScrollMinSize = new Size(150, 150);
            panel6.BackColor = Color.Snow;
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(19, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(334, 220);
            panel6.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("GyeonggiTitle Bold", 9F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(234, 69);
            label6.Name = "label6";
            label6.Size = new Size(46, 12);
            label6.TabIndex = 17;
            label6.Text = "Record";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("GyeonggiTitle Bold", 9F, FontStyle.Bold | FontStyle.Underline);
            label5.Location = new Point(128, 69);
            label5.Name = "label5";
            label5.Size = new Size(75, 12);
            label5.TabIndex = 16;
            label5.Text = "Stoped time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("GyeonggiTitle Bold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 129);
            label2.Location = new Point(30, 69);
            label2.Name = "label2";
            label2.Size = new Size(78, 12);
            label2.TabIndex = 15;
            label2.Text = "Started time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("GyeonggiTitle Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 129);
            label4.Location = new Point(11, 105);
            label4.Name = "label4";
            label4.Size = new Size(183, 19);
            label4.TabIndex = 14;
            label4.Text = "Please Select a date;";
            label4.MouseClick += label4_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("GyeonggiTitleV Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 12;
            label1.Text = "label1";
            label1.Paint += label1_Paint;
            // 
            // sizebutton
            // 
            sizebutton.FlatAppearance.BorderSize = 0;
            sizebutton.FlatStyle = FlatStyle.Flat;
            sizebutton.Font = new Font("Lucida Sans", 7F);
            sizebutton.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            sizebutton.IconColor = Color.Black;
            sizebutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sizebutton.IconSize = 25;
            sizebutton.ImageAlign = ContentAlignment.MiddleLeft;
            sizebutton.Location = new Point(0, 114);
            sizebutton.Name = "sizebutton";
            sizebutton.Size = new Size(110, 34);
            sizebutton.TabIndex = 7;
            sizebutton.Tag = "Calendar";
            sizebutton.Text = "startTime";
            sizebutton.TextAlign = ContentAlignment.MiddleLeft;
            sizebutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            sizebutton.UseVisualStyleBackColor = true;
            sizebutton.Click += sizebutton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(optionbutton);
            panel3.Controls.Add(trackbutton);
            panel3.Controls.Add(sizebutton);
            panel3.Controls.Add(btnmenu);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 481);
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
            optionbutton.Location = new Point(0, 146);
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
            trackbutton.Location = new Point(0, 83);
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            panel1.Size = new Size(98, 481);
            panel1.TabIndex = 0;
         
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Gray;
            ClientSize = new Size(471, 481);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form3";
            TopMost = true;
            
            Resize += Form1_Resize;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private TrackBar trackBar2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton trackbutton;
        private FontAwesome.Sharp.IconButton btnmenu;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton optionbutton;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton colorbutton;
        private FontAwesome.Sharp.IconButton sizebutton;
        private FontAwesome.Sharp.IconButton backgroundbutton;
       
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private FontAwesome.Sharp.IconButton stopwatchbtton;
        private Label label4;
        private Panel panel6;
        private Label label6;
        private Label label5;
        private Label label2;
    }
}
