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
using System.Configuration;
using System.Collections;
using System.Threading;

namespace ApartmentManager
{
    public partial class RoomInfoQueryForm : Form_Template
    {
        public RoomInfoQueryForm()
        {
            InitializeComponent();
        }
        private Form1 returnForm1 = null;
        private Dictionary<string,ArrayList> dicFloorRoom= null;
        private OdbcConnection odbcConn;
        private OdbcCommand odbcCmd;
        private string strConn;
        private OdbcDataAdapter oda;
        private DataSet ds;
        private DataRow[] drs;
        private DataTable dt;
        private int idFlag=1;
        private string[] strArray = new string[] { "编号", "楼层", "房间编号", "租客姓名", "租客人数", "手机号码", "身份证号码", "入住日期", "退房日期", "电表起始", "电表结束", "电费单价", "电费消费", "水表起始", "水表结束", "水费用单价", "水费消费", "房租费用", "综合费用" };

        public RoomInfoQueryForm(Form1 form1,Dictionary<string,ArrayList> dicFloorRoom)
        {
            InitializeComponent();
            this.returnForm1 = form1;
            this.dicFloorRoom = dicFloorRoom;
        }

        
        private void RoomInfoQueryForm_Load(object sender, EventArgs e)
        {
            strConn = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString.ToString();
            if (!dbConnect())
            {
                return;
            }

            foreach (string tmpKey in dicFloorRoom.Keys)
            {
                if (!cbb_floor.Items.Contains(tmpKey))
                {
                    cbb_floor.Items.Add(tmpKey);
                }   
            }
            cbb_floor.SelectedIndex = 0;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RoomInfoQueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.returnForm1.Visible = true;
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
                oda.Fill(ds, "room_info");

                dataGridView1.DataSource = ds.Tables["room_info"];
                //datagridview编辑表名
                for (int i = 0; i < strArray.Length; i++)
                {
                    dataGridView1.Columns[i].HeaderText = strArray[i];
                }
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

        private void cbb_floor_TextChanged(object sender, EventArgs e)
        {
            cbb_room_no.DataSource = dicFloorRoom[cbb_floor.Text];
            DataGridViewUpdate(cbb_floor.Text, cbb_room_no.Text);
        }

        private void DataGridViewUpdate(string strRoomFloor, string strRoomNo)
        {
            float elec_summay = 0;
            float water_summary = 0;
            float room_money = 0;
            float total_summary = 0;

            if (strRoomFloor == "" || strRoomFloor == "全部")
            {
                strRoomFloor = "*";
            }
            if (strRoomNo == "")
            {
                strRoomNo = "*";
            }
            string selectCmd = "Room_Floor like '" + strRoomFloor + "' and Room_No like '" + strRoomNo + "'";
            drs = ds.Tables["room_info"].Select(selectCmd,"ID");
            if (drs.Length > 0)
            {
                dt = drs[0].Table.Clone();
                foreach (DataRow tmpDr in drs)
                {
                    dt.ImportRow(tmpDr);
                    try
                    {
                        elec_summay += Convert.ToSingle(tmpDr["Elec_Cost"]);
                        water_summary += Convert.ToSingle(tmpDr["Water_Cost"]);
                        room_money += Convert.ToSingle(tmpDr["Room_Money"]);
                        total_summary += Convert.ToSingle(tmpDr["Room_Summary"]);
                    }
                    catch (Exception)
                    {
                        //防止数据转换失败，不做处理，不更新TextBox控件的值
                    }
                }
                dataGridView1.DataSource = dt;
                for (int i = 0; i < strArray.Length; i++)
                {
                    dataGridView1.Columns[i].HeaderText = strArray[i];
                }
                //获取dt的第一行数据
                try
                {
                    DataRow first_dr = dt.AsEnumerable().First<DataRow>();
                    idFlag = Convert.ToInt32(first_dr["ID"].ToString());
                }
                catch
                {
                    //数据库为空，idFlag设定为超级大数值，方便数据插入
                    idFlag = 100000;
                }

                txt_elec_cost.Text = elec_summay.ToString();
                txt_water_cost.Text = water_summary.ToString();
                txt_room_cost.Text = room_money.ToString();
                txt_fee_summay.Text = total_summary.ToString();
                lab_reminder.Text = "";
            }
            else
            {
                lab_reminder.Text = "数据库检索失败，暂未录入该楼层或该房间数据!!!";
                dataGridView1.DataSource = null;
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
        }

        private void cbb_room_no_TextChanged(object sender, EventArgs e)
        {
            DataGridViewUpdate(cbb_floor.Text, cbb_room_no.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.SelectedCells[0].RowIndex;  
            if (row_index < dataGridView1.RowCount - 1)
            {
                idFlag = Convert.ToInt32(dataGridView1.Rows[row_index].Cells["ID"].Value.ToString());
                try
                {
                    txt_elec_cost.Text = Convert.ToSingle(dataGridView1.Rows[row_index].Cells["Elec_Cost"].Value).ToString();
                    txt_water_cost.Text = Convert.ToSingle(dataGridView1.Rows[row_index].Cells["Water_Cost"].Value).ToString();
                    txt_room_cost.Text = Convert.ToSingle(dataGridView1.Rows[row_index].Cells["Room_Money"].Value).ToString();
                    txt_fee_summay.Text = Convert.ToSingle(dataGridView1.Rows[row_index].Cells["Room_Summary"].Value).ToString();
                }
                catch (Exception)
                {
                    //防止数据转换失败，不做处理，不更新TextBox控件的值
                }
            }
            else
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
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, idFlag,dicFloorRoom);
            form2.ShowDialog();
            int tmpFloorIndex = cbb_floor.SelectedIndex;
            int tmpRoomNoIndex = cbb_room_no.SelectedIndex;
            RoomInfoQueryForm_Load(sender, e);
            cbb_floor.SelectedIndex = tmpFloorIndex;
            cbb_room_no.SelectedIndex = tmpRoomNoIndex;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_edit_Click(sender, (DataGridViewCellEventArgs)e);
        }

        private void lab_title_DoubleClick(object sender, EventArgs e)
        {
            //删除数据表中的某一行，暂不实现了，如果有需要后面再重写这里
        }
    }
}
