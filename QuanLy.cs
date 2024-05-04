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
    public partial class QuanLy : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2QN68N2L\FWG;Initial Catalog=Swing;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from QUAN_LY";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public QuanLy()
        {
            InitializeComponent();
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_MaQL.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_TenQL.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_DiaChiQuan.Text = dgv.Rows[i].Cells[2].Value.ToString();

        }

        private void Nut_tim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from QUAN_LY where TenQL like N'%" + search_bar.Text + "%'";
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
            command.CommandText = "update QUAN_LY set TenQL=N'" + tb_TenQL.Text + "',DiaChi=N'" + tb_DiaChiQuan.Text + "'where MaQL='" + tb_MaQL.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Nut_Xoa_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete from QUAN_LY where MaQL='" + tb_MaQL.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "Insert into QUAN_LY values(N'" + tb_MaQL.Text + "',N'" + tb_TenQL.Text + "',N'" + tb_DiaChiQuan.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void HD_button_Click(object sender, EventArgs e)
        {

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
