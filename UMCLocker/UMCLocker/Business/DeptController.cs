using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;
using UMCLocker.Views;

namespace UMCLocker.Business
{
    public class DeptController : MainTabController
    {
        private List<DeptEntity> _depts;
        public DeptController(MainTab view) : base(view)
        {
            view.DgrvDept.SetDoubleBuffering(true);
        }

        public void LoadAll()
        {
            _depts = (List<DeptEntity>)(new DeptEntity()).GetAllData();
            bindingSource = new BindingSource();
            bindingSource.DataSource = _depts;
            view.DgrvDept.DataSource = bindingSource;
            view.DgrvDept.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            view.DgrvDept.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ChangeStateButton()
        {
            if (view.DgrvDept.Rows.Count == 0)
            {
                view.BtnEditDept.Enabled = false;
                view.BtnDeleteDept.Enabled = false;
            }
            else
            {
                view.BtnEditDept.Enabled = true;
                view.BtnDeleteDept.Enabled = true;
            }

        }

        public void btnAddDept_Click(object sender, EventArgs e)
        {
            string deptName = Constants.VALUE_DEFAULT;
            if (CustomViews.InputBox("New Department", "New Department name:", ref deptName) == DialogResult.OK)
            {
                DeptEntity dept = new DeptEntity(deptName);
                ResultInfo result = dept.Insert();
                if (result.code < 0)
                {
                    MessageBox.Show(result.message);
                }
                else
                {
                    // insert success
                    dept.id = int.Parse(result.message);
                    dept.index = view.DgrvDept.RowCount + 1;
                    _depts.Add(dept);
                    bindingSource.Insert(view.DgrvDept.RowCount, dept);
                    view.DgrvDept.Refresh();
                    view.DgrvDept.FirstDisplayedScrollingRowIndex = view.DgrvDept.RowCount - 1;
                    ChangeStateButton();
                }

            }
        }

        public void btnEditDept_Click(object sender, EventArgs e)
        {
            try
            {
                DeptEntity dept = _depts[view.DgrvDept.CurrentCell.RowIndex];
                string deptName = dept.name;
                if (CustomViews.InputBox("Update Department", "Department name:", ref deptName) == DialogResult.OK)
                {
                    dept.name = deptName;
                    ResultInfo result = dept.Update();
                    if (result.code < 0)
                    {
                        MessageBox.Show(result.message);
                    }
                    else
                    {
                        dept.id = int.Parse(result.message);
                        _depts.Where(d => d.id == dept.id).Select(d => { d.name = dept.name; return d; }).FirstOrDefault();
                        bindingSource.DataSource = _depts;
                        view.DgrvDept.Refresh();
                        view.DgrvDept.FirstDisplayedScrollingRowIndex = dept.index - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void btnDeleteDept_Click(object sender, EventArgs e)
        {
            try
            {
                DeptEntity dept = _depts[view.DgrvDept.CurrentCell.RowIndex];

                if (MessageBox.Show(string.Format(Constants.CONFIRM_DELETE_DEPT,dept.name), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResultInfo result = dept.Delete();
                    if (result.code < 0)
                    {
                        MessageBox.Show(result.message);
                    }
                    else
                    {
                        dept.id = int.Parse(result.message);
                        view.DgrvDept.Rows.RemoveAt(view.DgrvDept.CurrentCell.RowIndex);
                        _depts.RemoveAll(x => x.id == dept.id);
                        ChangeStateButton();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }


        }

        public void txbSearchDept_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                FilterByTxtSearch();
            }
        }

        public void btnSearchDept_Click(object sender, EventArgs e)
        {
            FilterByTxtSearch();
        }
        private void FilterByTxtSearch()
        {
            string searchStr = view.TxbSearchDept.Text.ToString();
            if (string.IsNullOrEmpty(searchStr))
            {
                bindingSource.DataSource = _depts;
            }
            else
            {
                bindingSource.DataSource = _depts.Where(x => x.name.ToLower().Contains(searchStr.ToLower())).ToList();
            }

            view.DgrvDept.Refresh();
        }
    }
}
