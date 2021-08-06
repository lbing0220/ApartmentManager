
namespace ApartmentManager
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.clockTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_showtime = new System.Windows.Forms.Label();
            this.lab_reminder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clockTime
            // 
            this.clockTime.Enabled = true;
            this.clockTime.Interval = 250;
            this.clockTime.Tick += new System.EventHandler(this.clockTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // lab_showtime
            // 
            this.lab_showtime.AutoSize = true;
            this.lab_showtime.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_showtime.ForeColor = System.Drawing.Color.Red;
            this.lab_showtime.Location = new System.Drawing.Point(38, 21);
            this.lab_showtime.Name = "lab_showtime";
            this.lab_showtime.Size = new System.Drawing.Size(0, 20);
            this.lab_showtime.TabIndex = 3;
            // 
            // lab_reminder
            // 
            this.lab_reminder.AutoSize = true;
            this.lab_reminder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lab_reminder.Font = new System.Drawing.Font("隶书", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_reminder.ForeColor = System.Drawing.Color.Red;
            this.lab_reminder.Location = new System.Drawing.Point(53, 253);
            this.lab_reminder.Name = "lab_reminder";
            this.lab_reminder.Size = new System.Drawing.Size(294, 20);
            this.lab_reminder.TabIndex = 4;
            this.lab_reminder.Text = "数据库系统加载中，请稍后...";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lab_reminder);
            this.Controls.Add(this.lab_showtime);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.DoubleClick += new System.EventHandler(this.StartForm_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer clockTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lab_showtime;
        private System.Windows.Forms.Label lab_reminder;
    }
}