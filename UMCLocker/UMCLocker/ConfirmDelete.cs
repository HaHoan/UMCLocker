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
        public Action<bool, DateTime> OK;
        public ConfirmDelete(string name)
        {
            InitializeComponent();
            dtpEndDate.Value = DateTime.Now;
            lblConfirm.Text = name + " đã trả khóa chưa?";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK(rbReturnKey.Checked,dtpEndDate.Value);
            Close();
        }
    }
}
