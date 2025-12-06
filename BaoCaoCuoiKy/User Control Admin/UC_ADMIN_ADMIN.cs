using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BaoCaoCuoiKy.User_Control
{
    public partial class UC_ADMIN_ADMIN : UserControl
    {
        public UC_ADMIN_ADMIN()
        {
            InitializeComponent();
        }

        private string MaAD, HoTen, SoDT, MatKhau, functionSave;
        private byte[] _anhBytes; // thêm ảnh như staff
        private Global global = new Global();
        private DataTable dtAdmin = new DataTable();
        private XL_ADMIN xlAdmin = new XL_ADMIN();

        private void UC_ADMIN_ADMIN_Load(object sender, EventArgs e)
        {
            disableButton();
            isEnableTextBox(false);
            resetDataTable();
        }

        private void DgAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_admin.SelectedRows.Count > 0)
            {
                var row = dg_admin.SelectedRows[0];
                string maAD = Convert.ToString(row.Cells["col_ma"].Value);
                string hoTen = Convert.ToString(row.Cells["col_ten"].Value);
                string dt = Convert.ToString(row.Cells["col_dt"].Value);

                try
                {
                    var bytes = GetImageByAdminId(maAD);
                    _anhBytes = bytes;
                    if (bytes != null && bytes.Length > 0)
                    {
                        using (var ms = new MemoryStream(bytes))
                            ImgEmployee.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        ImgEmployee.Image = null;
                    }
                }
                catch
                {
                    ImgEmployee.Image = null;
                    _anhBytes = null;
                }

                textBoxId.Text = maAD;
                textBoxName.Text = hoTen;
                textboxPhone.Text = dt;
                textboxPassword.Text = "";

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btn_save.Enabled = false;
                btnClear.Enabled = false;
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh admin";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImgEmployee.Image = Image.FromFile(ofd.FileName);  // preview
                        _anhBytes = File.ReadAllBytes(ofd.FileName);       // bytes
                    }
                    catch
                    {
                        _anhBytes = null;
                        ImgEmployee.Image = null;
                        global.notify("Không thể đọc ảnh đã chọn");
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            clearData();
            textBoxId.Text = autoIncrementAdminId(getIdAdminLastRow());
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
            functionSave = "insert";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEnableTextBox(true);
            textBoxId.Enabled = false;
            btn_save.Enabled = true;
            btnDelete.Enabled = false;
            btnCreate.Enabled = false;
            btnClear.Enabled = true;
            functionSave = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa admin?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (DeleteAdmin(textBoxId.Text))
                {
                    textBoxId.Text = "";
                    resetDataTable();
                    global.notify("Xóa admin thành công");
                }
                else global.notify("Xóa admin không thành công");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isEmptyInfoAdmin())
            {
                global.notify("Vui lòng nhập đầy đủ các trường");
            }
            else
            {
                switch (functionSave)
                {
                    case "insert":
                        addAdmin();
                        break;
                    case "update":
                        updateAdmin();
                        break;
                }
            }

            isEnableTextBox(false);
            btn_save.Enabled = false;
            btnEdit.Enabled = false;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            textBoxId.Text = "";
            functionSave = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (functionSave == "insert" || functionSave == "update")
            {
                var result = MessageBox.Show("Thông tin chưa được lưu!\nBạn chắc chắn muốn xóa chứ?", "Thông báo",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    btn_save.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCreate.Enabled = true;
                    btnClear.Enabled = false;
                    textBoxId.Text = "";
                    functionSave = "";
                    isEnableTextBox(false);
                    clearData();
                }
            }
        }

        // Thêm admin (kèm ảnh nếu có) giống staff
        private void addAdmin()
        {
            getData();
            using (var con = new SqlConnection(global.pathDatabase))
            using (var cmd = new SqlCommand(
                @"INSERT INTO ADMIN (MaAD, HoTen, SoDT, MatKhau, anh)
                  VALUES (@MaAD, @HoTen, @SoDT, @MatKhau, @anh)", con))
            {
                cmd.Parameters.AddWithValue("@MaAD", MaAD);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@SoDT", SoDT);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                if (_anhBytes == null)
                    cmd.Parameters.AddWithValue("@anh", DBNull.Value);
                else
                    cmd.Parameters.Add("@anh", SqlDbType.VarBinary, _anhBytes.Length).Value = _anhBytes;

                try
                {
                    con.Open();
                    var rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        resetDataTable();
                        global.notify("Thêm admin thành công");
                    }
                    else global.notify("Thêm admin không thành công");
                }
                catch { global.notify("Lỗi khi thêm admin"); }
            }
        }

        // Cập nhật admin (chỉ cập nhật ảnh nếu có _anhBytes) giống staff’s updateImage flag
        private void updateAdmin()
        {
            getData();
            bool updateImage = _anhBytes != null;

            string sql = updateImage
                ? @"UPDATE ADMIN SET HoTen=@HoTen, SoDT=@SoDT, MatKhau=ISNULL(@MatKhau, MatKhau), anh=@anh WHERE MaAD=@MaAD"
                : @"UPDATE ADMIN SET HoTen=@HoTen, SoDT=@SoDT, MatKhau=ISNULL(@MatKhau, MatKhau) WHERE MaAD=@MaAD";

            using (var con = new SqlConnection(global.pathDatabase))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@MaAD", MaAD);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@SoDT", SoDT);
                if (string.IsNullOrWhiteSpace(MatKhau))
                    cmd.Parameters.AddWithValue("@MatKhau", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                if (updateImage)
                {
                    if (_anhBytes == null)
                        cmd.Parameters.AddWithValue("@anh", DBNull.Value);
                    else
                        cmd.Parameters.Add("@anh", SqlDbType.VarBinary, _anhBytes.Length).Value = _anhBytes;
                }

                try
                {
                    con.Open();
                    var rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        resetDataTable();
                        global.notify("Cập nhật thông tin admin thành công");
                    }
                    else global.notify("Cập nhật thông tin admin không thành công");
                }
                catch { global.notify("Lỗi khi cập nhật admin"); }
            }
        }

        private bool DeleteAdmin(string maAD)
        {
            using (var con = new SqlConnection(global.pathDatabase))
            using (var cmd = new SqlCommand("DELETE FROM ADMIN WHERE MaAD = @MaAD", con))
            {
                cmd.Parameters.AddWithValue("@MaAD", maAD);
                try { con.Open(); return cmd.ExecuteNonQuery() > 0; }
                catch { return false; }
            }
        }

        private byte[] GetImageByAdminId(string maAD)
        {
            using (var con = new SqlConnection(global.pathDatabase))
            using (var cmd = new SqlCommand("SELECT anh FROM ADMIN WHERE MaAD=@MaAD", con))
            {
                cmd.Parameters.AddWithValue("@MaAD", maAD);
                con.Open();
                var result = cmd.ExecuteScalar();
                return result == DBNull.Value || result == null ? null : (byte[])result;
            }
        }

        private DataTable getListAdmin()
        {
            using (var con = new SqlConnection(global.pathDatabase))
            using (var cmd = new SqlCommand(@"SELECT MaAD, HoTen, SoDT FROM ADMIN", con))
            using (var adp = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                try { adp.Fill(dt); } catch { }
                return dt;
            }
        }

        private string getIdAdminLastRow()
        {
            using (var con = new SqlConnection(global.pathDatabase))
            using (var cmd = new SqlCommand(@"SELECT TOP 1 MaAD FROM ADMIN ORDER BY MaAD DESC", con))
            {
                try { con.Open(); var id = cmd.ExecuteScalar(); return id == null ? "AD000" : id.ToString(); }
                catch { return "AD000"; }
            }
        }

        private string autoIncrementAdminId(string lastId)
        {
            try { return global.autoIncrementId(lastId); }
            catch
            {
                if (string.IsNullOrEmpty(lastId) || lastId.Length < 2) return "AD001";
                var prefix = lastId.Substring(0, 2);
                int num; if (!int.TryParse(lastId.Substring(2), out num)) num = 0;
                num++; return $"{prefix}{num:000}";
            }
        }

        private bool isEmptyInfoAdmin()
        {
            return string.IsNullOrWhiteSpace(textBoxId.Text)
                || string.IsNullOrWhiteSpace(textBoxName.Text)
                || string.IsNullOrWhiteSpace(textboxPhone.Text)
                || string.IsNullOrWhiteSpace(textboxPassword.Text) && functionSave == "insert";
        }

        private void getData()
        {
            MaAD = textBoxId.Text;
            HoTen = textBoxName.Text;
            SoDT = textboxPhone.Text;
            MatKhau = textboxPassword.Text;
        }

        private void clearData()
        {
            textBoxName.Text = "";
            textboxPhone.Text = "";
            textboxPassword.Text = "";
            ImgEmployee.Image = null; // clear preview
            _anhBytes = null;         // clear bytes
        }

        private void resetDataTable()
        {
            clearData();
            dtAdmin = getListAdmin();
            global.addDataGridView(dtAdmin, dg_admin);
        }

        private void disableButton()
        {
            btn_save.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        private void isEnableTextBox(bool isEnable)
        {   
            textBoxId.Enabled = false;
            textBoxName.Enabled = isEnable;
            textboxPhone.Enabled = isEnable;
            textboxPassword.Enabled = isEnable;
        }
    }
}
