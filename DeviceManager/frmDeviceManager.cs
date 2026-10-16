
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace DeviceManager
{
    public partial class frmDeviceManager : Form
    {
        private readonly BindingList<Device> devices = new BindingList<Device>();
        private readonly BindingSource bindingSource = new BindingSource();
        private readonly ErrorProvider errorProvider = new ErrorProvider();

        private int nextId = 1;
        private Device? selectedDevice;

        public frmDeviceManager()
        {
            InitializeComponent();

            ConfigureForm();
            ConfigureGrid();
            ConfigureDataBinding();
            ConfigureCategories();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvDevices.SelectionChanged += dgvDevices_SelectionChanged;

            ClearInputs();
        }

        private void ConfigureForm()
        {
            errorProvider.ContainerControl = this;

            dgvDevices.AutoGenerateColumns = false;
            txtDeviceId.ReadOnly = false;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevices.MultiSelect = false;
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtDeviceId.ReadOnly = true;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigureGrid()
        {
            dgvDevices.Columns.Clear();

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDeviceId",
                HeaderText = "Mã thiết bị",
                DataPropertyName = nameof(Device.DeviceId),
                FillWeight = 80
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDeviceName",
                HeaderText = "Tên thiết bị",
                DataPropertyName = nameof(Device.DeviceName),
                FillWeight = 150
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                HeaderText = "Loại thiết bị",
                DataPropertyName = nameof(Device.Category),
                FillWeight = 110
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrice",
                HeaderText = "Đơn giá",
                DataPropertyName = nameof(Device.Price),
                FillWeight = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    FormatProvider = CultureInfo.GetCultureInfo("vi-VN"),
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity",
                HeaderText = "Số lượng tồn",
                DataPropertyName = nameof(Device.Quantity),
                FillWeight = 85
            });
        }

        private void ConfigureDataBinding()
        {
            bindingSource.DataSource = devices;
            dgvDevices.DataSource = bindingSource;
        }

        private void ConfigureCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[]
            {
                "Máy tính",
                "Điện thoại",
                "Máy in",
                "Thiết bị mạng",
                "Phụ kiện",
                "Khác"
            });

            cboCategory.SelectedIndex = -1;
        }

        private bool ValidateInputs()
        {
            errorProvider.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                errorProvider.SetError(txtDeviceName, "Tên thiết bị không được để trống.");
                valid = false;
            }

            if (cboCategory.SelectedIndex < 0)
            {
                errorProvider.SetError(cboCategory, "Vui lòng chọn loại thiết bị.");
                valid = false;
            }

            if (!decimal.TryParse(
                    txtPrice.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out decimal price) || price < 0)
            {
                errorProvider.SetError(txtPrice, "Đơn giá phải là số hợp lệ và không được nhỏ hơn 0.");
                valid = false;
            }

            return valid;
        }

        private bool TryGetPrice(out decimal price)
        {
            return decimal.TryParse(
                txtPrice.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out price);
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            TryGetPrice(out decimal price);

            Device device = new Device
            {
                DeviceId = $"TB{nextId:000}",
                DeviceName = txtDeviceName.Text.Trim(),
                Category = cboCategory.Text,
                Price = price,
                Quantity = (int)numQuantity.Value
            };

            devices.Add(device);
            nextId++;

            ClearInputs();
            MessageBox.Show("Thêm thiết bị thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (selectedDevice == null)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            TryGetPrice(out decimal price);

            selectedDevice.DeviceName = txtDeviceName.Text.Trim();
            selectedDevice.Category = cboCategory.Text;
            selectedDevice.Price = price;
            selectedDevice.Quantity = (int)numQuantity.Value;

            bindingSource.ResetBindings(false);

            MessageBox.Show("Cập nhật thiết bị thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (selectedDevice == null)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thiết bị này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                devices.Remove(selectedDevice);
                ClearInputs();
                MessageBox.Show("Đã xóa thiết bị.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvDevices_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvDevices.CurrentRow?.DataBoundItem is not Device device)
                return;

            selectedDevice = device;
            txtDeviceId.Text = device.DeviceId;
            txtDeviceName.Text = device.DeviceName;
            cboCategory.SelectedItem = device.Category;
            txtPrice.Text = device.Price.ToString(CultureInfo.CurrentCulture);
            numQuantity.Value = Math.Min(
                numQuantity.Maximum,
                Math.Max(numQuantity.Minimum, device.Quantity));
            errorProvider.Clear();
        }

        private void ClearInputs()
        {
            selectedDevice = null;
            dgvDevices.ClearSelection();

            txtDeviceId.Clear();
            txtDeviceName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            numQuantity.Value = 0;

            errorProvider.Clear();
            txtDeviceName.Focus();
        }
    }
}
