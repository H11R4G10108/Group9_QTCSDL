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
    public partial class Form1 : Form
    {
        //Phuong
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2QN68N2L\FWG;Initial Catalog=Swing;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NGUYEN_LIEU";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
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

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            showsubmenu(submenu2);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            showsubmenu(submenu1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Phuong
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Phuong
            int i;
            i = dgv.CurrentRow.Index;
            tb_MaNL.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_TenNL.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_DonVi.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_SoLuong.Text= dgv.Rows[i].Cells[3].Value.ToString();
        }
        private void gunaAdvenceButton15_Click(object sender, EventArgs e)
        {
            //thêm
            command.Connection.CreateCommand();
            command.CommandText = "Insert into NGUYEN_LIEU values('" + tb_MaNL.Text + "',N'" + tb_TenNL.Text + "',N'" + tb_DonVi.Text + "','" + tb_SoLuong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

   

        private void gunaAdvenceButton12_Click(object sender, EventArgs e)
        {
            //sửa
            command.Connection.CreateCommand();
            command.CommandText = "Update NGUYEN_LIEU set TenNL=N'" + tb_TenNL.Text + "',DonVi=N'" + tb_DonVi.Text + "', SoLuong='"+tb_SoLuong.Text +"'where MaNL='"+tb_MaNL.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void gunaAdvenceButton14_Click(object sender, EventArgs e)
        {
            //xóa
            command.Connection.CreateCommand();
            command.CommandText = "delete from NGUYEN_LIEU where MaNL='" + tb_MaNL.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            //thanh search
            

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //nút search
            command = connection.CreateCommand();
            command.CommandText = "select * from NGUYEN_LIEU where TenNL like N'%" + search_bar.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void Nut_reset_Click(object sender, EventArgs e)
        {
            //nút reset
            loaddata();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            //nút món nước
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
        private void NguyenLieu_button_Click(object sender, EventArgs e)
        {

        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            help nl = new help();
            nl.ShowDialog();
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
