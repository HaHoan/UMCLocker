using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
            view.PbStaffTrash.Location = new Point((view.PbStaff.Parent.ClientSize.Width / 2) - (view.PbStaff.Image.Width / 2),
                             (view.PbStaff.Parent.ClientSize.Height / 2) - (view.PbStaff.Image.Height / 2));
            view.PbStaffTrash.Refresh();
            UpdateWhenExpiredDate();
        }

        private void UpdateWhenExpiredDate()
        {
            using (var db = new UMCLOCKEREntities())
            {
                var list = db.Staffs.Where(m => m.state == Constants.STATE_OFF && m.take_back_date < DateTime.Now && m.note != Constants.NOTE_RETURN_KEY).ToList();
                foreach (var staff in list)
                {
                    bool isResolve = false;
                    var locker = db.Lockers.Where(m => m.id == staff.locker_id).FirstOrDefault();
                    if(locker.state == Constants.STATE_RESOLVE)
                    {
                        isResolve = true;
                    }
                    var shoes = db.Shoes.Where(m => m.id == staff.shoes_id).FirstOrDefault();
                    if(shoes.state == Constants.STATE_RESOLVE)
                    {
                        isResolve = true;
                    }
                    if(isResolve)
                    {
                        staff.note = Constants.NOTE_NOT_TAKE_BACK_KEY ;
                    }else
                    {
                        staff.note = Constants.NOTE_TAKE_BACK_KEY;
                    }
                  
                }
                db.SaveChanges();
            }
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
                view.PbStaffTrash.Hide();
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
            _staffs = (new StaffEntity()).GetAllStaffTrash();
        }

        public void LoadAll()
        {
            if (!view.BgStaffTrash.IsBusy)
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
            if (!view.isLogin) return;
            if (view.DgrvTrash.Rows.Count == 0)
            {
                view.BtnDeleteTrash.Enabled = false;
                view.BtnEditTrash.Enabled = false;

            }
            else
            {
                view.BtnDeleteTrash.Enabled = true;
                view.BtnEditTrash.Enabled = true;
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
            else if (string.IsNullOrEmpty(searchNote))
            {
                bindingSource.DataSource = _staffs.Where(x => x.end_date?.Month == searchMonth.Month && x.end_date?.Year == searchMonth.Year).ToList();
            }
            else if (searchMonth == null)
            {
                bindingSource.DataSource = _staffs.Where(x => x.note == searchNote).ToList();

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

        internal void btnExportTrash_Click(object sender, EventArgs e)
        {
            var choofdlog = new FolderBrowserDialog();

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string fileName = ExportUtils.GetFileName(choofdlog, Constants.EXCEL_STAFF_LIQUITE);
                var result = ExportUtils.ExportStaffTrash(_staffs, fileName);
                MessageBox.Show(result.message);

            }
        }

        internal void btnEditTrash_Click(object sender, EventArgs e)
        {
            try
            {
                StaffEntity s = ((List<StaffEntity>)bindingSource.DataSource)[view.DgrvTrash.CurrentCell.RowIndex];
                ConfirmDelete formConfirm = new ConfirmDelete(s);
                formConfirm.OK += (isReturnKey, endDate, note) =>
                {
                    using (var db = new UMCLOCKEREntities())
                    {
                        using (DbContextTransaction transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                var staff = db.Staffs.Where(m => m.id == s.id).FirstOrDefault();
                                staff.note = isReturnKey;
                                if(isReturnKey == Constants.NOTE_NOT_TAKE_BACK_KEY)
                                {
                                    staff.reason_change_key = note.Trim();
                                    var locker = db.Lockers.Where(m => m.id == staff.locker_id).FirstOrDefault();
                                    locker.state = Constants.STATE_RESOLVE;
                                   
                                    var shoes = db.Shoes.Where(m => m.id == staff.shoes_id).FirstOrDefault();
                                    shoes.state = Constants.STATE_RESOLVE;

                                }
                                else
                                {
                                    var locker = db.Lockers.Where(m => m.id == staff.locker_id).FirstOrDefault();
                                    locker.state = Constants.STATE_AVAIABLE;

                                    var shoes = db.Shoes.Where(m => m.id == staff.shoes_id).FirstOrDefault();
                                    shoes.state = Constants.STATE_AVAIABLE;
                                }
                                view.lockerController.LoadAll();
                                view.shoesController.LoadAll();
                                db.SaveChanges();
                                transaction.Commit();
                                view.BgStaffTrash.RunWorkerAsync();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw;
                            }
                           
                        }
                          
                    }
                   
                };
                formConfirm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
