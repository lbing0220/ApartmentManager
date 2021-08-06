using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManager
{
    public partial class ChangeUnitPriceForm : Form_Template
    {
        public ChangeUnitPriceForm()
        {
            InitializeComponent();
        }

        private void ChangeUnitPriceForm_Load(object sender, EventArgs e)
        {
            txt_elec_unit_price.Text = GetAppSettings("elec_unit_price");
            txt_water_unit_price.Text = GetAppSettings("water_unit_price");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            UpdateAppSettings("elec_unit_price", txt_elec_unit_price.Text);
            UpdateAppSettings("water_unit_price", txt_water_unit_price.Text);
            this.Close();
        }

        private void txt_elec_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_water_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //自主实现的方法
        //TextBox只能输入数字
        private void TextBoxInputNumberOnly(KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == (char)13))
            {
                MessageBox.Show("这里只能输入数字呦！", "输入提示");
                e.Handled = true;
            }
        }

        //获取AppConfig配置文件
        private static string GetAppSettings(string strKey)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == strKey)
                {
                    return ConfigurationManager.AppSettings[strKey];
                }
            }
            return null;
        }

        //写入Config配置文件
        private static void UpdateAppSettings(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it 
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting. 
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file. 
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section. 
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
