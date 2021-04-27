using System.Windows.Forms;

namespace UMCLocker
{
    partial class MainTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bgwStaff = new System.ComponentModel.BackgroundWorker();
            this.bgwLocker = new System.ComponentModel.BackgroundWorker();
            this.bgwShoes = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabCtrMain = new System.Windows.Forms.TabControl();
            this.tPStaff = new System.Windows.Forms.TabPage();
            this.dgrvStaff = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enter_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locker_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locker_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoes_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoes_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dpEnterMonth = new System.Windows.Forms.DateTimePicker();
            this.dpFilterEnterDate = new System.Windows.Forms.DateTimePicker();
            this.txbSearchStaff = new System.Windows.Forms.TextBox();
            this.tPKey = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNumberShoes = new System.Windows.Forms.Label();
            this.cbbShoesState = new System.Windows.Forms.ComboBox();
            this.cbbShoesType = new System.Windows.Forms.ComboBox();
            this.cbbShoesIndex = new System.Windows.Forms.ComboBox();
            this.cbbShoesNumber = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNumberLocker = new System.Windows.Forms.Label();
            this.cbbLockerState = new System.Windows.Forms.ComboBox();
            this.cbbLockerType = new System.Windows.Forms.ComboBox();
            this.cbbLockerIndex = new System.Windows.Forms.ComboBox();
            this.cbbLockerNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrvLocker = new System.Windows.Forms.DataGridView();
            this.dgrvShoes = new System.Windows.Forms.DataGridView();
            this.tPTrash = new System.Windows.Forms.TabPage();
            this.dgrvTrash = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbbNote = new System.Windows.Forms.ComboBox();
            this.dpMonth = new System.Windows.Forms.DateTimePicker();
            this.txbSearchTrash = new System.Windows.Forms.TextBox();
            this.tPSetting = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblImportQuitWork = new System.Windows.Forms.Label();
            this.btnImportQuitWork = new System.Windows.Forms.Button();
            this.lblImportKey = new System.Windows.Forms.Label();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSettingLockerDelete = new System.Windows.Forms.Button();
            this.btnDeleteLockerAll = new System.Windows.Forms.Button();
            this.txbTypeLocker1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSoOTrongTuLocker1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbLockerTo1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLockerFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImportLocker1 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnDeleteRangeShoes = new System.Windows.Forms.Button();
            this.btnDeleteShoesAll = new System.Windows.Forms.Button();
            this.txbTypeShoes = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbSoOTrongTuShoes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbShoesTo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbShoesFrom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnImportShoes1 = new System.Windows.Forms.Button();
            this.lblAddStaffState2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblImportStaffState1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txbLockerType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSoOTrongTuLocker = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLockerTo = new System.Windows.Forms.TextBox();
            this.txbTo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImportShoesState = new System.Windows.Forms.Label();
            this.btnImportShoes = new System.Windows.Forms.Button();
            this.lblImportLockerState = new System.Windows.Forms.Label();
            this.lblAddStaffState = new System.Windows.Forms.Label();
            this.btnImportLocker = new System.Windows.Forms.Button();
            this.btnAddStaffExcel = new System.Windows.Forms.Button();
            this.lblImportStaffState = new System.Windows.Forms.Label();
            this.btnImportStaff = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bgStaffTrash = new System.ComponentModel.BackgroundWorker();
            this.bgwSettingImportStaff = new System.ComponentModel.BackgroundWorker();
            this.bgwSettingAddStaff = new System.ComponentModel.BackgroundWorker();
            this.bgwSettingImportKey = new System.ComponentModel.BackgroundWorker();
            this.bgwImportQuitWork = new System.ComponentModel.BackgroundWorker();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.btnFilterEnterMonth = new System.Windows.Forms.Button();
            this.btnAllStaff = new System.Windows.Forms.Button();
            this.btnFilterEnterDate = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnShoesList = new System.Windows.Forms.Button();
            this.btnShoesSearch = new System.Windows.Forms.Button();
            this.btnDeleteShoes = new System.Windows.Forms.Button();
            this.btnAddShoes = new System.Windows.Forms.Button();
            this.btnLockerList = new System.Windows.Forms.Button();
            this.btnLockerSearch = new System.Windows.Forms.Button();
            this.btnDeleteLocker = new System.Windows.Forms.Button();
            this.btnAddLocker = new System.Windows.Forms.Button();
            this.pbStaffTrash = new System.Windows.Forms.PictureBox();
            this.btnTrashAll = new System.Windows.Forms.Button();
            this.btnTrashFilter = new System.Windows.Forms.Button();
            this.btnDeleteTrash = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabCtrMain.SuspendLayout();
            this.tPStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStaff)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tPKey.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLocker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvShoes)).BeginInit();
            this.tPTrash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrash)).BeginInit();
            this.panel10.SuspendLayout();
            this.tPSetting.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffTrash)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user-icon.png");
            this.imageList1.Images.SetKeyName(1, "key-icon.png");
            this.imageList1.Images.SetKeyName(2, "position-icon.png");
            this.imageList1.Images.SetKeyName(3, "departmet-icon.png");
            this.imageList1.Images.SetKeyName(4, "trash.png");
            this.imageList1.Images.SetKeyName(5, "settings-icon.png");
            this.imageList1.Images.SetKeyName(6, "settings-icon.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 61);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1283, 61);
            this.label3.TabIndex = 0;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ KHÓA TỦ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bgwStaff
            // 
            this.bgwStaff.WorkerReportsProgress = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabCtrMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1283, 649);
            this.panel3.TabIndex = 2;
            // 
            // tabCtrMain
            // 
            this.tabCtrMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabCtrMain.Controls.Add(this.tPStaff);
            this.tabCtrMain.Controls.Add(this.tPKey);
            this.tabCtrMain.Controls.Add(this.tPTrash);
            this.tabCtrMain.Controls.Add(this.tPSetting);
            this.tabCtrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrMain.ImageList = this.imageList1;
            this.tabCtrMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrMain.Name = "tabCtrMain";
            this.tabCtrMain.SelectedIndex = 0;
            this.tabCtrMain.Size = new System.Drawing.Size(1283, 649);
            this.tabCtrMain.TabIndex = 1;
            this.tabCtrMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrMain_SelectedIndexChanged);
            // 
            // tPStaff
            // 
            this.tPStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPStaff.Controls.Add(this.pbStaff);
            this.tPStaff.Controls.Add(this.dgrvStaff);
            this.tPStaff.Controls.Add(this.panel9);
            this.tPStaff.Controls.Add(this.panel4);
            this.tPStaff.ImageIndex = 0;
            this.tPStaff.Location = new System.Drawing.Point(4, 26);
            this.tPStaff.Name = "tPStaff";
            this.tPStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tPStaff.Size = new System.Drawing.Size(1275, 619);
            this.tPStaff.TabIndex = 0;
            this.tPStaff.Text = "Quản lý nhân viên";
            this.tPStaff.UseVisualStyleBackColor = true;
            // 
            // dgrvStaff
            // 
            this.dgrvStaff.AllowUserToAddRows = false;
            this.dgrvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgrvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvStaff.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgrvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.staff_code,
            this.full_name,
            this.gender,
            this.enter_date,
            this.department,
            this.position,
            this.locker_number,
            this.locker_index,
            this.shoes_number,
            this.shoes_index,
            this.id,
            this.locker,
            this.Pos,
            this.Dept,
            this.posId,
            this.info,
            this.deptId,
            this.Sho});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvStaff.Location = new System.Drawing.Point(3, 40);
            this.dgrvStaff.Name = "dgrvStaff";
            this.dgrvStaff.ReadOnly = true;
            this.dgrvStaff.RowHeadersVisible = false;
            this.dgrvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrvStaff.Size = new System.Drawing.Size(1267, 521);
            this.dgrvStaff.TabIndex = 2;
            this.dgrvStaff.VirtualMode = true;
            this.dgrvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvStaff_CellClick);
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "STT";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 56;
            // 
            // staff_code
            // 
            this.staff_code.DataPropertyName = "staff_code";
            this.staff_code.HeaderText = "Mã nhân viên ";
            this.staff_code.Name = "staff_code";
            this.staff_code.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Họ và tên";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "genderStr";
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // enter_date
            // 
            this.enter_date.DataPropertyName = "enter_date";
            this.enter_date.HeaderText = "Ngày vào";
            this.enter_date.Name = "enter_date";
            this.enter_date.ReadOnly = true;
            // 
            // department
            // 
            this.department.DataPropertyName = "deptName";
            this.department.HeaderText = "Phòng ban";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // position
            // 
            this.position.DataPropertyName = "posName";
            this.position.HeaderText = "Chức vụ";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // locker_number
            // 
            this.locker_number.DataPropertyName = "locker_number";
            this.locker_number.HeaderText = "Số tủ locker";
            this.locker_number.Name = "locker_number";
            this.locker_number.ReadOnly = true;
            // 
            // locker_index
            // 
            this.locker_index.DataPropertyName = "locker_index";
            this.locker_index.HeaderText = "Số ô locker";
            this.locker_index.Name = "locker_index";
            this.locker_index.ReadOnly = true;
            // 
            // shoes_number
            // 
            this.shoes_number.DataPropertyName = "shoes_number";
            this.shoes_number.HeaderText = "Số tủ giày";
            this.shoes_number.Name = "shoes_number";
            this.shoes_number.ReadOnly = true;
            // 
            // shoes_index
            // 
            this.shoes_index.DataPropertyName = "shoes_index";
            this.shoes_index.HeaderText = "Số ô giày";
            this.shoes_index.Name = "shoes_index";
            this.shoes_index.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // locker
            // 
            this.locker.DataPropertyName = "Locker";
            this.locker.HeaderText = "locker";
            this.locker.Name = "locker";
            this.locker.ReadOnly = true;
            this.locker.Visible = false;
            // 
            // Pos
            // 
            this.Pos.DataPropertyName = "Pos";
            this.Pos.HeaderText = "Pos";
            this.Pos.Name = "Pos";
            this.Pos.ReadOnly = true;
            this.Pos.Visible = false;
            // 
            // Dept
            // 
            this.Dept.DataPropertyName = "Dept";
            this.Dept.HeaderText = "Dept";
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            this.Dept.Visible = false;
            // 
            // posId
            // 
            this.posId.DataPropertyName = "position";
            this.posId.HeaderText = "posId";
            this.posId.Name = "posId";
            this.posId.ReadOnly = true;
            this.posId.Visible = false;
            // 
            // info
            // 
            this.info.DataPropertyName = "info";
            this.info.HeaderText = "info";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Visible = false;
            // 
            // deptId
            // 
            this.deptId.DataPropertyName = "department";
            this.deptId.HeaderText = "deptId";
            this.deptId.Name = "deptId";
            this.deptId.ReadOnly = true;
            this.deptId.Visible = false;
            // 
            // Sho
            // 
            this.Sho.DataPropertyName = "Sho";
            this.Sho.HeaderText = "Sho";
            this.Sho.Name = "Sho";
            this.Sho.ReadOnly = true;
            this.Sho.Visible = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblInfo);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 561);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1267, 53);
            this.panel9.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(14, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(33, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "None";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilterEnterMonth);
            this.panel4.Controls.Add(this.dpEnterMonth);
            this.panel4.Controls.Add(this.btnAllStaff);
            this.panel4.Controls.Add(this.btnFilterEnterDate);
            this.panel4.Controls.Add(this.dpFilterEnterDate);
            this.panel4.Controls.Add(this.txbSearchStaff);
            this.panel4.Controls.Add(this.btnDeleteStaff);
            this.panel4.Controls.Add(this.btnEditStaff);
            this.panel4.Controls.Add(this.btnAddStaff);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1267, 37);
            this.panel4.TabIndex = 0;
            // 
            // dpEnterMonth
            // 
            this.dpEnterMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEnterMonth.Location = new System.Drawing.Point(858, 9);
            this.dpEnterMonth.Name = "dpEnterMonth";
            this.dpEnterMonth.Size = new System.Drawing.Size(200, 20);
            this.dpEnterMonth.TabIndex = 17;
            // 
            // dpFilterEnterDate
            // 
            this.dpFilterEnterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFilterEnterDate.Location = new System.Drawing.Point(570, 8);
            this.dpFilterEnterDate.Name = "dpFilterEnterDate";
            this.dpFilterEnterDate.Size = new System.Drawing.Size(200, 20);
            this.dpFilterEnterDate.TabIndex = 14;
            // 
            // txbSearchStaff
            // 
            this.txbSearchStaff.ForeColor = System.Drawing.Color.Gray;
            this.txbSearchStaff.Location = new System.Drawing.Point(137, 8);
            this.txbSearchStaff.Name = "txbSearchStaff";
            this.txbSearchStaff.Size = new System.Drawing.Size(416, 20);
            this.txbSearchStaff.TabIndex = 4;
            this.txbSearchStaff.Text = "Nhập mã nhân viên";
            this.txbSearchStaff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchStaff_KeyDown);
            // 
            // tPKey
            // 
            this.tPKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPKey.Controls.Add(this.tableLayoutPanel1);
            this.tPKey.ImageIndex = 1;
            this.tPKey.Location = new System.Drawing.Point(4, 26);
            this.tPKey.Name = "tPKey";
            this.tPKey.Padding = new System.Windows.Forms.Padding(3);
            this.tPKey.Size = new System.Drawing.Size(1275, 619);
            this.tPKey.TabIndex = 1;
            this.tPKey.Text = "Quản lý khóa";
            this.tPKey.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgrvLocker, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgrvShoes, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1267, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblNumberShoes);
            this.panel5.Controls.Add(this.btnShoesList);
            this.panel5.Controls.Add(this.cbbShoesState);
            this.panel5.Controls.Add(this.cbbShoesType);
            this.panel5.Controls.Add(this.cbbShoesIndex);
            this.panel5.Controls.Add(this.btnShoesSearch);
            this.panel5.Controls.Add(this.cbbShoesNumber);
            this.panel5.Controls.Add(this.btnDeleteShoes);
            this.panel5.Controls.Add(this.btnAddShoes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(637, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(626, 29);
            this.panel5.TabIndex = 4;
            // 
            // lblNumberShoes
            // 
            this.lblNumberShoes.AutoSize = true;
            this.lblNumberShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberShoes.Location = new System.Drawing.Point(565, 9);
            this.lblNumberShoes.Name = "lblNumberShoes";
            this.lblNumberShoes.Size = new System.Drawing.Size(14, 13);
            this.lblNumberShoes.TabIndex = 13;
            this.lblNumberShoes.Text = "0";
            // 
            // cbbShoesState
            // 
            this.cbbShoesState.FormattingEnabled = true;
            this.cbbShoesState.Items.AddRange(new object[] {
            "AVAIABLE",
            "USED"});
            this.cbbShoesState.Location = new System.Drawing.Point(359, 3);
            this.cbbShoesState.Name = "cbbShoesState";
            this.cbbShoesState.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesState.TabIndex = 11;
            this.cbbShoesState.Text = "Trạng thái";
            this.cbbShoesState.SelectedIndexChanged += new System.EventHandler(this.cbbShoesState_SelectedIndexChanged);
            // 
            // cbbShoesType
            // 
            this.cbbShoesType.FormattingEnabled = true;
            this.cbbShoesType.Location = new System.Drawing.Point(265, 4);
            this.cbbShoesType.Name = "cbbShoesType";
            this.cbbShoesType.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesType.TabIndex = 10;
            this.cbbShoesType.Text = "Chọn loại";
            this.cbbShoesType.SelectedIndexChanged += new System.EventHandler(this.cbbShoesType_SelectedIndexChanged);
            // 
            // cbbShoesIndex
            // 
            this.cbbShoesIndex.FormattingEnabled = true;
            this.cbbShoesIndex.Location = new System.Drawing.Point(171, 3);
            this.cbbShoesIndex.Name = "cbbShoesIndex";
            this.cbbShoesIndex.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesIndex.TabIndex = 4;
            this.cbbShoesIndex.Text = "Chọn ô";
            this.cbbShoesIndex.TabIndexChanged += new System.EventHandler(this.cbbShoesIndex_SelectedIndexChanged);
            this.cbbShoesIndex.TextChanged += new System.EventHandler(this.cbbShoesIndex_TextChanged);
            this.cbbShoesIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbShoesIndex_KeyPress);
            // 
            // cbbShoesNumber
            // 
            this.cbbShoesNumber.FormattingEnabled = true;
            this.cbbShoesNumber.Location = new System.Drawing.Point(68, 5);
            this.cbbShoesNumber.Name = "cbbShoesNumber";
            this.cbbShoesNumber.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesNumber.TabIndex = 3;
            this.cbbShoesNumber.Text = "Chọn tủ";
            this.cbbShoesNumber.TabIndexChanged += new System.EventHandler(this.cbbShoesNumber_SelectedIndexChanged);
            this.cbbShoesNumber.TextChanged += new System.EventHandler(this.cbbShoesNumber_TextChanged);
            this.cbbShoesNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbShoesNumber_KeyPress);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblNumberLocker);
            this.panel6.Controls.Add(this.btnLockerList);
            this.panel6.Controls.Add(this.cbbLockerState);
            this.panel6.Controls.Add(this.cbbLockerType);
            this.panel6.Controls.Add(this.btnLockerSearch);
            this.panel6.Controls.Add(this.cbbLockerIndex);
            this.panel6.Controls.Add(this.cbbLockerNumber);
            this.panel6.Controls.Add(this.btnDeleteLocker);
            this.panel6.Controls.Add(this.btnAddLocker);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(4, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(626, 29);
            this.panel6.TabIndex = 3;
            // 
            // lblNumberLocker
            // 
            this.lblNumberLocker.AutoSize = true;
            this.lblNumberLocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberLocker.Location = new System.Drawing.Point(590, 8);
            this.lblNumberLocker.Name = "lblNumberLocker";
            this.lblNumberLocker.Size = new System.Drawing.Size(14, 13);
            this.lblNumberLocker.TabIndex = 12;
            this.lblNumberLocker.Text = "0";
            // 
            // cbbLockerState
            // 
            this.cbbLockerState.FormattingEnabled = true;
            this.cbbLockerState.Items.AddRange(new object[] {
            "AVAIABLE",
            "USED"});
            this.cbbLockerState.Location = new System.Drawing.Point(383, 2);
            this.cbbLockerState.Name = "cbbLockerState";
            this.cbbLockerState.Size = new System.Drawing.Size(88, 21);
            this.cbbLockerState.TabIndex = 10;
            this.cbbLockerState.Text = "Trạng thái";
            this.cbbLockerState.SelectedIndexChanged += new System.EventHandler(this.cbbLockerState_SelectedIndexChanged);
            // 
            // cbbLockerType
            // 
            this.cbbLockerType.FormattingEnabled = true;
            this.cbbLockerType.Location = new System.Drawing.Point(278, 2);
            this.cbbLockerType.Name = "cbbLockerType";
            this.cbbLockerType.Size = new System.Drawing.Size(88, 21);
            this.cbbLockerType.TabIndex = 9;
            this.cbbLockerType.Text = "Chọn loại";
            this.cbbLockerType.SelectedIndexChanged += new System.EventHandler(this.cbbLockerType_SelectedIndexChanged);
            // 
            // cbbLockerIndex
            // 
            this.cbbLockerIndex.FormattingEnabled = true;
            this.cbbLockerIndex.Location = new System.Drawing.Point(171, 3);
            this.cbbLockerIndex.Name = "cbbLockerIndex";
            this.cbbLockerIndex.Size = new System.Drawing.Size(88, 21);
            this.cbbLockerIndex.TabIndex = 4;
            this.cbbLockerIndex.Text = "Chọn ô";
            this.cbbLockerIndex.TabIndexChanged += new System.EventHandler(this.cbbLockerIndex_SelectedIndexChanged);
            this.cbbLockerIndex.TextChanged += new System.EventHandler(this.cbbLockerIndex_TextChanged);
            this.cbbLockerIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLockerIndex_KeyPress);
            // 
            // cbbLockerNumber
            // 
            this.cbbLockerNumber.FormattingEnabled = true;
            this.cbbLockerNumber.Location = new System.Drawing.Point(68, 2);
            this.cbbLockerNumber.Name = "cbbLockerNumber";
            this.cbbLockerNumber.Size = new System.Drawing.Size(88, 21);
            this.cbbLockerNumber.TabIndex = 3;
            this.cbbLockerNumber.Text = "Chọn tủ";
            this.cbbLockerNumber.TabIndexChanged += new System.EventHandler(this.cbbLockerNumber_SelectedIndexChanged);
            this.cbbLockerNumber.TextChanged += new System.EventHandler(this.cbbLockerNumber_TextChanged);
            this.cbbLockerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLockerNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tủ Giày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOCKER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrvLocker
            // 
            this.dgrvLocker.AllowUserToAddRows = false;
            this.dgrvLocker.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrvLocker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrvLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvLocker.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvLocker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvLocker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrvLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvLocker.Location = new System.Drawing.Point(4, 61);
            this.dgrvLocker.Name = "dgrvLocker";
            this.dgrvLocker.ReadOnly = true;
            this.dgrvLocker.RowHeadersVisible = false;
            this.dgrvLocker.Size = new System.Drawing.Size(626, 546);
            this.dgrvLocker.TabIndex = 5;
            this.dgrvLocker.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvLocker_CellMouseDoubleClick);
            // 
            // dgrvShoes
            // 
            this.dgrvShoes.AllowUserToAddRows = false;
            this.dgrvShoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrvShoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgrvShoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvShoes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvShoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvShoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrvShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvShoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvShoes.Location = new System.Drawing.Point(637, 61);
            this.dgrvShoes.Name = "dgrvShoes";
            this.dgrvShoes.ReadOnly = true;
            this.dgrvShoes.RowHeadersVisible = false;
            this.dgrvShoes.Size = new System.Drawing.Size(626, 546);
            this.dgrvShoes.TabIndex = 6;
            this.dgrvShoes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvShoes_CellMouseDoubleClick);
            // 
            // tPTrash
            // 
            this.tPTrash.Controls.Add(this.pbStaffTrash);
            this.tPTrash.Controls.Add(this.dgrvTrash);
            this.tPTrash.Controls.Add(this.panel10);
            this.tPTrash.ImageIndex = 4;
            this.tPTrash.Location = new System.Drawing.Point(4, 26);
            this.tPTrash.Name = "tPTrash";
            this.tPTrash.Padding = new System.Windows.Forms.Padding(3);
            this.tPTrash.Size = new System.Drawing.Size(1275, 619);
            this.tPTrash.TabIndex = 4;
            this.tPTrash.Text = "Danh sách nghỉ việc";
            this.tPTrash.UseVisualStyleBackColor = true;
            // 
            // dgrvTrash
            // 
            this.dgrvTrash.AllowUserToAddRows = false;
            this.dgrvTrash.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgrvTrash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrvTrash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvTrash.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvTrash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvTrash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgrvTrash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgrvTrash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.end_date,
            this.note,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvTrash.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgrvTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvTrash.Location = new System.Drawing.Point(3, 40);
            this.dgrvTrash.Name = "dgrvTrash";
            this.dgrvTrash.ReadOnly = true;
            this.dgrvTrash.RowHeadersVisible = false;
            this.dgrvTrash.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrvTrash.Size = new System.Drawing.Size(1269, 576);
            this.dgrvTrash.TabIndex = 5;
            this.dgrvTrash.VirtualMode = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "index";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "staff_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhân viên ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "full_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "genderStr";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "enter_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày vào";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "deptName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phòng ban";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "posName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Chức vụ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "locker_number";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số tủ locker";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "locker_index";
            this.dataGridViewTextBoxColumn9.HeaderText = "Số ô locker";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "shoes_number";
            this.dataGridViewTextBoxColumn10.HeaderText = "Số tủ giày";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "shoes_index";
            this.dataGridViewTextBoxColumn11.HeaderText = "Số ô giày";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "Ngày kết thúc";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Ghi chú";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn12.HeaderText = "id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Locker";
            this.dataGridViewTextBoxColumn13.HeaderText = "locker";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Pos";
            this.dataGridViewTextBoxColumn14.HeaderText = "Pos";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Dept";
            this.dataGridViewTextBoxColumn15.HeaderText = "Dept";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn16.HeaderText = "posId";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "info";
            this.dataGridViewTextBoxColumn17.HeaderText = "info";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "department";
            this.dataGridViewTextBoxColumn18.HeaderText = "deptId";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Sho";
            this.dataGridViewTextBoxColumn19.HeaderText = "Sho";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnTrashAll);
            this.panel10.Controls.Add(this.btnTrashFilter);
            this.panel10.Controls.Add(this.cbbNote);
            this.panel10.Controls.Add(this.dpMonth);
            this.panel10.Controls.Add(this.txbSearchTrash);
            this.panel10.Controls.Add(this.btnDeleteTrash);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1269, 37);
            this.panel10.TabIndex = 4;
            // 
            // cbbNote
            // 
            this.cbbNote.FormattingEnabled = true;
            this.cbbNote.Items.AddRange(new object[] {
            "Return key",
            "Not return key"});
            this.cbbNote.Location = new System.Drawing.Point(711, 5);
            this.cbbNote.Name = "cbbNote";
            this.cbbNote.Size = new System.Drawing.Size(121, 21);
            this.cbbNote.TabIndex = 6;
            // 
            // dpMonth
            // 
            this.dpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMonth.Location = new System.Drawing.Point(490, 7);
            this.dpMonth.Name = "dpMonth";
            this.dpMonth.Size = new System.Drawing.Size(200, 20);
            this.dpMonth.TabIndex = 5;
            // 
            // txbSearchTrash
            // 
            this.txbSearchTrash.ForeColor = System.Drawing.Color.Gray;
            this.txbSearchTrash.Location = new System.Drawing.Point(50, 8);
            this.txbSearchTrash.Name = "txbSearchTrash";
            this.txbSearchTrash.Size = new System.Drawing.Size(416, 20);
            this.txbSearchTrash.TabIndex = 4;
            this.txbSearchTrash.Text = "Nhập mã nhân viên";
            this.txbSearchTrash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchTrash_KeyDown);
            // 
            // tPSetting
            // 
            this.tPSetting.Controls.Add(this.panel11);
            this.tPSetting.ImageIndex = 5;
            this.tPSetting.Location = new System.Drawing.Point(4, 26);
            this.tPSetting.Name = "tPSetting";
            this.tPSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tPSetting.Size = new System.Drawing.Size(1275, 619);
            this.tPSetting.TabIndex = 5;
            this.tPSetting.Text = "Cài đặt";
            this.tPSetting.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.txbLockerType);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.txbSoOTrongTuLocker);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.txbLockerTo);
            this.panel11.Controls.Add(this.txbTo);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.lblImportShoesState);
            this.panel11.Controls.Add(this.btnImportShoes);
            this.panel11.Controls.Add(this.lblImportLockerState);
            this.panel11.Controls.Add(this.lblAddStaffState);
            this.panel11.Controls.Add(this.btnImportLocker);
            this.panel11.Controls.Add(this.btnAddStaffExcel);
            this.panel11.Controls.Add(this.lblImportStaffState);
            this.panel11.Controls.Add(this.btnImportStaff);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1269, 613);
            this.panel11.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblImportQuitWork);
            this.panel12.Controls.Add(this.btnImportQuitWork);
            this.panel12.Controls.Add(this.lblImportKey);
            this.panel12.Controls.Add(this.btnImportKey);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.lblAddStaffState2);
            this.panel12.Controls.Add(this.button3);
            this.panel12.Controls.Add(this.lblImportStaffState1);
            this.panel12.Controls.Add(this.button5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1269, 613);
            this.panel12.TabIndex = 14;
            // 
            // lblImportQuitWork
            // 
            this.lblImportQuitWork.AutoSize = true;
            this.lblImportQuitWork.Location = new System.Drawing.Point(287, 334);
            this.lblImportQuitWork.Name = "lblImportQuitWork";
            this.lblImportQuitWork.Size = new System.Drawing.Size(33, 13);
            this.lblImportQuitWork.TabIndex = 27;
            this.lblImportQuitWork.Text = "None";
            // 
            // btnImportQuitWork
            // 
            this.btnImportQuitWork.Location = new System.Drawing.Point(33, 329);
            this.btnImportQuitWork.Name = "btnImportQuitWork";
            this.btnImportQuitWork.Size = new System.Drawing.Size(211, 23);
            this.btnImportQuitWork.TabIndex = 26;
            this.btnImportQuitWork.Text = "Import nhân viên nghỉ việc";
            this.btnImportQuitWork.UseVisualStyleBackColor = true;
            this.btnImportQuitWork.Click += new System.EventHandler(this.btnImportQuitWork_Click);
            // 
            // lblImportKey
            // 
            this.lblImportKey.AutoSize = true;
            this.lblImportKey.Location = new System.Drawing.Point(293, 276);
            this.lblImportKey.Name = "lblImportKey";
            this.lblImportKey.Size = new System.Drawing.Size(33, 13);
            this.lblImportKey.TabIndex = 25;
            this.lblImportKey.Text = "None";
            // 
            // btnImportKey
            // 
            this.btnImportKey.Location = new System.Drawing.Point(33, 271);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(211, 23);
            this.btnImportKey.TabIndex = 24;
            this.btnImportKey.Text = "Import tủ giày và locker";
            this.btnImportKey.UseVisualStyleBackColor = true;
            this.btnImportKey.Click += new System.EventHandler(this.btnImportKey_Click);
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btnSettingLockerDelete);
            this.panel14.Controls.Add(this.btnDeleteLockerAll);
            this.panel14.Controls.Add(this.txbTypeLocker1);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Controls.Add(this.txbSoOTrongTuLocker1);
            this.panel14.Controls.Add(this.label9);
            this.panel14.Controls.Add(this.txbLockerTo1);
            this.panel14.Controls.Add(this.label10);
            this.panel14.Controls.Add(this.tbLockerFrom);
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.btnImportLocker1);
            this.panel14.Location = new System.Drawing.Point(21, 18);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1179, 29);
            this.panel14.TabIndex = 23;
            this.panel14.Visible = false;
            // 
            // btnSettingLockerDelete
            // 
            this.btnSettingLockerDelete.Location = new System.Drawing.Point(1086, 77);
            this.btnSettingLockerDelete.Name = "btnSettingLockerDelete";
            this.btnSettingLockerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSettingLockerDelete.TabIndex = 24;
            this.btnSettingLockerDelete.Text = "Xóa";
            this.btnSettingLockerDelete.UseVisualStyleBackColor = true;
            this.btnSettingLockerDelete.Click += new System.EventHandler(this.btnSettingLockerDelete_Click);
            // 
            // btnDeleteLockerAll
            // 
            this.btnDeleteLockerAll.Location = new System.Drawing.Point(66, 15);
            this.btnDeleteLockerAll.Name = "btnDeleteLockerAll";
            this.btnDeleteLockerAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLockerAll.TabIndex = 23;
            this.btnDeleteLockerAll.Text = "Xóa hết";
            this.btnDeleteLockerAll.UseVisualStyleBackColor = true;
            this.btnDeleteLockerAll.Click += new System.EventHandler(this.btnDeleteLockerAll_Click);
            // 
            // txbTypeLocker1
            // 
            this.txbTypeLocker1.Location = new System.Drawing.Point(696, 76);
            this.txbTypeLocker1.Name = "txbTypeLocker1";
            this.txbTypeLocker1.Size = new System.Drawing.Size(100, 20);
            this.txbTypeLocker1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(641, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Loại tủ";
            // 
            // txbSoOTrongTuLocker1
            // 
            this.txbSoOTrongTuLocker1.Location = new System.Drawing.Point(525, 77);
            this.txbSoOTrongTuLocker1.Name = "txbSoOTrongTuLocker1";
            this.txbSoOTrongTuLocker1.Size = new System.Drawing.Size(100, 20);
            this.txbSoOTrongTuLocker1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Số ô trong 1 tủ";
            // 
            // txbLockerTo1
            // 
            this.txbLockerTo1.Location = new System.Drawing.Point(306, 80);
            this.txbLockerTo1.Name = "txbLockerTo1";
            this.txbLockerTo1.Size = new System.Drawing.Size(100, 20);
            this.txbLockerTo1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đến tủ";
            // 
            // tbLockerFrom
            // 
            this.tbLockerFrom.Location = new System.Drawing.Point(110, 80);
            this.tbLockerFrom.Name = "tbLockerFrom";
            this.tbLockerFrom.Size = new System.Drawing.Size(100, 20);
            this.tbLockerFrom.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Từ tủ";
            // 
            // btnImportLocker1
            // 
            this.btnImportLocker1.Location = new System.Drawing.Point(856, 77);
            this.btnImportLocker1.Name = "btnImportLocker1";
            this.btnImportLocker1.Size = new System.Drawing.Size(211, 23);
            this.btnImportLocker1.TabIndex = 14;
            this.btnImportLocker1.Text = "Import tủ locker từ file excel";
            this.btnImportLocker1.UseVisualStyleBackColor = true;
            this.btnImportLocker1.Click += new System.EventHandler(this.btnImportLocker_Click);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.btnDeleteRangeShoes);
            this.panel13.Controls.Add(this.btnDeleteShoesAll);
            this.panel13.Controls.Add(this.txbTypeShoes);
            this.panel13.Controls.Add(this.label18);
            this.panel13.Controls.Add(this.txbSoOTrongTuShoes);
            this.panel13.Controls.Add(this.label17);
            this.panel13.Controls.Add(this.txbShoesTo);
            this.panel13.Controls.Add(this.label16);
            this.panel13.Controls.Add(this.txbShoesFrom);
            this.panel13.Controls.Add(this.label15);
            this.panel13.Controls.Add(this.btnImportShoes1);
            this.panel13.Location = new System.Drawing.Point(21, 63);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1179, 30);
            this.panel13.TabIndex = 22;
            this.panel13.Visible = false;
            // 
            // btnDeleteRangeShoes
            // 
            this.btnDeleteRangeShoes.Location = new System.Drawing.Point(1086, 99);
            this.btnDeleteRangeShoes.Name = "btnDeleteRangeShoes";
            this.btnDeleteRangeShoes.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRangeShoes.TabIndex = 31;
            this.btnDeleteRangeShoes.Text = "Xóa";
            this.btnDeleteRangeShoes.UseVisualStyleBackColor = true;
            this.btnDeleteRangeShoes.Click += new System.EventHandler(this.btnDeleteRangeShoes_Click);
            // 
            // btnDeleteShoesAll
            // 
            this.btnDeleteShoesAll.Location = new System.Drawing.Point(66, 37);
            this.btnDeleteShoesAll.Name = "btnDeleteShoesAll";
            this.btnDeleteShoesAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteShoesAll.TabIndex = 24;
            this.btnDeleteShoesAll.Text = "Xóa hết";
            this.btnDeleteShoesAll.UseVisualStyleBackColor = true;
            this.btnDeleteShoesAll.Click += new System.EventHandler(this.btnDeleteShoesAll_Click);
            // 
            // txbTypeShoes
            // 
            this.txbTypeShoes.Location = new System.Drawing.Point(708, 100);
            this.txbTypeShoes.Name = "txbTypeShoes";
            this.txbTypeShoes.Size = new System.Drawing.Size(100, 20);
            this.txbTypeShoes.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(649, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Loại tủ";
            // 
            // txbSoOTrongTuShoes
            // 
            this.txbSoOTrongTuShoes.Location = new System.Drawing.Point(538, 100);
            this.txbSoOTrongTuShoes.Name = "txbSoOTrongTuShoes";
            this.txbSoOTrongTuShoes.Size = new System.Drawing.Size(100, 20);
            this.txbSoOTrongTuShoes.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(454, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Số ô trong 1 tủ";
            // 
            // txbShoesTo
            // 
            this.txbShoesTo.Location = new System.Drawing.Point(318, 97);
            this.txbShoesTo.Name = "txbShoesTo";
            this.txbShoesTo.Size = new System.Drawing.Size(100, 20);
            this.txbShoesTo.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(259, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Đến tủ";
            // 
            // txbShoesFrom
            // 
            this.txbShoesFrom.Location = new System.Drawing.Point(122, 97);
            this.txbShoesFrom.Name = "txbShoesFrom";
            this.txbShoesFrom.Size = new System.Drawing.Size(100, 20);
            this.txbShoesFrom.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Từ tủ";
            // 
            // btnImportShoes1
            // 
            this.btnImportShoes1.Location = new System.Drawing.Point(859, 100);
            this.btnImportShoes1.Name = "btnImportShoes1";
            this.btnImportShoes1.Size = new System.Drawing.Size(211, 23);
            this.btnImportShoes1.TabIndex = 22;
            this.btnImportShoes1.Text = "Import tủ giày từ file excel";
            this.btnImportShoes1.UseVisualStyleBackColor = true;
            this.btnImportShoes1.Click += new System.EventHandler(this.btnImportShoes1_Click);
            // 
            // lblAddStaffState2
            // 
            this.lblAddStaffState2.AutoSize = true;
            this.lblAddStaffState2.Location = new System.Drawing.Point(293, 216);
            this.lblAddStaffState2.Name = "lblAddStaffState2";
            this.lblAddStaffState2.Size = new System.Drawing.Size(33, 13);
            this.lblAddStaffState2.TabIndex = 3;
            this.lblAddStaffState2.Text = "None";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thêm nhân viên từ file excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAddStaffExcel_Click);
            // 
            // lblImportStaffState1
            // 
            this.lblImportStaffState1.AutoSize = true;
            this.lblImportStaffState1.Location = new System.Drawing.Point(293, 149);
            this.lblImportStaffState1.Name = "lblImportStaffState1";
            this.lblImportStaffState1.Size = new System.Drawing.Size(33, 13);
            this.lblImportStaffState1.TabIndex = 1;
            this.lblImportStaffState1.Text = "None";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Import nhân viên từ file excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnImportStaff_Click);
            // 
            // txbLockerType
            // 
            this.txbLockerType.Location = new System.Drawing.Point(666, 135);
            this.txbLockerType.Name = "txbLockerType";
            this.txbLockerType.Size = new System.Drawing.Size(100, 20);
            this.txbLockerType.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Loại tủ";
            // 
            // txbSoOTrongTuLocker
            // 
            this.txbSoOTrongTuLocker.Location = new System.Drawing.Point(495, 136);
            this.txbSoOTrongTuLocker.Name = "txbSoOTrongTuLocker";
            this.txbSoOTrongTuLocker.Size = new System.Drawing.Size(100, 20);
            this.txbSoOTrongTuLocker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số ô trong 1 tủ";
            // 
            // txbLockerTo
            // 
            this.txbLockerTo.Location = new System.Drawing.Point(276, 139);
            this.txbLockerTo.Name = "txbLockerTo";
            this.txbLockerTo.Size = new System.Drawing.Size(100, 20);
            this.txbLockerTo.TabIndex = 9;
            // 
            // txbTo
            // 
            this.txbTo.AutoSize = true;
            this.txbTo.Location = new System.Drawing.Point(217, 139);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(39, 13);
            this.txbTo.TabIndex = 8;
            this.txbTo.Text = "Đến tủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Từ tủ";
            // 
            // lblImportShoesState
            // 
            this.lblImportShoesState.AutoSize = true;
            this.lblImportShoesState.Location = new System.Drawing.Point(258, 468);
            this.lblImportShoesState.Name = "lblImportShoesState";
            this.lblImportShoesState.Size = new System.Drawing.Size(33, 13);
            this.lblImportShoesState.TabIndex = 5;
            this.lblImportShoesState.Text = "None";
            // 
            // btnImportShoes
            // 
            this.btnImportShoes.Location = new System.Drawing.Point(21, 463);
            this.btnImportShoes.Name = "btnImportShoes";
            this.btnImportShoes.Size = new System.Drawing.Size(211, 23);
            this.btnImportShoes.TabIndex = 4;
            this.btnImportShoes.Text = "Import tủ giày từ file excel";
            this.btnImportShoes.UseVisualStyleBackColor = true;
            // 
            // lblImportLockerState
            // 
            this.lblImportLockerState.AutoSize = true;
            this.lblImportLockerState.Location = new System.Drawing.Point(273, 190);
            this.lblImportLockerState.Name = "lblImportLockerState";
            this.lblImportLockerState.Size = new System.Drawing.Size(33, 13);
            this.lblImportLockerState.TabIndex = 3;
            this.lblImportLockerState.Text = "None";
            // 
            // lblAddStaffState
            // 
            this.lblAddStaffState.AutoSize = true;
            this.lblAddStaffState.Location = new System.Drawing.Point(258, 85);
            this.lblAddStaffState.Name = "lblAddStaffState";
            this.lblAddStaffState.Size = new System.Drawing.Size(33, 13);
            this.lblAddStaffState.TabIndex = 3;
            this.lblAddStaffState.Text = "None";
            // 
            // btnImportLocker
            // 
            this.btnImportLocker.Location = new System.Drawing.Point(21, 185);
            this.btnImportLocker.Name = "btnImportLocker";
            this.btnImportLocker.Size = new System.Drawing.Size(211, 23);
            this.btnImportLocker.TabIndex = 2;
            this.btnImportLocker.Text = "Import tủ locker từ file excel";
            this.btnImportLocker.UseVisualStyleBackColor = true;
            this.btnImportLocker.Click += new System.EventHandler(this.btnImportLocker_Click);
            // 
            // btnAddStaffExcel
            // 
            this.btnAddStaffExcel.Location = new System.Drawing.Point(21, 80);
            this.btnAddStaffExcel.Name = "btnAddStaffExcel";
            this.btnAddStaffExcel.Size = new System.Drawing.Size(211, 23);
            this.btnAddStaffExcel.TabIndex = 2;
            this.btnAddStaffExcel.Text = "Thêm nhân viên từ file excel";
            this.btnAddStaffExcel.UseVisualStyleBackColor = true;
            this.btnAddStaffExcel.Click += new System.EventHandler(this.btnAddStaffExcel_Click);
            // 
            // lblImportStaffState
            // 
            this.lblImportStaffState.AutoSize = true;
            this.lblImportStaffState.Location = new System.Drawing.Point(258, 34);
            this.lblImportStaffState.Name = "lblImportStaffState";
            this.lblImportStaffState.Size = new System.Drawing.Size(33, 13);
            this.lblImportStaffState.TabIndex = 1;
            this.lblImportStaffState.Text = "None";
            // 
            // btnImportStaff
            // 
            this.btnImportStaff.Location = new System.Drawing.Point(21, 29);
            this.btnImportStaff.Name = "btnImportStaff";
            this.btnImportStaff.Size = new System.Drawing.Size(211, 23);
            this.btnImportStaff.TabIndex = 0;
            this.btnImportStaff.Text = "Import nhân viên từ file excel";
            this.btnImportStaff.UseVisualStyleBackColor = true;
            this.btnImportStaff.Click += new System.EventHandler(this.btnImportStaff_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbStaff
            // 
            this.pbStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStaff.BackColor = System.Drawing.Color.Transparent;
            this.pbStaff.Image = global::UMCLocker.Properties.Resources.loading;
            this.pbStaff.Location = new System.Drawing.Point(597, 258);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(64, 64);
            this.pbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStaff.TabIndex = 3;
            this.pbStaff.TabStop = false;
            // 
            // btnFilterEnterMonth
            // 
            this.btnFilterEnterMonth.FlatAppearance.BorderSize = 0;
            this.btnFilterEnterMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterEnterMonth.Image = global::UMCLocker.Properties.Resources.filter_icon;
            this.btnFilterEnterMonth.Location = new System.Drawing.Point(1071, 5);
            this.btnFilterEnterMonth.Name = "btnFilterEnterMonth";
            this.btnFilterEnterMonth.Size = new System.Drawing.Size(45, 23);
            this.btnFilterEnterMonth.TabIndex = 18;
            this.btnFilterEnterMonth.Tag = "0";
            this.btnFilterEnterMonth.UseVisualStyleBackColor = true;
            this.btnFilterEnterMonth.Click += new System.EventHandler(this.btnFilterEnterMonth_Click);
            // 
            // btnAllStaff
            // 
            this.btnAllStaff.FlatAppearance.BorderSize = 0;
            this.btnAllStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllStaff.Image = global::UMCLocker.Properties.Resources.list_icon;
            this.btnAllStaff.Location = new System.Drawing.Point(1122, 3);
            this.btnAllStaff.Name = "btnAllStaff";
            this.btnAllStaff.Size = new System.Drawing.Size(45, 23);
            this.btnAllStaff.TabIndex = 16;
            this.btnAllStaff.Tag = "0";
            this.btnAllStaff.UseVisualStyleBackColor = true;
            this.btnAllStaff.Click += new System.EventHandler(this.btnAllStaff_Click);
            // 
            // btnFilterEnterDate
            // 
            this.btnFilterEnterDate.FlatAppearance.BorderSize = 0;
            this.btnFilterEnterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterEnterDate.Image = global::UMCLocker.Properties.Resources.filter_icon;
            this.btnFilterEnterDate.Location = new System.Drawing.Point(776, 6);
            this.btnFilterEnterDate.Name = "btnFilterEnterDate";
            this.btnFilterEnterDate.Size = new System.Drawing.Size(45, 23);
            this.btnFilterEnterDate.TabIndex = 15;
            this.btnFilterEnterDate.Tag = "0";
            this.btnFilterEnterDate.UseVisualStyleBackColor = true;
            this.btnFilterEnterDate.Click += new System.EventHandler(this.btnFilterStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Image = global::UMCLocker.Properties.Resources.delete_icon;
            this.btnDeleteStaff.Location = new System.Drawing.Point(70, 0);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(35, 37);
            this.btnDeleteStaff.TabIndex = 2;
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditStaff.FlatAppearance.BorderSize = 0;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Image = global::UMCLocker.Properties.Resources.edit_icon;
            this.btnEditStaff.Location = new System.Drawing.Point(35, 0);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(35, 37);
            this.btnEditStaff.TabIndex = 1;
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Image = global::UMCLocker.Properties.Resources.add_icon;
            this.btnAddStaff.Location = new System.Drawing.Point(0, 0);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(35, 37);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnShoesList
            // 
            this.btnShoesList.FlatAppearance.BorderSize = 0;
            this.btnShoesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoesList.Image = global::UMCLocker.Properties.Resources.list_icon;
            this.btnShoesList.Location = new System.Drawing.Point(509, 0);
            this.btnShoesList.Name = "btnShoesList";
            this.btnShoesList.Size = new System.Drawing.Size(23, 23);
            this.btnShoesList.TabIndex = 12;
            this.btnShoesList.Tag = "0";
            this.btnShoesList.UseVisualStyleBackColor = true;
            this.btnShoesList.Click += new System.EventHandler(this.btnShoesList_Click);
            // 
            // btnShoesSearch
            // 
            this.btnShoesSearch.FlatAppearance.BorderSize = 0;
            this.btnShoesSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoesSearch.Image = global::UMCLocker.Properties.Resources.filter_icon;
            this.btnShoesSearch.Location = new System.Drawing.Point(463, 2);
            this.btnShoesSearch.Name = "btnShoesSearch";
            this.btnShoesSearch.Size = new System.Drawing.Size(23, 23);
            this.btnShoesSearch.TabIndex = 5;
            this.btnShoesSearch.Tag = "0";
            this.btnShoesSearch.UseVisualStyleBackColor = true;
            this.btnShoesSearch.Click += new System.EventHandler(this.btnShoesSearch_Click);
            // 
            // btnDeleteShoes
            // 
            this.btnDeleteShoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteShoes.FlatAppearance.BorderSize = 0;
            this.btnDeleteShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShoes.Image = global::UMCLocker.Properties.Resources.delete_icon;
            this.btnDeleteShoes.Location = new System.Drawing.Point(31, 0);
            this.btnDeleteShoes.Name = "btnDeleteShoes";
            this.btnDeleteShoes.Size = new System.Drawing.Size(31, 29);
            this.btnDeleteShoes.TabIndex = 1;
            this.btnDeleteShoes.UseVisualStyleBackColor = true;
            this.btnDeleteShoes.Click += new System.EventHandler(this.btnDeleteShoes_Click);
            // 
            // btnAddShoes
            // 
            this.btnAddShoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddShoes.FlatAppearance.BorderSize = 0;
            this.btnAddShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShoes.Image = global::UMCLocker.Properties.Resources.add_icon;
            this.btnAddShoes.Location = new System.Drawing.Point(0, 0);
            this.btnAddShoes.Name = "btnAddShoes";
            this.btnAddShoes.Size = new System.Drawing.Size(31, 29);
            this.btnAddShoes.TabIndex = 0;
            this.btnAddShoes.UseVisualStyleBackColor = true;
            this.btnAddShoes.Click += new System.EventHandler(this.btnAddShoes_Click);
            // 
            // btnLockerList
            // 
            this.btnLockerList.FlatAppearance.BorderSize = 0;
            this.btnLockerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockerList.Image = global::UMCLocker.Properties.Resources.list_icon;
            this.btnLockerList.Location = new System.Drawing.Point(531, 1);
            this.btnLockerList.Name = "btnLockerList";
            this.btnLockerList.Size = new System.Drawing.Size(42, 23);
            this.btnLockerList.TabIndex = 11;
            this.btnLockerList.Tag = "0";
            this.btnLockerList.UseVisualStyleBackColor = true;
            this.btnLockerList.Click += new System.EventHandler(this.btnLockerList_Click);
            // 
            // btnLockerSearch
            // 
            this.btnLockerSearch.FlatAppearance.BorderSize = 0;
            this.btnLockerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockerSearch.Image = global::UMCLocker.Properties.Resources.filter_icon;
            this.btnLockerSearch.Location = new System.Drawing.Point(495, 1);
            this.btnLockerSearch.Name = "btnLockerSearch";
            this.btnLockerSearch.Size = new System.Drawing.Size(42, 23);
            this.btnLockerSearch.TabIndex = 7;
            this.btnLockerSearch.Tag = "0";
            this.btnLockerSearch.UseVisualStyleBackColor = true;
            this.btnLockerSearch.Click += new System.EventHandler(this.btnLockerSearch_Click);
            // 
            // btnDeleteLocker
            // 
            this.btnDeleteLocker.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteLocker.FlatAppearance.BorderSize = 0;
            this.btnDeleteLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLocker.Image = global::UMCLocker.Properties.Resources.delete_icon;
            this.btnDeleteLocker.Location = new System.Drawing.Point(31, 0);
            this.btnDeleteLocker.Name = "btnDeleteLocker";
            this.btnDeleteLocker.Size = new System.Drawing.Size(31, 29);
            this.btnDeleteLocker.TabIndex = 1;
            this.btnDeleteLocker.UseVisualStyleBackColor = true;
            this.btnDeleteLocker.Click += new System.EventHandler(this.btnDeleteLocker_Click);
            // 
            // btnAddLocker
            // 
            this.btnAddLocker.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddLocker.FlatAppearance.BorderSize = 0;
            this.btnAddLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocker.Image = global::UMCLocker.Properties.Resources.add_icon;
            this.btnAddLocker.Location = new System.Drawing.Point(0, 0);
            this.btnAddLocker.Name = "btnAddLocker";
            this.btnAddLocker.Size = new System.Drawing.Size(31, 29);
            this.btnAddLocker.TabIndex = 0;
            this.btnAddLocker.UseVisualStyleBackColor = true;
            this.btnAddLocker.Click += new System.EventHandler(this.btnAddLocker_Click);
            // 
            // pbStaffTrash
            // 
            this.pbStaffTrash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStaffTrash.BackColor = System.Drawing.Color.Transparent;
            this.pbStaffTrash.Image = global::UMCLocker.Properties.Resources.loading;
            this.pbStaffTrash.Location = new System.Drawing.Point(605, 277);
            this.pbStaffTrash.Name = "pbStaffTrash";
            this.pbStaffTrash.Size = new System.Drawing.Size(64, 64);
            this.pbStaffTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStaffTrash.TabIndex = 6;
            this.pbStaffTrash.TabStop = false;
            // 
            // btnTrashAll
            // 
            this.btnTrashAll.FlatAppearance.BorderSize = 0;
            this.btnTrashAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrashAll.Image = global::UMCLocker.Properties.Resources.list_icon;
            this.btnTrashAll.Location = new System.Drawing.Point(889, 4);
            this.btnTrashAll.Name = "btnTrashAll";
            this.btnTrashAll.Size = new System.Drawing.Size(42, 23);
            this.btnTrashAll.TabIndex = 13;
            this.btnTrashAll.Tag = "0";
            this.btnTrashAll.UseVisualStyleBackColor = true;
            this.btnTrashAll.Click += new System.EventHandler(this.btnTrashAll_Click);
            // 
            // btnTrashFilter
            // 
            this.btnTrashFilter.FlatAppearance.BorderSize = 0;
            this.btnTrashFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrashFilter.Image = global::UMCLocker.Properties.Resources.filter_icon;
            this.btnTrashFilter.Location = new System.Drawing.Point(853, 4);
            this.btnTrashFilter.Name = "btnTrashFilter";
            this.btnTrashFilter.Size = new System.Drawing.Size(42, 23);
            this.btnTrashFilter.TabIndex = 12;
            this.btnTrashFilter.Tag = "0";
            this.btnTrashFilter.UseVisualStyleBackColor = true;
            this.btnTrashFilter.Click += new System.EventHandler(this.btnTrashFilter_Click);
            // 
            // btnDeleteTrash
            // 
            this.btnDeleteTrash.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteTrash.FlatAppearance.BorderSize = 0;
            this.btnDeleteTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrash.Image = global::UMCLocker.Properties.Resources.delete_icon;
            this.btnDeleteTrash.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteTrash.Name = "btnDeleteTrash";
            this.btnDeleteTrash.Size = new System.Drawing.Size(35, 37);
            this.btnDeleteTrash.TabIndex = 2;
            this.btnDeleteTrash.UseVisualStyleBackColor = true;
            this.btnDeleteTrash.Click += new System.EventHandler(this.btnDeleteTrash_Click);
            // 
            // MainTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1283, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khóa tủ";
            this.Load += new System.EventHandler(this.MainTab_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainTab_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainTab_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabCtrMain.ResumeLayout(false);
            this.tPStaff.ResumeLayout(false);
            this.tPStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStaff)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tPKey.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLocker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvShoes)).EndInit();
            this.tPTrash.ResumeLayout(false);
            this.tPTrash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrash)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tPSetting.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffTrash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabControl TabCtrMain { get { return tabCtrMain; } }
        public DataGridView DgrvStaff { get { return dgrvStaff; } }
        public Button BtnDeleteStaff { get { return btnDeleteStaff; } }
        public Button BtnEditStaff { get { return btnEditStaff; } }
        public TextBox TxbSearchStaff { get { return txbSearchStaff; } }
        public Button BtnShoesSearch { get { return btnShoesSearch; } }
        public ComboBox CbbShoesNumber { get { return cbbShoesNumber; } }
        public Button BtnDeleteShoes { get { return btnDeleteShoes; } }
        public Button BtnDeleteLocker { get { return btnDeleteLocker; } }
        public DataGridView DgrvLocker { get { return dgrvLocker; } }
        public DataGridView DgrvShoes { get { return dgrvShoes; } }
        
        public ComboBox CbbShoesIndex { get { return cbbShoesIndex; } }
        public ComboBox CbbLockerIndex { get { return cbbLockerIndex; } }
        public Button BtnLockerSearch { get { return btnLockerSearch; } }
        private System.ComponentModel.BackgroundWorker bgwStaff;
        private System.ComponentModel.BackgroundWorker bgwLocker;
        public System.ComponentModel.BackgroundWorker BgwLocker { get { return bgwLocker; } }
        private System.ComponentModel.BackgroundWorker bgwShoes;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private ErrorProvider errorProvider1;
        public DataGridView DgrvTrash { get { return dgrvTrash; } }
        private System.ComponentModel.BackgroundWorker bgStaffTrash;
        public TextBox TxbSearchTrash { get { return txbSearchTrash; } }
        public Button BtnDeleteTrash { get { return btnDeleteTrash; } }
        public ComboBox CbbLockerState { get => cbbLockerState; }
        public Label LblAddStaffState { get => lblAddStaffState2; }
        public Label LblImportStaffState { get => lblImportStaffState1; }
        private System.ComponentModel.BackgroundWorker bgwSettingImportStaff;
        private System.ComponentModel.BackgroundWorker bgwSettingAddStaff;
        public TextBox TxbLockerType { get => txbTypeLocker1; }
        public TextBox TxbSoOTrongTuLocker { get => txbSoOTrongTuLocker1; }
        public TextBox TxbLockerTo { get => txbLockerTo1; }
        public TextBox TbLockerFrom { get => tbLockerFrom; }
        public TextBox TxbTypeShoes { get => txbTypeShoes; }
        public TextBox TxbSoOTrongTuShoes { get => txbSoOTrongTuShoes; }
        public TextBox TxbShoesTo { get => txbShoesTo; }
        public TextBox TxbShoesFrom { get => txbShoesFrom; }
        private System.ComponentModel.BackgroundWorker bgwSettingImportKey;
        public Label LblNumberShoes { get => lblNumberShoes; }
        private System.ComponentModel.BackgroundWorker bgwImportQuitWork;
        private TabControl tabCtrMain;
        private TabPage tPStaff;
        private PictureBox pbStaff;
        private DataGridView dgrvStaff;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn staff_code;
        private DataGridViewTextBoxColumn full_name;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn enter_date;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn locker_number;
        private DataGridViewTextBoxColumn locker_index;
        private DataGridViewTextBoxColumn shoes_number;
        private DataGridViewTextBoxColumn shoes_index;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn locker;
        private DataGridViewTextBoxColumn Pos;
        private DataGridViewTextBoxColumn Dept;
        private DataGridViewTextBoxColumn posId;
        private DataGridViewTextBoxColumn info;
        private DataGridViewTextBoxColumn deptId;
        private DataGridViewTextBoxColumn Sho;
        private Panel panel9;
        private Label lblInfo;
        private Panel panel4;
        private Button btnFilterEnterMonth;
        private DateTimePicker dpEnterMonth;
        private Button btnAllStaff;
        private Button btnFilterEnterDate;
        private DateTimePicker dpFilterEnterDate;
        private TextBox txbSearchStaff;
        private Button btnDeleteStaff;
        private Button btnEditStaff;
        private Button btnAddStaff;
        private TabPage tPKey;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Label lblNumberShoes;
        private Button btnShoesList;
        private ComboBox cbbShoesState;
        private ComboBox cbbShoesType;
        private ComboBox cbbShoesIndex;
        private Button btnShoesSearch;
        private ComboBox cbbShoesNumber;
        private Button btnDeleteShoes;
        private Button btnAddShoes;
        private Panel panel6;
        private Label lblNumberLocker;
        private Button btnLockerList;
        private ComboBox cbbLockerState;
        private ComboBox cbbLockerType;
        private Button btnLockerSearch;
        private ComboBox cbbLockerIndex;
        private ComboBox cbbLockerNumber;
        private Button btnDeleteLocker;
        private Button btnAddLocker;
        private Label label2;
        private Label label1;
        private DataGridView dgrvLocker;
        private DataGridView dgrvShoes;
        private TabPage tPTrash;
        private DataGridView dgrvTrash;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn end_date;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private Panel panel10;
        private Button btnTrashAll;
        private Button btnTrashFilter;
        private ComboBox cbbNote;
        private DateTimePicker dpMonth;
        private TextBox txbSearchTrash;
        private Button btnDeleteTrash;
        private TabPage tPSetting;
        private Panel panel11;
        private Panel panel12;
        private Label lblImportQuitWork;
        private Button btnImportQuitWork;
        private Label lblImportKey;
        private Button btnImportKey;
        private Panel panel14;
        private Button btnSettingLockerDelete;
        private Button btnDeleteLockerAll;
        private TextBox txbTypeLocker1;
        private Label label8;
        private TextBox txbSoOTrongTuLocker1;
        private Label label9;
        private TextBox txbLockerTo1;
        private Label label10;
        private TextBox tbLockerFrom;
        private Label label5;
        private Button btnImportLocker1;
        private Panel panel13;
        private Button btnDeleteRangeShoes;
        private Button btnDeleteShoesAll;
        private TextBox txbTypeShoes;
        private Label label18;
        private TextBox txbSoOTrongTuShoes;
        private Label label17;
        private TextBox txbShoesTo;
        private Label label16;
        private TextBox txbShoesFrom;
        private Label label15;
        private Button btnImportShoes1;
        private Label lblAddStaffState2;
        private Button button3;
        private Label lblImportStaffState1;
        private Button button5;
        private TextBox txbLockerType;
        private Label label7;
        private TextBox txbSoOTrongTuLocker;
        private Label label6;
        private TextBox txbLockerTo;
        private Label txbTo;
        private Label label4;
        private Label lblImportShoesState;
        private Button btnImportShoes;
        private Label lblImportLockerState;
        private Label lblAddStaffState;
        private Button btnImportLocker;
        private Button btnAddStaffExcel;
        private Label lblImportStaffState;
        private Button btnImportStaff;
        private PictureBox pbStaffTrash;

        public System.ComponentModel.BackgroundWorker BgwImportQuitWork { get => bgwImportQuitWork; }
        public Button BtnTrashAll { get => btnTrashAll; }
        public Button BtnTrashFilter { get => btnTrashFilter; }
        public ComboBox CbbNote { get => cbbNote; }
        public Button BtnAllStaff { get => btnAllStaff; }
        public Button BtnFilterEnterDate { get => btnFilterEnterDate; }
        public Button BtnFilterEnterMonth { get => btnFilterEnterMonth; }
        public DateTimePicker DpEnterMonth { get => dpEnterMonth; }
        public DateTimePicker DpFilterEnterDate { get => dpFilterEnterDate; }
        public DateTimePicker DpMonth { get => dpMonth; }
        public Label LblImportQuitWork { get => lblImportQuitWork; }
        public Label LblNumberLocker { get => lblNumberLocker; }
        public Label LblImportKey { get => lblImportKey; }
        public System.ComponentModel.BackgroundWorker BgwSettingImportKey { get => bgwSettingImportKey; }
        public System.ComponentModel.BackgroundWorker BgwSettingAddStaff { get => bgwSettingAddStaff; }
        public System.ComponentModel.BackgroundWorker BgwSettingImportStaff { get => bgwSettingImportStaff; }
        public ComboBox CbbShoesState { get => cbbShoesState; }
        public Button BtnLockerList { get => btnLockerList; }
        public System.ComponentModel.BackgroundWorker BgStaffTrash { get { return bgStaffTrash; } }
        public ComboBox CbbLockerType { get { return cbbLockerType; } }

        public ComboBox CbbShoesType { get { return cbbShoesType; } }
        public PictureBox PbStaff { get { return pbStaff; } }
        public PictureBox PbStaffTrash { get { return pbStaffTrash; } }
        public Label LblInfo { get { return lblInfo; } }

        public System.ComponentModel.BackgroundWorker BgwShoes { get { return bgwShoes; } }

        public System.ComponentModel.BackgroundWorker BgwStaff { get { return bgwStaff; } }
        public ComboBox CbbLockerNumber { get { return cbbLockerNumber; } }
    }
}