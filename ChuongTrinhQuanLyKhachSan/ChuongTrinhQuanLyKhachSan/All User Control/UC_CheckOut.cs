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
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid , customer.cname, customer.mobile,  customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where chekout = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid , customer.cname, customer.mobile,  customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cname like '" + txt_Name.Text + "%' and chekout = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_CName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Room.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            if (txt_CName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txt_CheckOutDate.Text;
                    query = "update customer set chekout = 'YES', checkout = '" + cdate + "'where cid = " + id + " update rooms set booked = 'NO' where roomNo = '" + txt_Room.Text + "'";
                    fn.setData(query, "Check Out thành công");
                    try
                    {
                        // Lấy dữ liệu hiện tại trong DataGridView
                        DataTable currentData = guna2DataGridView1.DataSource as DataTable;

                        if (currentData == null || currentData.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Mở form ReportSach và truyền dữ liệu
                        Report.REP_Payment reportForm = new Report.REP_Payment(currentData);
                        reportForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    UC_CheckOut_Load(this, null);
                    clearAll();
                }
            } else
            {
                MessageBox.Show("Không có khách hàng để lựa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txt_CName.Clear();
            txt_Name.Clear();
            txt_Room.Clear();
            txt_CheckOutDate.ResetText();
        }

        private void btn_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txt_Room_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
