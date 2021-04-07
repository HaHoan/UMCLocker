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

namespace UMCLocker
{
    public partial class UserNewForm : Form
    {
        public StaffEntity _newStaff;
        private List<DeptEntity> _depts;
        private List<PosEntity> _pos;
        private Dictionary<int, List<int>> _dictLocker;
        private Dictionary<int, List<int>> _dictShoes;
        public delegate void CloseHandler(StaffEntity staff);
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
            
        }

        private void SetUpFormForChangeKeyLocker()
        {
            txbStaffCode.Enabled = false;
            txbFullName.Enabled = false;
            rbtnMale.Enabled = false;
            dtpEnterDate.Enabled = false;
            rbtnFemale.Enabled = false;
            cbbDepartment.Enabled = false;
            cbbPosition.Enabled = false;
            cbbShoesIndex.Enabled = false;
            cbbShoesNumber.Enabled = false;
        }

        private void SetUpFormForChangeKeyShoes()
        {
            txbStaffCode.Enabled = false;
            txbFullName.Enabled = false;
            rbtnMale.Enabled = false;
            dtpEnterDate.Enabled = false;
            rbtnFemale.Enabled = false;
            cbbDepartment.Enabled = false;
            cbbPosition.Enabled = false;
            cbbLockerIndex.Enabled = false;
            cbbLockerNumber.Enabled = false;
        }

        private void SetUpDataForEditMode()
        {
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
                cbbLockerNumber.SelectedIndex = cbbLockerNumber.Items.IndexOf(_newStaff.Locker.locker_number);
                MatchLockerIndex(_newStaff.Locker.locker_number);
                cbbLockerIndex.SelectedIndex = cbbLockerIndex.Items.IndexOf(_newStaff.Locker.locker_index);
            }

            if (_newStaff.shoes_id != null)
            {
                cbbShoesNumber.SelectedIndex = cbbShoesNumber.Items.IndexOf(_newStaff.Sho.shoes_number);
                MatchShoesIndex(_newStaff.Sho.shoes_number);
                cbbShoesIndex.SelectedIndex = cbbShoesIndex.Items.IndexOf(_newStaff.Sho.shoes_index);
            }

        }
        private void SetUpData()
        {
            _depts = (List<DeptEntity>)new DeptEntity().GetAllData();
            _pos = (List<PosEntity>)new PosEntity().GetAllData();
            List<Locker> lockers = new LockerEntity().GetEmptyData(_newStaff.id, _newStaff.gender);
            List<Sho> shoes = new ShoesEntity().GetEmptyData(_newStaff.id, _newStaff.gender);
            _dictLocker = new Dictionary<int, List<int>>();
            _dictShoes = new Dictionary<int, List<int>>();
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
            _dictLocker = LockerEntity.AddLockerToDict(lockers);
            foreach (int lockerNumber in _dictLocker.Keys)
            {
                cbbLockerNumber.Items.Add(lockerNumber);
            }

            _dictShoes = ShoesEntity.AddShoesToDict(shoes);
            foreach (int shoesNumber in _dictShoes.Keys)
            {
                cbbShoesNumber.Items.Add(shoesNumber);
            }

        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            try
            {
                _newStaff.staff_code = txbStaffCode.Text.ToString().Trim();
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
                ResultInfo result = new ResultInfo();
                if (_newStaff.Locker.locker_number > 0 && _newStaff.Locker.locker_index > 0)
                {
                    result = new LockerEntity()
                    {
                        locker_number = _newStaff.Locker.locker_number,
                        locker_index = _newStaff.Locker.locker_index,
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
                        }
                    }
                }

                if (_newStaff.Sho.shoes_number > 0 && _newStaff.Sho.shoes_index > 0)
                {
                    result = new ShoesEntity()
                    {
                        shoes_number = _newStaff.Sho.shoes_number,
                        shoes_index = _newStaff.Sho.shoes_index,
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
                        }
                    }
                }

                if (_type == FormType.Edit || _type == FormType.OnlyChangeKeyLocker || _type == FormType.OnlyChangeKeyShoes)
                {
                    result = _newStaff.Update();
                }
                else if (_type == FormType.New)
                {
                    result = new StaffEntity().Insert(_newStaff);
                    _newStaff.id = int.Parse(result.message);
                }

                if (result.code == Constants.SUCCESS)
                {
                    OnCloseHandler(_newStaff);
                    Close();
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

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            _newStaff.department = _depts[cbbDepartment.SelectedIndex].id;
        }

        private void cbbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            _newStaff.position = _pos[cbbPosition.SelectedIndex].id;
        }

        private void cbbLockerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLockerNumber.SelectedIndex >= 0)
            {
                _newStaff.Locker.locker_number = int.Parse(cbbLockerNumber.SelectedItem.ToString());
                MatchLockerIndex(_newStaff.Locker.locker_number);
            }
        }

        private void MatchLockerIndex(int? lNumber)
        {
            try
            {
                if (lNumber is int number)
                {
                    List<int> lockerIndex = _dictLocker[number];
                    cbbLockerIndex.Items.Clear();
                    foreach (int i in lockerIndex)
                    {
                        cbbLockerIndex.Items.Add(i);
                    }
                    cbbLockerIndex.Text = lockerIndex[0].ToString();
                }
            }
            catch (Exception e)
            {
                cbbLockerIndex.Items.Clear();
                cbbLockerIndex.Text = "";
            }


        }

        private void cbbShoesNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbShoesNumber.SelectedIndex >= 0)
            {
                _newStaff.Sho.shoes_number = int.Parse(cbbShoesNumber.SelectedItem.ToString());
                MatchShoesIndex(_newStaff.Sho.shoes_number);
            }
        }

        private void MatchShoesIndex(int? sNumber)
        {
            try
            {
                if (sNumber is int number)
                {
                    List<int> shoesIndex = _dictShoes[number];
                    cbbShoesIndex.Items.Clear();
                    foreach (int i in shoesIndex)
                    {
                        cbbShoesIndex.Items.Add(i);
                    }
                    cbbShoesIndex.Text = shoesIndex[0].ToString();

                }

            }
            catch (Exception e)
            {
                cbbShoesIndex.Items.Clear();
                cbbShoesIndex.Text = "";
            }


        }
        private void cbbLockerIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            _newStaff.Locker.locker_index = int.Parse(cbbLockerIndex.SelectedItem.ToString());
        }

        private void cbbShoesIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            _newStaff.Sho.shoes_index = int.Parse(cbbShoesIndex.SelectedItem.ToString());
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
            if ((sender as Button) != null && string.Equals((sender as Button).Name, @"CloseButton") && MessageBox.Show(Constants.CONFIRM_CLOSE_WITHOUT_SAVE, "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbbLockerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbLockerIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbShoesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbShoesIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbLockerNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {

                _newStaff.Locker.locker_number = int.Parse(cbbLockerNumber.Text);
                MatchLockerIndex(_newStaff.Locker.locker_number);
            }
            catch { }
        }

        private void cbbLockerIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _newStaff.Locker.locker_index = int.Parse(cbbLockerIndex.Text);

            }
            catch { }
        }

        private void cbbShoesNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _newStaff.Sho.shoes_number = int.Parse(cbbShoesNumber.Text);
                MatchShoesIndex(_newStaff.Sho.shoes_number);
            }
            catch { }
        }

        private void cbbShoesIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _newStaff.Sho.shoes_index = int.Parse(cbbShoesIndex.Text);

            }
            catch { }
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

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _newStaff.gender = rbtnMale.Checked ? Constants.MALE : Constants.FEMALE;
                SetUpData();
                if (!string.IsNullOrEmpty(_newStaff.locker_number) && int.Parse(_newStaff.locker_number) > 0)
                {
                    MatchLockerIndex(int.Parse(_newStaff.locker_number));
                }
                if (!string.IsNullOrEmpty(_newStaff.shoes_number) && int.Parse(_newStaff.shoes_number) > 0)
                {
                    MatchShoesIndex(int.Parse(_newStaff.shoes_number));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
            SetUpData();

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
            cbbLockerNumber.SelectAll();
            cbbLockerNumber.Focus();
        }
    }
}
