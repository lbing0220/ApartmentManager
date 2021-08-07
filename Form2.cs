using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;
using System.IO;

namespace ApartmentManager
{
    public partial class Form2 : Form_Template
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form form)
        {
            InitializeComponent();
            this.returnForm = form;
        }
        private Form returnForm = null;
        private int idFlag = 0;
        private bool modifyOrAddFlag = false;
        private Dictionary<string, ArrayList> dicFloorRoom = null;
        public Form2(Form form,int idFlag,Dictionary<string,ArrayList> dicFloorRoom)
        {
            InitializeComponent();
            this.returnForm = form;
            this.idFlag = idFlag;
            this.dicFloorRoom = dicFloorRoom;
        }

        private OdbcConnection odbcConn;
        private OdbcCommand odbcCmd;
        private OdbcDataAdapter oda;
        private DataTable dt;
        private OdbcCommandBuilder ocb;
        private DataSet ds;
        private string strConn;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string tmpKey in dicFloorRoom.Keys)
            {
                if (tmpKey != "全部")
                {
                    cbb_room_floor.Items.Add(tmpKey);
                }
            }
            //设置dtp_checkout_date的默认值为空，防止忘记输入,需要设置控件Format格式为Custom模式
            //也可以在属性栏里面设定
            //this.dateTimePicker1.Format=DateTimePickerFormat.Custom
            //this.dtp_checkout_date.CustomFormat = " ";
            for (int i = 1; i < 13; i++)
            {
                cbb_duration.Items.Add(i);
            }
            cbb_duration.SelectedIndex = 0;
            strConn = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString.ToString();
            if (!dbConnect())
            {
                return;
            }
            if (idFlag == 0)
            {
                try
                {
                    //获取ds.Tables["Room_Info"]的最后一行数据
                    DataRow last_dr = ds.Tables["Room_Info"].AsEnumerable().Last<DataRow>();
                    idFlag = Convert.ToInt32(last_dr["ID"].ToString()) + 1;
                }
                catch
                {
                    //数据库为空，idFlag设定为超级大数值，方便数据插入
                    idFlag = 100000;
                }
            }

            //默认给电费单价和水费单价赋值
            txt_elec_unit_price.Text = GetAppSettings("elec_unit_price");
            txt_water_unit_price.Text = GetAppSettings("water_unit_price");
            AllValueUpdate();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.returnForm.Visible = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_elec_calc_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (txt_elec_start.Text == "")
                {
                    txt_elec_start.Text = "0";
                }
                if (txt_elec_end.Text == "")
                {
                    txt_elec_end.Text = "0";
                }
                if (txt_elec_unit_price.Text == "")
                {
                    txt_elec_unit_price.Text = "0";
                }*/
                if (txt_elec_start.Text != "" && txt_elec_end.Text != "" && txt_elec_unit_price.Text != "")
                {
                    float elec_start = Convert.ToSingle(txt_elec_start.Text);
                    float elec_end = Convert.ToSingle(txt_elec_end.Text);
                    float elec_unit_price = Convert.ToSingle(txt_elec_unit_price.Text);

                    if (elec_end >= elec_start)
                    {
                        txt_elec_cost.Text = string.Format("{0:f}", elec_unit_price * (elec_end - elec_start));
                    }
                    else
                    {
                        txt_elec_cost.Text = "0";
                    }
                }
                else
                {
                    txt_elec_cost.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据输入有误，请检查", "数据转换失败");
            }
        }

        private void btn_water_calc_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (txt_water_start.Text == "")
                {
                    txt_water_start.Text = "0";
                }
                if (txt_water_end.Text == "")
                {
                    txt_water_end.Text = "0";
                }
                if (txt_water_unit_price.Text == "")
                {
                    txt_water_unit_price.Text = "0";
                }*/
                if (txt_water_start.Text != "" && txt_water_end.Text != "" && txt_water_unit_price.Text != "")
                {
                    float water_start = Convert.ToSingle(txt_water_start.Text);
                    float water_end = Convert.ToSingle(txt_water_end.Text);
                    float water_unit_price = Convert.ToSingle(txt_water_unit_price.Text);

                    if (water_end >= water_start)
                    {
                        txt_water_cost.Text = string.Format("{0:f}", water_unit_price * (water_end - water_start));
                    }
                    else
                    {
                        txt_water_cost.Text = "0";
                    }
                }
                else
                {
                    txt_water_cost.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据输入有误，请检查", "数据转换失败");
            }
        }
        

        private void txt_elec_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_elec_end_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_water_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_water_end_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_elec_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_water_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_room_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputNumberOnly(e);
        }

        private void txt_elec_cost_TextChanged(object sender, EventArgs e)
        {
            float room_summary = RoomSummaryCalc(txt_elec_cost.Text, txt_water_cost.Text, txt_room_money.Text,txt_room_money2.Text);
            txt_room_summary.Text = string.Format("{0:f}", room_summary);
        }

        private void txt_water_cost_TextChanged(object sender, EventArgs e)
        {
            txt_elec_cost_TextChanged(sender, e);
        }

        private void txt_room_money_TextChanged(object sender, EventArgs e)
        {
            txt_elec_cost_TextChanged(sender, e);
        }

        private void txt_room_money2_TextChanged(object sender, EventArgs e)
        {
            txt_elec_cost_TextChanged(sender, e);
        }

        private void txt_elec_end_TextChanged(object sender, EventArgs e)
        {
            btn_elec_calc_Click(sender, e);
        }

        private void txt_water_end_TextChanged(object sender, EventArgs e)
        {
            btn_water_calc_Click(sender, e);
        }

        private void txt_elec_start_TextChanged(object sender, EventArgs e)
        {
            btn_elec_calc_Click(sender, e);
        }

        private void txt_elec_unit_price_TextChanged(object sender, EventArgs e)
        {
            btn_elec_calc_Click(sender, e);
        }

        private void txt_water_start_TextChanged(object sender, EventArgs e)
        {
            btn_water_calc_Click(sender, e);
        }

        private void txt_water_unit_price_TextChanged(object sender, EventArgs e)
        {
            btn_water_calc_Click(sender, e);
        }



        //自主实现方法
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

        //TextBox空间内只能输入数字方法
        private void TextBoxInputNumberOnly(KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == (char)13))
            {
                MessageBox.Show("这里只能输入数字呦！", "输入提示");
                e.Handled = true;
            }
        }

        private void AccessDbBak()
        {
            string dbFilePath = GetAppSettings("AccessDBFilePath");
            if (File.Exists(dbFilePath))
            {
                if (File.GetLastWriteTime(dbFilePath).ToString("yyyyMMdd_HHmmss") != GetAppSettings("AccessDBFilePathLastWriteTime"))
                {
                    File.Copy(dbFilePath, dbFilePath + "_ " + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                    UpdateAppSettings("AccessDBFilePathLastWriteTime", File.GetLastWriteTime(dbFilePath).ToString("yyyyMMdd_HHmmss"));
                }
            }
        }
        //房间总价计算方法
        private float RoomSummaryCalc(params string[] txt_value)
        {
            float summary = 0;
            for (int i = 0; i < txt_value.Length; i++)
            {
                if (txt_value[i] == "")
                {
                    txt_value[i] = "0";
                }
                summary += Convert.ToSingle(txt_value[i]);
            }
            return summary;
        }

        private Boolean dbConnect()
        {
            try
            {
                odbcConn = new OdbcConnection(strConn);
                string strCmd = "select * from room_info order by ID";
                odbcCmd = new OdbcCommand(strCmd, odbcConn);
                oda = new OdbcDataAdapter(odbcCmd);
                ds = new DataSet();
                oda.Fill(ds, "Room_Info");
                return true;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("数据库链接失败，请检查ODBC数据源设定\n" + ex.ToString(), "数据库链接错误");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("软件发生其他错误，需要检查代码。错误信息如下\n" +
                    ex.ToString(), "其他错误");
                return false;
            }
        }

        private void AllValueUpdate()
        {
            dt = ds.Tables["Room_Info"];
            //设定dt主键
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };
            txt_db_id.Text = idFlag.ToString();
            DataRow[] drs = dt.Select();
            foreach (DataRow tmpDr in drs)
            {
                if (tmpDr["ID"].ToString() == txt_db_id.Text)
                {
                    modifyOrAddFlag = true;
                    cbb_room_floor.Text = tmpDr["Room_Floor"].ToString();
                    cbb_room_no.Text = tmpDr["Room_No"].ToString();
                    txt_owner_name.Text = tmpDr["Room_Owner"].ToString();
                    txt_owner_count.Text = tmpDr["Owner_Count"].ToString();
                    txt_phone.Text = tmpDr["Owner_Phone"].ToString();
                    txt_owner_id.Text = tmpDr["Owner_ID_No"].ToString();
                    try
                    {
                        dtp_checkin_date.Value = Convert.ToDateTime(tmpDr["Owner_Checkin_Date"].ToString());
                        dtp_checkout_date.Value = Convert.ToDateTime(tmpDr["Owner_Checkout_Date"].ToString());
                    }
                    catch (Exception)
                    {
                        dtp_checkin_date.Value = DateTime.Now;
                        dtp_checkout_date.Value = dtp_checkin_date.Value.AddMonths(1);
                    }

                    txt_elec_start.Text = tmpDr["Elec_Start"].ToString();
                    txt_elec_end.Text = tmpDr["Elec_End"].ToString();
                    txt_elec_unit_price.Text = tmpDr["Elec_Unit_Price"].ToString();
                    txt_water_start.Text = tmpDr["Water_Start"].ToString();
                    txt_water_end.Text = tmpDr["Water_End"].ToString();
                    txt_water_unit_price.Text = tmpDr["Water_Unit_Price"].ToString();
                    txt_room_money.Text = tmpDr["Room_Money"].ToString();
                }
            }           
        }

        private void ModifyValue2DB()
        {
            dt = null;
            dt = ds.Tables["Room_Info"];
            oda.FillSchema(dt, SchemaType.Mapped);
            DataRow dr = dt.Rows.Find(txt_db_id.Text);
            dr["Room_Floor"] = cbb_room_floor.Text.Trim();
            dr["Room_No"] = cbb_room_no.Text.Trim();
            dr["Room_Owner"] = txt_owner_name.Text.Trim();
            dr["Owner_Count"] = txt_owner_count.Text.Trim();
            dr["Owner_Phone"] = txt_phone.Text.Trim();
            dr["Owner_ID_No"] = txt_owner_id.Text.Trim();
            dr["Owner_Checkin_Date"] = dtp_checkin_date.Value.ToShortDateString();
            dr["Owner_Checkout_Date"] = dtp_checkout_date.Value.ToShortDateString() ;
            dr["Elec_Start"] = txt_elec_start.Text.Trim();
            dr["Elec_End"] = txt_elec_end.Text.Trim();
            dr["Elec_Unit_Price"] = txt_elec_unit_price.Text.Trim();
            dr["Elec_Cost"] = txt_elec_cost.Text.Trim();
            dr["Water_Start"] = txt_water_start.Text.Trim();
            dr["Water_End"] = txt_water_end.Text.Trim();
            dr["Water_Unit_Price"] = txt_water_unit_price.Text.Trim();
            dr["Water_Cost"] = txt_water_cost.Text.Trim();
            if (txt_room_money.Text == "")
            {
                txt_room_money.Text = "0";
            }
            if (txt_room_money2.Text == "")
            {
                txt_room_money2.Text = "0";
            }
            dr["Room_Money"] = (Convert.ToSingle(txt_room_money.Text.Trim()) + Convert.ToSingle(txt_room_money2.Text.Trim())).ToString(); ;
            dr["Room_Summary"] = txt_room_summary.Text.Trim();
            ocb = new OdbcCommandBuilder(oda);
            oda.Update(dt);
        }

        private void AddNewRows2DB()
        {
            dt = null;
            dt = ds.Tables["Room_Info"];
            oda.FillSchema(dt, SchemaType.Mapped);
            DataRow dr = dt.NewRow();
            dr["Room_Floor"] = cbb_room_floor.Text.Trim();
            dr["Room_No"] = cbb_room_no.Text.Trim();
            dr["Room_Owner"] = txt_owner_name.Text.Trim();
            dr["Owner_Count"] = txt_owner_count.Text.Trim();
            dr["Owner_Phone"] = txt_phone.Text.Trim();
            dr["Owner_ID_No"] = txt_owner_id.Text.Trim();
            dr["Owner_Checkin_Date"] = dtp_checkin_date.Value.ToShortDateString();
            dr["Owner_Checkout_Date"] = dtp_checkout_date.Value.ToShortDateString() ;
            dr["Elec_Start"] = txt_elec_start.Text.Trim();
            dr["Elec_End"] = txt_elec_end.Text.Trim(); 
            if (txt_room_money.Text == "")
            {
                txt_room_money.Text = "0";
            }
            if (txt_room_money2.Text == "")
            {
                txt_room_money2.Text = "0";
            }
            dr["Room_Money"] = (Convert.ToSingle(txt_room_money.Text.Trim()) + Convert.ToSingle(txt_room_money2.Text.Trim())).ToString();
            dr["Elec_Unit_Price"] = txt_elec_unit_price.Text.Trim();
            dr["Elec_Cost"] = txt_elec_cost.Text.Trim();
            dr["Water_Start"] = txt_water_start.Text.Trim();
            dr["Water_End"] = txt_water_end.Text.Trim();
            dr["Water_Unit_Price"] = txt_water_unit_price.Text.Trim();
            dr["Water_Cost"] = txt_water_cost.Text.Trim();
            if(txt_room_money.Text == "")
            {
                txt_room_money.Text = "0";
            }
            if (txt_room_money2.Text == "")
            {
                txt_room_money2.Text = "0";
            }
            dr["Room_Money"] = (Convert.ToSingle(txt_room_money.Text.Trim()) + Convert.ToSingle(txt_room_money2.Text.Trim())).ToString();
            dr["Room_Summary"] = txt_room_summary.Text.Trim();
            dt.Rows.Add(dr);
            ocb = new OdbcCommandBuilder(oda);
            oda.Update(dt);
        }

        private void lab_title_DoubleClick(object sender, EventArgs e)
        {
            ChangeUnitPriceForm tmpForm = new ChangeUnitPriceForm();
            //使用tmpForm.ShowDialog(),模态对话框
            tmpForm.ShowDialog();
            txt_elec_unit_price.Text = GetAppSettings("elec_unit_price");
            txt_water_unit_price.Text = GetAppSettings("water_unit_price");
            tmpForm.Dispose();
            
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (dtp_checkout_date.Value < dtp_checkin_date.Value)
            {
                MessageBox.Show("退房日期不能早于入住日期", "日期提示");
                return;
            }
            if (modifyOrAddFlag)
            {
                ModifyValue2DB();
                MessageBox.Show("数据修改成功","修改提示");
            }
            else
            {
                AddNewRows2DB();
                MessageBox.Show("数据插入成功","插入提示");
            }
            //使用多线程去备份数据文件
            Thread myThread = new(new ThreadStart(AccessDbBak));
            myThread.Start();
            this.Close();
        }

        private void dtp_checkin_date_ValueChanged(object sender, EventArgs e)
        {
            dtp_checkout_date.Value = dtp_checkin_date.Value.AddMonths(Convert.ToInt32(cbb_duration.Text));
        }

        private void dtp_checkout_date_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbb_duration_TextChanged(object sender, EventArgs e)
        {
            dtp_checkout_date.Value = dtp_checkin_date.Value.AddMonths(Convert.ToInt32(cbb_duration.Text));
        }

        private void cbb_room_floor_TextChanged(object sender, EventArgs e)
        {
            if (cbb_room_floor.SelectedIndex >= 0)
            {
                cbb_room_no.DataSource = dicFloorRoom[cbb_room_floor.Text];
            }
        }
    }
}
