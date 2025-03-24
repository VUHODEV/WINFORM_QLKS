using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKhachSan.All_User_Control
{
    public partial class UC_CustomerRes : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRes()
        {
            InitializeComponent();
            gdvKS.CellClick += new DataGridViewCellEventHandler(gdvKS_CellContentClick);

        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {
            cmb_Discount.Items.AddRange(new string[] { "10%", "20%", "30%", "40%", "50%" });
            cmb_Discount.SelectedIndex = 0; // Mặc định chọn 10%
            LoadCustomerData();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_Bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Room.SelectedIndex = -1;
            txt_RoomNo.Items.Clear();
            txt_Price.Clear();
        }

        private void txt_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_RoomNo.Items.Clear();
            query = "select roomNo from rooms where bed = '" + txt_Bed.Text + "' and roomType = '" + txt_Room.Text + "' and booked = 'No'";
            setComboBox(query, txt_RoomNo);
        }

        int rid;
        private void txt_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomid from rooms where roomNo = '" + txt_RoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txt_Price.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btn_AllotCustomer_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Contact.Text != "" && txt_Nationality.Text != "" && txt_Gender.Text != "" && txt_Dob.Text != "" && txt_IDProof.Text != "" && txt_Address.Text != "" && txt_Checkin.Text != "" && txt_Price.Text != "" && cmb_Discount.Text != "")
            {
                String name = txt_Name.Text;
                Int64 mobile = Int64.Parse(txt_Contact.Text);
                String national = txt_Nationality.Text;
                String gender = txt_Gender.Text;
                String dob = txt_Dob.Text;
                String idproof = txt_IDProof.Text;
                String address = txt_Address.Text;
                String checkin = txt_Checkin.Text;
                String discount = cmb_Discount.Text;

                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, roomid) values ('" + name + "'," + mobile + ",'" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "'," + rid + ") update rooms set booked = 'YES' where roomNo = '" + txt_RoomNo.Text + "'";
                fn.setData(query, " Số Phòng " + txt_RoomNo.Text + " Đăng Ký Khách Hàng Thành Công.");

                clearAll();
                LoadCustomerData();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void clearAll()
        {
            txt_Name.Clear();
            txt_Contact.Clear();
            txt_Nationality.Clear();
            txt_Gender.SelectedIndex = -1;
            txt_Dob.ResetText();
            txt_IDProof.Clear();
            txt_Address.Clear();
            txt_Checkin.ResetText();
            txt_Bed.SelectedIndex = -1;
            txt_Room.SelectedIndex = -1;
            txt_RoomNo.Items.Clear();
            txt_Price.Clear();
            cmb_Discount.SelectedIndex = -1;
        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public void LoadCustomerData()
        {
            query = "SELECT cname AS [Tên Khách], mobile AS [Số Điện Thoại], nationality AS [Quốc Tịch], gender AS [Giới Tính], dob AS [Ngày Sinh], idproof AS [CMND/CCCD], address AS [Địa Chỉ], checkin AS [Ngày Nhận Phòng], roomid AS [ID Phòng] FROM customer";
            DataSet ds = fn.getData(query);
            gdvKS.DataSource = ds.Tables[0];
        }
        private void gdvKS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem hàng được chọn có hợp lệ không
            {
                DataGridViewRow row = gdvKS.Rows[e.RowIndex];   

                txt_Name.Text = row.Cells["Tên Khách"].Value.ToString();
                txt_Contact.Text = row.Cells["Số Điện Thoại"].Value.ToString();
                txt_Nationality.Text = row.Cells["Quốc Tịch"].Value.ToString();
                txt_Gender.Text = row.Cells["Giới Tính"].Value.ToString();
                txt_Dob.Text = row.Cells["Ngày Sinh"].Value.ToString();
                txt_IDProof.Text = row.Cells["CMND/CCCD"].Value.ToString();
                txt_Address.Text = row.Cells["Địa Chỉ"].Value.ToString();
                txt_Checkin.Text = row.Cells["Ngày Nhận Phòng"].Value.ToString();

                // Lấy ID phòng và thiết lập lại các ComboBox liên quan
                rid = int.Parse(row.Cells["ID Phòng"].Value.ToString());
                query = $"SELECT bed, roomType FROM rooms WHERE roomid = {rid}";
                DataSet ds = fn.getData(query);

                txt_Bed.Text = ds.Tables[0].Rows[0][0].ToString();
                txt_Room.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            LoadCustomerData();
        }

        private void cmb_Discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Price.Text != "")
            {
                try
                {
                    decimal originalPrice = decimal.Parse(txt_Price.Text);
                    int discount = int.Parse(cmb_Discount.SelectedItem.ToString().Replace("%", ""));

                    // Tính giá cuối cùng sau khi giảm giá
                    decimal finalPrice = originalPrice - (originalPrice * discount / 100);
                    lbl_FinalPrice.Text = finalPrice.ToString("N2"); // Hiển thị giá cuối cùng
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra giá phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_FinalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
            