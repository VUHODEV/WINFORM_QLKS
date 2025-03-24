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
    public partial class UC_employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_employee()
        {
            InitializeComponent();
        }
        private void UC_employee_Load(object sender, EventArgs e)
        {
                getMaxID();
        }


        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                label_ToSet.Text = (num + 1).ToString();
            }
        }

        private void btn_Registaion_Click(object sender, EventArgs e)
        {
            if (txt_FullName.Text != "" && txt_MobileNumber.Text != "" && txt_Gender.Text != "" && txt_Email.Text != "" && txt_UserName.Text != "" && txt_Password.Text != "")
            {
                String fullName = txt_FullName.Text;
                Int64 mobileNum = Int64.Parse(txt_MobileNumber.Text);
                String gender = txt_Gender.Text;
                String email = txt_Email.Text;
                String userName = txt_UserName.Text;
                String pass = txt_Password.Text;

                query = "insert into employee (ename, mobile, gender, emailid, username, pass) values ('" + fullName + "', " + mobileNum + ", '" + gender + "','" + email + "','" + userName + "','" + pass + "')";
                fn.setData(query, "Đăng Ký Thành Công!!");

                clearAll();
                getMaxID();
            }
        }

        public void clearAll()
        {
            txt_FullName.Clear();
            txt_MobileNumber.Clear();
            txt_Gender.SelectedIndex = -1;
            txt_Email.Clear();
            txt_UserName.Clear();
            txt_Password.Clear();
        }

        private void tab_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Employee.SelectedIndex == 1)
            {
                setEmployee(dgv_Employee);
            }
            else if (tab_Employee.SelectedIndex == 2)
            {
                setEmployee(dgv_DeleteEmployee);
            }
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void txt_Delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txt_ID.Text + "";
                    fn.setData(query, "Thông Tin Nhân Viên Đã Được Xóa!!");
                    tab_Employee_SelectedIndexChanged(this, null);
                }
            }
        }

        private void UC_employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
