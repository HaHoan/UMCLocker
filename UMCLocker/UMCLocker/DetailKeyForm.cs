using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;

namespace UMCLocker
{
    public partial class DetailKeyForm : Form
    {
        public Locker locker;
        public Sho shoes;
        List<StaffEntity> listHistory;
        BindingSource bindingSource;
        public DetailKeyForm(Locker locker, Sho sho)
        {
            InitializeComponent();
            dgrvOwnedHistory.AutoGenerateColumns = false;
            bindingSource = new BindingSource();
            if (locker != null)
            {
                lblNumber.Text = locker.locker_number.ToString();
                lblIndex.Text = locker.locker_index.ToString();
                lblType.Text = locker.locker_type == Constants.MALE ? "Tủ nam" : "Tủ nữ";
                lblState.Text = locker.state;
                if (locker.owned is int owned)
                {
                    lblOwned.Text = StaffEntity.GetStaffById(owned).full_name;
                }
                listHistory = new LockerEntity().GetHistory(locker.id);
            }
            else if (sho != null)
            {
                lblNumber.Text = sho.shoes_number.ToString();
                lblIndex.Text = sho.shoes_index.ToString();
                lblType.Text = sho.shoes_type == Constants.MALE ? "Tủ nam" : "Tủ nữ";
                lblState.Text = sho.state;
                if (sho.owned is int owned)
                {
                    lblOwned.Text = StaffEntity.GetStaffById(owned).full_name;
                }
                listHistory = new ShoesEntity().GetHistory(sho.id);
            }
            bindingSource.DataSource = listHistory;
            dgrvOwnedHistory.DataSource = bindingSource;
            bindingSource.ResetBindings(true);
            dgrvOwnedHistory.Refresh();
        }

    }
}
