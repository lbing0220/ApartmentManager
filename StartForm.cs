using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ApartmentManager
{
    
    public partial class StartForm : Form
    {
        private int i;
        private bool stopFlag = false;
        public StartForm()
        {
            InitializeComponent();
            i = 8;
        }
        
        private void OpenNewForm()
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void clockTime_Tick(object sender, EventArgs e)
        {
            lab_showtime.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lab_reminder.Text = lab_reminder.Text.Substring(1, lab_reminder.Text.Length - 1) + lab_reminder.Text[0];
            if (!stopFlag)
            {
                if (i == 0)
                {
                    stopFlag = true;
                    OpenNewForm();
                }
                else
                {
                    i--;
                }
            }
        }

        private void lab_reminder_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void StartForm_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            lab_reminder.Parent = pictureBox1;
            lab_showtime.Parent = pictureBox1;
            lab_reminder.BackColor = Color.Transparent;
            lab_showtime.BackColor = Color.Transparent;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
