using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMCLocker.Business
{
    public class MainTabController
    {
        protected MainTab view;
        protected DataTable dt;
        protected BindingSource bindingSource;
        protected int selectedRow;
        public MainTabController(MainTab view)
        {
            this.view = view;
        }

    }
}
