
namespace ApartmentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_modify = new System.Windows.Forms.Button();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_floor = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_no = new System.Windows.Forms.Label();
            this.lab_price = new System.Windows.Forms.Label();
            this.cbb_floor = new System.Windows.Forms.ComboBox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.cbb_no = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_booking = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.opendbFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lab_db_reminder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(176, 346);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(100, 42);
            this.btn_modify.TabIndex = 0;
            this.btn_modify.Text = "价格修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("华文楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_title.ForeColor = System.Drawing.Color.Red;
            this.lab_title.Location = new System.Drawing.Point(290, 20);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(237, 30);
            this.lab_title.TabIndex = 1;
            this.lab_title.Text = "杰瑞公寓房间管理";
            this.lab_title.DoubleClick += new System.EventHandler(this.lab_title_DoubleClick);
            // 
            // lab_floor
            // 
            this.lab_floor.AutoSize = true;
            this.lab_floor.Location = new System.Drawing.Point(49, 75);
            this.lab_floor.Name = "lab_floor";
            this.lab_floor.Size = new System.Drawing.Size(68, 17);
            this.lab_floor.TabIndex = 2;
            this.lab_floor.Text = "房间楼层：";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(217, 75);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(68, 17);
            this.lab_type.TabIndex = 3;
            this.lab_type.Text = "房间类型：";
            // 
            // lab_no
            // 
            this.lab_no.AutoSize = true;
            this.lab_no.Location = new System.Drawing.Point(406, 75);
            this.lab_no.Name = "lab_no";
            this.lab_no.Size = new System.Drawing.Size(68, 17);
            this.lab_no.TabIndex = 4;
            this.lab_no.Text = "房间编号：";
            // 
            // lab_price
            // 
            this.lab_price.AutoSize = true;
            this.lab_price.Location = new System.Drawing.Point(595, 75);
            this.lab_price.Name = "lab_price";
            this.lab_price.Size = new System.Drawing.Size(68, 17);
            this.lab_price.TabIndex = 5;
            this.lab_price.Text = "房间价格：";
            // 
            // cbb_floor
            // 
            this.cbb_floor.FormattingEnabled = true;
            this.cbb_floor.Location = new System.Drawing.Point(110, 71);
            this.cbb_floor.Name = "cbb_floor";
            this.cbb_floor.Size = new System.Drawing.Size(100, 25);
            this.cbb_floor.TabIndex = 6;
            this.cbb_floor.TextChanged += new System.EventHandler(this.cbb_floor_TextChanged);
            // 
            // cbb_type
            // 
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Location = new System.Drawing.Point(278, 71);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(121, 25);
            this.cbb_type.TabIndex = 7;
            this.cbb_type.TextChanged += new System.EventHandler(this.cbb_type_TextChanged);
            // 
            // cbb_no
            // 
            this.cbb_no.FormattingEnabled = true;
            this.cbb_no.Location = new System.Drawing.Point(470, 71);
            this.cbb_no.Name = "cbb_no";
            this.cbb_no.Size = new System.Drawing.Size(121, 25);
            this.cbb_no.TabIndex = 8;
            this.cbb_no.TextChanged += new System.EventHandler(this.cbb_no_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(597, 213);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_booking
            // 
            this.btn_booking.Location = new System.Drawing.Point(546, 346);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(100, 42);
            this.btn_booking.TabIndex = 11;
            this.btn_booking.Text = "房间登记";
            this.btn_booking.UseVisualStyleBackColor = true;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(657, 72);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(121, 23);
            this.txt_price.TabIndex = 12;
            this.txt_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_price_KeyDown);
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(361, 346);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(100, 42);
            this.btn_query.TabIndex = 13;
            this.btn_query.Text = "履历查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // opendbFileDialog
            // 
            this.opendbFileDialog.FileName = "openFileDialog1";
            this.opendbFileDialog.Title = "请选择需要备份的Access数据库文件";
            // 
            // lab_db_reminder
            // 
            this.lab_db_reminder.AutoSize = true;
            this.lab_db_reminder.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_db_reminder.Location = new System.Drawing.Point(313, 48);
            this.lab_db_reminder.Name = "lab_db_reminder";
            this.lab_db_reminder.Size = new System.Drawing.Size(190, 16);
            this.lab_db_reminder.TabIndex = 14;
            this.lab_db_reminder.Text = "(数据库备份请双击上方红色字体)√已开启";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lab_db_reminder);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btn_booking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbb_no);
            this.Controls.Add(this.cbb_type);
            this.Controls.Add(this.cbb_floor);
            this.Controls.Add(this.lab_price);
            this.Controls.Add(this.lab_no);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.lab_floor);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.btn_modify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "杰瑞公寓房间管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_floor;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_no;
        private System.Windows.Forms.Label lab_price;
        private System.Windows.Forms.ComboBox cbb_floor;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.ComboBox cbb_no;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.OpenFileDialog opendbFileDialog;
        private System.Windows.Forms.Label lab_db_reminder;
    }
}

