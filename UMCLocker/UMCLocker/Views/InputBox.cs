using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMCLocker.Views
{
    public partial class InputBox : Form
    {

        public delegate void CloseHandler(int number, int index, string type, string formType);
        public event CloseHandler OnCloseHandler;
        public string from; // Locker or Shoes
        public InputBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnCloseHandler(int.Parse(txbNumber.Text), int.Parse(txbIndex.Text), (rbFemale.Checked ? Constants.FEMALE : Constants.MALE), from);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
