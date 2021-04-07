using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;

namespace UMCLocker.Business
{
    public class StaffTrashController : MainTabController
    {
        private List<StaffEntity> _staffs;

        public StaffTrashController(MainTab view) : base(view)
        {
            view.BgStaffTrash.DoWork += BgwStaffTrash_DoWork;
            view.BgStaffTrash.ProgressChanged += BgwStaffTrash_ProgressChanged;
            view.BgStaffTrash.RunWorkerCompleted += BgwStaffTrash_RunWorkerCompleted;
            view.DgrvTrash.SetDoubleBuffering(true);
            view.DgrvTrash.AutoGenerateColumns = false;
            view.TxbSearchTrash.GotFocus += new System.EventHandler(RemoveText);
            view.TxbSearchTrash.LostFocus += new System.EventHandler(AddText);
            view.DpMonth.Format = DateTimePickerFormat.Custom;
            view.DpMonth.CustomFormat = "MM yyyy";
            view.DpMonth.ShowUpDown = true;
        }

        private void BgwStaffTrash_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                bindingSource.DataSource = _staffs;
                view.DgrvTrash.DataSource = bindingSource;
                bindingSource.ResetBindings(true);
                view.DgrvTrash.Refresh();
                ChangeStateButton();
            }
            catch { }
        }

        private void BgwStaffTrash_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void BgwStaffTrash_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            bindingSource = new BindingSource();
            _staffs = (new StaffEntity()).GetAllData(Constants.STATE_OFF);
        }

        public void LoadAll()
        {
            view.BgStaffTrash.RunWorkerAsync();
        }

        internal void btnDeleteTrash_Click(object sender, EventArgs e)
        {
            try
            {
                StaffEntity s = ((List<StaffEntity>)bindingSource.DataSource)[view.DgrvTrash.CurrentCell.RowIndex];
                if (MessageBox.Show(string.Format(Constants.CONFIRM_DELETE_STAFF_FOREVER, s.full_name), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResultInfo result = s.Delete();
                    if (result.code < 0)
                    {
                        MessageBox.Show(result.message);
                    }
                    else
                    {
                        view.DgrvTrash.Rows.RemoveAt(view.DgrvTrash.CurrentCell.RowIndex);
                        _staffs.RemoveAll(x => x.id == s.id);
                        view.UpdateLockerAfterDeleteUser();
                        ChangeStateButton();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void ChangeStateButton()
        {
            if (view.DgrvTrash.Rows.Count == 0)
            {
                view.BtnDeleteTrash.Enabled = false;
            }
            else
            {
                view.BtnDeleteTrash.Enabled = true;
            }

        }

        internal void txbSearchTrash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterByTextSearch();
            }
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                AddText(null, null);
            }
            else
            {
                RemoveText(null, null);
            }
        }
        private void FilterByTextSearch()
        {
            string searchStr = view.TxbSearchTrash.Text.ToString();
            if (string.IsNullOrEmpty(searchStr))
            {
                bindingSource.DataSource = _staffs;
            }
            else
            {
                bindingSource.DataSource = _staffs.Where(x => x.staff_code == searchStr).ToList();
            }

            view.DgrvTrash.Refresh();
            ChangeStateButton();

        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (view.TxbSearchTrash.Text == "Nhập mã nhân viên")
            {
                view.TxbSearchTrash.Text = "";
                view.TxbSearchTrash.ForeColor = Color.Black;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(view.TxbSearchTrash.Text))
            {
                view.TxbSearchTrash.Text = "Nhập mã nhân viên";
                view.TxbSearchTrash.ForeColor = Color.Gray;
            }

        }

        internal void btnTrashFilter_Click(object sender, EventArgs e)
        {
            string searchNote = view.CbbNote.Text.ToString();
            DateTime searchMonth = view.DpMonth.Value.Date;

            if (string.IsNullOrEmpty(searchNote) && searchMonth == null)
            {
                bindingSource.DataSource = _staffs;
            }
            else
            {
                bindingSource.DataSource = _staffs.Where(x => x.note == searchNote && x.end_date?.Month == searchMonth.Month && x.end_date?.Year == searchMonth.Year).ToList();
            }

            view.DgrvTrash.Refresh();
            ChangeStateButton();
        }

        internal void btnTrashAll_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = _staffs;
            view.DgrvTrash.Refresh();
            ChangeStateButton();
            view.DpMonth.Value = DateTime.Now;
            view.CbbNote.Text = "";
        }
    }
}
