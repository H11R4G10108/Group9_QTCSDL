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
    public partial class MonNuoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2QN68N2L\FWG;Initial Catalog=Swing;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from MON_NUOC";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public MonNuoc()
        {
            InitializeComponent();
            cus();
        }
        private void cus()
        {
            submenu2.Visible = false;
            submenu1.Visible = false;
        }
        private void hideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;
        }
        private void showsubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            showsubmenu(submenu1);
        }

        private void HD_button_Click(object sender, EventArgs e)
        {
            showsubmenu(submenu2);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void MonNuoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_MaMon.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_TenMon.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_DonGia.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void gunaAdvenceButton14_Click(object sender, EventArgs e)
        {
            //xóa
            command.Connection.CreateCommand();
            command.CommandText = "delete from MON_NUOC where MaMon='" + tb_MaMon.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void nut_sua_Click(object sender, EventArgs e)
        {
            //sửa
            command.Connection.CreateCommand();
            command.CommandText = "update MON_NUOC set TenMon=N'" + tb_TenMon.Text + "',DonGia='" + tb_DonGia.Text + "'where MaMon='" + tb_MaMon.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void gunaAdvenceButton15_Click(object sender, EventArgs e)
        {
            //them dl
            command.Connection.CreateCommand();
            command.CommandText = "Insert into MON_NUOC values('" + tb_MaMon.Text + "',N'" + tb_TenMon.Text + "','" + tb_DonGia.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void nut_tim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from MON_NUOC where TenMon like N'%" + search_bar.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void nut_reset_Click(object sender, EventArgs e)
        {
            loaddata();
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

        private void nhaCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            nhaCC nl = new nhaCC();
            nl.ShowDialog();
            this.Close();
        }
    }
}
