//using ExCSS;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Controls.Ribbon;
using System.Windows.Media.Media3D;
//using clockapp2;
using System.Data;
using calendar;
using FontAwesome.Sharp;
using System.IO;



namespace clockapp
{

    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private Size formSize;
        private int borderSize = 5;
        [System.ComponentModel.Browsable(true)]
        public override bool AutoSize { get; set; }

        int cnt = 0;
        int colorcnt = 0;
        bool Flagstop = false;     // stop을 눌러야 save가 활성화되도록 함
        bool dtplaycheck = false; // 처음 play 버튼을 누른 시간

        DateTime dtstop;
        DateTime dtplay;

        Form2 form2 = new Form2();
        Form3 form3 = new Form3();


        public Form1()
        {

            InitializeComponent();
            form3.Datasendevent3_1 += new Form3.datageteventhadler3_1(this.Dataget3_1);
            label1.BackColor = Color.Transparent;
            // label3.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            // textbox3.Visible = false;

            form2.Show();
            form2.Visible = false;
            form3.Show();
            form3.Visible = false;

            this.TopMost = true;

            // trackBar2.BackColor = Color.Transparent;
            CollapsMenu();
            this.Padding = new Padding(borderSize);
            // this.BackColor = Color.FromArgb(98, 102, 244); // border 색상
            panel5.Visible = false;
            textBox1.Visible = false;


        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //Dllimport 는 외부 dll 함수 호출 이경우는 win 32 api 호출 한다 마우스 캡처를 해제한다? 모르겠다 써봐야알듯
        //entrypoint는 호출할 함수 지정해주는거 

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int Iparam);
        // 이경우는 마찬가지로 sendmessage 호출 윈도우에 메세지를 보낼수 있다
        // hwind 같은 경우는 윈도우의 핸들을 나타내는 매개변수
        // wMsg 는 전송할 아이디 매개변수고
        // wparam iparam 은 추가 데이터 나타내는 매개변수


        private void panel2_MouseDown(object sender, MouseEventArgs e) // 마우스 다운을 통해 핸들기능 추가
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }//마우스 다운 이벤트가 발생하면 호출 
        //sender 는 이벤트를 발생시킨 객체를 나타낸다
        //mouseEventargs 는 마우스 이벤트 정보 포함 마우스 버튼 클릭 위치 알수있음
        //sendmessage 는 특정 윈도우에 메세지를 보넴 0x112 는 윈도우 이동 

        protected override void WndProc(ref Message m)
        {
            const int WM_SETREDRAW = 0x0083;
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST

                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;

                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            if (m.Msg == WM_SETREDRAW && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();



        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 11, 11, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize) ;
                    this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void exitbotton_MouseClick(object sender, MouseEventArgs e)
        {
            // Application.Exit();

            this.Hide();

            int count = 0;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Visible == false)
                    count++;
            }
            //label1.Text = count.ToString(); // Active Forms value :)
            if (count == 3)
            {
                Application.Exit();
            }

        }


        private void maxwindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnmenu_MouseClick(object sender, MouseEventArgs e)
        {
            CollapsMenu();

            if (panel5.Visible == true)
            {
                optionMenucollapso();
            }

        }
        private void CollapsMenu()
        {
            if (this.panel1.Width > 104)
            {
                panel1.Width = 40;
                panel3.Width = 40;
                pictureBox1.Visible = false;
                btnmenu.Dock = DockStyle.Top;
                foreach (Button btnmenu in this.panel3.Controls.OfType<Button>())
                {
                    btnmenu.Text = "";
                    btnmenu.ImageAlign = ContentAlignment.MiddleLeft;
                    btnmenu.Padding = new Padding(0);

                }
            }

            else
            {
                panel1.Width = 105;
                panel3.Width = 105;
                pictureBox1.Visible = true;
                btnmenu.Dock = DockStyle.None;
                foreach (Button btnmenu in this.panel3.Controls.OfType<Button>())
                {
                    btnmenu.Text = "  " + btnmenu.Tag.ToString();
                    btnmenu.ImageAlign = ContentAlignment.MiddleLeft;
                    btnmenu.Padding = new Padding(0, 0, 0, 0);

                }
            }

        }


        private void pauserun_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                pauserun.IconChar = FontAwesome.Sharp.IconChar.Play;
                pauserun.Text = "  Pause";
                stopwatch.Stop();
                Flagstop = true;
                dtstop = DateTime.Now;

            }
            else
            {
                pauserun.IconChar = FontAwesome.Sharp.IconChar.Pause;
                stopwatch.Start();
                Flagstop = false;
                pauserun.Text = "  Play";
                if (dtplaycheck == false)
                {
                    dtplay = DateTime.Now;
                    dtplaycheck = true;
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);

        }

        private void trackbutton_Click(object sender, EventArgs e)
        {
            if (trackBar2.Visible == true)
            {
                trackbutton.IconChar = FontAwesome.Sharp.IconChar.Egg;
                trackBar2.Visible = false;
            }
            else
            {
                trackbutton.IconChar = FontAwesome.Sharp.IconChar.Dove;
                trackBar2.Visible = true;
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trackBar2.Value * 0.01;
        }



        private void optionbutton_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == true)
            {
                panel5.Visible = false;
            }
            else
            {
                panel5.Visible = true;
            }
            optionMenucollapso();

        }

        private void optionMenucollapso()
        {
            if (this.panel1.Width == 40)
            {
                panel5.Width = 40;
                foreach (Button btnmenu in this.panel5.Controls.OfType<Button>())
                {
                    btnmenu.Text = "";
                    btnmenu.ImageAlign = ContentAlignment.MiddleLeft;
                    btnmenu.Padding = new Padding(0);

                }
            }
            else
            {
                panel5.Width = 105;
                foreach (Button btnmenu in this.panel5.Controls.OfType<Button>())
                {
                    btnmenu.Text = "  " + btnmenu.Tag.ToString();
                    btnmenu.ImageAlign = ContentAlignment.MiddleLeft;
                    btnmenu.Padding = new Padding(0, 0, 0, 0);
                }
            }
        }


        private void sizebutton_Click(object sender, EventArgs e)
        {

            cnt++;

            if (cnt == 3)
            {
                cnt = 0;
            }

            if (cnt == 0)
            {
                label1.Font = new Font(label1.Font.FontFamily, 60);
                label3.Font = new Font(label3.Font.FontFamily, 25);
                textBox1.Font = new Font(textBox1.Font.FontFamily, 25);
                trackBar2.Width = 120;
                trackBar2.Location = new Point(236, 130);
                label3.Location = new Point(28, 140);
                label1.Location = new Point(17, 33);
            }
            else if (cnt == 1)
            {
                //label1.Font = new Font(label1.Font.FontFamily, 40);
                //label3.Font = new Font(label3.Font.FontFamily, 20);
                //textBox1.Font = new Font(textBox1.Font.FontFamily, 20);
                //trackBar2.Width = 80;
                //trackBar2.Height = 25;
                //trackBar2.Location = new Point(179, 80);
                //label3.Location = new Point(24, 93);
                //label1.Location = new Point(18, 20);

                label1.Font = new Font(label1.Font.FontFamily, 40);
                label3.Font = new Font(label3.Font.FontFamily, 20);
                trackBar2.Width = 80;
                trackBar2.Height = 25;
                trackBar2.Location = new Point(179, 90);
                label3.Location = new Point(20, 106);
            }
            else if (cnt == 2)
            {
                //label1.Font = new Font(label1.Font.FontFamily, 90);
                //label3.Font = new Font(label3.Font.FontFamily, 30);
                //textBox1.Font = new Font(textBox1.Font.FontFamily, 30);
                //trackBar2.Width = 250;
                //trackBar2.Location = new Point(280, 170);
                //label3.Location = new Point(40, 170);

                label1.Font = new Font(label1.Font.FontFamily, 30);
                label3.Font = new Font(label3.Font.FontFamily, 15);
                textBox1.Font = new Font(textBox1.Font.FontFamily, 15);
                trackBar2.Width = 50;
                trackBar2.Location = new Point(140, 60);
                label3.Location = new Point(19, 73);
                label1.Location = new Point(15, 19);
            }

        }
        private void colorbutton_Click(object sender, EventArgs e)
        {
            colorcnt++;

            if (colorcnt == 3)
            {
                colorcnt = 0;
            }

            if (colorcnt == 2)
            {
                panel3.BackColor = Color.Linen;
                panel5.BackColor = Color.Linen;
                this.BackColor = Color.LightPink;
            }
            else if (colorcnt == 1)
            {
                panel3.BackColor = Color.LightSkyBlue;
                panel5.BackColor = Color.LightSkyBlue;
                this.BackColor = Color.DeepSkyBlue;

            }
            else if (colorcnt == 0)
            {
                panel3.BackColor = Color.LightGray;
                panel5.BackColor = Color.LightGray;
                this.BackColor = Color.Gray;

            }

        }
        private void timebutton_Click(object sender, EventArgs e)
        {
            //  Application.Run(form2);
            form2.Datasendevent += new Form2.datageteventhadler(this.Dataget);
            form2.Show();

        }
        private void Dataget(int x)
        {
            this.Visible = true;
        }

        private void label3_DoubleClick_1(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label3.Visible = false;
            textBox1.Location = label3.Location;
            textBox1.Size = label3.Size;
            textBox1.Text = label3.Text;
            textBox1.Font = label3.Font;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label3.Text = textBox1.Text;
                textBox1.Visible = false;
                label3.Visible = true;
                int i = 0, j = 0;
                int poxx = 0;
                while (label3.Text.Length > j)
                {
                    if (label3.Text[i] == ' ') { i++; }

                    else
                    {
                        poxx++;
                        break;
                    }
                    j++;
                }

                if (label3.Text.Length == 0 || poxx == 0)
                {
                    label3.Text = "                   ";
                }
            }
            return;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Flagstop == true)
            {
                StreamWriter File = new StreamWriter("clockTestapp.txt", append: true);
                File.Write(dtplay.ToString("yy/MM/dd"));
                File.Write("\n");
                File.Write(label3.Text);
                File.Write("\n");
                File.Write(dtplay.ToString("t"));
                File.Write("    ");
                File.Write(dtstop.ToString("t"));
                File.Write("    ");
                File.Write(label1.Text);
                File.Write("\n");
                File.Close();
            }
            else
            {
                ToolTip toolTip = new ToolTip();

                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 300;

                toolTip.SetToolTip(saveButton, "plz press stop button");
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            form3.Show();
        }
        private void Dataget3_1(int x)
        {
            this.Visible = true;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ColorDialog color = new ColorDialog();
                DialogResult result = color.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set form background to the selected color.
                    label1.ForeColor = color.Color;
                }
            }
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ColorDialog color = new ColorDialog();

                DialogResult result = color.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set form background to the selected color.
                    label3.ForeColor = color.Color;
                }
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                ColorDialog color = new ColorDialog();

                DialogResult result = color.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set form background to the selected color.
                    panel3.BackColor = color.Color;
                    panel5.BackColor = color.Color;
                }
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ColorDialog color = new ColorDialog();

                DialogResult result = color.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Set form background to the selected color.
                    this.BackColor = color.Color;
                }
            }
        }

        private void panel4_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && File.Exists(files[0]))
            {
                string filePath = files[0];

                panel4.BackgroundImage = Bitmap.FromFile(filePath);
            }
        }

        private void panel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;

            }
        }

      
    }
}
