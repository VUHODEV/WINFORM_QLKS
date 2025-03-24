using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKhachSan.Report
{
    public partial class REP_Payment : Form
    {

        public REP_Payment(DataTable data)
        {
            InitializeComponent();
        }

        private void REP_Payment_Load(object sender, EventArgs e)
        {
            List<Payment> data = GetCustomerData();

            // Bind the data to the report
            BindReport(data);
        }

        private List<Payment> GetCustomerData()
        {
            // Replace this with your actual database query logic
            function dbFunction = new function();
            string query = "SELECT cname, checkin, checkout, roomid, roomNo, price, sumprice FROM customer Where cname = '" + "'";
            List<Payment> customerList = new List<Payment>();

            var ds = dbFunction.getData(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    customerList.Add(new Payment
                    {
                        cname = row["cName"].ToString(),
                        checkin = row["checkin"].ToString(),
                        checkout = row["checkout"].ToString(),
                        roomid = (row["roomid"].ToString()),
                        roomNo = row["roomNo"].ToString(),
                        price = row["price"].ToString(),
                        Tongtien = row["sumprice"].ToString()
                    });
                }
            }
            return customerList;
        }

        private void BindReport(List<Payment> data)
        {
            // Set up the ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();

            // Add the data source
            ReportDataSource dataSource = new ReportDataSource("DataSet1", data);
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            // Load the report definition file
            reportViewer1.LocalReport.ReportEmbeddedResource = "C:\\WINFORM_DOAN\\ChuongtrinhQuanLyKhachSan\\ChuongTrinhQuanLyKhachSan\\Report\\REP_Payment.rdlc";

            // Refresh the report
            reportViewer1.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}