using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    internal class XL_STAFF
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;

        public XL_STAFF()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }

        public string getNameStaff(string maNV)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT HoTenNV FROM NHANVIEN WHERE MaNV = @MaNV";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", maNV);

                        object result = command.ExecuteScalar();
                        return result == null ? "" : result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return "";
            }
        }

        public DataTable getListStaff()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // Lấy đầy đủ cột (bao gồm Anh). Bạn có thể đổi sang các cột cụ thể nếu cần.
                string query = "SELECT * FROM NHANVIEN";
                using (adapter = new SqlDataAdapter(query, connection))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public string getIdStaffLastRow()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // SQL Server chuẩn: FETCH NEXT 1 ROW ONLY
                string selectCommand = "SELECT MaNV FROM NHANVIEN ORDER BY MaNV DESC OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY;";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    object result = command.ExecuteScalar();
                    return result == null ? "" : result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public int getCountSumStaff()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT COUNT(*) FROM NHANVIEN";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool ExistsStaff(string MaNV)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = @MaNV";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", MaNV);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Insert không kèm ảnh (Anh = NULL)
        public bool AddStaff(string MaNV, string TenNV, string DienThoai, string GioiTinh, string ChucVu, string DiaChi, DateTime NgaySinh, DateTime NgayVaoLam)
        {
            return AddStaff(MaNV, TenNV, DienThoai, GioiTinh, ChucVu, DiaChi, NgaySinh, NgayVaoLam, null);
        }

        // Insert có thể kèm ảnh (byte[] Anh). Nếu null -> lưu NULL
        public bool AddStaff(string MaNV, string TenNV, string DienThoai, string GioiTinh, string ChucVu, string DiaChi, DateTime NgaySinh, DateTime NgayVaoLam, byte[] Anh)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string insertCommand =
                    "INSERT INTO NHANVIEN (MaNV, HoTenNV, DienThoai, GioiTinh, NgaySinh, ChucVu, DiaChi, NgayVaoLam, Anh) " +
                    "VALUES (@MaNV, @TenNV, @DienThoai, @GioiTinh, @NgaySinh, @ChucVu, @DiaChi, @NgayVaoLam, @Anh)";

                using (SqlCommand command = new SqlCommand(insertCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", MaNV);
                    command.Parameters.AddWithValue("@TenNV", TenNV);
                    command.Parameters.AddWithValue("@DienThoai", DienThoai);
                    command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    command.Parameters.AddWithValue("@ChucVu", ChucVu);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@NgayVaoLam", NgayVaoLam);
                    if (Anh == null)
                        command.Parameters.AddWithValue("@Anh", DBNull.Value);
                    else
                        command.Parameters.Add("@Anh", SqlDbType.VarBinary, Anh.Length).Value = Anh;

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public bool DeleteStaff(string MaNV)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string deleteCommand = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV";
                using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", MaNV);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public byte[] GetImageByStaffId(string maNV)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT Anh FROM NHANVIEN WHERE MaNV=@MaNV", connection))
            {
                command.Parameters.AddWithValue("@MaNV", maNV);
                connection.Open();
                var result = command.ExecuteScalar();
                return result == DBNull.Value || result == null ? null : (byte[])result;
            }
        }

        // Chỉ cập nhật ảnh theo MaNV
        public bool UpdateStaffImage(string MaNV, byte[] Anh)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand("UPDATE NHANVIEN SET Anh = @Anh WHERE MaNV = @MaNV", connection))
                {
                    command.Parameters.AddWithValue("@MaNV", MaNV);
                    if (Anh == null)
                        command.Parameters.AddWithValue("@Anh", DBNull.Value);
                    else
                        command.Parameters.Add("@Anh", SqlDbType.VarBinary, Anh.Length).Value = Anh;

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        // Update không kèm ảnh (giữ ảnh hiện tại)
        public bool UpdateStaff(string MaNV, string TenNV, string DienThoai, string GioiTinh, string ChucVu, string DiaChi, DateTime NgaySinh, DateTime NgayVaoLam)
        {
            return UpdateStaff(MaNV, TenNV, DienThoai, GioiTinh, ChucVu, DiaChi, NgaySinh, NgayVaoLam, null, false);
        }

        // Update có thể kèm ảnh. Nếu updateImage = true thì cập nhật cột Anh, ngược lại giữ nguyên.
        public bool UpdateStaff(string MaNV, string TenNV, string DienThoai, string GioiTinh, string ChucVu, string DiaChi, DateTime NgaySinh, DateTime NgayVaoLam, byte[] Anh, bool updateImage)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string updateCommandBase =
                    "UPDATE NHANVIEN SET " +
                    "HoTenNV = @TenNV, " +
                    "DienThoai = @DienThoai, " +
                    "GioiTinh = @GioiTinh, " +
                    "NgaySinh = @NgaySinh, " +
                    "ChucVu = @ChucVu, " +
                    "DiaChi = @DiaChi, " +
                    "NgayVaoLam = @NgayVaoLam";

                string updateCommand = updateImage
                    ? updateCommandBase + ", Anh = @Anh WHERE MaNV = @MaNV"
                    : updateCommandBase + " WHERE MaNV = @MaNV";

                using (SqlCommand command = new SqlCommand(updateCommand, connection))
                {
                    command.Parameters.AddWithValue("@TenNV", TenNV);
                    command.Parameters.AddWithValue("@DienThoai", DienThoai);
                    command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    command.Parameters.AddWithValue("@ChucVu", ChucVu);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@NgayVaoLam", NgayVaoLam);
                    command.Parameters.AddWithValue("@MaNV", MaNV);

                    if (updateImage)
                    {
                        if (Anh == null)
                            command.Parameters.AddWithValue("@Anh", DBNull.Value);
                        else
                            command.Parameters.Add("@Anh", SqlDbType.VarBinary, Anh.Length).Value = Anh;
                    }

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
