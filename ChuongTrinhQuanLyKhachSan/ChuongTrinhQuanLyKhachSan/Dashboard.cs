using ChuongTrinhQuanLyKhachSan.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKhachSan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            btn_AddRoom.PerformClick();
            uC_CheckOut1.Visible = false;
            uC_CustomerDetails1.Visible = false;
            uC_employee1.Visible = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_AddRoom.Left + 50;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btn_CustomerRes_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_CustomerRes.Left + 60;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_CheckOut.Left + 60;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btn_CustomerDetail_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_CustomerDetail.Left + 60;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void uC_employee1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Employee.Left + 60;
            uC_employee1.Visible = true;
            uC_employee1.BringToFront();
        }
    }
}
