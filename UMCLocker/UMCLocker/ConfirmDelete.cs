using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMCLocker
{
    public partial class ConfirmDelete : Form
    {
        public Action<string, DateTime, string> OK;
        public ConfirmDelete(Staff s)
        {
            InitializeComponent();
            dtpNgayTraKhoa.Value = DateTime.Now;
            lblConfirm.Text = s.full_name + " đã trả khóa chưa?";
            if (!string.IsNullOrEmpty(s.note))
            {
                cbbNote.Text = s.note;
            }
            if(s.end_date is DateTime ed)
            {
                dtpNgayTraKhoa.Value = ed;
            }
            txbReasonKeyCannotTakeback.Text = s.reason_change_key;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK(cbbNote.Text, dtpNgayTraKhoa.Value, txbReasonKeyCannotTakeback.Text);
            Close();
        }
    }
}
