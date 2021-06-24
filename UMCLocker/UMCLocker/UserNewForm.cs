using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Business;
using UMCLocker.Entities;
using System.Data.Entity;

namespace UMCLocker
{
    public partial class UserNewForm : Form
    {
        public StaffEntity _newStaff;
        private List<DeptEntity> _depts;
        private List<PosEntity> _pos;
        public delegate void CloseHandler();
        public event CloseHandler OnCloseHandler;
        public FormType _type;
        public UserNewForm()
        {
            InitializeComponent();

        }

        public UserNewForm(StaffEntity staff, FormType type)
        {
            InitializeComponent();
            _newStaff = staff;
            _type = type;
        }

        private void UserNewForm_Load(object sender, EventArgs e)
        {
            _depts = (List<DeptEntity>)new DeptEntity().GetAllData();
            _pos = (List<PosEntity>)new PosEntity().GetAllData();
            cbbDepartment.Items.Clear();
            cbbPosition.Items.Clear();
            foreach (Dept dept in _depts)
            {
                cbbDepartment.Items.Add(dept.name);
            }

            foreach (Pos pos in _pos)
            {
                cbbPosition.Items.Add(pos.name);
            }
            this.ActiveControl = txbStaffCode;
        }

        private void SetUpFormForChangeKeyLocker()
        {
            //txbStaffCode.Enabled = false;
            //txbFullName.Enabled = false;
            //rbtnMale.Enabled = false;
            //dtpEnterDate.Enabled = false;
            //rbtnFemale.Enabled = false;
            //cbbDepartment.Enabled = false;
            //cbbPosition.Enabled = false;
        }

        private void SetUpFormForChangeKeyShoes()
        {
            //txbStaffCode.Enabled = false;
            //txbFullName.Enabled = false;
            //rbtnMale.Enabled = false;
            //dtpEnterDate.Enabled = false;
            //rbtnFemale.Enabled = false;
            //cbbDepartment.Enabled = false;
            //cbbPosition.Enabled = false;
        }

        private void SetUpDataForEditMode()
        {
            //txbStaffCode.Enabled = false;
            //txbFullName.Enabled = false;
            //rbtnMale.Enabled = false;
            //dtpEnterDate.Enabled = true;
            //rbtnFemale.Enabled = false;
            //cbbDepartment.Enabled = true;
            //cbbPosition.Enabled = true;
            cbbReasonChangeKey.Enabled = true;
            txbStaffCode.Text = _newStaff.staff_code;
            txbFullName.Text = _newStaff.full_name;
            if (_newStaff.gender == Constants.MALE)
            {
                rbtnMale.Checked = true;
            }
            else rbtnFemale.Checked = true;
            if (_newStaff.enter_date is DateTime date)
            {
                dtpEnterDate.Value = date;
            }
            if (_newStaff.department != null)
            {
                for (int i = 0; i < _depts.Count; i++)
                {
                    if (_depts[i].id == _newStaff.department)
                    {
                        cbbDepartment.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (_newStaff.position != null)
            {
                for (int i = 0; i < _pos.Count; i++)
                {
                    if (_pos[i].id == _newStaff.position)
                    {
                        cbbPosition.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (_newStaff.locker_id != null)
            {
                txbLockerNumber.Text = _newStaff.Locker.locker_number.ToString();
                txbLockerIndex.Text = _newStaff.Locker.locker_index.ToString();
            }
            else
            {
                txbLockerNumber.Text = "";
                txbLockerIndex.Text = "";
            }

            if (_newStaff.shoes_id != null)
            {
                txbShoesNumber.Text = _newStaff.Sho.shoes_number.ToString();
                txbShoesIndex.Text = _newStaff.Sho.shoes_index.ToString();
            }
            else
            {
                txbShoesNumber.Text = "";
                txbShoesIndex.Text = "";
            }
            txbLockerNumber.SelectAll();
            txbLockerNumber.Focus();
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            SaveStaff();
        }

        private void SaveStaff()
        {
            try
            {
                _newStaff.staff_code = txbStaffCode.Text.ToString().Trim();
                if (_newStaff.CheckUserExist() && _type == FormType.New)
                {
                    MessageBox.Show("Đã tồn tại nhân viên " + _newStaff.staff_code + " này rồi!");
                    txbStaffCode.SelectAll();
                    txbStaffCode.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(_newStaff.staff_code))
                {
                    txbStaffCode.Focus();
                    lblStaffCodeError.ForeColor = Color.Red;
                    return;
                }
                _newStaff.full_name = txbFullName.Text.ToString().Trim();
                if (string.IsNullOrEmpty(_newStaff.full_name))
                {
                    txbFullName.Focus();
                    lblFullNameError.ForeColor = Color.Red;
                    return;
                }
                if (rbtnMale.Checked)
                {
                    _newStaff.gender = Constants.MALE;
                   
                    _newStaff.Locker.locker_type = Constants.MALE;
                    _newStaff.Sho.shoes_type = Constants.MALE;
                }
                else
                {
                    _newStaff.gender = Constants.FEMALE;
                    _newStaff.Locker.locker_type = Constants.FEMALE;
                    _newStaff.Sho.shoes_type = Constants.FEMALE;
                }
                _newStaff.enter_date = dtpEnterDate.Value.Date;
                try
                {
                    _newStaff.department = _depts.Where(m => m.name == cbbDepartment.Text.Trim()).FirstOrDefault().id;
                    _newStaff.position = _pos.Where(m => m.name == cbbPosition.Text.Trim()).FirstOrDefault().id;
                }
                catch (Exception) { }
              
                ResultInfo result = new ResultInfo();
                if (!string.IsNullOrEmpty(txbLockerNumber.Text.Trim()) && !string.IsNullOrEmpty(txbLockerIndex.Text.Trim()))
                {
                    result = new LockerEntity()
                    {
                        locker_number = int.Parse(txbLockerNumber.Text),
                        locker_index = int.Parse(txbLockerIndex.Text),
                        locker_type = _newStaff.Locker.locker_type,
                        owned = _newStaff.id
                    }.IsLockerInUsed();
                    if (result.code != Constants.SUCCESS)
                    {
                        MessageBox.Show(result.message);
                        return;
                    }
                    else
                    {
                        _newStaff.locker_id = int.Parse(result.message);
                        if (_newStaff.locker_id is int locker_id)
                        {
                            _newStaff.Locker.id = locker_id;
                            _newStaff.Locker.locker_number = int.Parse(txbLockerNumber.Text);
                            _newStaff.Locker.locker_index = int.Parse(txbLockerIndex.Text);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(txbShoesNumber.Text.Trim()) && !string.IsNullOrEmpty(txbShoesIndex.Text.Trim()))
                {
                    result = new ShoesEntity()
                    {
                        shoes_number = int.Parse(txbShoesNumber.Text),
                        shoes_index = int.Parse(txbShoesIndex.Text),
                        shoes_type = _newStaff.Sho.shoes_type,
                        owned = _newStaff.id
                    }.IsShoesInUsed();
                    if (result.code != Constants.SUCCESS)
                    {
                        MessageBox.Show(result.message);
                        return;
                    }
                    else
                    {

                        _newStaff.shoes_id = int.Parse(result.message);
                        if (_newStaff.shoes_id is int shoes_id)
                        {
                            _newStaff.Sho.id = shoes_id;
                            _newStaff.Sho.shoes_number = int.Parse(txbShoesNumber.Text);
                            _newStaff.Sho.shoes_index = int.Parse(txbShoesIndex.Text);
                        }
                    }
                }

                if (_type == FormType.Edit || _type == FormType.OnlyChangeKeyLocker || _type == FormType.OnlyChangeKeyShoes)
                {
                    _newStaff.reason_change_key = cbbReasonChangeKey.Text;
                    _newStaff.date_change_key = DateTime.Now;
                    result = _newStaff.Update();
                }
                else if (_type == FormType.New)
                {
                    result = new StaffEntity().Insert(_newStaff);
                    _newStaff.id = int.Parse(result.message);
                }

                if (result.code == Constants.SUCCESS)
                {
                    txbStaffCode.SelectAll();
                    txbStaffCode.Focus();
                    lblStatus.Text = "OK";
                }
                else if (result.code == Constants.ERROR_DUPLICATE_DATA)
                {
                    lblStaffCodeError.Text = Constants.DUPPLICATE;
                    lblStaffCodeError.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    MessageBox.Show(result.message);
                    return;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void txbStaffCode_TextChanged(object sender, EventArgs e)
        {
            lblStaffCodeError.Text = Constants.REQUIRED;
            lblStaffCodeError.ForeColor = Color.Black;
        }

        private void txbFullName_TextChanged(object sender, EventArgs e)
        {
            lblFullNameError.ForeColor = Color.Black;
        }

        private void UserNewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseHandler();
        }


        private void UserNewForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    btnSaveStaff_Click(sender, e);
                }
                else if (e.KeyCode.Equals(Keys.X))
                {
                    Close();
                }
            }
        }

        private void UserNewForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
            {
                btnSaveStaff.PerformClick();
            }
        }

        private void UserNewForm_Shown(object sender, EventArgs e)
        {
            KeyPreview = true;
            if (_type == FormType.New)
            {
                _newStaff = new StaffEntity();
                _newStaff.gender = rbtnMale.Checked ? Constants.MALE : Constants.FEMALE;
            }
            if (_newStaff.Locker == null) _newStaff.Locker = new Locker();
            if (_newStaff.Sho == null) _newStaff.Sho = new Sho();

            if (_type == FormType.Edit)
            {
                SetUpDataForEditMode();
            }
            else if (_type == FormType.OnlyChangeKeyLocker)
            {
                SetUpDataForEditMode();
                SetUpFormForChangeKeyLocker();
            }
            else if (_type == FormType.OnlyChangeKeyShoes)
            {
                SetUpDataForEditMode();
                SetUpFormForChangeKeyShoes();
            }

        }

        private void txbLockerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyEnterNumber(sender, e);
        }

        private void onlyEnterNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbLockerIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyEnterNumber(sender, e);
        }

        private void txbShoesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyEnterNumber(sender, e);
        }

        private void txbShoesIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyEnterNumber(sender, e);
        }

        private void txbLockerNumber_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                txbLockerIndex.SelectAll();
                txbLockerIndex.Focus();
            }
        }

        private void txbLockerIndex_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                txbShoesNumber.SelectAll();
                txbShoesNumber.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txbLockerNumber.SelectAll();
                txbLockerNumber.Focus();
            }
        }

        private void txbShoesNumber_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                txbShoesIndex.SelectAll();
                txbShoesIndex.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txbLockerNumber.SelectAll();
                txbLockerIndex.SelectAll();
            }
        }

        private void txbShoesIndex_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveStaff();
            }

        }

        private void txbStaffCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && _type == FormType.Edit)
            {
                var db = new UMCLOCKEREntities();
                var staff = db.Staffs.Include(m => m.Locker).Include(m => m.Sho).Where(m => m.staff_code == txbStaffCode.Text.Trim()).FirstOrDefault();
                if(staff == null)
                {
                    MessageBox.Show("Chưa có nhân viên này!");
                    return;
                }
                _newStaff = new StaffEntity(staff);
                lblStatus.Text = "";
                SetUpDataForEditMode();
            }
        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
