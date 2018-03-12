using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BaiTapThemXoaSua
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-66H7CRL\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True";
        private int id = -1;

        public Form1()
        {
            InitializeComponent();
           // layDuLieu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.ChiTietHoaDonBan' table. You can move, or remove it, as needed.
            //this.chiTietHoaDonBanTableAdapter.Fill(this.quanLyNhaHangDataSet.ChiTietHoaDonBan);
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.ChiTietHoaDonNhap' table. You can move, or remove it, as needed.
            //this.chiTietHoaDonNhapTableAdapter.Fill(this.quanLyNhaHangDataSet.ChiTietHoaDonNhap);
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.quanLyNhaHangDataSet.NhanVien);
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.NguyenLieu' table. You can move, or remove it, as needed.
            //this.nguyenLieuTableAdapter.Fill(this.quanLyNhaHangDataSet.NguyenLieu);
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.HoaDonThanhToan' table. You can move, or remove it, as needed.
            //this.hoaDonThanhToanTableAdapter.Fill(this.quanLyNhaHangDataSet.HoaDonThanhToan);
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.quanLyNhaHangDataSet.KhachHang);
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.LoaiMonAn' table. You can move, or remove it, as needed.
            //this.loaiMonAnTableAdapter.Fill(this.quanLyNhaHangDataSet.LoaiMonAn);
            //// TODO: This line of code loads data into the 'quanLyNhaHangDataSet.Menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter.Fill(this.quanLyNhaHangDataSet.Menu);
            layDuLieu();
            layDuLieuNL();
            layDuLieuLoaiMonAn();
            layDuLieuMeNu();
            layDuLieuKH();
            layDuLieuChiTietHoaDonNhap();
            layDuLieuNV();
            layDuLieuChiTietHoaDonBan();
            layDuLieuHDN();
            layDuLieuHDTT();
        }
        private void layDuLieu()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectBan";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsBan = new DataSet();
                adapter.Fill(dsBan);

                dgvBan.DataSource = dsBan.Tables[0];

                dgvBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        private void layDuLieuKH()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectKhachHang";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsKhachHang = new DataSet();
                adapter.Fill(dsKhachHang);

                dgvKhachHang.DataSource = dsKhachHang.Tables[0];

                dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void layDuLieuHDTT()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectHoaDonThanhToan";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsHDTT = new DataSet();
                adapter.Fill(dsHDTT);

                dgvHDTT.DataSource = dsHDTT.Tables[0];

                dgvHDTT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvHDTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        private void layDuLieuHDN()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectHoaDonNhapHang";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsHDN = new DataSet();
                adapter.Fill(dsHDN);

                dgvHoaDonNhapHang.DataSource = dsHDN.Tables[0];

                dgvHoaDonNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvHoaDonNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void layDuLieuChiTietHoaDonBan()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectChiTietHoaDonBan";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsChiTietHoaDonBan = new DataSet();
                adapter.Fill(dsChiTietHoaDonBan);

                dgvChiTietHoaDonBan.DataSource = dsChiTietHoaDonBan.Tables[0];

                dgvChiTietHoaDonBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvChiTietHoaDonBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void layDuLieuNV()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectNhanVien";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsNhanVien = new DataSet();
                adapter.Fill(dsNhanVien);

                dgvNhanVien.DataSource = dsNhanVien.Tables[0];

                dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void layDuLieuChiTietHoaDonNhap()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectChiTietHoaDonNhap";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsChiTietHoaDonNhap = new DataSet();
                adapter.Fill(dsChiTietHoaDonNhap);

                dgvcthdn.DataSource = dsChiTietHoaDonNhap.Tables[0];

                dgvcthdn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvcthdn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void layDuLieuMeNu()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectMeNu";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsMeNu = new DataSet();
                adapter.Fill(dsMeNu);

                dgvMeNu.DataSource = dsMeNu.Tables[0];

                dgvMeNu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvMeNu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void layDuLieuLoaiMonAn()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectLoaiMonAn";
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsLoaiMonAn = new DataSet();
                adapter.Fill(dsLoaiMonAn);

                dgvloaimonan.DataSource = dsLoaiMonAn.Tables[0];

                dgvloaimonan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvloaimonan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void layDuLieuNL()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "SelectNguyenLieu";
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dsNguyenLieu = new DataSet();
                adapter.Fill(dsNguyenLieu);

                dgvNL.DataSource = dsNguyenLieu.Tables[0];

                dgvNL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvNL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connectionString);

            //try
            //{
            //    conn.Open();
            //    SqlCommand command = new SqlCommand();
            //    command.CommandText = "DELETEBan";
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("@maban", txtmaban.Text);
            //    // command.Parameters.AddWithValue("@tenkh", txtTen.Text);
            //    //command.Parameters.AddWithValue("@makh", txtmakh.Text);
            //    command.Connection = conn;
            //    command.ExecuteNonQuery();
            //    layDuLieu();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            //}
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            }

        private void btnnhaplai_Click_1(object sender, EventArgs e)
        {
          
           
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvBan_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btndocdulieukh_Click(object sender, EventArgs e)
        {
            //layDuLieuKH();
        }

    

        private void btnThemKh_Click(object sender, EventArgs e)
        {
          
        }

        private void btnXoaKh_Click(object sender, EventArgs e)
        {
        }

        private void btnSuaKh_Click(object sender, EventArgs e)
        {

        }

        private void btnnhaplaiKh_Click(object sender, EventArgs e)
        {

        }

        private void txttimkiemkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void btnDocDuLieu_Click_1(object sender, EventArgs e)
        {
            //layDuLieu();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           // layDuLieu();
        }

       

        private void btnthemloaimonan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemLoaiMonAn  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maloaimonan", txtmaloaimonan.Text);
                    command.Parameters.AddWithValue("@tenmonan", txttenloaimonan.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongialoaimonan.Text);
                    command.Parameters.AddWithValue("@chitiet", txtchitietloaimonan.Text);
                    command.ExecuteNonQuery();

                    layDuLieuLoaiMonAn();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnsualoaimonan_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITLoaiMonAn", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maloaimonan", txtmaloaimonan.Text);
                    command.Parameters.AddWithValue("@tenmonan", txttenloaimonan.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongialoaimonan.Text);
                    command.Parameters.AddWithValue("@chitiet", txtchitietloaimonan.Text);
                    command.ExecuteNonQuery();
                    layDuLieuLoaiMonAn();
                    MessageBox.Show("Update thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Update");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnxoaloaimonan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Loai Mon An  ?" + txtmaloaimonan.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETELoaiMonAn";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maloaimonan", txtmaloaimonan.Text);
                    // command.Parameters.AddWithValue("@tenkh", txtTen.Text);
                    //command.Parameters.AddWithValue("@makh", txtmakh.Text);
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuLoaiMonAn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvloaimonan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaloaimonan.Text = dgvloaimonan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenloaimonan.Text = dgvloaimonan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdongialoaimonan.Text = dgvloaimonan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtchitietloaimonan.Text = dgvloaimonan.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

      

        private void btnThemMeNu_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemMeNu  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mamonan", txtmamonan.Text);
                    command.Parameters.AddWithValue("@tenmonan", txttenmonan.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongiamenu.Text);
                    command.Parameters.AddWithValue("@maloaimonan", comboBox1.SelectedValue.ToString());
                    command.ExecuteNonQuery();

                    layDuLieuMeNu();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnSuaMeNu_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITMeNu", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mamonan", txtmamonan.Text);
                    command.Parameters.AddWithValue("@tenmonan", txttenmonan.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongiamenu.Text);
                    command.Parameters.AddWithValue("@maloaimonan", comboBox1.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    layDuLieuMeNu();
                    MessageBox.Show("Update thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Update");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnXoaMeNu_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa MeNu  ?" + txtmaloaimonan.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETEMeNu";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mamonan", txtmamonan.Text);
                
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuMeNu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void dgvMeNu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmamonan.Text = dgvMeNu.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenmonan.Text = dgvMeNu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdongiamenu.Text = dgvMeNu.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.SelectedValue = dgvMeNu.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnThemKH_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemKhachHang  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@makh", txtmakh.Text);
                    command.Parameters.AddWithValue("@tenkh", txttenkh.Text);
                    command.Parameters.AddWithValue("@sotien", txtsotienkh.Text);
                    command.Parameters.AddWithValue("@mathanhtoan",comboboxmaKH.SelectedValue.ToString() );
                    command.ExecuteNonQuery();

                    layDuLieuKH();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvKhachHang_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenkh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsotienkh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboboxmaKH.SelectedValue = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnSuaKH_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITKhachHang", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@makh", txtmakh.Text);
                    command.Parameters.AddWithValue("@tenkh", txttenkh.Text);
                    command.Parameters.AddWithValue("@sotien", txtsotienkh.Text);
                    command.Parameters.AddWithValue("@mathanhtoan", comboboxmaKH.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    layDuLieuKH();
                    MessageBox.Show("Update thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Update");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaKH_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Khach Hang "+ txtmakh.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETEKhachHang";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@makh", txtmakh.Text);

                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuKH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnthemcthdn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(" ThemChiTietHoaDonNhap", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahdnhap", txtmacthdnhap.Text);
                    command.Parameters.AddWithValue("@soluong", txtsoluongcthdn.Text);
                    command.Parameters.AddWithValue("@dongian", txtdongiacthdn.Text);
                    command.Parameters.AddWithValue("@manl", comboboxmanlcthdn.SelectedValue.ToString());
                    command.ExecuteNonQuery();

                    layDuLieuChiTietHoaDonNhap();
                    MessageBox.Show("Thêm Thành Công");
                }
               catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvcthdn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmacthdnhap.Text = dgvcthdn.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtsoluongcthdn.Text = dgvcthdn.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdongiacthdn.Text = dgvcthdn.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboboxmanlcthdn.SelectedValue = dgvcthdn.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnsuacthdn_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITChiTietHoaDonNhap", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahdnhap", txtmacthdnhap.Text);
                    command.Parameters.AddWithValue("@soluong", txtsoluongcthdn.Text);
                    command.Parameters.AddWithValue("@dongian", txtdongiacthdn.Text);
                    command.Parameters.AddWithValue("@manl", comboboxmanlcthdn.SelectedValue.ToString());
                    command.ExecuteNonQuery();
                    layDuLieuChiTietHoaDonNhap();
                    MessageBox.Show("Update thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Update");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btncthdn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiet hoa don nhap " + txtmacthdnhap.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETEChiTietHoaDonNhap";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahdnhap", txtmacthdnhap.Text);

                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuChiTietHoaDonNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemNhanVien  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@manv", txtmanv.Text);
                    command.Parameters.AddWithValue("@tennv", txttennv.Text);
                    command.Parameters.AddWithValue("@gioitinh", comboboxgioitinh.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@scmt", txtscmt.Text);
                    command.Parameters.AddWithValue("@ngaylamviec", txtngaylamviec.Text);
                    command.Parameters.AddWithValue("@ngaynghi", txtngaynghi.Text);
                    command.Parameters.AddWithValue("@trangthai", txtTrangThai.Text);
                    command.ExecuteNonQuery();

                    layDuLieuNV();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnSuaNhanvien_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITNhanVien", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@manv", txtmanv.Text);
                    command.Parameters.AddWithValue("@tennv", txttennv.Text);
                    command.Parameters.AddWithValue("@gioitinh", comboboxgioitinh.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@scmt", txtscmt.Text);
                    command.Parameters.AddWithValue("@ngaylamviec", txtngaylamviec.Text);
                    command.Parameters.AddWithValue("@ngaynghi", txtngaynghi.Text);
                    command.Parameters.AddWithValue("@trangthai", txtTrangThai.Text);
                    command.ExecuteNonQuery();
                    layDuLieuNV();
                    MessageBox.Show("Update thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Update");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttennv.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboboxgioitinh.SelectedValue = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtscmt.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtngaylamviec.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtngaynghi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTrangThai.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhan vien " + txtmanv.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETENhanVien";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@manv",txtmanv.Text);

                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuNV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnthemcthdb_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemChiTietHoaDonBan  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahdban", txtmacthdban.Text);
                    command.Parameters.AddWithValue("@tenhd", txttencthdban.Text);
                    command.Parameters.AddWithValue("@dongia", txtcthdb.Text);
                    command.Parameters.AddWithValue("@ngaynhap", dateTimePicker2.Text);
                    command.Parameters.AddWithValue("@manv", cmbmanvcthdb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@mamonan", cmbmamonancthdb.SelectedValue.ToString());
                 
                    command.ExecuteNonQuery();

                    layDuLieuChiTietHoaDonBan();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvChiTietHoaDonBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmacthdban.Text = dgvChiTietHoaDonBan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttencthdban.Text = dgvChiTietHoaDonBan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcthdb.Text = dgvChiTietHoaDonBan.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker2.Value = DateTime.Parse(dgvChiTietHoaDonBan.Rows[e.RowIndex].Cells[3].Value.ToString());
            cmbmanvcthdb.SelectedValue = dgvChiTietHoaDonBan.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbmamonancthdb.SelectedValue = dgvChiTietHoaDonBan.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btnXoacthdb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiet hoa don ban " + txtmacthdban.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETEChiTietHoaDonBan";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahdban", txtmacthdban.Text);

                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuChiTietHoaDonBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnSuacthdb_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITChiTietHoaDonBan  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahdban", txtmacthdban.Text);
                    command.Parameters.AddWithValue("@tenhd", txttencthdban.Text);
                    command.Parameters.AddWithValue("@dongia", txtcthdb.Text);
                    command.Parameters.AddWithValue("@ngaynhap", dateTimePicker2.Text);
                    command.Parameters.AddWithValue("@manv", cmbmanvcthdb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@mamonan", cmbmamonancthdb.SelectedValue.ToString());

                    command.ExecuteNonQuery();

                    layDuLieuChiTietHoaDonBan();
                    MessageBox.Show("UPDATE Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Not Update!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemHoaDonNhap  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahd", txtmahdn.Text);
                    command.Parameters.AddWithValue("@tenhd", txttenhdn.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongiahdn.Text);
                    command.Parameters.AddWithValue("@ngaynhap", dateTimePicker3.Text);
                    command.Parameters.AddWithValue("@manv", cmbmanvhdn.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@mahdnhap", cmbmahdnhap.SelectedValue.ToString());

                    command.ExecuteNonQuery();

                    layDuLieuHDN();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvHoaDonNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahdn.Text = dgvHoaDonNhapHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenhdn.Text = dgvHoaDonNhapHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdongiahdn.Text = dgvHoaDonNhapHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker3.Value = DateTime.Parse(dgvHoaDonNhapHang.Rows[e.RowIndex].Cells[3].Value.ToString());
            cmbmanvhdn.SelectedValue = dgvHoaDonNhapHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbmahdnhap.SelectedValue = dgvHoaDonNhapHang.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btnSuaHDN_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITHoaDonNhap  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahd", txtmahdn.Text);
                    command.Parameters.AddWithValue("@tenhd", txttenhdn.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongiahdn.Text);
                    command.Parameters.AddWithValue("@ngaynhap", dateTimePicker3.Text);
                    command.Parameters.AddWithValue("@manv", cmbmanvhdn.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@mahdnhap", cmbmahdnhap.SelectedValue.ToString());

                    command.ExecuteNonQuery();

                    layDuLieuHDN();
                    MessageBox.Show("Update Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnXoaHDN_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hoa don nhap " + txtmacthdban.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETEHoaDonNhap";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mahd", txtmahdn.Text);

                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuHDN();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnThemHDTT_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemHoaDonThanhToan  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mathanhtoan", txtmathanhtoan.Text);
                    command.Parameters.AddWithValue("@tenkh", cmbtenKhHDTT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@tongtien", txtTongTienHDTT.Text);
                    command.Parameters.AddWithValue("@mahdban", cmbMaHDBHDTT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@manv", cmbMaNVHDTT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@maban", cmbMaBanHDTT.SelectedValue.ToString());

                    command.ExecuteNonQuery();

                    layDuLieuHDTT();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvHDTT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmathanhtoan.Text = dgvHDTT.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbtenKhHDTT.SelectedValue = dgvHDTT.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTongTienHDTT.Text = dgvHDTT.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbMaHDBHDTT.SelectedValue = dgvHDTT.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbMaNVHDTT.SelectedValue = dgvHDTT.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbMaBanHDTT.SelectedValue = dgvHDTT.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnSuaHDTT_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITHoaDonThanhToan  ", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mathanhtoan", txtmathanhtoan.Text);
                    command.Parameters.AddWithValue("@tenkh", cmbtenKhHDTT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@tongtien", txtTongTienHDTT.Text);
                    command.Parameters.AddWithValue("@mahdban", cmbMaHDBHDTT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@manv", cmbMaNVHDTT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@maban", cmbMaBanHDTT.SelectedValue.ToString());

                    command.ExecuteNonQuery();

                    layDuLieuHDTT();
                    MessageBox.Show("Update Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnXoaHDTT_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Hoa Don Thanh Toan " + txtmathanhtoan.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETEHoaDonThanhToan";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mathanhtoan", txtmathanhtoan.Text);

                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuHDTT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaban.Text = dgvBan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dgvBan.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgvNL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanl.Text = dgvNL.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttennl.Text = dgvNL.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdongia.Text = dgvNL.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemNguyenLieu", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@manl", txtmanl.Text);
                    command.Parameters.AddWithValue("@tennl", txttennl.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongia.Text);
                    command.ExecuteNonQuery();

                    layDuLieuNL();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemBan", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maban", txtmaban.Text);
                    command.Parameters.AddWithValue("@tenban", txtTen.Text);

                    command.ExecuteNonQuery();

                    layDuLieu();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR!");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "DELETEBan";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maban", txtmaban.Text);
                // command.Parameters.AddWithValue("@tenkh", txtTen.Text);
                //command.Parameters.AddWithValue("@makh", txtmakh.Text);
                command.Connection = conn;
                command.ExecuteNonQuery();
                layDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn sửa Bàn  ?" + txtmaban.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("EDITBan", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@maban", txtmaban.Text);
                        command.Parameters.AddWithValue("@tenban", txtTen.Text);

                        command.ExecuteNonQuery();
                        layDuLieu();
                        MessageBox.Show("Sửa Thành Công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không sửa được");
                    }
                    finally
                    {
                        if (conn != null && conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void btnnhaplaiBan_Click(object sender, EventArgs e)
        {
            txtmaban.Clear();
            txtTen.Clear();
        }

        private void btnXoaNl_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Nguyen Lieu  ?" + txtmanl.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {

                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETENguyenLieu";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@manl", txtmanl.Text);
                    // command.Parameters.AddWithValue("@tenkh", txtTen.Text);
                    //command.Parameters.AddWithValue("@makh", txtmakh.Text);
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    layDuLieuNL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnSuaNL_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("EDITNguyenLieu", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@manl", txtmanl.Text);
                    command.Parameters.AddWithValue("@tennl", txttennl.Text);
                    command.Parameters.AddWithValue("@dongia", txtdongia.Text);
                    command.ExecuteNonQuery();
                    layDuLieuNL();
                    MessageBox.Show("Update thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Update");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnnhaplaiNL_Click(object sender, EventArgs e)
        {

            txtmanl.Clear();
            txttennl.Clear();
            txtdongia.Clear();
        }

        private void txtTimKiemBan_TextChanged(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Ban WHERE TenBan like @tenban", conn);
                    //SqlCommand command = new SqlCommand("SELECTBan", conn);
                    command.Parameters.AddWithValue("@tenban", "%" + txtTimKiemBan.Text + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dsBan = new DataSet();
                    adapter.Fill(dsBan);
                    dgvBan.DataSource = dsBan.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txttimkiemnl_TextChanged(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM NguyenLieu WHERE TenNL like @tennl", conn);
                    command.Parameters.AddWithValue("@tennl", "%" + txttimkiemnl.Text + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dsNL = new DataSet();
                    adapter.Fill(dsNL);
                    dgvNL.DataSource = dsNL.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}