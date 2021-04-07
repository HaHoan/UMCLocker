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
            view.LblImportQuitWork.Text = msg;
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
               db.Staffs.RemoveRange(db.Staffs);
                db.Lockers.RemoveRange(db.Lockers);
               db.Shoes.RemoveRange(db.Shoes);
                db.SaveChanges();
            }
            ResultInfo result = Utils.ImportKeyFromExcelToDb(sFileName);
            e.Result = result.message;
        }

        private void BgwSettingImportKey_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string msg = (string)e.Result;
            view.LblImportKey.Text = msg;
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
            view.LblAddStaffState.Text = msg;
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
            view.LblImportStaffState.Text = msg;
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
                view.LblImportStaffState.Text = "Loading..";
                view.BgwSettingImportStaff.RunWorkerAsync(argument: sFileName);
            }
        }

        internal void btnAddStaffExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                view.LblAddStaffState.Text = "Loading..";
                view.BgwSettingAddStaff.RunWorkerAsync(argument: sFileName);
            }
        }

        internal void btnImportLocker_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.TbLockerFrom.Text) ||
                string.IsNullOrEmpty(view.TxbLockerTo.Text) ||
                string.IsNullOrEmpty(view.TxbLockerType.Text) ||
                string.IsNullOrEmpty(view.TxbSoOTrongTuLocker.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            try
            {
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    int locker_number = int.Parse(view.TbLockerFrom.Text.ToString());
                    int locker_index = int.Parse(view.TxbLockerTo.Text.ToString());
                    string locker_type = view.TxbLockerType.Text.ToString();

                    var from = new SqlParameter("@from", locker_number);
                    var to = new SqlParameter("@to", locker_index);
                    var soo1tu = new SqlParameter("@soo1tu", int.Parse(view.TxbSoOTrongTuLocker.Text.ToString()));
                    var loaitu = new SqlParameter("@loaitu", locker_type);
                    db.Database.ExecuteSqlCommand("enter_locker @from, @to,@soo1tu, @loaitu",
                        parameters: new[] { from, to, soo1tu, loaitu });
                    view.lockerController.LoadAll();
                    MessageBox.Show("Thêm thành công!");
                    return;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal void btnImportShoes1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.TxbShoesFrom.Text) ||
               string.IsNullOrEmpty(view.TxbShoesTo.Text) ||
               string.IsNullOrEmpty(view.TxbTypeShoes.Text) ||
               string.IsNullOrEmpty(view.TxbSoOTrongTuShoes.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            try
            {
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    int shoes_number = int.Parse(view.TxbShoesFrom.Text.ToString());
                    int shoes_index = int.Parse(view.TxbShoesTo.Text.ToString());
                    string shoes_type = view.TxbTypeShoes.Text.ToString();

                    var from = new SqlParameter("@from", shoes_number);
                    var to = new SqlParameter("@to", shoes_index);
                    var soo1tu = new SqlParameter("@soo1tu", int.Parse(view.TxbSoOTrongTuShoes.Text.ToString()));
                    var loaitu = new SqlParameter("@loaitu", shoes_type);
                    db.Database.ExecuteSqlCommand("enter_shoes @from, @to,@soo1tu, @loaitu",
                        parameters: new[] { from, to, soo1tu, loaitu });
                    view.shoesController.LoadAll();
                    MessageBox.Show("Thêm thành công!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
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

        internal void btnSettingLockerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(view.TbLockerFrom.Text) ||
                string.IsNullOrEmpty(view.TxbLockerTo.Text) ||
                string.IsNullOrEmpty(view.TxbLockerType.Text) ||
                string.IsNullOrEmpty(view.TxbSoOTrongTuLocker.Text))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                    return;
                }
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    int locker_number = int.Parse(view.TbLockerFrom.Text.ToString());
                    int locker_index = int.Parse(view.TxbLockerTo.Text.ToString());
                    string locker_type = view.TxbLockerType.Text.ToString();

                    var from = new SqlParameter("@from", locker_number);
                    var to = new SqlParameter("@to", locker_index);
                    var soo1tu = new SqlParameter("@soo1tu", int.Parse(view.TxbSoOTrongTuLocker.Text.ToString()));
                    var loaitu = new SqlParameter("@loaitu", locker_type);
                    db.Database.ExecuteSqlCommand("delete_range_locker @from, @to,@soo1tu, @loaitu",
                        parameters: new[] { from, to, soo1tu, loaitu });
                    view.lockerController.LoadAll();
                    MessageBox.Show("Xóa thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void btnDeleteRangeShoes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.TxbShoesFrom.Text) ||
              string.IsNullOrEmpty(view.TxbShoesTo.Text) ||
              string.IsNullOrEmpty(view.TxbTypeShoes.Text) ||
              string.IsNullOrEmpty(view.TxbSoOTrongTuShoes.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            try
            {
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    int shoes_number = int.Parse(view.TxbShoesFrom.Text.ToString());
                    int shoes_index = int.Parse(view.TxbShoesTo.Text.ToString());
                    string shoes_type = view.TxbTypeShoes.Text.ToString();

                    var from = new SqlParameter("@from", shoes_number);
                    var to = new SqlParameter("@to", shoes_index);
                    var soo1tu = new SqlParameter("@soo1tu", int.Parse(view.TxbSoOTrongTuShoes.Text.ToString()));
                    var loaitu = new SqlParameter("@loaitu", shoes_type);
                    db.Database.ExecuteSqlCommand("delete_range_shoes @from, @to,@soo1tu, @loaitu",
                        parameters: new[] { from, to, soo1tu, loaitu });
                    view.shoesController.LoadAll();
                    MessageBox.Show("Xóa thành công!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
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
                    view.LblImportKey.Text = "Loading..";
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
                view.LblImportQuitWork.Text = "Loading..";
                view.BgwImportQuitWork.RunWorkerAsync(argument: sFileName);
            }
        }
    }
}
