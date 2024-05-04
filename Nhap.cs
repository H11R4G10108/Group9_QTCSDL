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
    public partial class Nhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2QN68N2L\FWG;Initial Catalog=Swing;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHAP_NGUYEN_LIEU";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Nhap()
        {
            InitializeComponent();
        }

        private void Nhap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            // TODO: This line of code loads data into the 'swingDataSet1.NHAP_NGUYEN_LIEU' table. You can move, or remove it, as needed.

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

        private void MuaChiTiet_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuaCT nl = new MuaCT();
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_MaDNH.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_MaNV.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_date.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_TongCong.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void Nut_tim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHAP_NGUYEN_LIEU where MaDNH like '%" + search_bar.Text + "%'";
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
            command.CommandText = "update NHAP_NGUYEN_LIEU set MaNV='" + tb_MaNV.Text + "',NgayNhap='" + tb_date.Value.ToShortDateString() + "',TongCong='" + tb_TongCong.Text + "'where MaDNH='" + tb_MaDNH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Nut_Xoa_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete from NHAP_NGUYEN_LIEU where MaDNH='" + tb_MaDNH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "Insert into NHAP_NGUYEN_LIEU values('" + tb_MaDNH.Text + "','" + tb_MaNV.Text + "','" + tb_date.Value.ToShortDateString() + "','" + tb_TongCong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void tb_date_ValueChanged(object sender, EventArgs e)
        {
            tb_date.CustomFormat = "dd/MM/yyyy";
        }

        private void tb_date_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Back)
            {
                tb_date.CustomFormat=" ";
            }
        }
    }
}
