using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //查詢
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strNOBR = tbNOBR.Text;
            string strH_CODE = tbKEY_MAN.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var data = from a in db.ABS
                       where a.NOBR == strNOBR //&& a.BDATE >= new DateTime(2022, 1, 1) && a.BDATE <= new DateTime(2022, 1, 31)
                       select new TestDto { 員工編號 = a.NOBR, 請假日期 = a.BDATE, 開始時間 = a.BTIME, 結束時間 = a.ETIME ,建檔人員 = a.KEY_MAN};
            dgvTable.DataSource = data; 
        }
        //新增
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string strNOBR = tbNOBR.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var newCustomer = new ABS
            {
                NOBR = strNOBR,
                BDATE = DateTime.Now,
                EDATE = DateTime.Now,
                BTIME = "",
                ETIME = "",
                H_CODE = "",
                TOL_HOURS = 0,
                KEY_MAN = "",
                KEY_DATE = DateTime.Now,
                YYMM = "",
                NOTEDIT = true,
                NOTE = "",
                SYSCREATE = true,
                TOL_DAY = 0,
                A_NAME = "",
                SERNO = "",
                nocalc = true,
                SYSCREATE1 = true,
                Memo = "",
                Guid = "",
                Balance = 0,
                LeaveHours = 0,
                OT_HRS = 0,
            };
            db.ABS.InsertOnSubmit(newCustomer);
            db.SubmitChanges();
        }
        //修改
        private void btnModify_Click(object sender, EventArgs e)
        {
            string strNOBR = tbNOBR.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();
            string strKEY_MAN = tbKEY_MAN.Text;//strKEY_MAN.Text;
            var data = (from a in db.ABS
                        where a.NOBR == strKEY_MAN
                        select a).First();
            data.KEY_MAN = strKEY_MAN;
            db.SubmitChanges();
        }
        //刪除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strNOBR = tbNOBR.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var data = (from a in db.ABS
                        where a.NOBR == strNOBR
                        select a).First();
            db.ABS.DeleteOnSubmit(data);
            db.SubmitChanges();
        }

        public class TestDto
        {
            public string 員工編號 { get; set; }
            public string 員工姓名 { get; set; }
            public DateTime 請假日期 { get; set; }
            public string 開始時間 { get; set; }
            public string 結束時間 { get; set; }
            public string 請假代碼 { get; set; }
            public string 建檔人員 { get; set; }
        }
    }
}
