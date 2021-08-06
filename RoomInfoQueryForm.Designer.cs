
namespace ApartmentManager
{
    partial class RoomInfoQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfoQueryForm));
            this.lab_title = new System.Windows.Forms.Label();
            this.cbb_room_no = new System.Windows.Forms.ComboBox();
            this.cbb_floor = new System.Windows.Forms.ComboBox();
            this.lab_room_no = new System.Windows.Forms.Label();
            this.lab_floor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_elec_cost = new System.Windows.Forms.Label();
            this.txt_elec_cost = new System.Windows.Forms.TextBox();
            this.txt_water_cost = new System.Windows.Forms.TextBox();
            this.lab_water_cost = new System.Windows.Forms.Label();
            this.txt_room_cost = new System.Windows.Forms.TextBox();
            this.lab_room_cost = new System.Windows.Forms.Label();
            this.txt_fee_summay = new System.Windows.Forms.TextBox();
            this.lab_fee_summay = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lab_reminder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_title.ForeColor = System.Drawing.Color.Red;
            this.lab_title.Location = new System.Drawing.Point(294, 31);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(210, 24);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "入住信息履历查询";
            this.lab_title.DoubleClick += new System.EventHandler(this.lab_title_DoubleClick);
            // 
            // cbb_room_no
            // 
            this.cbb_room_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_room_no.FormattingEnabled = true;
            this.cbb_room_no.Location = new System.Drawing.Point(524, 77);
            this.cbb_room_no.Name = "cbb_room_no";
            this.cbb_room_no.Size = new System.Drawing.Size(121, 25);
            this.cbb_room_no.TabIndex = 15;
            this.cbb_room_no.TextChanged += new System.EventHandler(this.cbb_room_no_TextChanged);
            // 
            // cbb_floor
            // 
            this.cbb_floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_floor.FormattingEnabled = true;
            this.cbb_floor.Location = new System.Drawing.Point(184, 77);
            this.cbb_floor.Name = "cbb_floor";
            this.cbb_floor.Size = new System.Drawing.Size(100, 25);
            this.cbb_floor.TabIndex = 13;
            this.cbb_floor.TextChanged += new System.EventHandler(this.cbb_floor_TextChanged);
            // 
            // lab_room_no
            // 
            this.lab_room_no.AutoSize = true;
            this.lab_room_no.Location = new System.Drawing.Point(460, 81);
            this.lab_room_no.Name = "lab_room_no";
            this.lab_room_no.Size = new System.Drawing.Size(68, 17);
            this.lab_room_no.TabIndex = 11;
            this.lab_room_no.Text = "房间编号：";
            // 
            // lab_floor
            // 
            this.lab_floor.AutoSize = true;
            this.lab_floor.Location = new System.Drawing.Point(123, 81);
            this.lab_floor.Name = "lab_floor";
            this.lab_floor.Size = new System.Drawing.Size(68, 17);
            this.lab_floor.TabIndex = 9;
            this.lab_floor.Text = "房间楼层：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(733, 207);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lab_elec_cost
            // 
            this.lab_elec_cost.AutoSize = true;
            this.lab_elec_cost.Location = new System.Drawing.Point(79, 366);
            this.lab_elec_cost.Name = "lab_elec_cost";
            this.lab_elec_cost.Size = new System.Drawing.Size(68, 17);
            this.lab_elec_cost.TabIndex = 17;
            this.lab_elec_cost.Text = "电费合计：";
            // 
            // txt_elec_cost
            // 
            this.txt_elec_cost.Location = new System.Drawing.Point(147, 363);
            this.txt_elec_cost.Name = "txt_elec_cost";
            this.txt_elec_cost.Size = new System.Drawing.Size(69, 23);
            this.txt_elec_cost.TabIndex = 18;
            // 
            // txt_water_cost
            // 
            this.txt_water_cost.Location = new System.Drawing.Point(315, 363);
            this.txt_water_cost.Name = "txt_water_cost";
            this.txt_water_cost.Size = new System.Drawing.Size(69, 23);
            this.txt_water_cost.TabIndex = 20;
            // 
            // lab_water_cost
            // 
            this.lab_water_cost.AutoSize = true;
            this.lab_water_cost.Location = new System.Drawing.Point(247, 366);
            this.lab_water_cost.Name = "lab_water_cost";
            this.lab_water_cost.Size = new System.Drawing.Size(68, 17);
            this.lab_water_cost.TabIndex = 19;
            this.lab_water_cost.Text = "水费合计：";
            // 
            // txt_room_cost
            // 
            this.txt_room_cost.Location = new System.Drawing.Point(483, 363);
            this.txt_room_cost.Name = "txt_room_cost";
            this.txt_room_cost.Size = new System.Drawing.Size(69, 23);
            this.txt_room_cost.TabIndex = 22;
            // 
            // lab_room_cost
            // 
            this.lab_room_cost.AutoSize = true;
            this.lab_room_cost.Location = new System.Drawing.Point(415, 366);
            this.lab_room_cost.Name = "lab_room_cost";
            this.lab_room_cost.Size = new System.Drawing.Size(68, 17);
            this.lab_room_cost.TabIndex = 21;
            this.lab_room_cost.Text = "房费合计：";
            // 
            // txt_fee_summay
            // 
            this.txt_fee_summay.Location = new System.Drawing.Point(651, 363);
            this.txt_fee_summay.Name = "txt_fee_summay";
            this.txt_fee_summay.Size = new System.Drawing.Size(69, 23);
            this.txt_fee_summay.TabIndex = 24;
            // 
            // lab_fee_summay
            // 
            this.lab_fee_summay.AutoSize = true;
            this.lab_fee_summay.Location = new System.Drawing.Point(583, 366);
            this.lab_fee_summay.Name = "lab_fee_summay";
            this.lab_fee_summay.Size = new System.Drawing.Size(68, 17);
            this.lab_fee_summay.TabIndex = 23;
            this.lab_fee_summay.Text = "综合收入：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(174, 404);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 34);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(534, 404);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 34);
            this.btn_edit.TabIndex = 26;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lab_reminder
            // 
            this.lab_reminder.AutoSize = true;
            this.lab_reminder.Font = new System.Drawing.Font("华文楷体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_reminder.ForeColor = System.Drawing.Color.Red;
            this.lab_reminder.Location = new System.Drawing.Point(224, 111);
            this.lab_reminder.Name = "lab_reminder";
            this.lab_reminder.Size = new System.Drawing.Size(0, 17);
            this.lab_reminder.TabIndex = 27;
            // 
            // RoomInfoQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_reminder);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_fee_summay);
            this.Controls.Add(this.lab_fee_summay);
            this.Controls.Add(this.txt_room_cost);
            this.Controls.Add(this.lab_room_cost);
            this.Controls.Add(this.txt_water_cost);
            this.Controls.Add(this.lab_water_cost);
            this.Controls.Add(this.txt_elec_cost);
            this.Controls.Add(this.lab_elec_cost);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbb_room_no);
            this.Controls.Add(this.cbb_floor);
            this.Controls.Add(this.lab_room_no);
            this.Controls.Add(this.lab_floor);
            this.Controls.Add(this.lab_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomInfoQueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入住信息履历查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomInfoQueryForm_FormClosing);
            this.Load += new System.EventHandler(this.RoomInfoQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.ComboBox cbb_room_no;
        private System.Windows.Forms.ComboBox cbb_floor;
        private System.Windows.Forms.Label lab_room_no;
        private System.Windows.Forms.Label lab_floor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_elec_cost;
        private System.Windows.Forms.TextBox txt_elec_cost;
        private System.Windows.Forms.TextBox txt_water_cost;
        private System.Windows.Forms.Label lab_water_cost;
        private System.Windows.Forms.TextBox txt_room_cost;
        private System.Windows.Forms.Label lab_room_cost;
        private System.Windows.Forms.TextBox txt_fee_summay;
        private System.Windows.Forms.Label lab_fee_summay;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lab_reminder;
    }
}