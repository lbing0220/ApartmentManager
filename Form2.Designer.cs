
namespace ApartmentManager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_db_id = new System.Windows.Forms.Label();
            this.txt_db_id = new System.Windows.Forms.TextBox();
            this.lab_room_floor = new System.Windows.Forms.Label();
            this.cbb_room_floor = new System.Windows.Forms.ComboBox();
            this.lab_room_no = new System.Windows.Forms.Label();
            this.cbb_room_no = new System.Windows.Forms.ComboBox();
            this.lab_owner_name = new System.Windows.Forms.Label();
            this.txt_owner_name = new System.Windows.Forms.TextBox();
            this.lab_owner_count = new System.Windows.Forms.Label();
            this.txt_owner_count = new System.Windows.Forms.TextBox();
            this.lab_owner_id = new System.Windows.Forms.Label();
            this.txt_owner_id = new System.Windows.Forms.TextBox();
            this.lab_checkin_date = new System.Windows.Forms.Label();
            this.dtp_checkin_date = new System.Windows.Forms.DateTimePicker();
            this.lab_checkout_date = new System.Windows.Forms.Label();
            this.dtp_checkout_date = new System.Windows.Forms.DateTimePicker();
            this.lab_elec_start = new System.Windows.Forms.Label();
            this.txt_elec_start = new System.Windows.Forms.TextBox();
            this.lab_elec_end = new System.Windows.Forms.Label();
            this.txt_elec_end = new System.Windows.Forms.TextBox();
            this.lab_elec_unit_price = new System.Windows.Forms.Label();
            this.txt_elec_unit_price = new System.Windows.Forms.TextBox();
            this.lab_elec_cost = new System.Windows.Forms.Label();
            this.txt_elec_cost = new System.Windows.Forms.TextBox();
            this.btn_elec_calc = new System.Windows.Forms.Button();
            this.btn_water_calc = new System.Windows.Forms.Button();
            this.txt_water_cost = new System.Windows.Forms.TextBox();
            this.lab_water_cost = new System.Windows.Forms.Label();
            this.txt_water_unit_price = new System.Windows.Forms.TextBox();
            this.lab_water_unit_price = new System.Windows.Forms.Label();
            this.txt_water_end = new System.Windows.Forms.TextBox();
            this.lab_water_end = new System.Windows.Forms.Label();
            this.txt_water_start = new System.Windows.Forms.TextBox();
            this.lab_water_start = new System.Windows.Forms.Label();
            this.lab_room_money = new System.Windows.Forms.Label();
            this.txt_room_money = new System.Windows.Forms.TextBox();
            this.lab_cost_summary = new System.Windows.Forms.Label();
            this.txt_room_summary = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lab_reminder = new System.Windows.Forms.Label();
            this.lab_duration = new System.Windows.Forms.Label();
            this.cbb_duration = new System.Windows.Forms.ComboBox();
            this.txt_room_money2 = new System.Windows.Forms.TextBox();
            this.lab_room_money2 = new System.Windows.Forms.Label();
            this.lab_month = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_phone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("楷体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_title.ForeColor = System.Drawing.Color.Red;
            this.lab_title.Location = new System.Drawing.Point(231, 9);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(345, 40);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "房间租客信息登记";
            this.lab_title.DoubleClick += new System.EventHandler(this.lab_title_DoubleClick);
            // 
            // lab_db_id
            // 
            this.lab_db_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_db_id.AutoSize = true;
            this.lab_db_id.Location = new System.Drawing.Point(63, 92);
            this.lab_db_id.Name = "lab_db_id";
            this.lab_db_id.Size = new System.Drawing.Size(44, 17);
            this.lab_db_id.TabIndex = 1;
            this.lab_db_id.Text = "编号：";
            // 
            // txt_db_id
            // 
            this.txt_db_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_db_id.Location = new System.Drawing.Point(149, 89);
            this.txt_db_id.Name = "txt_db_id";
            this.txt_db_id.ReadOnly = true;
            this.txt_db_id.Size = new System.Drawing.Size(68, 23);
            this.txt_db_id.TabIndex = 2;
            // 
            // lab_room_floor
            // 
            this.lab_room_floor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_room_floor.AutoSize = true;
            this.lab_room_floor.Location = new System.Drawing.Point(291, 92);
            this.lab_room_floor.Name = "lab_room_floor";
            this.lab_room_floor.Size = new System.Drawing.Size(68, 17);
            this.lab_room_floor.TabIndex = 3;
            this.lab_room_floor.Text = "房间楼层：";
            // 
            // cbb_room_floor
            // 
            this.cbb_room_floor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_room_floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_room_floor.FormattingEnabled = true;
            this.cbb_room_floor.Location = new System.Drawing.Point(365, 88);
            this.cbb_room_floor.Name = "cbb_room_floor";
            this.cbb_room_floor.Size = new System.Drawing.Size(68, 25);
            this.cbb_room_floor.TabIndex = 4;
            this.cbb_room_floor.TextChanged += new System.EventHandler(this.cbb_room_floor_TextChanged);
            // 
            // lab_room_no
            // 
            this.lab_room_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_room_no.AutoSize = true;
            this.lab_room_no.Location = new System.Drawing.Point(482, 92);
            this.lab_room_no.Name = "lab_room_no";
            this.lab_room_no.Size = new System.Drawing.Size(68, 17);
            this.lab_room_no.TabIndex = 5;
            this.lab_room_no.Text = "房间编号：";
            // 
            // cbb_room_no
            // 
            this.cbb_room_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_room_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_room_no.FormattingEnabled = true;
            this.cbb_room_no.Location = new System.Drawing.Point(568, 88);
            this.cbb_room_no.Name = "cbb_room_no";
            this.cbb_room_no.Size = new System.Drawing.Size(68, 25);
            this.cbb_room_no.TabIndex = 6;
            // 
            // lab_owner_name
            // 
            this.lab_owner_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_owner_name.AutoSize = true;
            this.lab_owner_name.Location = new System.Drawing.Point(63, 146);
            this.lab_owner_name.Name = "lab_owner_name";
            this.lab_owner_name.Size = new System.Drawing.Size(56, 17);
            this.lab_owner_name.TabIndex = 7;
            this.lab_owner_name.Text = "入住人：";
            // 
            // txt_owner_name
            // 
            this.txt_owner_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_owner_name.Location = new System.Drawing.Point(130, 143);
            this.txt_owner_name.Name = "txt_owner_name";
            this.txt_owner_name.Size = new System.Drawing.Size(60, 23);
            this.txt_owner_name.TabIndex = 8;
            // 
            // lab_owner_count
            // 
            this.lab_owner_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_owner_count.AutoSize = true;
            this.lab_owner_count.Location = new System.Drawing.Point(214, 146);
            this.lab_owner_count.Name = "lab_owner_count";
            this.lab_owner_count.Size = new System.Drawing.Size(68, 17);
            this.lab_owner_count.TabIndex = 9;
            this.lab_owner_count.Text = "入住人数：";
            // 
            // txt_owner_count
            // 
            this.txt_owner_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_owner_count.Location = new System.Drawing.Point(279, 143);
            this.txt_owner_count.Name = "txt_owner_count";
            this.txt_owner_count.Size = new System.Drawing.Size(32, 23);
            this.txt_owner_count.TabIndex = 10;
            // 
            // lab_owner_id
            // 
            this.lab_owner_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_owner_id.AutoSize = true;
            this.lab_owner_id.Location = new System.Drawing.Point(482, 146);
            this.lab_owner_id.Name = "lab_owner_id";
            this.lab_owner_id.Size = new System.Drawing.Size(92, 17);
            this.lab_owner_id.TabIndex = 13;
            this.lab_owner_id.Text = "租客身份证号：";
            // 
            // txt_owner_id
            // 
            this.txt_owner_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_owner_id.Location = new System.Drawing.Point(568, 143);
            this.txt_owner_id.Name = "txt_owner_id";
            this.txt_owner_id.Size = new System.Drawing.Size(165, 23);
            this.txt_owner_id.TabIndex = 14;
            // 
            // lab_checkin_date
            // 
            this.lab_checkin_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_checkin_date.AutoSize = true;
            this.lab_checkin_date.Location = new System.Drawing.Point(63, 200);
            this.lab_checkin_date.Name = "lab_checkin_date";
            this.lab_checkin_date.Size = new System.Drawing.Size(68, 17);
            this.lab_checkin_date.TabIndex = 15;
            this.lab_checkin_date.Text = "入住时间：";
            // 
            // dtp_checkin_date
            // 
            this.dtp_checkin_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_checkin_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_checkin_date.Location = new System.Drawing.Point(149, 197);
            this.dtp_checkin_date.Name = "dtp_checkin_date";
            this.dtp_checkin_date.Size = new System.Drawing.Size(100, 23);
            this.dtp_checkin_date.TabIndex = 16;
            this.dtp_checkin_date.ValueChanged += new System.EventHandler(this.dtp_checkin_date_ValueChanged);
            // 
            // lab_checkout_date
            // 
            this.lab_checkout_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_checkout_date.AutoSize = true;
            this.lab_checkout_date.Location = new System.Drawing.Point(482, 200);
            this.lab_checkout_date.Name = "lab_checkout_date";
            this.lab_checkout_date.Size = new System.Drawing.Size(68, 17);
            this.lab_checkout_date.TabIndex = 20;
            this.lab_checkout_date.Text = "退房时间：";
            // 
            // dtp_checkout_date
            // 
            this.dtp_checkout_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_checkout_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_checkout_date.Location = new System.Drawing.Point(568, 197);
            this.dtp_checkout_date.Name = "dtp_checkout_date";
            this.dtp_checkout_date.Size = new System.Drawing.Size(165, 23);
            this.dtp_checkout_date.TabIndex = 21;
            // 
            // lab_elec_start
            // 
            this.lab_elec_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_elec_start.AutoSize = true;
            this.lab_elec_start.Location = new System.Drawing.Point(63, 254);
            this.lab_elec_start.Name = "lab_elec_start";
            this.lab_elec_start.Size = new System.Drawing.Size(92, 17);
            this.lab_elec_start.TabIndex = 22;
            this.lab_elec_start.Text = "入住电表读数：";
            // 
            // txt_elec_start
            // 
            this.txt_elec_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_elec_start.Location = new System.Drawing.Point(149, 251);
            this.txt_elec_start.Name = "txt_elec_start";
            this.txt_elec_start.Size = new System.Drawing.Size(62, 23);
            this.txt_elec_start.TabIndex = 23;
            this.txt_elec_start.TextChanged += new System.EventHandler(this.txt_elec_start_TextChanged);
            this.txt_elec_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_elec_start_KeyPress);
            // 
            // lab_elec_end
            // 
            this.lab_elec_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_elec_end.AutoSize = true;
            this.lab_elec_end.Location = new System.Drawing.Point(231, 254);
            this.lab_elec_end.Name = "lab_elec_end";
            this.lab_elec_end.Size = new System.Drawing.Size(92, 17);
            this.lab_elec_end.TabIndex = 24;
            this.lab_elec_end.Text = "退房电表读数：";
            // 
            // txt_elec_end
            // 
            this.txt_elec_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_elec_end.Location = new System.Drawing.Point(329, 251);
            this.txt_elec_end.Name = "txt_elec_end";
            this.txt_elec_end.Size = new System.Drawing.Size(62, 23);
            this.txt_elec_end.TabIndex = 25;
            this.txt_elec_end.TextChanged += new System.EventHandler(this.txt_elec_end_TextChanged);
            this.txt_elec_end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_elec_end_KeyPress);
            // 
            // lab_elec_unit_price
            // 
            this.lab_elec_unit_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_elec_unit_price.AutoSize = true;
            this.lab_elec_unit_price.Location = new System.Drawing.Point(438, 254);
            this.lab_elec_unit_price.Name = "lab_elec_unit_price";
            this.lab_elec_unit_price.Size = new System.Drawing.Size(68, 17);
            this.lab_elec_unit_price.TabIndex = 26;
            this.lab_elec_unit_price.Text = "电费单价：";
            // 
            // txt_elec_unit_price
            // 
            this.txt_elec_unit_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_elec_unit_price.Location = new System.Drawing.Point(514, 251);
            this.txt_elec_unit_price.Name = "txt_elec_unit_price";
            this.txt_elec_unit_price.ReadOnly = true;
            this.txt_elec_unit_price.Size = new System.Drawing.Size(62, 23);
            this.txt_elec_unit_price.TabIndex = 27;
            this.txt_elec_unit_price.TextChanged += new System.EventHandler(this.txt_elec_unit_price_TextChanged);
            this.txt_elec_unit_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_elec_unit_price_KeyPress);
            // 
            // lab_elec_cost
            // 
            this.lab_elec_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_elec_cost.AutoSize = true;
            this.lab_elec_cost.Location = new System.Drawing.Point(592, 254);
            this.lab_elec_cost.Name = "lab_elec_cost";
            this.lab_elec_cost.Size = new System.Drawing.Size(68, 17);
            this.lab_elec_cost.TabIndex = 28;
            this.lab_elec_cost.Text = "电费总额：";
            // 
            // txt_elec_cost
            // 
            this.txt_elec_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_elec_cost.Location = new System.Drawing.Point(653, 251);
            this.txt_elec_cost.Name = "txt_elec_cost";
            this.txt_elec_cost.ReadOnly = true;
            this.txt_elec_cost.Size = new System.Drawing.Size(62, 23);
            this.txt_elec_cost.TabIndex = 29;
            this.txt_elec_cost.TextChanged += new System.EventHandler(this.txt_elec_cost_TextChanged);
            // 
            // btn_elec_calc
            // 
            this.btn_elec_calc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_elec_calc.Location = new System.Drawing.Point(735, 251);
            this.btn_elec_calc.Name = "btn_elec_calc";
            this.btn_elec_calc.Size = new System.Drawing.Size(42, 23);
            this.btn_elec_calc.TabIndex = 30;
            this.btn_elec_calc.Text = "计算";
            this.btn_elec_calc.UseVisualStyleBackColor = true;
            this.btn_elec_calc.Click += new System.EventHandler(this.btn_elec_calc_Click);
            // 
            // btn_water_calc
            // 
            this.btn_water_calc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_water_calc.Location = new System.Drawing.Point(735, 305);
            this.btn_water_calc.Name = "btn_water_calc";
            this.btn_water_calc.Size = new System.Drawing.Size(42, 23);
            this.btn_water_calc.TabIndex = 39;
            this.btn_water_calc.Text = "计算";
            this.btn_water_calc.UseVisualStyleBackColor = true;
            this.btn_water_calc.Click += new System.EventHandler(this.btn_water_calc_Click);
            // 
            // txt_water_cost
            // 
            this.txt_water_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_water_cost.Location = new System.Drawing.Point(653, 305);
            this.txt_water_cost.Name = "txt_water_cost";
            this.txt_water_cost.ReadOnly = true;
            this.txt_water_cost.Size = new System.Drawing.Size(62, 23);
            this.txt_water_cost.TabIndex = 38;
            this.txt_water_cost.TextChanged += new System.EventHandler(this.txt_water_cost_TextChanged);
            // 
            // lab_water_cost
            // 
            this.lab_water_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_water_cost.AutoSize = true;
            this.lab_water_cost.Location = new System.Drawing.Point(592, 308);
            this.lab_water_cost.Name = "lab_water_cost";
            this.lab_water_cost.Size = new System.Drawing.Size(68, 17);
            this.lab_water_cost.TabIndex = 37;
            this.lab_water_cost.Text = "水费总额：";
            // 
            // txt_water_unit_price
            // 
            this.txt_water_unit_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_water_unit_price.Location = new System.Drawing.Point(512, 305);
            this.txt_water_unit_price.Name = "txt_water_unit_price";
            this.txt_water_unit_price.ReadOnly = true;
            this.txt_water_unit_price.Size = new System.Drawing.Size(62, 23);
            this.txt_water_unit_price.TabIndex = 36;
            this.txt_water_unit_price.TextChanged += new System.EventHandler(this.txt_water_unit_price_TextChanged);
            this.txt_water_unit_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_water_unit_price_KeyPress);
            // 
            // lab_water_unit_price
            // 
            this.lab_water_unit_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_water_unit_price.AutoSize = true;
            this.lab_water_unit_price.Location = new System.Drawing.Point(438, 308);
            this.lab_water_unit_price.Name = "lab_water_unit_price";
            this.lab_water_unit_price.Size = new System.Drawing.Size(68, 17);
            this.lab_water_unit_price.TabIndex = 35;
            this.lab_water_unit_price.Text = "水费单价：";
            // 
            // txt_water_end
            // 
            this.txt_water_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_water_end.Location = new System.Drawing.Point(329, 305);
            this.txt_water_end.Name = "txt_water_end";
            this.txt_water_end.Size = new System.Drawing.Size(62, 23);
            this.txt_water_end.TabIndex = 34;
            this.txt_water_end.TextChanged += new System.EventHandler(this.txt_water_end_TextChanged);
            this.txt_water_end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_water_end_KeyPress);
            // 
            // lab_water_end
            // 
            this.lab_water_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_water_end.AutoSize = true;
            this.lab_water_end.Location = new System.Drawing.Point(231, 308);
            this.lab_water_end.Name = "lab_water_end";
            this.lab_water_end.Size = new System.Drawing.Size(92, 17);
            this.lab_water_end.TabIndex = 33;
            this.lab_water_end.Text = "退房水表读数：";
            // 
            // txt_water_start
            // 
            this.txt_water_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_water_start.Location = new System.Drawing.Point(149, 305);
            this.txt_water_start.Name = "txt_water_start";
            this.txt_water_start.Size = new System.Drawing.Size(62, 23);
            this.txt_water_start.TabIndex = 32;
            this.txt_water_start.TextChanged += new System.EventHandler(this.txt_water_start_TextChanged);
            this.txt_water_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_water_start_KeyPress);
            // 
            // lab_water_start
            // 
            this.lab_water_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_water_start.AutoSize = true;
            this.lab_water_start.Location = new System.Drawing.Point(63, 308);
            this.lab_water_start.Name = "lab_water_start";
            this.lab_water_start.Size = new System.Drawing.Size(92, 17);
            this.lab_water_start.TabIndex = 31;
            this.lab_water_start.Text = "入住水表读数：";
            // 
            // lab_room_money
            // 
            this.lab_room_money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_room_money.AutoSize = true;
            this.lab_room_money.Location = new System.Drawing.Point(63, 362);
            this.lab_room_money.Name = "lab_room_money";
            this.lab_room_money.Size = new System.Drawing.Size(68, 17);
            this.lab_room_money.TabIndex = 40;
            this.lab_room_money.Text = "已交房租：";
            // 
            // txt_room_money
            // 
            this.txt_room_money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_room_money.Location = new System.Drawing.Point(149, 359);
            this.txt_room_money.Name = "txt_room_money";
            this.txt_room_money.ReadOnly = true;
            this.txt_room_money.Size = new System.Drawing.Size(62, 23);
            this.txt_room_money.TabIndex = 41;
            this.txt_room_money.TextChanged += new System.EventHandler(this.txt_room_money_TextChanged);
            this.txt_room_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_room_money_KeyPress);
            // 
            // lab_cost_summary
            // 
            this.lab_cost_summary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_cost_summary.AutoSize = true;
            this.lab_cost_summary.Location = new System.Drawing.Point(493, 362);
            this.lab_cost_summary.Name = "lab_cost_summary";
            this.lab_cost_summary.Size = new System.Drawing.Size(80, 17);
            this.lab_cost_summary.TabIndex = 44;
            this.lab_cost_summary.Text = "房间总费用：";
            // 
            // txt_room_summary
            // 
            this.txt_room_summary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_room_summary.Location = new System.Drawing.Point(579, 359);
            this.txt_room_summary.Name = "txt_room_summary";
            this.txt_room_summary.ReadOnly = true;
            this.txt_room_summary.Size = new System.Drawing.Size(100, 23);
            this.txt_room_summary.TabIndex = 45;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.Location = new System.Drawing.Point(514, 404);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(91, 34);
            this.btn_OK.TabIndex = 47;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.Location = new System.Drawing.Point(207, 404);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 34);
            this.btn_cancel.TabIndex = 46;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lab_reminder
            // 
            this.lab_reminder.AutoSize = true;
            this.lab_reminder.Location = new System.Drawing.Point(285, 49);
            this.lab_reminder.Name = "lab_reminder";
            this.lab_reminder.Size = new System.Drawing.Size(236, 17);
            this.lab_reminder.TabIndex = 48;
            this.lab_reminder.Text = "（双击以上红色字体可修改水电费用单价）";
            // 
            // lab_duration
            // 
            this.lab_duration.AutoSize = true;
            this.lab_duration.Location = new System.Drawing.Point(291, 200);
            this.lab_duration.Name = "lab_duration";
            this.lab_duration.Size = new System.Drawing.Size(59, 17);
            this.lab_duration.TabIndex = 17;
            this.lab_duration.Text = "入住时长:";
            // 
            // cbb_duration
            // 
            this.cbb_duration.FormattingEnabled = true;
            this.cbb_duration.Location = new System.Drawing.Point(365, 196);
            this.cbb_duration.Name = "cbb_duration";
            this.cbb_duration.Size = new System.Drawing.Size(37, 25);
            this.cbb_duration.TabIndex = 18;
            this.cbb_duration.TextChanged += new System.EventHandler(this.cbb_duration_TextChanged);
            // 
            // txt_room_money2
            // 
            this.txt_room_money2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_room_money2.Location = new System.Drawing.Point(329, 359);
            this.txt_room_money2.Name = "txt_room_money2";
            this.txt_room_money2.Size = new System.Drawing.Size(62, 23);
            this.txt_room_money2.TabIndex = 43;
            this.txt_room_money2.TextChanged += new System.EventHandler(this.txt_room_money2_TextChanged);
            // 
            // lab_room_money2
            // 
            this.lab_room_money2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_room_money2.AutoSize = true;
            this.lab_room_money2.Location = new System.Drawing.Point(243, 362);
            this.lab_room_money2.Name = "lab_room_money2";
            this.lab_room_money2.Size = new System.Drawing.Size(68, 17);
            this.lab_room_money2.TabIndex = 42;
            this.lab_room_money2.Text = "本次房租：";
            // 
            // lab_month
            // 
            this.lab_month.AutoSize = true;
            this.lab_month.Location = new System.Drawing.Point(412, 200);
            this.lab_month.Name = "lab_month";
            this.lab_month.Size = new System.Drawing.Size(20, 17);
            this.lab_month.TabIndex = 19;
            this.lab_month.Text = "月";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone.Location = new System.Drawing.Point(391, 143);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(85, 23);
            this.txt_phone.TabIndex = 12;
            // 
            // lab_phone
            // 
            this.lab_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_phone.AutoSize = true;
            this.lab_phone.Location = new System.Drawing.Point(326, 146);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(68, 17);
            this.lab_phone.TabIndex = 11;
            this.lab_phone.Text = "手机号码：";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.lab_month);
            this.Controls.Add(this.txt_room_money2);
            this.Controls.Add(this.lab_room_money2);
            this.Controls.Add(this.cbb_duration);
            this.Controls.Add(this.lab_duration);
            this.Controls.Add(this.lab_reminder);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_room_summary);
            this.Controls.Add(this.lab_cost_summary);
            this.Controls.Add(this.txt_room_money);
            this.Controls.Add(this.lab_room_money);
            this.Controls.Add(this.btn_water_calc);
            this.Controls.Add(this.txt_water_cost);
            this.Controls.Add(this.lab_water_cost);
            this.Controls.Add(this.txt_water_unit_price);
            this.Controls.Add(this.lab_water_unit_price);
            this.Controls.Add(this.txt_water_end);
            this.Controls.Add(this.lab_water_end);
            this.Controls.Add(this.txt_water_start);
            this.Controls.Add(this.lab_water_start);
            this.Controls.Add(this.btn_elec_calc);
            this.Controls.Add(this.txt_elec_cost);
            this.Controls.Add(this.lab_elec_cost);
            this.Controls.Add(this.txt_elec_unit_price);
            this.Controls.Add(this.lab_elec_unit_price);
            this.Controls.Add(this.txt_elec_end);
            this.Controls.Add(this.lab_elec_end);
            this.Controls.Add(this.txt_elec_start);
            this.Controls.Add(this.lab_elec_start);
            this.Controls.Add(this.dtp_checkout_date);
            this.Controls.Add(this.lab_checkout_date);
            this.Controls.Add(this.dtp_checkin_date);
            this.Controls.Add(this.lab_checkin_date);
            this.Controls.Add(this.txt_owner_id);
            this.Controls.Add(this.lab_owner_id);
            this.Controls.Add(this.txt_owner_count);
            this.Controls.Add(this.lab_owner_count);
            this.Controls.Add(this.txt_owner_name);
            this.Controls.Add(this.lab_owner_name);
            this.Controls.Add(this.cbb_room_no);
            this.Controls.Add(this.lab_room_no);
            this.Controls.Add(this.cbb_room_floor);
            this.Controls.Add(this.lab_room_floor);
            this.Controls.Add(this.txt_db_id);
            this.Controls.Add(this.lab_db_id);
            this.Controls.Add(this.lab_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入住信息登记";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_db_id;
        private System.Windows.Forms.TextBox txt_db_id;
        private System.Windows.Forms.Label lab_room_floor;
        private System.Windows.Forms.ComboBox cbb_room_floor;
        private System.Windows.Forms.Label lab_room_no;
        private System.Windows.Forms.ComboBox cbb_room_no;
        private System.Windows.Forms.Label lab_owner_name;
        private System.Windows.Forms.TextBox txt_owner_name;
        private System.Windows.Forms.Label lab_owner_count;
        private System.Windows.Forms.TextBox txt_owner_count;
        private System.Windows.Forms.Label lab_owner_id;
        private System.Windows.Forms.TextBox txt_owner_id;
        private System.Windows.Forms.Label lab_checkin_date;
        private System.Windows.Forms.DateTimePicker dtp_checkin_date;
        private System.Windows.Forms.Label lab_checkout_date;
        private System.Windows.Forms.DateTimePicker dtp_checkout_date;
        private System.Windows.Forms.Label lab_elec_start;
        private System.Windows.Forms.TextBox txt_elec_start;
        private System.Windows.Forms.Label lab_elec_end;
        private System.Windows.Forms.TextBox txt_elec_end;
        private System.Windows.Forms.Label lab_elec_unit_price;
        private System.Windows.Forms.TextBox txt_elec_unit_price;
        private System.Windows.Forms.Label lab_elec_cost;
        private System.Windows.Forms.TextBox txt_elec_cost;
        private System.Windows.Forms.Button btn_elec_calc;
        private System.Windows.Forms.Button btn_water_calc;
        private System.Windows.Forms.TextBox txt_water_cost;
        private System.Windows.Forms.Label lab_water_cost;
        private System.Windows.Forms.TextBox txt_water_unit_price;
        private System.Windows.Forms.Label lab_water_unit_price;
        private System.Windows.Forms.TextBox txt_water_end;
        private System.Windows.Forms.Label lab_water_end;
        private System.Windows.Forms.TextBox txt_water_start;
        private System.Windows.Forms.Label lab_water_start;
        private System.Windows.Forms.Label lab_room_money;
        private System.Windows.Forms.TextBox txt_room_money;
        private System.Windows.Forms.Label lab_cost_summary;
        private System.Windows.Forms.TextBox txt_room_summary;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lab_reminder;
        private System.Windows.Forms.Label lab_duration;
        private System.Windows.Forms.ComboBox cbb_duration;
        private System.Windows.Forms.TextBox txt_room_money2;
        private System.Windows.Forms.Label lab_room_money2;
        private System.Windows.Forms.Label lab_month;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_phone;
    }
}