using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKhachSan.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_RoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            if (txt_RoomNo.Text != "" && txt_RoomType.Text != "" && txt_Bed.Text != "" && txt_Price.Text != "")
            {
                String roomno = txt_RoomNo.Text;
                String roomtype = txt_RoomType.Text;
                String bed = txt_Bed.Text;
                Int64 price = Int64.Parse(txt_Price.Text);



                query = "insert into rooms (roomNo, roomType, bed, price) values ('" + roomno + "','" + roomtype + "','" + bed + "'," + price + ")";
                fn.setData(query, "Đã Thêm Phòng");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lưu Ý !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txt_RoomNo.Clear();
            txt_RoomType.SelectedIndex = -1;
            txt_Bed.SelectedIndex = -1;
            txt_Price.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);    
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
