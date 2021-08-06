
namespace ApartmentManager
{
    partial class ChangeUnitPriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUnitPriceForm));
            this.lab_elec_unit_price = new System.Windows.Forms.Label();
            this.txt_elec_unit_price = new System.Windows.Forms.TextBox();
            this.txt_water_unit_price = new System.Windows.Forms.TextBox();
            this.lab_water_unit_price = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_elec_unit_price
            // 
            this.lab_elec_unit_price.AutoSize = true;
            this.lab_elec_unit_price.Location = new System.Drawing.Point(88, 58);
            this.lab_elec_unit_price.Name = "lab_elec_unit_price";
            this.lab_elec_unit_price.Size = new System.Drawing.Size(104, 17);
            this.lab_elec_unit_price.TabIndex = 0;
            this.lab_elec_unit_price.Text = "请输入电费单价：";
            // 
            // txt_elec_unit_price
            // 
            this.txt_elec_unit_price.Location = new System.Drawing.Point(207, 58);
            this.txt_elec_unit_price.Name = "txt_elec_unit_price";
            this.txt_elec_unit_price.Size = new System.Drawing.Size(100, 23);
            this.txt_elec_unit_price.TabIndex = 1;
            this.txt_elec_unit_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_elec_unit_price_KeyPress);
            // 
            // txt_water_unit_price
            // 
            this.txt_water_unit_price.Location = new System.Drawing.Point(207, 104);
            this.txt_water_unit_price.Name = "txt_water_unit_price";
            this.txt_water_unit_price.Size = new System.Drawing.Size(100, 23);
            this.txt_water_unit_price.TabIndex = 3;
            this.txt_water_unit_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_water_unit_price_KeyPress);
            // 
            // lab_water_unit_price
            // 
            this.lab_water_unit_price.AutoSize = true;
            this.lab_water_unit_price.Location = new System.Drawing.Point(88, 104);
            this.lab_water_unit_price.Name = "lab_water_unit_price";
            this.lab_water_unit_price.Size = new System.Drawing.Size(104, 17);
            this.lab_water_unit_price.TabIndex = 2;
            this.lab_water_unit_price.Text = "请输入水费单价：";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_title.ForeColor = System.Drawing.Color.Red;
            this.lab_title.Location = new System.Drawing.Point(88, 9);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(235, 24);
            this.lab_title.TabIndex = 4;
            this.lab_title.Text = "请输入新的水电单价";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(84, 138);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(248, 138);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ChangeUnitPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 176);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.txt_water_unit_price);
            this.Controls.Add(this.lab_water_unit_price);
            this.Controls.Add(this.txt_elec_unit_price);
            this.Controls.Add(this.lab_elec_unit_price);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeUnitPriceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "水电单价修改";
            this.Load += new System.EventHandler(this.ChangeUnitPriceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_elec_unit_price;
        private System.Windows.Forms.TextBox txt_elec_unit_price;
        private System.Windows.Forms.TextBox txt_water_unit_price;
        private System.Windows.Forms.Label lab_water_unit_price;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}