using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;
using UMCLocker.Views;

namespace UMCLocker.Business
{
    public class LockerController : MainTabController
    {
        private List<Locker> _lockers;
        private Dictionary<int, List<int>> _dictLocker;
        private Locker selectedLocker;

        public LockerController(MainTab view) : base(view)
        {
            view.BgwLocker.DoWork += BgwLocker_DoWork;
            view.BgwLocker.RunWorkerCompleted += BgwLocker_RunWorkerCompleted;
            view.DgrvLocker.SetDoubleBuffering(true);
        }

        private void BgwLocker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Số tủ");
            dt.Columns.Add("Số ô");
            dt.Columns.Add("Loại");
            dt.Columns.Add("Trạng thái");
            view.DgrvLocker.DataSource = dt;
            view.DgrvLocker.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            view.DgrvLocker.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            view.DgrvLocker.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            AddLockerToTable(_lockers);

            _dictLocker = LockerEntity.AddLockerToDict(_lockers);
            view.LblNumberLocker.Text = view.DgrvLocker.RowCount.ToString();
            UpdateCbbFilter();
            selectedLocker = new Locker();
        }

        private void BgwLocker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _lockers = (List<Locker>)(new LockerEntity()).GetAllData();
        }

        public void LoadAll()
        {
            view.BgwLocker.RunWorkerAsync();
        }

        private void AddLockerToTable(List<Locker> lockers)
        {
            if (lockers == null) return;
            dt.Clear();
            foreach (Locker locker in lockers)
            {
                DataRow row = dt.NewRow();
                row[0] = locker.locker_number;
                row[1] = locker.locker_index;
                row[2] = (locker.locker_type == Constants.FEMALE) ? "Tủ nữ" : "Tủ nam";
                row[3] = locker.state;
                dt.Rows.Add(row);
            }
            ChangeStateButton();
        }

        private void ChangeStateButton()
        {
            if (!view.isLogin) return;
            if (view.DgrvLocker.Rows.Count == 0)
            {
                view.BtnDeleteLocker.Enabled = false;
            }
            else
            {
                view.BtnDeleteLocker.Enabled = true;
            }
        }

        private void UpdateCbbFilter()
        {
            if (_dictLocker == null) return;
            view.CbbLockerNumber.Items.Clear();
            view.CbbLockerIndex.Items.Clear();
            view.CbbLockerType.Items.Clear();
            view.CbbLockerNumber.Text = "Chọn tủ";
            view.CbbLockerIndex.Text = "Chọn ô";
            view.CbbLockerType.Text = "Chọn loại";
            foreach (int lockerNumber in _dictLocker.Keys)
            {
                view.CbbLockerNumber.Items.Add(lockerNumber);
            }
            view.CbbLockerType.Items.Add("Tủ nam");
            view.CbbLockerType.Items.Add("Tủ nữ");
        }

        public void btnAddLocker_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox();
            inputBox.from = Constants.LOCKER;
            inputBox.OnCloseHandler += view.OnCloseInputBox;
            inputBox.ShowDialog();
        }

        public void InputBoxReturnOK(Locker locker)
        {
            ResultInfo result = new LockerEntity().Insert(locker);
            if (result.code == Constants.SUCCESS)
            {
                // insert success
                DataRow row = dt.NewRow();
                row[0] = locker.locker_number;
                row[1] = locker.locker_index;
                row[2] = (locker.locker_type == Constants.FEMALE) ? "Tủ nữ" : "Tủ nam";
                row[3] = locker.state;
                dt.Rows.Add(row);
                _lockers.Add(locker);
                _dictLocker.AddObjectToDict(locker.locker_number, locker.locker_index);
                UpdateCbbFilter();
                view.DgrvLocker.Refresh();
                ChangeStateButton();
            }
            else if (result.code == Constants.ERROR_DUPLICATE_DATA)
            {
                MessageBox.Show(result.message);
                return;
            }
            else if (result.code < 0)
            {
                MessageBox.Show(result.message);
                return;
            }
        }

        public void btnDeleteLocker_Click(object sender, EventArgs e)
        {
            try
            {
                int lockerNumber = int.Parse(view.DgrvLocker.Rows[view.DgrvLocker.CurrentCell.RowIndex].Cells[0].Value.ToString());
                int lockerIndex = int.Parse(view.DgrvLocker.Rows[view.DgrvLocker.CurrentCell.RowIndex].Cells[1].Value.ToString());
                string lockerType = view.DgrvLocker.Rows[view.DgrvLocker.CurrentCell.RowIndex].Cells[2].Value.ToString() == "Tủ nữ" ? "F" : "M";
                if (MessageBox.Show(string.Format(Constants.CONFIRM_DELETE_KEY, lockerNumber + "-" + lockerIndex), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_lockers[view.DgrvLocker.CurrentCell.RowIndex].owned is int owned)
                    {
                        StaffEntity staff = StaffEntity.GetStaffById(owned);
                        if (CustomViews.MessageBox("Warning", string.Format(Constants.NOTICE_DELETE_FOREIGN_KEY, staff.full_name), "Change key", Properties.Resources.key_icon) == DialogResult.OK)
                        {
                            // Show user form to change key
                            UserNewForm newForm = new UserNewForm(staff, FormType.OnlyChangeKeyLocker);
                            newForm.OnCloseHandler += view.OnCloseStaffForm;
                            newForm.Show();
                        }
                    }
                    else
                    {
                        LockerEntity l = new LockerEntity() { locker_number = lockerNumber, locker_index = lockerIndex, locker_type = lockerType };
                        ResultInfo result = l.Delete();
                        if (result.code < 0)
                        {
                            MessageBox.Show(result.message);
                        }
                        else
                        {
                            view.DgrvLocker.Rows.RemoveAt(view.DgrvLocker.CurrentCell.RowIndex);
                            _lockers.RemoveAll(x => x.locker_index == lockerIndex && x.locker_number == lockerNumber);
                            _dictLocker.RemoveElement(l.locker_number, l.locker_index);
                            UpdateCbbFilter();
                            ChangeStateButton();
                            MessageBox.Show(result.message);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        public void cbbLockerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedLocker.locker_number = int.Parse(view.CbbLockerNumber.SelectedItem.ToString());
                MatchLockerIndex(selectedLocker.locker_number);
            }
            catch
            {

            }
        }

        private void MatchLockerIndex(int lNumber)
        {
            List<int> lockerIndex = _dictLocker[lNumber];
            view.CbbLockerIndex.Items.Clear();
            foreach (int i in lockerIndex)
            {
                view.CbbLockerIndex.Items.Add(i);
            }
            view.CbbLockerIndex.SelectedIndex = 0;
        }
        public void cbbLockerNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                selectedLocker.locker_number = int.Parse(view.CbbLockerNumber.Text.ToString());
                MatchLockerIndex(selectedLocker.locker_number);
            }
            catch
            {

            }
        }

        public void btnLockerSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            try
            {
                DataView dv = dt.DefaultView;
                StringBuilder filerStr = new StringBuilder();
                if (selectedLocker.locker_number > 0)
                {
                    filerStr.Append(string.Format("[Số tủ] = '{0}'", selectedLocker.locker_number));
                }
                if (selectedLocker.locker_index > 0)
                {
                    if (!string.IsNullOrEmpty(filerStr.ToString()))
                    {
                        filerStr.Append(" AND ");
                    }
                    filerStr.Append(string.Format("[Số ô] = '{0}'", selectedLocker.locker_index));
                }
                if (!string.IsNullOrEmpty(selectedLocker.locker_type))
                {
                    if (!string.IsNullOrEmpty(filerStr.ToString()))
                    {
                        filerStr.Append(" AND ");
                    }
                    filerStr.Append(string.Format("[Loại] = '{0}'", selectedLocker.locker_type));
                }
                if (!string.IsNullOrEmpty(selectedLocker.state))
                {
                    if (!string.IsNullOrEmpty(filerStr.ToString()))
                    {
                        filerStr.Append(" AND ");
                    }
                    filerStr.Append(string.Format("[Trạng thái] = '{0}'", selectedLocker.state));
                }
                dv.RowFilter = filerStr.ToString();
                view.DgrvLocker.DataSource = dv.ToTable();
                view.DgrvLocker.Refresh();
                view.LblNumberLocker.Text = view.DgrvLocker.RowCount.ToString();
                ChangeStateButton();
            }
            catch { }
        }
        internal void btnLockerList_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("[Số tủ] like '%{0}%'", "");

            // If show all list -> cbb will be reset to -1;
            view.CbbLockerNumber.SelectedIndex = -1;
            view.CbbLockerIndex.SelectedIndex = -1;
            view.CbbLockerType.SelectedIndex = -1;
            view.CbbLockerState.SelectedIndex = -1;
            view.CbbLockerNumber.Text = "Chọn tủ";
            view.CbbLockerIndex.Text = "Chọn ô";
            view.CbbLockerType.Text = "Chọn loại";
            view.CbbLockerState.Text = "Trạng thái";
            selectedLocker.locker_number = 0;
            selectedLocker.locker_index = 0;
            selectedLocker.locker_type = "";
            selectedLocker.state = "";
            view.DgrvLocker.DataSource = dv.ToTable();
            view.LblNumberLocker.Text = view.DgrvLocker.RowCount.ToString();
        }

        internal void cbbLockerState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.CbbLockerState.SelectedItem == null)
            {
                selectedLocker.state = "";
            }
            else
                selectedLocker.state = view.CbbLockerState.SelectedItem.ToString();
        }

        internal void cbbLockerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.CbbLockerType.SelectedItem == null)
            {
                selectedLocker.locker_type = "";
            }
            else
                selectedLocker.locker_type = view.CbbLockerType.SelectedItem.ToString();
        }

        public void cbbLockerIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedLocker.locker_index = int.Parse(view.CbbLockerIndex.SelectedItem.ToString());
            }
            catch
            {

            }
        }

        public void cbbLockerIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                selectedLocker.locker_index = int.Parse(view.CbbLockerIndex.Text.ToString());
            }
            catch
            {

            }
        }

        internal void btnEditLocker_Click(object sender, EventArgs e)
        {
            try
            {
                int lockerNumber = int.Parse(view.DgrvLocker.Rows[view.DgrvLocker.CurrentCell.RowIndex].Cells[0].Value.ToString());
                int lockerIndex = int.Parse(view.DgrvLocker.Rows[view.DgrvLocker.CurrentCell.RowIndex].Cells[1].Value.ToString());
                string lockerType = view.DgrvLocker.Rows[view.DgrvLocker.CurrentCell.RowIndex].Cells[2].Value.ToString() == "Tủ nữ" ? "F" : "M";
                var locker = LockerEntity.lockerBy(lockerNumber, lockerIndex, lockerType);
                if (locker.state != Constants.STATE_RESOLVE)
                {
                    MessageBox.Show("Locker này không cần xử lý!");
                    return;
                }
                if (MessageBox.Show(string.Format(Constants.CONFIRM_EDIT_KEY, lockerNumber + "-" + lockerIndex), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool result = LockerEntity.updateState(Constants.STATE_AVAIABLE, lockerNumber, lockerIndex, lockerType);
                    if (result)
                    {
                        LoadAll();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public void dgrvLocker_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


            }
        }

        public void dgrvLocker_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int locker_number = int.Parse(view.DgrvLocker.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int locker_index = int.Parse(view.DgrvLocker.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string locker_type = view.DgrvLocker.Rows[e.RowIndex].Cells[2].Value.ToString() == "Tủ nữ" ? Constants.FEMALE : Constants.MALE;

                    Locker lockerSelected = _lockers.Where(x => x.locker_index == locker_index && x.locker_number == locker_number && x.locker_type == locker_type).FirstOrDefault();

                    DetailKeyForm formDetail = new DetailKeyForm(lockerSelected, null);
                    formDetail.ShowDialog();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void cbbLockerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void cbbLockerIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
