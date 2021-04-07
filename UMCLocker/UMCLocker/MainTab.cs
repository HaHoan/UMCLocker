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
        DeptController deptController;
        PosController posController;
        public StaffController staffController;
        public StaffTrashController staffTrashController;
        SettingController settingController;
        public MainTab()
        {
            InitializeComponent();
        }

        private void MainTab_Load(object sender, EventArgs e)

        {
            KeyPreview = true;
            lockerController = new LockerController(this);
            shoesController = new ShoesController(this);
            deptController = new DeptController(this);
            posController = new PosController(this);
            staffController = new StaffController(this);
            staffTrashController = new StaffTrashController(this);
            settingController = new SettingController(this);
            staffController.LoadAll();
            lockerController.LoadAll();
            shoesController.LoadAll();
            deptController.LoadAll();
            posController.LoadAll();
            staffTrashController.LoadAll();
            //  Utils.ReadingFileXLMSToDB(@"D:\18.HOANHT\Doccument\Phần mềm quản lý khóa\Danh sách sử dụng tủ giầy, locker 2020.xlsx");
            //Utils.UpdateKey();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            deptController.btnAddDept_Click(sender, e);
        }

        private void btnEditDept_Click(object sender, EventArgs e)
        {
            deptController.btnEditDept_Click(sender, e);
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            deptController.btnDeleteDept_Click(sender, e);

        }

        private void btnAddPos_Click(object sender, EventArgs e)
        {
            posController.btnAddPos_Click(sender, e);
        }

        private void btnEditPos_Click(object sender, EventArgs e)
        {
            posController.btnEditPos_Click(sender, e);
        }

        private void btnDeletePos_Click(object sender, EventArgs e)
        {
            posController.btnDeletePos_Click(sender, e);

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

        public void OnCloseStaffForm(StaffEntity staff)
        {
            staffController.UpdateTableAfterAddNew(staff);
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

        private void txbSearchDept_KeyDown(object sender, KeyEventArgs e)
        {
            deptController.txbSearchDept_KeyDown(sender, e);
        }

        private void btnSearchDept_Click(object sender, EventArgs e)
        {
            deptController.btnSearchDept_Click(sender, e);
        }

        private void txbSearchPos_KeyDown(object sender, KeyEventArgs e)
        {
            posController.txbSearchPos_KeyDown(sender, e);
        }

        private void btnSearchPos_Click(object sender, EventArgs e)
        {
            posController.btnSearchPos_Click(sender, e);
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

        private void dgrvPos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posController.dgrvPos_CellClick(sender, e);
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

        private void btnImportStaff_Click(object sender, EventArgs e)
        {
            settingController.btnImportStaff_Click(sender, e);
        }

        private void btnAddStaffExcel_Click(object sender, EventArgs e)
        {
            settingController.btnAddStaffExcel_Click(sender, e);
        }

        private void btnImportLocker_Click(object sender, EventArgs e)
        {
            settingController.btnImportLocker_Click(sender, e);
        }

        private void btnImportShoes1_Click(object sender, EventArgs e)
        {
            settingController.btnImportShoes1_Click(sender, e);
        }

        private void btnDeleteLockerAll_Click(object sender, EventArgs e)
        {
            settingController.btnDeleteLockerAll_Click(sender, e);
        }

        private void btnDeleteShoesAll_Click(object sender, EventArgs e)
        {
            settingController.btnDeleteShoesAll_Click(sender, e);
        }

        private void btnSettingLockerDelete_Click(object sender, EventArgs e)
        {
            settingController.btnSettingLockerDelete_Click(sender, e);
        }

        private void btnDeleteRangeShoes_Click(object sender, EventArgs e)
        {
            settingController.btnDeleteRangeShoes_Click(sender, e);
        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {
            settingController.btnImportKey_Click(sender, e);
        }

        private void btnImportQuitWork_Click(object sender, EventArgs e)
        {
            settingController.btnImportQuitWork_Click(sender, e);
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
            if (e.KeyCode == Keys.E && Control.ModifierKeys == Keys.Control)
            {
                btnEditStaff.PerformClick();
            }
               
        }
    }
}
