using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernClinic
{
    public partial class Login : Form
    {
       
       
        public Login()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
          
        {
            SqlConnection conn = new SqlConnection(DataConnection.connectionString);
            try
            {
                conn.Open();
                string tk = txtUsername.Text;
                string mk = txtPW.Text;
                string checkLG_string = "Select LoaiNV from NHANVIEN where Username = '" + tk + "' and Password = '" + mk + "'";
                SqlCommand cmd= new SqlCommand(checkLG_string, conn);
                SqlDataReader check = cmd.ExecuteReader();
                if (check.Read())
                {
                    string role = check[0].ToString();
                    switch (role)
                    {  
                     case "4":
                            MainMenu mn = new MainMenu();
                            mn.TenNV = "dăđă";
                        mn.Show();
                        this.Hide();
                            break;

                        case "3":
                            MessageBox.Show("Sai tên thông tin", "Thất bại", MessageBoxButtons.OK);
                            break;
                        case "2":
                            MessageBox.Show("Sai tên thông tin", "Thất bại", MessageBoxButtons.OK);
                            break;
                        case "1":
                            MessageBox.Show("Sai tên thông tin", "Thất bại", MessageBoxButtons.OK);
                            break;
                    }
                } else
                MessageBox.Show("Sai tên thông tin","Thất bại",MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
           

            

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
