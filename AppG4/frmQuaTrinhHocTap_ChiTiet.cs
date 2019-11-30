using AppG4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG4.Data
{
    public partial class frmQuaTrinhHocTap_ChiTiet : Form
    {
        private HistoryLearning history;
        public frmQuaTrinhHocTap_ChiTiet(HistoryLearning history)
        {
            InitializeComponent();
            if (history != null)
            {
                this.history = history;
                this.Text = "Chỉnh sửa quá trình học tập";
                txtNoiHoc.Text = history.SchoolName;
                
            }
            else
            {
                //Thêm mới
                this.Text = "Thêm mới quá trình chỉnh sửa";
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (history != null)
            {
                //Chỉnh sửa
            }
        }
    }
}
