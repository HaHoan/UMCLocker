using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;
using UMCLocker.Views;

namespace UMCLocker.Business
{
    public class ShoesController : MainTabController
    {
        private List<Sho> _shoes;
        private Dictionary<int, List<int>> _dictShoes;
        private Sho selectedSho;

        public ShoesController(MainTab view) : base(view)
        {
            view.BgwShoes.DoWork += BgwShoes_DoWork;
            view.BgwShoes.RunWorkerCompleted += BgwShoes_RunWorkerCompleted;
            view.DgrvShoes.SetDoubleBuffering(true);
        }

        private void BgwShoes_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Số tủ");
            dt.Columns.Add("Số ô");
            dt.Columns.Add("Loại");
            dt.Columns.Add("Trạng thái");
            view.DgrvShoes.DataSource = dt;
            view.DgrvShoes.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            view.DgrvShoes.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            view.DgrvShoes.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            AddShoesToTable(_shoes);
            _dictShoes = ShoesEntity.AddShoesToDict(_shoes);
            view.LblNumberShoes.Text = view.DgrvShoes.RowCount.ToString();
            UpdateCbbFilter();
            selectedSho = new Sho();
        }

        private void BgwShoes_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _shoes = (List<Sho>)(new ShoesEntity()).GetAllData();
        }

        public void LoadAll()
        {
            view.BgwShoes.RunWorkerAsync();
        }

        private void UpdateCbbFilter()
        {
            if (_dictShoes == null) return;
            view.CbbShoesNumber.Items.Clear();
            view.CbbShoesIndex.Items.Clear();
            view.CbbShoesNumber.Text = "Chọn tủ";
            view.CbbShoesIndex.Text = "Chọn ô";
            foreach (int shoesNumber in _dictShoes.Keys)
            {
                view.CbbShoesNumber.Items.Add(shoesNumber);
            }
            view.CbbShoesType.Items.Clear();
            view.CbbShoesType.Items.Add("Tủ nam");
            view.CbbShoesType.Items.Add("Tủ nữ");
        }
        private void AddShoesToTable(List<Sho> shoes)
        {
            if (shoes == null) return;
            dt.Clear();
            foreach (Sho s in shoes)
            {
                DataRow row = dt.NewRow();
                row[0] = s.shoes_number;
                row[1] = s.shoes_index;
                row[2] = (s.shoes_type == Constants.FEMALE) ? "Tủ nữ" : "Tủ nam";
                row[3] = s.state ;
                dt.Rows.Add(row);
            }
            ChangeStateButton();
        }

        private void ChangeStateButton()
        {
            if (view.DgrvShoes.Rows.Count == 0)
            {
                view.BtnDeleteShoes.Enabled = false;
            }
            else
            {
                view.BtnDeleteShoes.Enabled = true;
            }

        }

        public void btnAddShoes_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox();
            inputBox.from = Constants.SHOES;
            inputBox.OnCloseHandler += view.OnCloseInputBox;
            inputBox.ShowDialog();
        }

        public void btnDeleteShoes_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(view.DgrvShoes.Rows[view.DgrvShoes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                int index = int.Parse(view.DgrvShoes.Rows[view.DgrvShoes.CurrentCell.RowIndex].Cells[1].Value.ToString());
                string type = view.DgrvShoes.Rows[view.DgrvShoes.CurrentCell.RowIndex].Cells[2].Value.ToString() == "Tủ nữ" ? "F" : "M";

                if (MessageBox.Show(string.Format(Constants.CONFIRM_DELETE_KEY, number + "-" + index), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_shoes[view.DgrvShoes.CurrentCell.RowIndex].owned is int owned)
                    {
                        StaffEntity staff = StaffEntity.GetStaffById(owned);
                        if (CustomViews.MessageBox("Warning", string.Format(Constants.NOTICE_DELETE_FOREIGN_KEY, staff.full_name), "Change key", Properties.Resources.key_icon) == DialogResult.OK)
                        {
                            // Show user form to change key
                            UserNewForm newForm = new UserNewForm(staff, FormType.OnlyChangeKeyShoes);
                            newForm.OnCloseHandler += view.OnCloseStaffForm;
                            newForm.Show();
                        }
                    }
                    else
                    {
                        ShoesEntity shoes = new ShoesEntity() { shoes_number = number, shoes_index = index, shoes_type = type};
                        ResultInfo result = shoes.Delete();
                        if (result.code < 0)
                        {
                            MessageBox.Show(Constants.NOTICE_DELETE_FAILED);
                        }
                        else
                        {
                            view.DgrvShoes.Rows.RemoveAt(view.DgrvShoes.CurrentCell.RowIndex);
                            _shoes.RemoveAll(x => x.shoes_index == index && x.shoes_number == number);
                            _dictShoes.RemoveElement(shoes.shoes_number, shoes.shoes_index);
                            UpdateCbbFilter();
                            ChangeStateButton();
                            MessageBox.Show(result.message);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public void InputBoxReturnOK(Sho sho)
        {
            ResultInfo result = new ShoesEntity().Insert(sho);
            if (result.code == Constants.ERROR_COMMON)
            {
                MessageBox.Show(result.message);
                return;
            }
            else if (result.code == Constants.ERROR_DUPLICATE_DATA)
            {
                MessageBox.Show(result.message);
                return;
            }
            else if (result.code == Constants.SUCCESS)
            {
                // insert success
                DataRow row = dt.NewRow();
                row[0] = sho.shoes_number;
                row[1] = sho.shoes_index;
                row[2] = (sho.shoes_type == Constants.FEMALE) ? "Tủ nữ" : "Tủ nam";
                row[3] = sho.state;
                dt.Rows.Add(row);
                _shoes.Add(sho);
                _dictShoes.AddObjectToDict(sho.shoes_number, sho.shoes_index);
                UpdateCbbFilter();
                view.DgrvShoes.Refresh();
                ChangeStateButton();
            }
        }

        public void cbbShoesNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedSho.shoes_number = int.Parse(view.CbbShoesNumber.SelectedItem.ToString());
                MatchShoesIndex(selectedSho.shoes_number);
            }
            catch
            {
            }
        }

        public void cbbShoesNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                selectedSho.shoes_number = int.Parse(view.CbbShoesNumber.Text.ToString());
                MatchShoesIndex(selectedSho.shoes_number);
            }
            catch
            {

            }
        }

        public void cbbShoesIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedSho.shoes_index = int.Parse(view.CbbShoesIndex.SelectedItem.ToString());
            }
            catch { }
        }

        private void MatchShoesIndex(int sNumber)
        {
            List<int> shoesIndex = _dictShoes[sNumber];
            view.CbbShoesIndex.Items.Clear();
            foreach (int i in shoesIndex)
            {
                view.CbbShoesIndex.Items.Add(i);
            }
            view.CbbShoesIndex.SelectedIndex = 0;
        }

        public void cbbShoesIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                selectedSho.shoes_index = int.Parse(view.CbbShoesIndex.Text.ToString());
            }
            catch { }
        }

        public void btnShoesSearch_Click(object sender, EventArgs e)
        {
            try
            {

                DataView dv = dt.DefaultView;
                StringBuilder filerStr = new StringBuilder();
                if (selectedSho.shoes_number > 0)
                {
                    filerStr.Append(string.Format("[Số tủ] = '{0}'", selectedSho.shoes_number));
                }
                if (selectedSho.shoes_index > 0)
                {
                    if (!string.IsNullOrEmpty(filerStr.ToString()))
                    {
                        filerStr.Append(" AND ");
                    }
                    filerStr.Append(string.Format("[Số ô] = '{0}'", selectedSho.shoes_index));
                }
                if (!string.IsNullOrEmpty(selectedSho.shoes_type))
                {
                    if (!string.IsNullOrEmpty(filerStr.ToString()))
                    {
                        filerStr.Append(" AND ");
                    }
                    filerStr.Append(string.Format("[Loại] = '{0}'", selectedSho.shoes_type));
                }
                if (!string.IsNullOrEmpty(selectedSho.state))
                {
                    if (!string.IsNullOrEmpty(filerStr.ToString()))
                    {
                        filerStr.Append(" AND ");
                    }
                    filerStr.Append(string.Format("[Trạng thái] = '{0}'", selectedSho.state));
                }
                dv.RowFilter = filerStr.ToString();
                view.DgrvShoes.DataSource = dv.ToTable();
                view.DgrvShoes.Refresh();
                view.LblNumberShoes.Text = view.DgrvShoes.RowCount.ToString();
                ChangeStateButton();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        internal void cbbShoesState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.CbbShoesState.SelectedItem == null)
            {
                selectedSho.state = "";
            }
            else
            {
                selectedSho.state = view.CbbShoesState.SelectedItem.ToString();
            }
        }

        internal void cbbShoesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.CbbShoesType.SelectedItem == null)
            {
                selectedSho.shoes_type = "";
            }
            else
            {
                selectedSho.shoes_type = view.CbbShoesType.SelectedItem.ToString();
            }
        }

        internal void btnShoesList_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("[Số tủ] like '%{0}%'", "");

            // If show all list -> cbb will be reset to -1;
            view.CbbShoesNumber.SelectedIndex = -1;
            view.CbbShoesIndex.SelectedIndex = -1;
            view.CbbShoesType.SelectedIndex = -1;
            view.CbbShoesState.SelectedIndex = -1;
            view.CbbShoesNumber.Text = "Chọn tủ";
            view.CbbShoesIndex.Text = "Chọn ô";
            view.CbbShoesType.Text = "Chọn loại";
            view.CbbShoesState.Text = "Trạng thái";
            selectedSho.shoes_number = 0;
            selectedSho.shoes_index = 0;
            selectedSho.shoes_type = "";
            selectedSho.state = "";
            view.DgrvShoes.DataSource = dv.ToTable();
            view.LblNumberShoes.Text = view.DgrvShoes.RowCount.ToString();
            view.LblNumberShoes.Text = view.DgrvShoes.RowCount.ToString();

        }

        public void dgrvShoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int shoes_number = int.Parse(view.DgrvShoes.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int shoes_index = int.Parse(view.DgrvShoes.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string shoes_type = view.DgrvShoes.Rows[e.RowIndex].Cells[2].Value.ToString() == "Tủ nữ" ? Constants.FEMALE : Constants.MALE;

                    Sho shoesSelected = _shoes.Where(x => x.shoes_index == shoes_index && x.shoes_number == shoes_number && x.shoes_type == shoes_type).FirstOrDefault();

                    DetailKeyForm formDetail = new DetailKeyForm(null,shoesSelected);
                    formDetail.ShowDialog();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        internal void btnEditShoes_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(view.DgrvShoes.Rows[view.DgrvShoes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                int index = int.Parse(view.DgrvShoes.Rows[view.DgrvShoes.CurrentCell.RowIndex].Cells[1].Value.ToString());
                string type = view.DgrvShoes.Rows[view.DgrvShoes.CurrentCell.RowIndex].Cells[2].Value.ToString() == "Tủ nữ" ? "F" : "M";
                var shoes = ShoesEntity.shoesBy(number, index, type);
                if(shoes == null || shoes.state != Constants.STATE_RESOLVE)
                {
                    MessageBox.Show("Khóa giày này không cần xử lý!");
                    return;
                }
                if (MessageBox.Show(string.Format(Constants.CONFIRM_EDIT_KEY, number + "-" + index), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   bool result = ShoesEntity.updateState(Constants.STATE_AVAIABLE,number, index, type);
                    if (result)
                    {
                        LoadAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void cbbShoesNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void cbbShoesIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
