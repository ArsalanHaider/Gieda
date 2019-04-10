using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic.connection con = new Logic.connection();

            con.Select("Select * from [Userss] where userName='" + txtUserName.Text + "' and userPassword='" + txtPassword.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int roleId = int.Parse(dt.Rows[0][3].ToString());
                // string name = dt.Rows[0][4].ToString();
                int userId = int.Parse(dt.Rows[0][0].ToString());
                con.Insert("INSERT INTO UserLoginTimeLog(userId,userLoginTime)VALUES  ('" + userId + "','" + DateTime.Now.ToString("MM-dd-yyyy h:mm:ss tt") + "')");



                if (roleId == 1 || roleId == 2 || roleId == 3)
                {
                    this.Hide();
                    MAIN mainForm = new MAIN(userId);
                    mainForm.Show();


                }
                else if (roleId == 4 || roleId == 5)
                {
                    this.Hide();
                    UserMain mainForm = new UserMain(userId);
                    mainForm.Show();


                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "GIEDA Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
