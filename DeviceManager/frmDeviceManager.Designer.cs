namespace DeviceManager
{
    partial class frmDeviceManager
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
            grpInput = new GroupBox();
            numQuantity = new NumericUpDown();
            cboCategory = new ComboBox();
            txtPrice = new TextBox();
            txtDeviceName = new TextBox();
            txtDeviceId = new TextBox();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            lblDeviceName = new Label();
            lblDeviceId = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvDevices = new DataGridView();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(numQuantity);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(txtPrice);
            grpInput.Controls.Add(txtDeviceName);
            grpInput.Controls.Add(txtDeviceId);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(lblPrice);
            grpInput.Controls.Add(lblCategory);
            grpInput.Controls.Add(lblDeviceName);
            grpInput.Controls.Add(lblDeviceId);
            grpInput.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(940, 220);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin thiết bị";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(126, 194);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 30);
            numQuantity.TabIndex = 9;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(126, 112);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(157, 31);
            cboCategory.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(126, 152);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 30);
            txtPrice.TabIndex = 7;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new Point(126, 70);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(125, 30);
            txtDeviceName.TabIndex = 6;
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new Point(126, 25);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.ReadOnly = true;
            txtDeviceId.Size = new Size(125, 30);
            txtDeviceId.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(13, 200);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 17);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Số lượng tồn:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(13, 159);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 17);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Đơn giá:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(13, 119);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 17);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Loại thiết bị:";
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceName.Location = new Point(13, 77);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(89, 17);
            lblDeviceName.TabIndex = 1;
            lblDeviceName.Text = "Tên thiết bị:";
            // 
            // lblDeviceId
            // 
            lblDeviceId.AutoSize = true;
            lblDeviceId.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceId.Location = new Point(13, 32);
            lblDeviceId.Name = "lblDeviceId";
            lblDeviceId.Size = new Size(85, 17);
            lblDeviceId.TabIndex = 0;
            lblDeviceId.Text = "Mã thiết bị:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(26, 261);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(267, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(526, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(746, 261);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(153, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Làm mới / Hủy";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvDevices
            // 
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevices.Location = new Point(12, 351);
            dgvDevices.MultiSelect = false;
            dgvDevices.Name = "dgvDevices";
            dgvDevices.ReadOnly = true;
            dgvDevices.RowHeadersWidth = 51;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevices.Size = new Size(940, 188);
            dgvDevices.TabIndex = 5;
            // 
            // frmDeviceManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(dgvDevices);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grpInput);
            Name = "frmDeviceManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục thiết bị điện tử";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private TextBox txtPrice;
        private TextBox txtDeviceName;
        private TextBox txtDeviceId;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblDeviceName;
        private Label lblDeviceId;
        private ComboBox cboCategory;
        private NumericUpDown numQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvDevices;
    }
}