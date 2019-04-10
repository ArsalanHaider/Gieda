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
    public partial class MAIN : Form
    {
        public int uid;

        public MAIN(int userId)
        {
            InitializeComponent();
            Logic.connection con = new Logic.connection();
            this.uid = userId;
            con.Select("SELECT Userss.userName, UserRoles.role FROM UserRoles INNER JOIN Userss ON Userss.roleId=UserRoles.roleId where userId='" + uid + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               // lblUserName.Text = dt.Rows[0]["userName"].ToString();
               // label6.Text = dt.Rows[0]["role"].ToString();


            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnHome);
            Home.Dashboard dashboard = new Home.Dashboard(uid);
            dashboard.MdiParent = this;
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }

        private void btnAllotees_Click(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnAllotees);
            Home.Allottee allottee = new Home.Allottee();
            //Allottees.AllotteesDetails allottee = new Allottees.AllotteesDetails();
            allottee.MdiParent = this;
            allottee.StartPosition = FormStartPosition.CenterScreen;
            allottee.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnUsers);
            Home.User UserHome = new Home.User();
            UserHome.MdiParent = this;
            UserHome.StartPosition = FormStartPosition.CenterScreen;
            UserHome.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnReports);

            Home.Phase Phase = new Home.Phase();
            Phase.MdiParent = this;
            Phase.StartPosition = FormStartPosition.CenterScreen;
            Phase.Show();
        }

        private void btnPlots_Click(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnPlots);
            Home.Plot plot = new Home.Plot();
            plot.MdiParent = this;
            plot.StartPosition = FormStartPosition.CenterScreen;
            plot.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnExit);
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Gieda Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Main_load(object sender, EventArgs e)
        {
            //label7.Text = DateTime.UtcNow.ToString();

            Home.Dashboard dashboard = new Home.Dashboard(uid);
            dashboard.MdiParent = this;
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();


            foreach (Control control in this.Controls)
            {

                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.White;
                    // 4#
                    break;
                }

            }
        }

        private void moveSidePanel_Paint(Control btn)
        {
            moveSidePanel.Top = btn.Top;
            moveSidePanel.Height = btn.Height;
        }
    }
    }

