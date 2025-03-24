using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKhachSan.Report
{
    internal class Payment
    {
        public string cname { get; set; }
        public string checkin  { get; set; }
        public string checkout { get; set; }
        public string roomid { get; set; }
        public string roomNo { get; set; }
        public string price { get; set; }
        public string Tongtien { get; set; }
    }
}
