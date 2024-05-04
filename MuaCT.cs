using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Swing
{
    public partial class MuaCT : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2QN68N2L\FWG;Initial Catalog=Swing;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from MUA_NGUYEN_LIEU_CHI_TIET";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public MuaCT()
        {
            InitializeComponent();
        }

        private void MuaCT_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            // TODO: This line of code loads data into the 'swingDataSet1.MUA_NGUYEN_LIEU_CHI_TIET' table. You can move, or remove it, as needed.

        }

        private void NguyenLieu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 nl = new Form1();
            nl.ShowDialog();
            this.Close();
        }


        private void MonNuoc_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonNuoc nl = new MonNuoc();
            nl.ShowDialog();
            this.Close();
        }

        private void Nhanvien_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nl = new NhanVien();
            nl.ShowDialog();
            this.Close();
        }

        private void QuanLy_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLy nl = new QuanLy();
            nl.ShowDialog();
            this.Close();
        }

        private void Ban_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ban nl = new Ban();
            nl.ShowDialog();
            this.Close();
        }

        private void BanChiTiet_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanCT nl = new BanCT();
            nl.ShowDialog();
            this.Close();
        }

        private void Mua_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mua nl = new Mua();
            nl.ShowDialog();
            this.Close();
        }

        private void Nhap_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhap nl = new Nhap();
            nl.ShowDialog();
            this.Close();
        }

        private void NhapChiTiet_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapCT nl = new NhapCT();
            nl.ShowDialog();
            this.Close();
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            help nl = new help();
            nl.ShowDialog();
            this.Close();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_MaDMH.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_MaNL.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_DonGia.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_SoLuong.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_ThanhTien.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nut_tim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHAN_VIEN where MaDMH like '%" + search_bar.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        private void Nut_reset_Click(object sender, EventArgs e)
        {
            loaddata();

        }

        private void Nut_sua_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "update MUA_NGUYEN_LIEU_CHI_TIET set DonGia='" + tb_DonGia.Text + "',SoLuong='" + tb_SoLuong.Text + "',ThanhTien='" + tb_ThanhTien.Text + "'where MaDMH='" + tb_MaDMH.Text + "'and MaNL='" + tb_MaNL.Text + "'";
            command.ExecuteNonQuery();
            loaddata();

        }

        private void Nut_Xoa_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete from MUA_NGUYEN_LIEU_CHI_TIET where MaDMH='" + tb_MaDMH.Text + "' and MaNL='" + tb_MaNL.Text + "'";
            command.ExecuteNonQuery();
            loaddata();

        }

        private void Nut_them_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "Insert into MUA_NGUYEN_LIEU_CHI_TIET values('" + tb_MaDMH.Text + "','" + tb_MaNL.Text + "','" + tb_DonGia.Text + "','" + tb_SoLuong.Text + "','" + tb_ThanhTien.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            nhaCC nl = new nhaCC();
            nl.ShowDialog();
            this.Close();
        }
    }
}
