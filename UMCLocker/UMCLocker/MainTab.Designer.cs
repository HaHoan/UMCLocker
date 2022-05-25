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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bgwStaff = new System.ComponentModel.BackgroundWorker();
            this.bgwLocker = new System.ComponentModel.BackgroundWorker();
            this.bgwShoes = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabCtrMain = new System.Windows.Forms.TabControl();
            this.tPStaff = new System.Windows.Forms.TabPage();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.dgrvStaff = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enter_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnExportStaff = new System.Windows.Forms.Button();
            this.btnFilterEnterMonth = new System.Windows.Forms.Button();
            this.dpEnterMonth = new System.Windows.Forms.DateTimePicker();
            this.btnAllStaff = new System.Windows.Forms.Button();
            this.btnFilterEnterDate = new System.Windows.Forms.Button();
            this.dpFilterEnterDate = new System.Windows.Forms.DateTimePicker();
            this.txbSearchStaff = new System.Windows.Forms.TextBox();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.tPTrash = new System.Windows.Forms.TabPage();
            this.pbStaffTrash = new System.Windows.Forms.PictureBox();
            this.dgrvTrash = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnEditTrash = new System.Windows.Forms.Button();
            this.btnExportTrash = new System.Windows.Forms.Button();
            this.btnTrashAll = new System.Windows.Forms.Button();
            this.btnTrashFilter = new System.Windows.Forms.Button();
            this.cbbNote = new System.Windows.Forms.ComboBox();
            this.dpMonth = new System.Windows.Forms.DateTimePicker();
            this.txbSearchTrash = new System.Windows.Forms.TextBox();
            this.btnDeleteTrash = new System.Windows.Forms.Button();
            this.tPKey = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteShoes = new System.Windows.Forms.Button();
            this.btnEditShoes = new System.Windows.Forms.Button();
            this.lblNumberShoes = new System.Windows.Forms.Label();
            this.btnShoesList = new System.Windows.Forms.Button();
            this.cbbShoesState = new System.Windows.Forms.ComboBox();
            this.cbbShoesType = new System.Windows.Forms.ComboBox();
            this.cbbShoesIndex = new System.Windows.Forms.ComboBox();
            this.btnShoesSearch = new System.Windows.Forms.Button();
            this.cbbShoesNumber = new System.Windows.Forms.ComboBox();
            this.btnAddShoes = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDeleteLocker = new System.Windows.Forms.Button();
            this.btnEditLocker = new System.Windows.Forms.Button();
            this.lblNumberLocker = new System.Windows.Forms.Label();
            this.btnLockerList = new System.Windows.Forms.Button();
            this.cbbLockerState = new System.Windows.Forms.ComboBox();
            this.cbbLockerType = new System.Windows.Forms.ComboBox();
            this.btnLockerSearch = new System.Windows.Forms.Button();
            this.cbbLockerIndex = new System.Windows.Forms.ComboBox();
            this.cbbLockerNumber = new System.Windows.Forms.ComboBox();
            this.btnAddLocker = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrvLocker = new System.Windows.Forms.DataGridView();
            this.dgrvShoes = new System.Windows.Forms.DataGridView();
            this.tPSetting = new System.Windows.Forms.TabPage();
            this.lblStatusDup = new System.Windows.Forms.Label();
            this.btnFinđuplicateKey = new System.Windows.Forms.Button();
            this.lblStatusAddStaff = new System.Windows.Forms.Label();
            this.btnAddNewStaffFromExcel = new System.Windows.Forms.Button();
            this.tPChart = new System.Windows.Forms.TabPage();
            this.chartShoesNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLockerNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartShoesNu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLockerNu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bgStaffTrash = new System.ComponentModel.BackgroundWorker();
            this.bgwSettingImportStaff = new System.ComponentModel.BackgroundWorker();
            this.bgwSettingAddStaff = new System.ComponentModel.BackgroundWorker();
            this.bgwSettingImportKey = new System.ComponentModel.BackgroundWorker();
            this.bgwImportQuitWork = new System.ComponentModel.BackgroundWorker();
            this.bgwSync = new System.ComponentModel.BackgroundWorker();
            this.bgwSettingFindDup = new System.ComponentModel.BackgroundWorker();
            this.bgwChart = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeBackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonNotTakeBackKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabCtrMain.SuspendLayout();
            this.tPStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStaff)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tPTrash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrash)).BeginInit();
            this.panel10.SuspendLayout();
            this.tPKey.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLocker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvShoes)).BeginInit();
            this.tPSetting.SuspendLayout();
            this.tPChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartShoesNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLockerNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartShoesNu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLockerNu)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.imageList1.Images.SetKeyName(7, "icons8-chart-20.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::UMCLocker.Properties.Resources.icons8_account_48;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(1166, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 43);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1359, 61);
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
            this.panel2.Location = new System.Drawing.Point(0, 744);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabCtrMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1359, 683);
            this.panel3.TabIndex = 2;
            // 
            // tabCtrMain
            // 
            this.tabCtrMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabCtrMain.Controls.Add(this.tPStaff);
            this.tabCtrMain.Controls.Add(this.tPTrash);
            this.tabCtrMain.Controls.Add(this.tPKey);
            this.tabCtrMain.Controls.Add(this.tPSetting);
            this.tabCtrMain.Controls.Add(this.tPChart);
            this.tabCtrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrMain.ImageList = this.imageList1;
            this.tabCtrMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrMain.Name = "tabCtrMain";
            this.tabCtrMain.SelectedIndex = 0;
            this.tabCtrMain.Size = new System.Drawing.Size(1359, 683);
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
            this.tPStaff.Size = new System.Drawing.Size(1351, 653);
            this.tPStaff.TabIndex = 0;
            this.tPStaff.Text = "Quản lý nhân viên";
            this.tPStaff.UseVisualStyleBackColor = true;
            // 
            // pbStaff
            // 
            this.pbStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStaff.BackColor = System.Drawing.Color.Transparent;
            this.pbStaff.Image = global::UMCLocker.Properties.Resources.loading;
            this.pbStaff.Location = new System.Drawing.Point(635, 275);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(64, 64);
            this.pbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStaff.TabIndex = 3;
            this.pbStaff.TabStop = false;
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
            this.CustomerStaff,
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
            this.dgrvStaff.Size = new System.Drawing.Size(1343, 555);
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
            // CustomerStaff
            // 
            this.CustomerStaff.DataPropertyName = "customer";
            this.CustomerStaff.HeaderText = "Khách hàng";
            this.CustomerStaff.Name = "CustomerStaff";
            this.CustomerStaff.ReadOnly = true;
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
            this.panel9.Location = new System.Drawing.Point(3, 595);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1343, 53);
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
            this.panel4.Controls.Add(this.btnSync);
            this.panel4.Controls.Add(this.btnExportStaff);
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
            this.panel4.Size = new System.Drawing.Size(1343, 37);
            this.panel4.TabIndex = 0;
            // 
            // btnSync
            // 
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Image = global::UMCLocker.Properties.Resources.icons8_sync_30;
            this.btnSync.Location = new System.Drawing.Point(1211, 5);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(40, 23);
            this.btnSync.TabIndex = 20;
            this.btnSync.Tag = "0";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnExportStaff
            // 
            this.btnExportStaff.FlatAppearance.BorderSize = 0;
            this.btnExportStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportStaff.Image = global::UMCLocker.Properties.Resources.import_excel1;
            this.btnExportStaff.Location = new System.Drawing.Point(1160, 6);
            this.btnExportStaff.Name = "btnExportStaff";
            this.btnExportStaff.Size = new System.Drawing.Size(45, 23);
            this.btnExportStaff.TabIndex = 19;
            this.btnExportStaff.Tag = "0";
            this.btnExportStaff.UseVisualStyleBackColor = true;
            this.btnExportStaff.Click += new System.EventHandler(this.btnExportStaff_Click);
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
            // dpEnterMonth
            // 
            this.dpEnterMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEnterMonth.Location = new System.Drawing.Point(858, 9);
            this.dpEnterMonth.Name = "dpEnterMonth";
            this.dpEnterMonth.Size = new System.Drawing.Size(200, 20);
            this.dpEnterMonth.TabIndex = 17;
            // 
            // btnAllStaff
            // 
            this.btnAllStaff.FlatAppearance.BorderSize = 0;
            this.btnAllStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllStaff.Image = global::UMCLocker.Properties.Resources.list_icon;
            this.btnAllStaff.Location = new System.Drawing.Point(1112, 6);
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
            // tPTrash
            // 
            this.tPTrash.Controls.Add(this.pbStaffTrash);
            this.tPTrash.Controls.Add(this.dgrvTrash);
            this.tPTrash.Controls.Add(this.panel10);
            this.tPTrash.ImageIndex = 4;
            this.tPTrash.Location = new System.Drawing.Point(4, 26);
            this.tPTrash.Name = "tPTrash";
            this.tPTrash.Padding = new System.Windows.Forms.Padding(3);
            this.tPTrash.Size = new System.Drawing.Size(1351, 653);
            this.tPTrash.TabIndex = 4;
            this.tPTrash.Text = "Danh sách nghỉ việc";
            this.tPTrash.UseVisualStyleBackColor = true;
            // 
            // pbStaffTrash
            // 
            this.pbStaffTrash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStaffTrash.BackColor = System.Drawing.Color.Transparent;
            this.pbStaffTrash.Image = global::UMCLocker.Properties.Resources.loading;
            this.pbStaffTrash.Location = new System.Drawing.Point(643, 294);
            this.pbStaffTrash.Name = "pbStaffTrash";
            this.pbStaffTrash.Size = new System.Drawing.Size(64, 64);
            this.pbStaffTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStaffTrash.TabIndex = 6;
            this.pbStaffTrash.TabStop = false;
            // 
            // dgrvTrash
            // 
            this.dgrvTrash.AllowUserToAddRows = false;
            this.dgrvTrash.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgrvTrash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrvTrash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvTrash.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvTrash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvTrash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrvTrash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgrvTrash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Customer,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.end_date,
            this.TakeBackDate,
            this.note,
            this.ReasonNotTakeBackKey,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvTrash.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrvTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvTrash.Location = new System.Drawing.Point(3, 40);
            this.dgrvTrash.Name = "dgrvTrash";
            this.dgrvTrash.ReadOnly = true;
            this.dgrvTrash.RowHeadersVisible = false;
            this.dgrvTrash.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrvTrash.Size = new System.Drawing.Size(1345, 610);
            this.dgrvTrash.TabIndex = 5;
            this.dgrvTrash.VirtualMode = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnEditTrash);
            this.panel10.Controls.Add(this.btnExportTrash);
            this.panel10.Controls.Add(this.btnTrashAll);
            this.panel10.Controls.Add(this.btnTrashFilter);
            this.panel10.Controls.Add(this.cbbNote);
            this.panel10.Controls.Add(this.dpMonth);
            this.panel10.Controls.Add(this.txbSearchTrash);
            this.panel10.Controls.Add(this.btnDeleteTrash);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1345, 37);
            this.panel10.TabIndex = 4;
            // 
            // btnEditTrash
            // 
            this.btnEditTrash.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditTrash.FlatAppearance.BorderSize = 0;
            this.btnEditTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTrash.Image = global::UMCLocker.Properties.Resources.edit_icon;
            this.btnEditTrash.Location = new System.Drawing.Point(0, 0);
            this.btnEditTrash.Name = "btnEditTrash";
            this.btnEditTrash.Size = new System.Drawing.Size(35, 37);
            this.btnEditTrash.TabIndex = 15;
            this.btnEditTrash.UseVisualStyleBackColor = true;
            this.btnEditTrash.Click += new System.EventHandler(this.btnEditTrash_Click);
            // 
            // btnExportTrash
            // 
            this.btnExportTrash.FlatAppearance.BorderSize = 0;
            this.btnExportTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTrash.Image = global::UMCLocker.Properties.Resources.import_excel;
            this.btnExportTrash.Location = new System.Drawing.Point(1012, 4);
            this.btnExportTrash.Name = "btnExportTrash";
            this.btnExportTrash.Size = new System.Drawing.Size(42, 23);
            this.btnExportTrash.TabIndex = 14;
            this.btnExportTrash.Tag = "0";
            this.btnExportTrash.UseVisualStyleBackColor = true;
            this.btnExportTrash.Click += new System.EventHandler(this.btnExportTrash_Click);
            // 
            // btnTrashAll
            // 
            this.btnTrashAll.FlatAppearance.BorderSize = 0;
            this.btnTrashAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrashAll.Image = global::UMCLocker.Properties.Resources.list_icon;
            this.btnTrashAll.Location = new System.Drawing.Point(949, 4);
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
            this.btnTrashFilter.Location = new System.Drawing.Point(873, 4);
            this.btnTrashFilter.Name = "btnTrashFilter";
            this.btnTrashFilter.Size = new System.Drawing.Size(42, 23);
            this.btnTrashFilter.TabIndex = 12;
            this.btnTrashFilter.Tag = "0";
            this.btnTrashFilter.UseVisualStyleBackColor = true;
            this.btnTrashFilter.Click += new System.EventHandler(this.btnTrashFilter_Click);
            // 
            // cbbNote
            // 
            this.cbbNote.FormattingEnabled = true;
            this.cbbNote.Items.AddRange(new object[] {
            "NV có trả khóa",
            "NV không trả khóa",
            "Đã thu hồi và chưa trả khóa",
            "Khóa không thu hồi được"});
            this.cbbNote.Location = new System.Drawing.Point(732, 7);
            this.cbbNote.Name = "cbbNote";
            this.cbbNote.Size = new System.Drawing.Size(121, 21);
            this.cbbNote.TabIndex = 6;
            // 
            // dpMonth
            // 
            this.dpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpMonth.Location = new System.Drawing.Point(517, 7);
            this.dpMonth.Name = "dpMonth";
            this.dpMonth.Size = new System.Drawing.Size(200, 20);
            this.dpMonth.TabIndex = 5;
            // 
            // txbSearchTrash
            // 
            this.txbSearchTrash.ForeColor = System.Drawing.Color.Gray;
            this.txbSearchTrash.Location = new System.Drawing.Point(79, 8);
            this.txbSearchTrash.Name = "txbSearchTrash";
            this.txbSearchTrash.Size = new System.Drawing.Size(416, 20);
            this.txbSearchTrash.TabIndex = 4;
            this.txbSearchTrash.Text = "Nhập mã nhân viên";
            this.txbSearchTrash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearchTrash_KeyDown);
            // 
            // btnDeleteTrash
            // 
            this.btnDeleteTrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTrash.FlatAppearance.BorderSize = 0;
            this.btnDeleteTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrash.Image = global::UMCLocker.Properties.Resources.delete_icon;
            this.btnDeleteTrash.Location = new System.Drawing.Point(38, 1);
            this.btnDeleteTrash.Name = "btnDeleteTrash";
            this.btnDeleteTrash.Size = new System.Drawing.Size(35, 37);
            this.btnDeleteTrash.TabIndex = 2;
            this.btnDeleteTrash.UseVisualStyleBackColor = true;
            this.btnDeleteTrash.Click += new System.EventHandler(this.btnDeleteTrash_Click);
            // 
            // tPKey
            // 
            this.tPKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPKey.Controls.Add(this.tableLayoutPanel1);
            this.tPKey.ImageIndex = 1;
            this.tPKey.Location = new System.Drawing.Point(4, 26);
            this.tPKey.Name = "tPKey";
            this.tPKey.Padding = new System.Windows.Forms.Padding(3);
            this.tPKey.Size = new System.Drawing.Size(1275, 653);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1267, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteShoes);
            this.panel5.Controls.Add(this.btnEditShoes);
            this.panel5.Controls.Add(this.lblNumberShoes);
            this.panel5.Controls.Add(this.btnShoesList);
            this.panel5.Controls.Add(this.cbbShoesState);
            this.panel5.Controls.Add(this.cbbShoesType);
            this.panel5.Controls.Add(this.cbbShoesIndex);
            this.panel5.Controls.Add(this.btnShoesSearch);
            this.panel5.Controls.Add(this.cbbShoesNumber);
            this.panel5.Controls.Add(this.btnAddShoes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(637, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(626, 29);
            this.panel5.TabIndex = 4;
            // 
            // btnDeleteShoes
            // 
            this.btnDeleteShoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteShoes.FlatAppearance.BorderSize = 0;
            this.btnDeleteShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShoes.Image = global::UMCLocker.Properties.Resources.delete_icon;
            this.btnDeleteShoes.Location = new System.Drawing.Point(66, 0);
            this.btnDeleteShoes.Name = "btnDeleteShoes";
            this.btnDeleteShoes.Size = new System.Drawing.Size(35, 29);
            this.btnDeleteShoes.TabIndex = 15;
            this.btnDeleteShoes.UseVisualStyleBackColor = true;
            this.btnDeleteShoes.Click += new System.EventHandler(this.btnDeleteShoes_Click);
            // 
            // btnEditShoes
            // 
            this.btnEditShoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditShoes.FlatAppearance.BorderSize = 0;
            this.btnEditShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShoes.Image = global::UMCLocker.Properties.Resources.edit_icon;
            this.btnEditShoes.Location = new System.Drawing.Point(31, 0);
            this.btnEditShoes.Name = "btnEditShoes";
            this.btnEditShoes.Size = new System.Drawing.Size(35, 29);
            this.btnEditShoes.TabIndex = 14;
            this.btnEditShoes.UseVisualStyleBackColor = true;
            this.btnEditShoes.Click += new System.EventHandler(this.btnEditShoes_Click);
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
            // btnShoesList
            // 
            this.btnShoesList.FlatAppearance.BorderSize = 0;
            this.btnShoesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoesList.Image = global::UMCLocker.Properties.Resources.list_icon;
            this.btnShoesList.Location = new System.Drawing.Point(521, 2);
            this.btnShoesList.Name = "btnShoesList";
            this.btnShoesList.Size = new System.Drawing.Size(23, 23);
            this.btnShoesList.TabIndex = 12;
            this.btnShoesList.Tag = "0";
            this.btnShoesList.UseVisualStyleBackColor = true;
            this.btnShoesList.Click += new System.EventHandler(this.btnShoesList_Click);
            // 
            // cbbShoesState
            // 
            this.cbbShoesState.FormattingEnabled = true;
            this.cbbShoesState.Items.AddRange(new object[] {
            "AVAIABLE",
            "USED",
            "Cần xử lý"});
            this.cbbShoesState.Location = new System.Drawing.Point(384, 3);
            this.cbbShoesState.Name = "cbbShoesState";
            this.cbbShoesState.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesState.TabIndex = 11;
            this.cbbShoesState.Text = "Trạng thái";
            this.cbbShoesState.SelectedIndexChanged += new System.EventHandler(this.cbbShoesState_SelectedIndexChanged);
            // 
            // cbbShoesType
            // 
            this.cbbShoesType.FormattingEnabled = true;
            this.cbbShoesType.Location = new System.Drawing.Point(290, 4);
            this.cbbShoesType.Name = "cbbShoesType";
            this.cbbShoesType.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesType.TabIndex = 10;
            this.cbbShoesType.Text = "Chọn loại";
            this.cbbShoesType.SelectedIndexChanged += new System.EventHandler(this.cbbShoesType_SelectedIndexChanged);
            // 
            // cbbShoesIndex
            // 
            this.cbbShoesIndex.FormattingEnabled = true;
            this.cbbShoesIndex.Location = new System.Drawing.Point(195, 4);
            this.cbbShoesIndex.Name = "cbbShoesIndex";
            this.cbbShoesIndex.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesIndex.TabIndex = 4;
            this.cbbShoesIndex.Text = "Chọn ô";
            this.cbbShoesIndex.TabIndexChanged += new System.EventHandler(this.cbbShoesIndex_SelectedIndexChanged);
            this.cbbShoesIndex.TextChanged += new System.EventHandler(this.cbbShoesIndex_TextChanged);
            this.cbbShoesIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbShoesIndex_KeyPress);
            // 
            // btnShoesSearch
            // 
            this.btnShoesSearch.FlatAppearance.BorderSize = 0;
            this.btnShoesSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoesSearch.Image = global::UMCLocker.Properties.Resources.filter_icon;
            this.btnShoesSearch.Location = new System.Drawing.Point(478, 2);
            this.btnShoesSearch.Name = "btnShoesSearch";
            this.btnShoesSearch.Size = new System.Drawing.Size(23, 23);
            this.btnShoesSearch.TabIndex = 5;
            this.btnShoesSearch.Tag = "0";
            this.btnShoesSearch.UseVisualStyleBackColor = true;
            this.btnShoesSearch.Click += new System.EventHandler(this.btnShoesSearch_Click);
            // 
            // cbbShoesNumber
            // 
            this.cbbShoesNumber.FormattingEnabled = true;
            this.cbbShoesNumber.Location = new System.Drawing.Point(102, 5);
            this.cbbShoesNumber.Name = "cbbShoesNumber";
            this.cbbShoesNumber.Size = new System.Drawing.Size(88, 21);
            this.cbbShoesNumber.TabIndex = 3;
            this.cbbShoesNumber.Text = "Chọn tủ";
            this.cbbShoesNumber.TabIndexChanged += new System.EventHandler(this.cbbShoesNumber_SelectedIndexChanged);
            this.cbbShoesNumber.TextChanged += new System.EventHandler(this.cbbShoesNumber_TextChanged);
            this.cbbShoesNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbShoesNumber_KeyPress);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDeleteLocker);
            this.panel6.Controls.Add(this.btnEditLocker);
            this.panel6.Controls.Add(this.lblNumberLocker);
            this.panel6.Controls.Add(this.btnLockerList);
            this.panel6.Controls.Add(this.cbbLockerState);
            this.panel6.Controls.Add(this.cbbLockerType);
            this.panel6.Controls.Add(this.btnLockerSearch);
            this.panel6.Controls.Add(this.cbbLockerIndex);
            this.panel6.Controls.Add(this.cbbLockerNumber);
            this.panel6.Controls.Add(this.btnAddLocker);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(4, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(626, 29);
            this.panel6.TabIndex = 3;
            // 
            // btnDeleteLocker
            // 
            this.btnDeleteLocker.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteLocker.FlatAppearance.BorderSize = 0;
            this.btnDeleteLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLocker.Image = global::UMCLocker.Properties.Resources.delete_icon;
            this.btnDeleteLocker.Location = new System.Drawing.Point(66, 0);
            this.btnDeleteLocker.Name = "btnDeleteLocker";
            this.btnDeleteLocker.Size = new System.Drawing.Size(35, 29);
            this.btnDeleteLocker.TabIndex = 14;
            this.btnDeleteLocker.UseVisualStyleBackColor = true;
            this.btnDeleteLocker.Click += new System.EventHandler(this.btnDeleteLocker_Click);
            // 
            // btnEditLocker
            // 
            this.btnEditLocker.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditLocker.FlatAppearance.BorderSize = 0;
            this.btnEditLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLocker.Image = global::UMCLocker.Properties.Resources.edit_icon;
            this.btnEditLocker.Location = new System.Drawing.Point(31, 0);
            this.btnEditLocker.Name = "btnEditLocker";
            this.btnEditLocker.Size = new System.Drawing.Size(35, 29);
            this.btnEditLocker.TabIndex = 13;
            this.btnEditLocker.UseVisualStyleBackColor = true;
            this.btnEditLocker.Click += new System.EventHandler(this.btnEditLocker_Click);
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
            // cbbLockerState
            // 
            this.cbbLockerState.FormattingEnabled = true;
            this.cbbLockerState.Items.AddRange(new object[] {
            "AVAIABLE",
            "USED",
            "Cần xử lý"});
            this.cbbLockerState.Location = new System.Drawing.Point(405, 2);
            this.cbbLockerState.Name = "cbbLockerState";
            this.cbbLockerState.Size = new System.Drawing.Size(88, 21);
            this.cbbLockerState.TabIndex = 10;
            this.cbbLockerState.Text = "Trạng thái";
            this.cbbLockerState.SelectedIndexChanged += new System.EventHandler(this.cbbLockerState_SelectedIndexChanged);
            // 
            // cbbLockerType
            // 
            this.cbbLockerType.FormattingEnabled = true;
            this.cbbLockerType.Location = new System.Drawing.Point(310, 2);
            this.cbbLockerType.Name = "cbbLockerType";
            this.cbbLockerType.Size = new System.Drawing.Size(88, 21);
            this.cbbLockerType.TabIndex = 9;
            this.cbbLockerType.Text = "Chọn loại";
            this.cbbLockerType.SelectedIndexChanged += new System.EventHandler(this.cbbLockerType_SelectedIndexChanged);
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
            // cbbLockerIndex
            // 
            this.cbbLockerIndex.FormattingEnabled = true;
            this.cbbLockerIndex.Location = new System.Drawing.Point(211, 3);
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
            this.cbbLockerNumber.Location = new System.Drawing.Point(113, 2);
            this.cbbLockerNumber.Name = "cbbLockerNumber";
            this.cbbLockerNumber.Size = new System.Drawing.Size(88, 21);
            this.cbbLockerNumber.TabIndex = 3;
            this.cbbLockerNumber.Text = "Chọn tủ";
            this.cbbLockerNumber.TabIndexChanged += new System.EventHandler(this.cbbLockerNumber_SelectedIndexChanged);
            this.cbbLockerNumber.TextChanged += new System.EventHandler(this.cbbLockerNumber_TextChanged);
            this.cbbLockerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLockerNumber_KeyPress);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrvLocker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrvLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvLocker.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvLocker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvLocker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrvLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvLocker.Location = new System.Drawing.Point(4, 61);
            this.dgrvLocker.Name = "dgrvLocker";
            this.dgrvLocker.ReadOnly = true;
            this.dgrvLocker.RowHeadersVisible = false;
            this.dgrvLocker.Size = new System.Drawing.Size(626, 580);
            this.dgrvLocker.TabIndex = 5;
            this.dgrvLocker.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvLocker_CellMouseDoubleClick);
            // 
            // dgrvShoes
            // 
            this.dgrvShoes.AllowUserToAddRows = false;
            this.dgrvShoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrvShoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgrvShoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvShoes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrvShoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvShoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgrvShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvShoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvShoes.Location = new System.Drawing.Point(637, 61);
            this.dgrvShoes.Name = "dgrvShoes";
            this.dgrvShoes.ReadOnly = true;
            this.dgrvShoes.RowHeadersVisible = false;
            this.dgrvShoes.Size = new System.Drawing.Size(626, 580);
            this.dgrvShoes.TabIndex = 6;
            this.dgrvShoes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvShoes_CellMouseDoubleClick);
            // 
            // tPSetting
            // 
            this.tPSetting.Controls.Add(this.lblStatusDup);
            this.tPSetting.Controls.Add(this.btnFinđuplicateKey);
            this.tPSetting.Controls.Add(this.lblStatusAddStaff);
            this.tPSetting.Controls.Add(this.btnAddNewStaffFromExcel);
            this.tPSetting.ImageIndex = 5;
            this.tPSetting.Location = new System.Drawing.Point(4, 26);
            this.tPSetting.Name = "tPSetting";
            this.tPSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tPSetting.Size = new System.Drawing.Size(1275, 653);
            this.tPSetting.TabIndex = 5;
            this.tPSetting.Text = "Cài đặt";
            this.tPSetting.UseVisualStyleBackColor = true;
            // 
            // lblStatusDup
            // 
            this.lblStatusDup.AutoSize = true;
            this.lblStatusDup.Location = new System.Drawing.Point(257, 122);
            this.lblStatusDup.Name = "lblStatusDup";
            this.lblStatusDup.Size = new System.Drawing.Size(33, 13);
            this.lblStatusDup.TabIndex = 4;
            this.lblStatusDup.Text = "None";
            // 
            // btnFinđuplicateKey
            // 
            this.btnFinđuplicateKey.Location = new System.Drawing.Point(38, 117);
            this.btnFinđuplicateKey.Name = "btnFinđuplicateKey";
            this.btnFinđuplicateKey.Size = new System.Drawing.Size(166, 23);
            this.btnFinđuplicateKey.TabIndex = 3;
            this.btnFinđuplicateKey.Text = "Tìm nhân viên trùng khóa";
            this.btnFinđuplicateKey.UseVisualStyleBackColor = true;
            this.btnFinđuplicateKey.Click += new System.EventHandler(this.btnFinđuplicateKey_Click);
            // 
            // lblStatusAddStaff
            // 
            this.lblStatusAddStaff.AutoSize = true;
            this.lblStatusAddStaff.Location = new System.Drawing.Point(231, 48);
            this.lblStatusAddStaff.Name = "lblStatusAddStaff";
            this.lblStatusAddStaff.Size = new System.Drawing.Size(33, 13);
            this.lblStatusAddStaff.TabIndex = 2;
            this.lblStatusAddStaff.Text = "None";
            // 
            // btnAddNewStaffFromExcel
            // 
            this.btnAddNewStaffFromExcel.Location = new System.Drawing.Point(38, 44);
            this.btnAddNewStaffFromExcel.Name = "btnAddNewStaffFromExcel";
            this.btnAddNewStaffFromExcel.Size = new System.Drawing.Size(166, 23);
            this.btnAddNewStaffFromExcel.TabIndex = 0;
            this.btnAddNewStaffFromExcel.Text = "Nhập nhân viên mới";
            this.btnAddNewStaffFromExcel.UseVisualStyleBackColor = true;
            this.btnAddNewStaffFromExcel.Click += new System.EventHandler(this.btnAddNewStaffFromExcel_Click);
            // 
            // tPChart
            // 
            this.tPChart.Controls.Add(this.chartShoesNam);
            this.tPChart.Controls.Add(this.chartLockerNam);
            this.tPChart.Controls.Add(this.chartShoesNu);
            this.tPChart.Controls.Add(this.chartLockerNu);
            this.tPChart.Controls.Add(this.tableLayoutPanel2);
            this.tPChart.ImageIndex = 7;
            this.tPChart.Location = new System.Drawing.Point(4, 26);
            this.tPChart.Name = "tPChart";
            this.tPChart.Size = new System.Drawing.Size(1275, 653);
            this.tPChart.TabIndex = 6;
            this.tPChart.Text = "Biểu đồ";
            this.tPChart.UseVisualStyleBackColor = true;
            // 
            // chartShoesNam
            // 
            chartArea1.Name = "ChartArea1";
            this.chartShoesNam.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartShoesNam.Legends.Add(legend1);
            this.chartShoesNam.Location = new System.Drawing.Point(691, 346);
            this.chartShoesNam.Name = "chartShoesNam";
            this.chartShoesNam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartShoesNam.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Locker";
            this.chartShoesNam.Series.Add(series1);
            this.chartShoesNam.Size = new System.Drawing.Size(531, 300);
            this.chartShoesNam.TabIndex = 4;
            this.chartShoesNam.Text = "chart2";
            title1.Name = "Tủ Locker nữ";
            this.chartShoesNam.Titles.Add(title1);
            // 
            // chartLockerNam
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLockerNam.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLockerNam.Legends.Add(legend2);
            this.chartLockerNam.Location = new System.Drawing.Point(691, 36);
            this.chartLockerNam.Name = "chartLockerNam";
            this.chartLockerNam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartLockerNam.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "Locker";
            this.chartLockerNam.Series.Add(series2);
            this.chartLockerNam.Size = new System.Drawing.Size(531, 300);
            this.chartLockerNam.TabIndex = 3;
            this.chartLockerNam.Text = "chart3";
            title2.Name = "Tủ Locker nữ";
            this.chartLockerNam.Titles.Add(title2);
            // 
            // chartShoesNu
            // 
            chartArea3.Name = "ChartArea1";
            this.chartShoesNu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartShoesNu.Legends.Add(legend3);
            this.chartShoesNu.Location = new System.Drawing.Point(20, 344);
            this.chartShoesNu.Name = "chartShoesNu";
            this.chartShoesNu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartShoesNu.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsVisibleInLegend = false;
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series3.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series3.Legend = "Legend1";
            series3.Name = "Locker";
            this.chartShoesNu.Series.Add(series3);
            this.chartShoesNu.Size = new System.Drawing.Size(531, 300);
            this.chartShoesNu.TabIndex = 2;
            this.chartShoesNu.Text = "chart1";
            title3.Name = "Tủ Locker nữ";
            this.chartShoesNu.Titles.Add(title3);
            // 
            // chartLockerNu
            // 
            chartArea4.Name = "ChartArea1";
            this.chartLockerNu.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartLockerNu.Legends.Add(legend4);
            this.chartLockerNu.Location = new System.Drawing.Point(20, 34);
            this.chartLockerNu.Name = "chartLockerNu";
            this.chartLockerNu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartLockerNu.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsVisibleInLegend = false;
            series4.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series4.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "Locker";
            this.chartLockerNu.Series.Add(series4);
            this.chartLockerNu.Size = new System.Drawing.Size(531, 300);
            this.chartLockerNu.TabIndex = 1;
            this.chartLockerNu.Text = "chartLockerNu";
            title4.Name = "Tủ Locker nữ";
            this.chartLockerNu.Titles.Add(title4);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1275, 653);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(631, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "TỦ NAM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(631, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "TỦ NỮ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bgwSync
            // 
            this.bgwSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSync_DoWork);
            this.bgwSync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSync_RunWorkerCompleted);
            // 
            // bgwSettingFindDup
            // 
            this.bgwSettingFindDup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSettingFindDup_DoWork);
            // 
            // bgwChart
            // 
            this.bgwChart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwChart_DoWork);
            this.bgwChart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwChart_RunWorkerCompleted);
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
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "staff_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhân viên ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 113;
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
            // Customer
            // 
            this.Customer.DataPropertyName = "customer";
            this.Customer.HeaderText = "Khách hàng";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
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
            this.end_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "Ngày kết thúc";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            this.end_date.Width = 112;
            // 
            // TakeBackDate
            // 
            this.TakeBackDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TakeBackDate.DataPropertyName = "take_back_date";
            this.TakeBackDate.HeaderText = "Ngày thu hồi";
            this.TakeBackDate.Name = "TakeBackDate";
            this.TakeBackDate.ReadOnly = true;
            this.TakeBackDate.Width = 104;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Ghi chú";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // ReasonNotTakeBackKey
            // 
            this.ReasonNotTakeBackKey.DataPropertyName = "reason_change_key";
            this.ReasonNotTakeBackKey.HeaderText = "Remark";
            this.ReasonNotTakeBackKey.Name = "ReasonNotTakeBackKey";
            this.ReasonNotTakeBackKey.ReadOnly = true;
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
            // MainTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1359, 754);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStaff)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tPTrash.ResumeLayout(false);
            this.tPTrash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrash)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tPKey.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLocker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvShoes)).EndInit();
            this.tPSetting.ResumeLayout(false);
            this.tPSetting.PerformLayout();
            this.tPChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartShoesNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLockerNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartShoesNu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLockerNu)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        public Button BtnEditTrash { get { return btnEditTrash; } }
        public ComboBox CbbLockerState { get => cbbLockerState; }
        private System.ComponentModel.BackgroundWorker bgwSettingImportStaff;
        private System.ComponentModel.BackgroundWorker bgwSettingAddStaff;
       
        private System.ComponentModel.BackgroundWorker bgwSettingImportKey;
        public Label LblNumberShoes { get => lblNumberShoes; }
        private System.ComponentModel.BackgroundWorker bgwImportQuitWork;
        private TabControl tabCtrMain;
        private TabPage tPStaff;
        private PictureBox pbStaff;
        private DataGridView dgrvStaff;
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
        private Button btnAddShoes;
        private Panel panel6;
        private Label lblNumberLocker;
        private Button btnLockerList;
        private ComboBox cbbLockerState;
        private ComboBox cbbLockerType;
        private Button btnLockerSearch;
        private ComboBox cbbLockerIndex;
        private ComboBox cbbLockerNumber;
        private Button btnAddLocker;
        private Label label2;
        private Label label1;
        private DataGridView dgrvLocker;
        private DataGridView dgrvShoes;
        private TabPage tPTrash;
        private DataGridView dgrvTrash;
        private Panel panel10;
        private Button btnTrashAll;
        private Button btnTrashFilter;
        private ComboBox cbbNote;
        private DateTimePicker dpMonth;
        private TextBox txbSearchTrash;
        private Button btnDeleteTrash;
        private TabPage tPSetting;
        private PictureBox pbStaffTrash;
        private Button btnExportStaff;
        private Button btnExportTrash;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn staff_code;
        private DataGridViewTextBoxColumn full_name;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn enter_date;
        private DataGridViewTextBoxColumn CustomerStaff;
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
        private Button btnSync;
        private System.ComponentModel.BackgroundWorker bgwSync;
        private Button btnEditStaff;
        private Button btnEditTrash;
        private Button btnLogin;
        private Button btnAddNewStaffFromExcel;
        private Label lblStatusAddStaff;
        private Button btnDeleteShoes;
        private Button btnEditShoes;
        private Button btnDeleteLocker;
        private Button btnEditLocker;
        private Button btnFinđuplicateKey;
        private System.ComponentModel.BackgroundWorker bgwSettingFindDup;
        private Label lblStatusDup;
        private TabPage tPChart;
        private System.ComponentModel.BackgroundWorker bgwChart;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLockerNu;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartShoesNam;
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartShoesNam { get => chartShoesNam; }
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLockerNam;
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartLockerNam { get => chartLockerNam; }
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShoesNu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn end_date;
        private DataGridViewTextBoxColumn TakeBackDate;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn ReasonNotTakeBackKey;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

        public System.Windows.Forms.DataVisualization.Charting.Chart ChartShoesNu { get => chartShoesNu; }
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartLockerNu { get => chartLockerNu; }
        public System.ComponentModel.BackgroundWorker BgwChart { get => bgwChart; }
        public System.ComponentModel.BackgroundWorker BgwSettingFindDup { get => bgwSettingFindDup; }
        public Label LblStatusAddStaff { get => lblStatusAddStaff; }
        public System.ComponentModel.BackgroundWorker BgwSync  { get => bgwSync; }

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
        public Label LblNumberLocker { get => lblNumberLocker; }
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