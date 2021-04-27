using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;

namespace UMCLocker.Business
{
    public class StaffController : MainTabController
    {
        private List<StaffEntity> _staffs;
        private int oldScrollIndex = 0;
        public Action LoadCompleted;
        public StaffController(MainTab view) : base(view)
        {
            view.BgwStaff.DoWork += BgwStaff_DoWork;
            view.BgwStaff.ProgressChanged += BgwStaff_ProgressChanged;
            view.BgwStaff.RunWorkerCompleted += BgwStaff_RunWorkerCompleted;
            view.DgrvStaff.SetDoubleBuffering(true);
            view.DgrvStaff.AutoGenerateColumns = false;
            view.PbStaff.Location = new Point((view.PbStaff.Parent.ClientSize.Width / 2) - (view.PbStaff.Image.Width / 2),
                              (view.PbStaff.Parent.ClientSize.Height / 2) - (view.PbStaff.Image.Height / 2));
            view.PbStaff.Refresh();
            view.TxbSearchStaff.GotFocus += new System.EventHandler(RemoveText);
            view.TxbSearchStaff.LostFocus += new System.EventHandler(AddText);
            view.DpEnterMonth.Format = DateTimePickerFormat.Custom;
            view.DpFilterEnterDate.Format = DateTimePickerFormat.Custom;
            view.DpFilterEnterDate.CustomFormat = "dd-MM-yyyy";
            view.DpEnterMonth.CustomFormat = "MM yyyy";
            view.DpEnterMonth.ShowUpDown = true;
            view.DgrvStaff.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
       
        private void BgwStaff_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {

                 bindingSource.DataSource = _staffs;
                view.DgrvStaff.DataSource = bindingSource;
                bindingSource.ResetBindings(true);
                view.DgrvStaff.Refresh();
                FilterByTextSearch();
                if (view.DgrvStaff.Rows.Count > 0 && oldScrollIndex >= 0)
                {
                    view.DgrvStaff.FirstDisplayedScrollingRowIndex = oldScrollIndex;
                    view.DgrvStaff.Rows[oldScrollIndex].Selected = true;
                    view.DgrvStaff.CurrentCell = view.DgrvStaff.Rows[oldScrollIndex].Cells[0];
                    UpdateTextInfo();
                }
               
                view.PbStaff.Hide();
                ChangeStateButton();
                LoadCompleted();
            }
            catch { }
        }
        private void UpdateTextInfo()
        {
            try
            {
                StaffEntity s = ((List<StaffEntity>)bindingSource.DataSource)[view.DgrvStaff.CurrentCell.RowIndex];
                view.LblInfo.Text = s.info;
            }catch(Exception e)
            {
                view.LblInfo.Text = "";
            }
           
        }
        private void BgwStaff_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void BgwStaff_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            bindingSource = new BindingSource();
            _staffs = (new StaffEntity()).GetAllData();
        }

        public void LoadAll()

        {
            view.BgwStaff.RunWorkerAsync();
        }

        private void ChangeStateButton()
        {
            if (view.DgrvStaff.Rows.Count == 0)
            {
                view.BtnEditStaff.Enabled = false;
                view.BtnDeleteStaff.Enabled = false;
            }
            else
            {
                view.BtnEditStaff.Enabled = true;
                view.BtnDeleteStaff.Enabled = true;
            }

        }
        public void btnAddStaff_Click(object sender, EventArgs e)
        {
            UserNewForm newForm = new UserNewForm(null, FormType.New);
            newForm.OnCloseHandler += view.OnCloseStaffForm;
            newForm.Show();
        }

        public void btnEditStaff_Click(object sender, EventArgs e)
        {
            try
            {                   
                int id = int.Parse(view.DgrvStaff.Rows[view.DgrvStaff.CurrentCell.RowIndex].Cells[11].Value.ToString());
                 StaffEntity s1 = _staffs.Where(x => x.id == id ).FirstOrDefault();
                 StaffEntity s = StaffEntity.GetStaffById(id);
                s.index = s1.index;
                if(s != null)
                {
                    UserNewForm newForm = new UserNewForm(s, FormType.Edit);
                    newForm.OnCloseHandler += view.OnCloseStaffForm;
                    newForm.Show();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void UpdateTableAfterAddNew(StaffEntity staff)
        {
            try
            {
                if (staff.index == 0)
                {
                    staff.index = view.DgrvStaff.RowCount + 1;
                    _staffs.Add(staff);
                    bindingSource.Insert(view.DgrvStaff.RowCount, staff);
                    view.DgrvStaff.Refresh();
                    ChangeStateButton();
                    view.DgrvStaff.FirstDisplayedScrollingRowIndex = view.DgrvStaff.RowCount - 1;
                    view.DgrvStaff.Rows[view.DgrvStaff.RowCount].Selected = true;
                    view.DgrvStaff.CurrentCell = view.DgrvStaff.Rows[view.DgrvStaff.RowCount].Cells[0];
                    UpdateTextInfo();
                }
                else
                {
                    // _staffs.Where(d => d.id == staff.id).Select(d => { d.id = staff.id; return d; }).FirstOrDefault();
                    //_staffs = new StaffEntity().GetAllData(Constants.STATE_ON);
                    // bindingSource.DataSource = _staffs;
                    oldScrollIndex = staff.index - 1;
                    LoadAll();
                }

              
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }

        }
        public void btnDeleteStaff_Click(object sender, EventArgs e)
        {

            try
            {
                StaffEntity s = ((List<StaffEntity>)bindingSource.DataSource)[view.DgrvStaff.CurrentCell.RowIndex];
                ConfirmDelete formConfirm = new ConfirmDelete(s.full_name);
                formConfirm.OK += (isReturnKey, endDate) =>
                {
                    s.end_date = endDate;
                    s.note = isReturnKey ? Constants.NOTE_RETURN_KEY : Constants.NOTE_NOT_RETURN_KEY;
                    ResultInfo result = s.MoveToTrash();
                    if (result.code < 0)
                    {
                        MessageBox.Show(result.message);
                    }
                    else
                    {
                        view.DgrvStaff.Rows.RemoveAt(view.DgrvStaff.CurrentCell.RowIndex);
                        _staffs.RemoveAll(x => x.id == s.id);
                        if (view.DgrvStaff.Rows.Count > 0)
                        {
                            view.LblInfo.Text = ((List<StaffEntity>)bindingSource.DataSource)[0].info;
                        }
                        else
                        {
                            view.LblInfo.Text = "";
                        }
                        view.UpdateLockerAfterDeleteUser();
                        ChangeStateButton();
                    }
                };
                formConfirm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void FilterByTextSearch()
        {
            string searchStr = view.TxbSearchStaff.Text.ToString();
            if (string.IsNullOrEmpty(searchStr) || searchStr == "Nhập mã nhân viên")
            {
                bindingSource.DataSource = _staffs;
            }
            else
            {
                bindingSource.DataSource = _staffs.Where(x => x.staff_code == searchStr).ToList();
            }

            view.DgrvStaff.Refresh();
            ChangeStateButton();
            UpdateTextInfo();

        }

        public void FilterByListStaff(int owned)
        {
            try
            {
                List<StaffEntity> listStaff = new List<StaffEntity>();
                StaffEntity staff = _staffs.Where(x => x.id == owned).FirstOrDefault();
                if (staff != null)
                {
                    listStaff.Add(staff);
                }
                bindingSource.DataSource = listStaff;
                view.DgrvStaff.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

        }

        public void txbSearchStaff_KeyDown(object sender, KeyEventArgs e)
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

        public void RemoveText(object sender, EventArgs e)
        {
            if (view.TxbSearchStaff.Text == "Nhập mã nhân viên")
            {
                view.TxbSearchStaff.Text = "";
                view.TxbSearchStaff.ForeColor = Color.Black;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(view.TxbSearchStaff.Text))
            {
                view.TxbSearchStaff.Text = "Nhập mã nhân viên";
                view.TxbSearchStaff.ForeColor = Color.Gray;
            }

        }

        internal void dgrvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    StaffEntity s = ((List<StaffEntity>)bindingSource.DataSource)[view.DgrvStaff.CurrentCell.RowIndex];
                    view.LblInfo.Text = s.info;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        internal void btnFilterStaff_Click(object sender, EventArgs e)
        {
            DateTime searchEnterDate = view.DpFilterEnterDate.Value.Date;

            if (searchEnterDate == null)
            {
                bindingSource.DataSource = _staffs;
            }
            else
            {
                bindingSource.DataSource = _staffs.Where(x => x.enter_date == searchEnterDate).ToList();
            }

            view.DgrvStaff.Refresh();
            ChangeStateButton();
        }

        internal void btnAllStaff_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = _staffs;
            view.DgrvStaff.Refresh();
            ChangeStateButton();
            view.DpFilterEnterDate.Value = DateTime.Now;
        }

        internal void btnFilterEnterMonth_Click(object sender, EventArgs e)
        {
            DateTime searchMonth = view.DpEnterMonth.Value.Date;

            if (searchMonth == null)
            {
                bindingSource.DataSource = _staffs;
            }
            else
            {
                bindingSource.DataSource = _staffs.Where(x => x.enter_date?.Month == searchMonth.Month && x.enter_date?.Year == searchMonth.Year).ToList();
            }

            view.DgrvStaff.Refresh();
            ChangeStateButton();
        }
    }
}
