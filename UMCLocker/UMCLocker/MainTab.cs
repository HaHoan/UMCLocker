using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UMCLocker.Business;
using UMCLocker.Entities;
using UMCLocker.Views;

namespace UMCLocker
{
    public partial class MainTab : Form
    {

        public LockerController lockerController;
        public ShoesController shoesController;
        public StaffController staffController;
        public StaffTrashController staffTrashController;
        SettingController settingController;
        public bool isLogin = false;
        public MainTab()
        {
            InitializeComponent();

        }

        private void MainTab_Load(object sender, EventArgs e)

        {
            KeyPreview = true;
            lockerController = new LockerController(this);
            shoesController = new ShoesController(this);
            staffController = new StaffController(this);
            staffTrashController = new StaffTrashController(this);
            settingController = new SettingController(this);
            staffController.LoadAll();
            staffController.LoadCompleted += () =>
            {
                staffTrashController.LoadAll();
            };
            lockerController.LoadAll();
            shoesController.LoadAll();
            DisableButton();
        }


        private void btnAddLocker_Click(object sender, EventArgs e)
        {

            lockerController.btnAddLocker_Click(sender, e);
        }

        private void btnDeleteLocker_Click(object sender, EventArgs e)
        {
            lockerController.btnDeleteLocker_Click(sender, e);
        }

        private void btnFilterLocker_Click(object sender, EventArgs e)
        {
            // lockerController.btnFilterLocker_Click(sender, e);
        }

        private void cbbLockerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockerController.cbbLockerNumber_SelectedIndexChanged(sender, e);
        }

        private void cbbLockerNumber_TextChanged(object sender, EventArgs e)
        {
            lockerController.cbbLockerNumber_TextChanged(sender, e);
        }


        private void btnAddShoes_Click(object sender, EventArgs e)
        {
            shoesController.btnAddShoes_Click(sender, e);
        }

        private void btnDeleteShoes_Click(object sender, EventArgs e)
        {
            shoesController.btnDeleteShoes_Click(sender, e);
        }

        private void cbbShoesNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            shoesController.cbbShoesNumber_SelectedIndexChanged(sender, e);
        }


        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            staffController.btnAddStaff_Click(sender, e);
        }

        public void OnCloseStaffForm()
        {
            staffController.LoadAll();
            lockerController.LoadAll();
            shoesController.LoadAll();
        }

        public void OnCloseInputBox(int number, int index, string type, string from)
        {
            if (from == Constants.LOCKER)
            {
                lockerController.InputBoxReturnOK(new Locker() { locker_number = number, locker_index = index, locker_type = type });
            }
            else if (from == Constants.SHOES)
            {
                shoesController.InputBoxReturnOK(new Sho() { shoes_number = number, shoes_index = index, shoes_type = type });
            }
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            staffController.btnEditStaff_Click(sender, e);
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            staffController.btnDeleteStaff_Click(sender, e);

        }

        private void cbbShoesNumber_TextChanged(object sender, EventArgs e)
        {
            shoesController.cbbShoesNumber_TextChanged(sender, e);
        }

        private void cbbShoesIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            shoesController.cbbShoesIndex_SelectedIndexChanged(sender, e);
        }

        public void cbbShoesIndex_TextChanged(object sender, EventArgs e)
        {
            shoesController.cbbShoesIndex_TextChanged(sender, e);
        }

        private void btnLockerSearch_Click(object sender, EventArgs e)
        {
            lockerController.btnLockerSearch_Click(sender, e);
        }

        private void cbbLockerIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockerController.cbbLockerIndex_SelectedIndexChanged(sender, e);
        }

        private void cbbLockerIndex_TextChanged(object sender, EventArgs e)
        {
            lockerController.cbbLockerIndex_TextChanged(sender, e);
        }

        private void btnShoesSearch_Click(object sender, EventArgs e)
        {
            shoesController.btnShoesSearch_Click(sender, e);
        }

        private void txbSearchStaff_KeyDown(object sender, KeyEventArgs e)
        {
            staffController.txbSearchStaff_KeyDown(sender, e);
        }


        private void dgrvLocker_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lockerController.dgrvLocker_CellMouseDoubleClick(sender, e);
        }

        internal void FindUseByKey(int owned)
        {
            staffController.FilterByListStaff(owned);
        }
        internal void UpdateLockerAfterDeleteUser()
        {
            lockerController.LoadAll();
            shoesController.LoadAll();
            staffTrashController.LoadAll();
        }
        private void dgrvShoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shoesController.dgrvShoes_CellMouseDoubleClick(sender, e);
        }

        private void MainTab_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.N))
                {
                    if (tabCtrMain.SelectedTab.Name == Constants.TAPPAGE_STAFF)
                    {
                        btnAddStaff_Click(sender, e);
                    }
                }
            }
        }

        private void cbbLockerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lockerController.cbbLockerNumber_KeyPress(sender, e);
        }

        private void cbbLockerIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            lockerController.cbbLockerIndex_KeyPress(sender, e);
        }

        private void cbbShoesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            shoesController.cbbShoesNumber_KeyPress(sender, e);
        }

        private void cbbShoesIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            shoesController.cbbShoesIndex_KeyPress(sender, e);
        }

        private void cbbLockerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockerController.cbbLockerType_SelectedIndexChanged(sender, e);
        }

        private void cbbShoesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            shoesController.cbbShoesType_SelectedIndexChanged(sender, e);
        }

        private void btnDeleteTrash_Click(object sender, EventArgs e)
        {
            staffTrashController.btnDeleteTrash_Click(sender, e);
        }

        private void dgrvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            staffController.dgrvStaff_CellContentClick(sender, e);
        }

        private void txbSearchTrash_KeyDown(object sender, KeyEventArgs e)
        {
            staffTrashController.txbSearchTrash_KeyDown(sender, e);
        }

        private void cbbLockerState_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockerController.cbbLockerState_SelectedIndexChanged(sender, e);
        }

        private void btnLockerList_Click(object sender, EventArgs e)
        {
            lockerController.btnLockerList_Click(sender, e);
        }

        private void cbbShoesState_SelectedIndexChanged(object sender, EventArgs e)
        {
            shoesController.cbbShoesState_SelectedIndexChanged(sender, e);
        }

        private void btnShoesList_Click(object sender, EventArgs e)
        {
            shoesController.btnShoesList_Click(sender, e);
        }


        private void btnTrashFilter_Click(object sender, EventArgs e)
        {
            staffTrashController.btnTrashFilter_Click(sender, e);
        }

        private void btnTrashAll_Click(object sender, EventArgs e)
        {
            staffTrashController.btnTrashAll_Click(sender, e);
        }

        private void btnFilterStaff_Click(object sender, EventArgs e)
        {
            staffController.btnFilterStaff_Click(sender, e);
        }

        private void btnAllStaff_Click(object sender, EventArgs e)
        {
            staffController.btnAllStaff_Click(sender, e);
        }

        private void btnFilterEnterMonth_Click(object sender, EventArgs e)
        {
            staffController.btnFilterEnterMonth_Click(sender, e);
        }

        private void MainTab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O && Control.ModifierKeys == Keys.Control)
            {
                btnEditStaff.PerformClick();
            }

        }

        private void tabCtrMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportStaff_Click(object sender, EventArgs e)
        {
            staffController.btnExportStaff_Click(sender, e);
        }

        private void btnExportTrash_Click(object sender, EventArgs e)
        {
            staffTrashController.btnExportTrash_Click(sender, e);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            staffController.btnSync_Click(sender, e);
        }

        private void bgwSync_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            staffController.bgwSync_DoWork(sender, e);
        }

        private void bgwSync_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            staffController.bgwSync_RunWorkerCompleted(sender, e);
        }

        private void btnEditTrash_Click(object sender, EventArgs e)
        {
            staffTrashController.btnEditTrash_Click(sender, e);
        }
        private void DisableButton()
        {
            btnAddStaff.Enabled = false;
            btnEditStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
            btnAddLocker.Enabled = false;
            btnDeleteLocker.Enabled = false;
            btnAddShoes.Enabled = false;
            btnDeleteShoes.Enabled = false;
            btnDeleteTrash.Enabled = false;
            btnEditTrash.Enabled = false;
            btnAddNewStaffFromExcel.Enabled = false;
            btnEditLocker.Enabled = false;
            btnEditShoes.Enabled = false;
        }
        private void EnableButton()
        {
            btnAddStaff.Enabled = true;
            btnEditStaff.Enabled = true;
            btnDeleteStaff.Enabled = true;
            btnAddLocker.Enabled = true;
            btnDeleteLocker.Enabled = true;
            btnAddShoes.Enabled = true;
            btnDeleteShoes.Enabled = true;
            btnDeleteTrash.Enabled = true;
            btnEditTrash.Enabled = true;
            btnAddNewStaffFromExcel.Enabled = true;
            btnEditLocker.Enabled = true;
            btnEditShoes.Enabled = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                isLogin = false;
                btnLogin.Text = "Login";
                DisableButton();
            }
            else
            {
                var loginForm = new LoginForm();
                loginForm.LoginOK += (username) =>
                {
                    btnLogin.Text = username;
                    isLogin = true;
                    EnableButton();
                };
                loginForm.ShowDialog();
            }

        }

        private void btnAddNewStaffFromExcel_Click(object sender, EventArgs e)
        {
            settingController.btnAddNewStaffFromExcel_Click(sender, e);
        }

        private void btnEditLocker_Click(object sender, EventArgs e)
        {
            lockerController.btnEditLocker_Click(sender, e);
        }

        private void btnEditShoes_Click(object sender, EventArgs e)
        {
            shoesController.btnEditShoes_Click(sender, e);
        }
    }
}
