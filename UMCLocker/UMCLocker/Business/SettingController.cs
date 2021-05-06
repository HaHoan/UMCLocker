using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;

namespace UMCLocker.Business
{
    public class SettingController : MainTabController
    {
        public SettingController(MainTab view) : base(view)
        {
            view.BgwSettingImportStaff.DoWork += BgwSettingImportStaff_DoWork;
            view.BgwSettingImportStaff.RunWorkerCompleted += BgwSettingImportStaff_RunWorkerCompleted;
            view.BgwSettingAddStaff.DoWork += BgwSettingAddStaff_DoWork;
            view.BgwSettingAddStaff.RunWorkerCompleted += BgwSettingAddStaff_RunWorkerCompleted;
            view.BgwSettingImportKey.DoWork += BgwSettingImportKey_DoWork;
            view.BgwSettingImportKey.RunWorkerCompleted += BgwSettingImportKey_RunWorkerCompleted;
            view.BgwImportQuitWork.DoWork += BgwImportQuitWork_DoWork;
            view.BgwImportQuitWork.RunWorkerCompleted += BgwImportQuitWork_RunWorkerCompleted;
        }
        private void BgwImportQuitWork_DoWork(object sender, DoWorkEventArgs e)
        {
            string sFileName = (string)e.Argument;
            ResultInfo result = Utils.ImportQuitWork(sFileName);
            e.Result = result.message;
        }

        private void BgwImportQuitWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string msg = (string)e.Result;
            view.lockerController.LoadAll();
            view.shoesController.LoadAll();
            view.staffController.LoadAll();
            view.staffTrashController.LoadAll();
        }

        private void BgwSettingImportKey_DoWork(object sender, DoWorkEventArgs e)
        {
            string sFileName = (string)e.Argument;
            using (UMCLOCKEREntities db = new UMCLOCKEREntities())
            {
               //db.Staffs.RemoveRange(db.Staffs);
               // db.Lockers.RemoveRange(db.Lockers);
               //db.Shoes.RemoveRange(db.Shoes);
               // db.SaveChanges();
            }
            ResultInfo result = Utils.ImportKeyFromExcelToDb(sFileName);
            e.Result = result.message;
        }

        private void BgwSettingImportKey_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string msg = (string)e.Result;
            view.lockerController.LoadAll();
            view.shoesController.LoadAll();
            view.staffController.LoadAll();
        }

        private void BgwSettingAddStaff_DoWork(object sender, DoWorkEventArgs e)
        {
            string sFileName = (string)e.Argument;
            ResultInfo result = Utils.AddStaffToDB(sFileName);
            e.Result = result.message;
        }

        private void BgwSettingAddStaff_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string msg = (string)e.Result;
            view.LblStatusAddStaff.Text = msg;
            view.staffController.LoadAll();
        }

        private void BgwSettingImportStaff_DoWork(object sender, DoWorkEventArgs e)
        {
            string sFileName = (string)e.Argument;
            using (UMCLOCKEREntities db = new UMCLOCKEREntities())
            {
                db.Staffs.RemoveRange(db.Staffs);
                db.Pos.RemoveRange(db.Pos);
                db.Depts.RemoveRange(db.Depts);
                db.SaveChanges();
            }
            ResultInfo result = Utils.ImportAllStaffToDB(sFileName);
            e.Result = result.message;
        }

        private void BgwSettingImportStaff_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string msg = (string)e.Result;
            view.staffController.LoadAll();
            view.lockerController.LoadAll();
            view.shoesController.LoadAll();
       
        }

        internal void btnImportStaff_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                view.BgwSettingImportStaff.RunWorkerAsync(argument: sFileName);
            }
        }

        internal void btnAddStaffExcel_Click(object sender, EventArgs e)
        {
            
        }

       

       

        internal void btnDeleteLockerAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    db.Staffs.RemoveRange(db.Staffs);
                    db.Lockers.RemoveRange(db.Lockers);
                    db.SaveChanges();
                    view.lockerController.LoadAll();
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal void btnDeleteShoesAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    db.Staffs.RemoveRange(db.Staffs);
                    db.Shoes.RemoveRange(db.Shoes);
                    db.SaveChanges();
                    view.shoesController.LoadAll();
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        internal void btnImportKey_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.FilterIndex = 1;

                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                     string sFileName = choofdlog.FileName;
                    view.BgwSettingImportKey.RunWorkerAsync(argument: sFileName);
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        internal void btnImportQuitWork_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                view.BgwImportQuitWork.RunWorkerAsync(argument: sFileName);
            }
        }

        internal void btnAddNewStaffFromExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                view.LblStatusAddStaff.Text = "Loading...";
                view.BgwSettingAddStaff.RunWorkerAsync(argument: sFileName);
            }
        }
    }
}
