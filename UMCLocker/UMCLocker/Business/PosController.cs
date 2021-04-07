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
    public class PosController : MainTabController
    {
        private List<PosEntity> _pos;
        public PosController(MainTab view) : base(view)
        {
            view.DgrvPos.SetDoubleBuffering(true);
        }

        public void LoadAll()
        {
            dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("STT");
            dt.Columns.Add("Position name");
            view.DgrvPos.DataSource = dt;
            _pos = (List<PosEntity>)(new PosEntity()).GetAllData();
            AddPosToTable(_pos);
            view.DgrvPos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            view.DgrvPos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            view.DgrvPos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void AddPosToTable(List<PosEntity> pos)
        {
            if(pos == null)
            {
                return;
            }
            dt.Clear();
            int i = 1;
            foreach (Pos p in pos)
            {
                DataRow row = dt.NewRow();
                row[0] = i;
                row[1] = p.name;
                dt.Rows.Add(row);
                i++;
            }
            ChangeStateButton();
        }

        private void ChangeStateButton()
        {
            if (view.DgrvPos.Rows.Count == 0)
            {
                view.BtnEditPos.Enabled = false;
                view.BtnDeletePos.Enabled = false;
            }
            else
            {
                view.BtnEditPos.Enabled = true;
                view.BtnDeletePos.Enabled = true;
            }

        }

        public void btnAddPos_Click(object sender, EventArgs e)
        {
            string posName = Constants.VALUE_DEFAULT;
            if (CustomViews.InputBox("New Department", "New Department name:", ref posName) == DialogResult.OK)
            {
                PosEntity p = new PosEntity(posName);
                ResultInfo result = p.Insert();
                if (result.code < 0)
                {
                    MessageBox.Show(Constants.NOTICE_INSERT_FAILED);
                }
                else
                {
                    // insert success
                    p.id = int.Parse(result.message);
                    _pos.Add(p);
                    AddPosToTable(_pos);
                    ChangeStateButton();
                }

            }
        }

        public void btnEditPos_Click(object sender, EventArgs e)
        {
            try
            {
                PosEntity p = _pos[view.DgrvPos.CurrentCell.RowIndex];
                string posName = p.name;
                if (CustomViews.InputBox("Update Department", "Department name:", ref posName) == DialogResult.OK)
                {
                    p.name = posName;
                    ResultInfo result = p.Update();
                    if (result.code < 0)
                    {
                        MessageBox.Show(Constants.NOTICE_UPDATE_FAILED);
                    }
                    else
                    {
                        p.id = int.Parse(result.message);
                        _pos.Where(pos => pos.id == p.id).Select(pos => { pos.name = p.name; return pos; }).FirstOrDefault();
                        AddPosToTable(_pos);
                    }
                }
            }
            catch { }
        }

        public void btnDeletePos_Click(object sender, EventArgs e)
        {
            try
            {
                PosEntity p = _pos[view.DgrvPos.CurrentCell.RowIndex];
                string posName = p.name;
                if (MessageBox.Show(string.Format(Constants.CONFIRM_DELETE_POS,posName), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResultInfo result = p.Delete();
                    if (result.code < 0)
                    {
                        MessageBox.Show(Constants.NOTICE_DELETE_FAILED);
                    }
                    else
                    {
                        view.DgrvPos.Rows.RemoveAt(selectedRow);
                        p.id = int.Parse(result.message);
                        _pos.RemoveAll(x => x.id == p.id);
                        ChangeStateButton();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }


        }

        public void dgrvPos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = e.RowIndex;
            }
        }

        public void txbSearchPos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterByName();
            }
        }

        public void btnSearchPos_Click(object sender, EventArgs e)
        {
            FilterByName();
        }

        private void FilterByName()
        {
            string searchStr = view.TxbSearchPos.Text.ToString();
            if (string.IsNullOrEmpty(searchStr))
            {
                AddPosToTable(_pos);
            }
            else
            {
                AddPosToTable(PosEntity.FilterByName(_pos, searchStr));
            }
        }

    }
}
