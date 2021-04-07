namespace UMCLocker
{
    partial class UserNewForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFullNameError = new System.Windows.Forms.Label();
            this.lblStaffCodeError = new System.Windows.Forms.Label();
            this.dtpEnterDate = new System.Windows.Forms.DateTimePicker();
            this.cbbShoesIndex = new System.Windows.Forms.ComboBox();
            this.cbbShoesNumber = new System.Windows.Forms.ComboBox();
            this.cbbLockerIndex = new System.Windows.Forms.ComboBox();
            this.cbbLockerNumber = new System.Windows.Forms.ComboBox();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbStaffCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSaveStaff);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(764, 469);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thêm nhân viên mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveStaff.FlatAppearance.BorderSize = 0;
            this.btnSaveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStaff.Image = global::UMCLocker.Properties.Resources.sav_icon;
            this.btnSaveStaff.Location = new System.Drawing.Point(694, 10);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(58, 39);
            this.btnSaveStaff.TabIndex = 23;
            this.btnSaveStaff.UseVisualStyleBackColor = true;
            this.btnSaveStaff.Click += new System.EventHandler(this.btnSaveStaff_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblFullNameError);
            this.panel3.Controls.Add(this.lblStaffCodeError);
            this.panel3.Controls.Add(this.dtpEnterDate);
            this.panel3.Controls.Add(this.cbbShoesIndex);
            this.panel3.Controls.Add(this.cbbShoesNumber);
            this.panel3.Controls.Add(this.cbbLockerIndex);
            this.panel3.Controls.Add(this.cbbLockerNumber);
            this.panel3.Controls.Add(this.cbbPosition);
            this.panel3.Controls.Add(this.cbbDepartment);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txbStaffCode);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txbFullName);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.rbtnMale);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.rbtnFemale);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 408);
            this.panel3.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(530, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "( * )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(530, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "( * )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(262, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "( * )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(262, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "( * )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số ô";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số tủ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Số ô";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số tủ";
            // 
            // lblFullNameError
            // 
            this.lblFullNameError.AutoSize = true;
            this.lblFullNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameError.ForeColor = System.Drawing.Color.Black;
            this.lblFullNameError.Location = new System.Drawing.Point(606, 82);
            this.lblFullNameError.Name = "lblFullNameError";
            this.lblFullNameError.Size = new System.Drawing.Size(27, 16);
            this.lblFullNameError.TabIndex = 27;
            this.lblFullNameError.Text = "( * )";
            // 
            // lblStaffCodeError
            // 
            this.lblStaffCodeError.AutoSize = true;
            this.lblStaffCodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffCodeError.ForeColor = System.Drawing.Color.Black;
            this.lblStaffCodeError.Location = new System.Drawing.Point(606, 47);
            this.lblStaffCodeError.Name = "lblStaffCodeError";
            this.lblStaffCodeError.Size = new System.Drawing.Size(27, 16);
            this.lblStaffCodeError.TabIndex = 26;
            this.lblStaffCodeError.Text = "( * )";
            // 
            // dtpEnterDate
            // 
            this.dtpEnterDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEnterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnterDate.Location = new System.Drawing.Point(107, 167);
            this.dtpEnterDate.Name = "dtpEnterDate";
            this.dtpEnterDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEnterDate.TabIndex = 8;
            // 
            // cbbShoesIndex
            // 
            this.cbbShoesIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbShoesIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbShoesIndex.FormattingEnabled = true;
            this.cbbShoesIndex.Location = new System.Drawing.Point(403, 361);
            this.cbbShoesIndex.Name = "cbbShoesIndex";
            this.cbbShoesIndex.Size = new System.Drawing.Size(121, 21);
            this.cbbShoesIndex.TabIndex = 3;
            this.cbbShoesIndex.SelectedIndexChanged += new System.EventHandler(this.cbbShoesIndex_SelectedIndexChanged);
            this.cbbShoesIndex.TextChanged += new System.EventHandler(this.cbbShoesIndex_TextChanged);
            this.cbbShoesIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbShoesIndex_KeyPress);
            // 
            // cbbShoesNumber
            // 
            this.cbbShoesNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbShoesNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbShoesNumber.FormattingEnabled = true;
            this.cbbShoesNumber.Location = new System.Drawing.Point(135, 361);
            this.cbbShoesNumber.Name = "cbbShoesNumber";
            this.cbbShoesNumber.Size = new System.Drawing.Size(121, 21);
            this.cbbShoesNumber.TabIndex = 2;
            this.cbbShoesNumber.SelectedIndexChanged += new System.EventHandler(this.cbbShoesNumber_SelectedIndexChanged);
            this.cbbShoesNumber.TextChanged += new System.EventHandler(this.cbbShoesNumber_TextChanged);
            this.cbbShoesNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbShoesNumber_KeyPress);
            // 
            // cbbLockerIndex
            // 
            this.cbbLockerIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLockerIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLockerIndex.FormattingEnabled = true;
            this.cbbLockerIndex.Location = new System.Drawing.Point(403, 317);
            this.cbbLockerIndex.Name = "cbbLockerIndex";
            this.cbbLockerIndex.Size = new System.Drawing.Size(121, 21);
            this.cbbLockerIndex.TabIndex = 1;
            this.cbbLockerIndex.SelectedIndexChanged += new System.EventHandler(this.cbbLockerIndex_SelectedIndexChanged);
            this.cbbLockerIndex.TextChanged += new System.EventHandler(this.cbbLockerIndex_TextChanged);
            this.cbbLockerIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLockerIndex_KeyPress);
            // 
            // cbbLockerNumber
            // 
            this.cbbLockerNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLockerNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLockerNumber.FormattingEnabled = true;
            this.cbbLockerNumber.Location = new System.Drawing.Point(135, 318);
            this.cbbLockerNumber.Name = "cbbLockerNumber";
            this.cbbLockerNumber.Size = new System.Drawing.Size(121, 21);
            this.cbbLockerNumber.TabIndex = 0;
            this.cbbLockerNumber.SelectedIndexChanged += new System.EventHandler(this.cbbLockerNumber_SelectedIndexChanged);
            this.cbbLockerNumber.TextChanged += new System.EventHandler(this.cbbLockerNumber_TextChanged);
            this.cbbLockerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLockerNumber_KeyPress);
            // 
            // cbbPosition
            // 
            this.cbbPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Location = new System.Drawing.Point(100, 263);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(424, 21);
            this.cbbPosition.TabIndex = 10;
            this.cbbPosition.SelectedIndexChanged += new System.EventHandler(this.cbbPosition_SelectedIndexChanged);
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(100, 214);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(424, 21);
            this.cbbDepartment.TabIndex = 9;
            this.cbbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbbDepartment_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nhân viên";
            // 
            // txbStaffCode
            // 
            this.txbStaffCode.Location = new System.Drawing.Point(107, 43);
            this.txbStaffCode.Name = "txbStaffCode";
            this.txbStaffCode.Size = new System.Drawing.Size(493, 20);
            this.txbStaffCode.TabIndex = 4;
            this.txbStaffCode.TextChanged += new System.EventHandler(this.txbStaffCode_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Họ tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tủ giày";
            // 
            // txbFullName
            // 
            this.txbFullName.Location = new System.Drawing.Point(107, 81);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(493, 20);
            this.txbFullName.TabIndex = 5;
            this.txbFullName.TextChanged += new System.EventHandler(this.txbFullName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Giới tính";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(107, 125);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(47, 17);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Nam";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tủ Locker";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(211, 125);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(39, 17);
            this.rbtnFemale.TabIndex = 7;
            this.rbtnFemale.Text = "Nữ";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "Ngày vào";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Vị trí";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 9;
            this.label16.Text = "Phòng ban";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::UMCLocker.Properties.Resources.find_icon;
            this.button2.Location = new System.Drawing.Point(596, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.Name = "UserNewForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserNewForm_FormClosing);
            this.Load += new System.EventHandler(this.UserNewForm_Load);
            this.Shown += new System.EventHandler(this.UserNewForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNewForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserNewForm_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbStaffCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbShoesIndex;
        private System.Windows.Forms.ComboBox cbbShoesNumber;
        private System.Windows.Forms.ComboBox cbbLockerIndex;
        private System.Windows.Forms.ComboBox cbbLockerNumber;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.DateTimePicker dtpEnterDate;
        private System.Windows.Forms.Label lblFullNameError;
        private System.Windows.Forms.Label lblStaffCodeError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}