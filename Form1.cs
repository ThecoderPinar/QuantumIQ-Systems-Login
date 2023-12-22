using System;
using System.Drawing.Drawing2D;
using System.Drawing; 
using System.Windows.Forms; 

namespace QuantumIQSystemsLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0X2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hw, int msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if (tbusername.Text == "" || tbpassword.Text == "")
            //{
            //    MessageBox.Show("Invalid User Name or Password");
            // }
            if (tbusername.Text == "")
            {
                MessageBox.Show("invalid User Name");
                tbusername.Focus();
                return;
            }     
            if (tbpassword.Text == "")
            {
                MessageBox.Show("Invalid Password");
                tbpassword.Focus();
                return;
            }
            MessageBox.Show("Successfully Login");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
