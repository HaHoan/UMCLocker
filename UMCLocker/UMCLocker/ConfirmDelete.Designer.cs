namespace UMCLocker
{
    partial class ConfirmDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDelete));
            this.lblConfirm = new System.Windows.Forms.Label();
            this.rbReturnKey = new System.Windows.Forms.RadioButton();
            this.rbNotReturnKey = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(13, 13);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(198, 13);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "Nhân viên này đã trả khóa chưa?";
            // 
            // rbReturnKey
            // 
            this.rbReturnKey.AutoSize = true;
            this.rbReturnKey.Checked = true;
            this.rbReturnKey.Location = new System.Drawing.Point(21, 44);
            this.rbReturnKey.Name = "rbReturnKey";
            this.rbReturnKey.Size = new System.Drawing.Size(55, 17);
            this.rbReturnKey.TabIndex = 1;
            this.rbReturnKey.TabStop = true;
            this.rbReturnKey.Text = "Trả rồi";
            this.rbReturnKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbReturnKey.UseVisualStyleBackColor = true;
            // 
            // rbNotReturnKey
            // 
            this.rbNotReturnKey.AutoSize = true;
            this.rbNotReturnKey.Location = new System.Drawing.Point(147, 44);
            this.rbNotReturnKey.Name = "rbNotReturnKey";
            this.rbNotReturnKey.Size = new System.Drawing.Size(65, 17);
            this.rbNotReturnKey.TabIndex = 2;
            this.rbNotReturnKey.Text = "Chưa trả";
            this.rbNotReturnKey.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(107, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(91, 86);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "End Date";
            // 
            // ConfirmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbNotReturnKey);
            this.Controls.Add(this.rbReturnKey);
            this.Controls.Add(this.lblConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.RadioButton rbReturnKey;
        private System.Windows.Forms.RadioButton rbNotReturnKey;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
    }
}