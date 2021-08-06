using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;
using System.Threading;
using System.Configuration;
using System.IO;


namespace ApartmentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int idFlag = 0;
        private string dbFilePath = null;
        private string strConn;
        private OdbcConnection odbcConn;
        private OdbcCommand odbcCmd;
        private OdbcDataAdapter oda;
        private DataSet ds;
        private DataTable dt;
        private DataRow dr;
        private DataRow[] drs;
        private OdbcCommandBuilder ocb;
        private ArrayList cbb_floor_list = new();
        private ArrayList cbb_type_list = new();
        private ArrayList cbb_no_list = new();
        Dictionary<string, ArrayList> dicFloorRoom = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //界面初始化，导入数据库的room_list表
            strConn = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString.ToString();
            if (!dbUpdate())
            {
                return;
            }
            dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            UpdateDictionary();
            

            //使用多线程去备份数据文件
            Thread myThread = new(new ThreadStart(AccessDbBak));
            myThread.Start();
        }
        
        private void cbb_floor_TextChanged(object sender, EventArgs e)
        {
            DtUpdate(cbb_floor.Text.Trim(), cbb_type.Text.Trim());
        }

        private void cbb_type_TextChanged(object sender, EventArgs e)
        {
            DtUpdate(cbb_floor.Text.Trim(), cbb_type.Text.Trim());
        }

        private void cbb_no_TextChanged(object sender, EventArgs e)
        {
            string selectCmd = "Room_No like '" + cbb_no.Text.Trim() + "'";
            if (ds.Tables[0].Select(selectCmd).Length > 0)
            {
                txt_price.Text = ds.Tables[0].Select(selectCmd)[0][4].ToString();
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            string selectCmd = "Room_No like '" + cbb_no.Text.Trim() + "'";
            if (ds.Tables[0].Select(selectCmd).Length > 0)
            {
                int p_key = Convert.ToInt32(ds.Tables[0].Select(selectCmd)[0][0]);
                WriteDB(p_key);

                //获取当前的筛选条件
                int floor_index = cbb_floor.SelectedIndex;
                int type_index = cbb_type.SelectedIndex;
                Form1_Load(sender, e);
                //重置筛选条件
                cbb_floor.SelectedIndex = floor_index;
                cbb_type.SelectedIndex = type_index;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.SelectedCells[0].RowIndex;
            if (row_index < dataGridView1.RowCount -1)
            {
                cbb_no.Text = dataGridView1.Rows[row_index].Cells["Room_No"].Value.ToString();
            }
        }

        //以下是自主实现的方法
        //ArrayList去重
        private ArrayList removeDuplicate(ArrayList arrayList)
        {
            ArrayList tempList = new ArrayList();
            foreach (string str in arrayList)
            {
                if (!tempList.Contains(str))
                {
                    tempList.Add(str);
                }
            }
            return tempList;
        }

        //dataGridView初始化
        private Boolean dbUpdate()
        {
            try
            {
                odbcConn = new OdbcConnection(strConn);
                odbcCmd = new OdbcCommand("select * from room_list", odbcConn);
                oda = new OdbcDataAdapter(odbcCmd);
                ds = new DataSet();
                oda.Fill(ds, "room_list");
                dataGridView1.DataSource = ds.Tables["room_list"];
                dataGridView1.Columns[0].HeaderText = "数据库编号";
                dataGridView1.Columns[1].HeaderText = "房间编号";
                dataGridView1.Columns[2].HeaderText = "房间类型";
                dataGridView1.Columns[3].HeaderText = "房间楼层";
                dataGridView1.Columns[4].HeaderText = "房间价格";
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

        //筛选条件，更新datgridview空间数据源
        private void DtUpdate(string strRoomFloor, string strRoomType)
        {
            if (strRoomFloor == "" || strRoomFloor == "全部")
            {
                strRoomFloor = "*";
            }
            if (strRoomType == "")
            {
                strRoomType = "*";
            }
            string selectCmd = "Room_Floor like '" + strRoomFloor + "' and Room_Type like '" + strRoomType + "'";
            drs = ds.Tables["room_list"].Select(selectCmd);
            if (drs.Length > 0)
            {
                cbb_no_list.Clear();
                dt = drs[0].Table.Clone();
                foreach (DataRow tmpDr in drs)
                {
                    dt.ImportRow(tmpDr);
                    cbb_no_list.Add(tmpDr[1]);
                }

                cbb_no.DataSource = null;   //需要先把数据线清理掉才可以重新绑定数据源
                cbb_no.DataSource = cbb_no_list;
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("暂无所选房型，请重新选择筛选条件", "房型选择错误警告");
            }
        }
        //更新数据库
        private void WriteDB(int p_key)
        {
            try
            {
                odbcConn = new OdbcConnection(strConn);
                odbcCmd = new OdbcCommand("select * from room_list", odbcConn);
                oda = new OdbcDataAdapter();
                oda.SelectCommand = odbcCmd;


                oda.FillSchema(dt, SchemaType.Mapped);
                dr = dt.Rows.Find(p_key);
                dr["room_price"] = Convert.ToSingle(txt_price.Text);
                ocb = new OdbcCommandBuilder(oda);
                oda.Update(dt);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("房间价格设置错误，只能设置为数字(包括小数)\n" +
                    "错误信息如下：\n" + ex.ToString(), "格式转换错误");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txt_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btn_modify_Click(sender, e);
            }
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            //UpdateDictionary();
            Form2 form2 = new(this,idFlag,dicFloorRoom);
            form2.Show();
            this.Hide();
        }

        private void UpdateDictionary()
        {
            ArrayList tmpList;
            ArrayList tmpAllList;
            DataRow[] queryDr = ds.Tables["room_list"].Select();
            cbb_floor_list.Add("");
            cbb_type_list.Add("");

            foreach (DataRow tempRow in queryDr)
            {
                cbb_floor_list.Add(tempRow[3]);
                cbb_type_list.Add(tempRow[2]);
                cbb_no_list.Add(tempRow[1]);
            }
            cbb_floor.DataSource = removeDuplicate(cbb_floor_list);
            cbb_type.DataSource = removeDuplicate(cbb_type_list);
            cbb_no.DataSource = cbb_no_list;
            
            dicFloorRoom.Clear();
            foreach (string tmpStr in removeDuplicate(cbb_floor_list))
            {
                tmpList = new ArrayList();
                tmpList.Add("");
                tmpAllList = new ArrayList();
                tmpAllList.Add("");

                foreach (DataRow tmpDr in queryDr)
                {
                    tmpAllList.Add(tmpDr["Room_No"]);
                    if (tmpDr["Room_Floor"].ToString() == tmpStr)
                    {
                        tmpList.Add(tmpDr["Room_No"]);
                    }
                }
                if (tmpStr == "")
                {
                    dicFloorRoom.Add("全部", tmpAllList);
                }
                else
                {
                    dicFloorRoom.Add(tmpStr, tmpList);
                }
            }
        }
        private void btn_query_Click(object sender, EventArgs e)
        {
            //UpdateDictionary();
            RoomInfoQueryForm riqform = new RoomInfoQueryForm(this, dicFloorRoom) ;
            riqform.Show();
            this.Hide();
        }

        private void lab_title_DoubleClick(object sender, EventArgs e)
        {
            opendbFileDialog.FileName = "Test.accdb";
            opendbFileDialog.Filter =@"Office数据库 |*.accdb;*.xls;*.xlsx|所有文件|*.*";
           
            //通过Result的结果可以开启或者关闭数据库备份
            DialogResult result = opendbFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                dbFilePath = opendbFileDialog.FileName;
            }
            else if(result == DialogResult.Cancel)
            {
                dbFilePath = "";
            }
            UpdateAppSettings("AccessDBFilePath", dbFilePath);
            if (File.Exists(dbFilePath))
            {
                UpdateAppSettings("AccessDBFilePathLastWriteTime", File.GetLastWriteTime(dbFilePath).ToString("yyyyMMdd_HHmmss"));
            }
        }

        private void AccessDbBak()
        {
            dbFilePath = GetAppSettings("AccessDBFilePath");
            if (File.Exists(dbFilePath))
            {
                if (File.GetLastWriteTime(dbFilePath).ToString("yyyyMMdd_HHmmss") != GetAppSettings("AccessDBFilePathLastWriteTime"))
                {
                    File.Copy(dbFilePath, dbFilePath + "_ " + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                    UpdateAppSettings("AccessDBFilePathLastWriteTime", File.GetLastWriteTime(dbFilePath).ToString("yyyyMMdd_HHmmss"));
                }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
