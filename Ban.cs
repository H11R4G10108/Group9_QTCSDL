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
    public partial class Ban : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2QN68N2L\FWG;Initial Catalog=Swing;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public Ban()
        {
            InitializeComponent();
        }

        private void Ban_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void NguyenLieu_button_Click_1(object sender, EventArgs e)
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

        private void exit_Click(object sender, EventArgs e)
        {
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
            tb_MaDB.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_MaNV.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_SoCT.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_NgayCT.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_TongCong.Text= dgv.Rows[i].Cells[4].Value.ToString();
        }
        private void Nut_tim_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BAN where MaDB like '%" + search_bar.Text + "%'";
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
            command.CommandText = "update BAN set MaNV='" + tb_MaNV.Text + "', SoCT='" + tb_SoCT.Text + "',NgayCT='" + tb_NgayCT.Value.ToShortDateString() + "',TongCong='" + tb_TongCong.Text + "'where MaDB='" + tb_MaDB.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Nut_Xoa_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete from BAN where MaDB='" + tb_MaDB.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void nut_them_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "Insert into BAN values('" + tb_MaDB.Text + "','" + tb_MaNV.Text + "','" + tb_SoCT.Text + "','" + tb_NgayCT.Value.ToShortDateString() + "','"+ tb_TongCong.Text +"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void tb_NgayCT_ValueChanged(object sender, EventArgs e)
        {
            tb_NgayCT.CustomFormat = "dd/MM/yyyy";
        }

        private void tb_NgayCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                tb_NgayCT.CustomFormat = " ";
            }
        }
    }
}
