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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection str = new SqlConnection(@"Data Source=LAPTOP-2QN68N2L\FWG;Initial Catalog=Swing;Integrated Security=True");

        private void gunaAdvenceButton15_Click(object sender, EventArgs e)
        {
            string usename, ppass;
            int kt = 0;
            usename = username.Text;
            ppass = pass.Text;
            for (int i = 0; i < usename.Length; ++i)
            {
                if (usename[i] == '~' || usename[i] == '`' || usename[i] == '!' || usename[i] == '@' || usename[i] == '#' || usename[i] == '$' || usename[i] == '%' || usename[i] == '^' || usename[i] == '&' || usename[i] == '*' || usename[i] == '(' || usename[i] == ')' || usename[i] == '_' || usename[i] == '-' || usename[i] == '+' || usename[i] == '=' || usename[i] == '~' || usename[i] == '{' || usename[i] == '[' || usename[i] == ']' || usename[i] == '}' || usename[i] == '|' || usename[i] == ':' || usename[i] == ';' || usename[i] == ':' || usename[i] == '"' || usename[i] == '<' || usename[i] == '>' || usename[i] == ',' || usename[i] == '.' || usename[i] == '/' || usename[i] == '?')
                // \.'
                {
                    kt = 1;
                }
            }
            for (int i=0;i<ppass.Length;++i)
            {
                if (ppass[i] == '~' || ppass[i] == '`' || ppass[i] == '!' || ppass[i] == '@' || ppass[i] == '#' || ppass[i] == '$' || ppass[i] == '%' || ppass[i] == '^' || ppass[i] == '&' || ppass[i] == '*' || ppass[i] == '(' || ppass[i] == ')' || ppass[i] == '_' || ppass[i] == '-' || ppass[i] == '+' || ppass[i] == '=' || ppass[i] == '~' || ppass[i] == '{' || ppass[i] == '[' || ppass[i] == ']' || ppass[i] == '}' || ppass[i] == '|' || ppass[i] == ':' || ppass[i] == ';' || ppass[i] == ':' || ppass[i] == '"' || ppass[i] == '<' || ppass[i] == '>' || ppass[i] == ',' || ppass[i] == '.' || ppass[i] == '/' || ppass[i] == '?')
                {
                    kt = 1;
                }
            }
            if (kt == 0)
            {
                
                string querry = "select * from DANG_NHAP where Usename='" + username.Text + "'and pass=CONVERT(varchar(10),HASHBYTES('SHA2_256','" + pass.Text + "'),1)";
                SqlDataAdapter sda = new SqlDataAdapter(querry, str);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)

                {
                    usename = username.Text;
                    ppass = pass.Text;
                    //chuyenform
                    this.Hide();
                    Form1 nl = new Form1();
                    nl.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }

            }
            else
            {
                MessageBox.Show("Không sử dụng ký tự đặc biệt!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }  
}

